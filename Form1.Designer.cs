using System.Drawing;

namespace Elevator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.displayControl = new System.Windows.Forms.Label();
            this.displayZero = new System.Windows.Forms.Label();
            this.displayOne = new System.Windows.Forms.Label();
            this.control1 = new System.Windows.Forms.Button();
            this.control0 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeLogsButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.doorOneLeft = new System.Windows.Forms.PictureBox();
            this.buttonOne = new System.Windows.Forms.PictureBox();
            this.buttonZero = new System.Windows.Forms.PictureBox();
            this.elevator = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doorOneRight = new System.Windows.Forms.PictureBox();
            this.doorZeroLeft = new System.Windows.Forms.PictureBox();
            this.doorZeroRight = new System.Windows.Forms.PictureBox();
            this.doorsTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorOneLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorOneRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorZeroLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorZeroRight)).BeginInit();
            this.SuspendLayout();
            // 
            // displayControl
            // 
            this.displayControl.AutoSize = true;
            this.displayControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.displayControl.Location = new System.Drawing.Point(119, 284);
            this.displayControl.Name = "displayControl";
            this.displayControl.Size = new System.Drawing.Size(57, 63);
            this.displayControl.TabIndex = 7;
            this.displayControl.Text = "0";
            // 
            // displayZero
            // 
            this.displayZero.AutoSize = true;
            this.displayZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.displayZero.Location = new System.Drawing.Point(654, 559);
            this.displayZero.Name = "displayZero";
            this.displayZero.Size = new System.Drawing.Size(57, 63);
            this.displayZero.TabIndex = 8;
            this.displayZero.Text = "0";
            // 
            // displayOne
            // 
            this.displayOne.AutoSize = true;
            this.displayOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.displayOne.Location = new System.Drawing.Point(654, 70);
            this.displayOne.Name = "displayOne";
            this.displayOne.Size = new System.Drawing.Size(57, 63);
            this.displayOne.TabIndex = 9;
            this.displayOne.Text = "0";
            // 
            // control1
            // 
            this.control1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.control1.Location = new System.Drawing.Point(121, 350);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(55, 50);
            this.control1.TabIndex = 10;
            this.control1.Text = "1";
            this.control1.UseVisualStyleBackColor = true;
            this.control1.Click += new System.EventHandler(this.control1_Click);
            // 
            // control0
            // 
            this.control0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.control0.Location = new System.Drawing.Point(121, 395);
            this.control0.Name = "control0";
            this.control0.Size = new System.Drawing.Size(55, 50);
            this.control0.TabIndex = 11;
            this.control0.Text = "0";
            this.control0.UseVisualStyleBackColor = true;
            this.control0.Click += new System.EventHandler(this.control0_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operations,
            this.dateTime});
            this.dataGridView1.Location = new System.Drawing.Point(1284, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(511, 325);
            this.dataGridView1.TabIndex = 13;
            // 
            // operations
            // 
            this.operations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operations.HeaderText = "Operations";
            this.operations.Name = "operations";
            this.operations.ReadOnly = true;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Date Time";
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Width = 120;
            // 
            // storeLogsButton
            // 
            this.storeLogsButton.Location = new System.Drawing.Point(1284, 155);
            this.storeLogsButton.Name = "storeLogsButton";
            this.storeLogsButton.Size = new System.Drawing.Size(511, 53);
            this.storeLogsButton.TabIndex = 14;
            this.storeLogsButton.Text = "Store Logs";
            this.storeLogsButton.UseVisualStyleBackColor = true;
            this.storeLogsButton.Click += new System.EventHandler(this.storeLogs_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // doorOneLeft
            // 
            this.doorOneLeft.Image = global::Elevator2.Properties.Resources.door3;
            this.doorOneLeft.Location = new System.Drawing.Point(463, 136);
            this.doorOneLeft.Name = "doorOneLeft";
            this.doorOneLeft.Size = new System.Drawing.Size(223, 406);
            this.doorOneLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.doorOneLeft.TabIndex = 16;
            this.doorOneLeft.TabStop = false;
            // 
            // buttonOne
            // 
            this.buttonOne.Image = global::Elevator2.Properties.Resources.button1;
            this.buttonOne.Location = new System.Drawing.Point(952, 235);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(173, 152);
            this.buttonOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonOne.TabIndex = 6;
            this.buttonOne.TabStop = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Image = global::Elevator2.Properties.Resources.button1;
            this.buttonZero.Location = new System.Drawing.Point(952, 796);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(173, 152);
            this.buttonZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonZero.TabIndex = 5;
            this.buttonZero.TabStop = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // elevator
            // 
            this.elevator.Image = global::Elevator2.Properties.Resources.inner;
            this.elevator.Location = new System.Drawing.Point(462, 650);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(445, 410);
            this.elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevator.TabIndex = 4;
            this.elevator.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1853, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(67, 66);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Elevator2.Properties.Resources.building;
            this.pictureBox1.Location = new System.Drawing.Point(-227, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // doorOneRight
            // 
            this.doorOneRight.Image = global::Elevator2.Properties.Resources.door3;
            this.doorOneRight.Location = new System.Drawing.Point(683, 136);
            this.doorOneRight.Name = "doorOneRight";
            this.doorOneRight.Size = new System.Drawing.Size(223, 406);
            this.doorOneRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.doorOneRight.TabIndex = 17;
            this.doorOneRight.TabStop = false;
            // 
            // doorZeroLeft
            // 
            this.doorZeroLeft.Image = global::Elevator2.Properties.Resources.door3;
            this.doorZeroLeft.Location = new System.Drawing.Point(463, 652);
            this.doorZeroLeft.Name = "doorZeroLeft";
            this.doorZeroLeft.Size = new System.Drawing.Size(223, 406);
            this.doorZeroLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.doorZeroLeft.TabIndex = 18;
            this.doorZeroLeft.TabStop = false;
            // 
            // doorZeroRight
            // 
            this.doorZeroRight.Image = global::Elevator2.Properties.Resources.door3;
            this.doorZeroRight.Location = new System.Drawing.Point(683, 652);
            this.doorZeroRight.Name = "doorZeroRight";
            this.doorZeroRight.Size = new System.Drawing.Size(223, 406);
            this.doorZeroRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.doorZeroRight.TabIndex = 19;
            this.doorZeroRight.TabStop = false;
            // 
            // doorsTimer
            // 
            this.doorsTimer.Interval = 1;
            this.doorsTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.doorOneRight);
            this.Controls.Add(this.doorZeroRight);
            this.Controls.Add(this.doorZeroLeft);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.doorOneLeft);
            this.Controls.Add(this.storeLogsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.control0);
            this.Controls.Add(this.control1);
            this.Controls.Add(this.displayOne);
            this.Controls.Add(this.displayControl);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.displayZero);
            this.Controls.Add(this.elevator);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorOneLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorOneRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorZeroLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorZeroRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox elevator;
        private System.Windows.Forms.PictureBox buttonZero;
        private System.Windows.Forms.PictureBox buttonOne;
        private System.Windows.Forms.Label displayControl;
        private System.Windows.Forms.Label displayZero;
        private System.Windows.Forms.Label displayOne;
        private System.Windows.Forms.Button control1;
        private System.Windows.Forms.Button control0;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.Button storeLogsButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox doorOneLeft;
        private System.Windows.Forms.PictureBox doorOneRight;
        private System.Windows.Forms.PictureBox doorZeroLeft;
        private System.Windows.Forms.PictureBox doorZeroRight;
        private System.Windows.Forms.Timer doorsTimer;
    }
}

