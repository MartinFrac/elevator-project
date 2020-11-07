using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Elevator
{
    public partial class Form1 : Form
    {
        public static String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Elevator.accdb";
        private OleDbCommandBuilder builder;
        private Dictionary<int, int> floorsToPixelHeight = new Dictionary<int, int>();
        private List<Label> displays = new List<Label>(); 
        private int currentFloor;
        private int nextFloor;
        DataSet dataSet;
        OleDbDataAdapter adapter;
        OleDbConnection connection;
        public Form1()
        {
            currentFloor = 0;
            nextFloor = 0;
            floorsToPixelHeight.Add(0, 625);
            floorsToPixelHeight.Add(1, 75);
            dataSet = new DataSet("operationsDS");
            InitializeComponent();
            displays.Add(displayControl);
            displays.Add(displayZero);
            displays.Add(displayOne);
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
            connection = new OleDbConnection(connectionString);
            try
            {
                adapter = new OleDbDataAdapter("Select * from operations", connection);
                adapter.Fill(dataSet, "operations");
                DataTable operations = dataSet.Tables[0];
                IEnumerable<DataRow> rows = operations.AsEnumerable();
                foreach (DataRow row in rows.Reverse())
                {
                    dataGridView1.Rows.Add(new Object[] { row["content"], row["entered"] });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            if (currentFloor != floor && !timer1.Enabled)
            {
                nextFloor = floor;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentPixels = floorsToPixelHeight[currentFloor];
            int nextPixels = floorsToPixelHeight[nextFloor];
            if (elevator.Top != nextPixels)
            {
                if (nextPixels > currentPixels)
                {
                    elevator.Top += 10;
                } else
                {
                    elevator.Top -= 10;
                }
            } else
            {
                timer1.Stop();
                log("Elevator moved from floor No. " + currentFloor + " to floor No. " + nextFloor);
                currentFloor = nextFloor;
                changeDisplays(currentFloor);
                //builder = new OleDbCommandBuilder(adapter);
                //int noOfRows = dataSet.Tables[0].Rows.Count;
                //int lastId = Int32.Parse(dataSet.Tables[0].Rows[noOfRows - 1].ItemArray[0].ToString());
                //var nextId = lastId + 1;
                //DataRow row = dataSet.Tables[0].NewRow();
                //row[0] = nextId;
                //row[1] = "Elevator moved to floor No. " + currentFloor.ToString();
                //row[2] = DateTime.Now;
                //dataSet.Tables[0].Rows.Add(row);
                //dataGridView1.Rows.Insert(0, new object[] { row[1], row[2] });
                //adapter.Update(dataSet.Tables[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Elevator.accdb";
            DataSet dataSet = new DataSet();
            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from operations", connection);
                BindingSource bindingSource = new BindingSource();
                dataGridView1.DataSource = bindingSource;
                adapter.Fill(dataSet);
                adapter.Dispose();
                bindingSource.DataSource = dataSet;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void storeLogs_Click(object sender, EventArgs e)
        {
            builder = new OleDbCommandBuilder(adapter);
            adapter.Update(dataSet.Tables[0]);
        }
    }
}
