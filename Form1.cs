using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Threading;

namespace Elevator
{
    public partial class Form1 : Form
    {
        //connection
        public static String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Elevator.accdb";
        //data structures
        private HashSet<int> floors = new HashSet<int> { 0, 1 };
        private Dictionary<int, int> floorsToPixelHeight = new Dictionary<int, int>();
        private Dictionary<int, int> PixelHeightToFloors = new Dictionary<int, int>();
        private List<Label> displays = new List<Label>();
        public List<SortedSet<int>> queues = new List<SortedSet<int>>();
        public Boolean[] visited = new Boolean[2];
        public HashSet<int> toBeVisitedSet = new HashSet<int>();
        public Queue<int> queueToBeVisited = new Queue<int>();
        public List<int> floorOrder = new List<int>();
        //variables
        private int currentFloor;
        private int nextFloor;
        private int lastFloor;
        public int CurrentFloor {
            get => this.currentFloor; 
            set
            {
                if (floors.Contains(value))
                {
                    this.currentFloor = value;
                }
            } 
        }
        public int NextFloor {
            get => this.nextFloor;
            set
            {
                if (floors.Contains(value))
                {
                    this.nextFloor = value;
                }
            }
        }
        public int LastFloor
        {
            get => this.lastFloor;
            set
            {
                if (floors.Contains(value))
                {
                    this.lastFloor = value;
                }
            }
        }
        //data
        DataSet dataSet;
        //state
        private State _state;
        public Form1()
        {
            _state = new StationaryState();
            TransitionTo(_state);
            currentFloor = 0;
            nextFloor = 0;
            floorsToPixelHeight.Add(0, 625);
            floorsToPixelHeight.Add(1, 75);
            PixelHeightToFloors.Add(625, 0);
            PixelHeightToFloors.Add(75, 1);
            dataSet = new DataSet("operationsDS");
            InitializeComponent();
            displays.Add(displayControl);
            displays.Add(displayZero);
            displays.Add(displayOne);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Form1: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        private void log(String log)
        {
            var noOfRows = dataSet.Tables[0].Rows.Count;
            var lastId = Int32.Parse(dataSet.Tables[0].Rows[noOfRows - 1].ItemArray[0].ToString());
            var nextId = lastId + 1;
            DataRow row = dataSet.Tables[0].NewRow();
            row[0] = nextId;
            row[1] = log;
            row[2] = DateTime.Now;
            dataSet.Tables[0].Rows.Add(row);
            dataGridView1.Rows.Insert(0, new object[] { row[1], row[2] });
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                String query = "Select * from operations";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.Fill(dataSet, "operations");
                    DataTable operations = dataSet.Tables[0];
                    IEnumerable<DataRow> rows = operations.AsEnumerable();
                    foreach (DataRow row in rows.Reverse())
                    {
                        dataGridView1.Rows.Add(new Object[] { row["content"], row["entered"] });
                    }
                }
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            moveElevator(0);
            log("Button on the floor zero clicked");
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            moveElevator(1);
            log("Button on the floor one clicked");
        }

        private void control1_Click(object sender, EventArgs e)
        {
            moveElevator(1);
            log("Button one on the control panel clicked");
        }

        private void control0_Click(object sender, EventArgs e)
        {
            moveElevator(0);
            log("Button zero on the control panel clicked");
        }

        private void changeDisplays(int floor)
        {
            foreach (Label element in displays)
            {
                element.Text = floor.ToString();
            }
        }

        private void moveElevator(int floor)
        {
            if (!toBeVisitedSet.Contains(floor) && elevator.Top != floorsToPixelHeight[floor])
            {
                _state.MoveElevator(floor);
            }
        }

        private void openDoors()
        {
            Thread.Sleep(2000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentPixels = elevator.Top;
            int nextPixels = floorsToPixelHeight[nextFloor];
            updateCurrentFloor(currentPixels);
            if (currentPixels != nextPixels)
            {
                stopIfOnTheWay();
                if (currentPixels > nextPixels)
                {
                    elevator.Top -= 10;
                }
                else if (currentPixels < nextPixels)
                {
                    elevator.Top += 10;
                }
            }
            else
            {
                stopElevator();
                findNextFloor();
            }
                
        }

        private void findNextFloor()
        {
            if (queueToBeVisited.Count == 0)
            {
                timer1.Stop();
                TransitionTo(new StationaryState());
            } 
            else 
            {
                while (true)
                {
                    int pop = queueToBeVisited.Dequeue();
                    if (visited[pop])
                    {
                        visited[pop] = true;
                    } else
                    {
                        nextFloor = pop;
                        break;
                    }
                }
            }
        }

        private void updateCurrentFloor(int currentPixels)
        {
            if (PixelHeightToFloors.ContainsKey(currentPixels))
            {
                currentFloor = PixelHeightToFloors[currentPixels];
            }
        }

        private void stopElevator()
        {
            toBeVisitedSet.Remove(currentFloor);
            visited[currentFloor] = true;
            log("Elevator moved from floor No. " + lastFloor + " to floor No. " + currentFloor);
            lastFloor = currentFloor;
            changeDisplays(currentFloor);
            openDoors();
        }

        private void stopIfOnTheWay()
        {
            int currentPixels = elevator.Top;
            if (PixelHeightToFloors.ContainsKey(currentPixels)) {
                int floor = PixelHeightToFloors[currentPixels];
                if (toBeVisitedSet.Contains(floor)) {
                    stopElevator();
                }
            }
        }

        private void storeLogs_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void storeLogs(BackgroundWorker backgroundWorker)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                String query = "Select * from operations";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                    try
                    {
                        adapter.Update(dataSet.Tables[0]);
                    }
                    catch (Exception ex)
                    {
                        log(ex.Message);
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = sender as BackgroundWorker;
            storeLogs(backgroundWorker);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) Console.WriteLine("Operation cancelled");
            else if (e.Error != null) Console.WriteLine(e.Error.Message);
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
