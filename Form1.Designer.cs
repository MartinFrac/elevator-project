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
            this.exit = new System.Windows.Forms.PictureBox();
            this.elevator = new System.Windows.Forms.PictureBox();
            this.buttonZero = new System.Windows.Forms.PictureBox();
            this.buttonOne = new System.Windows.Forms.PictureBox();
            this.displayControl = new System.Windows.Forms.Label();
            this.displayZero = new System.Windows.Forms.Label();
            this.displayOne = new System.Windows.Forms.Label();
            this.control1 = new System.Windows.Forms.Button();
            this.control0 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeLogs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // elevator
            // 
            this.elevator.Image = ((System.Drawing.Image)(resources.GetObject("elevator.Image")));
            this.elevator.Location = new System.Drawing.Point(445, 625);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(461, 442);
            this.elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevator.TabIndex = 4;
            this.elevator.TabStop = false;
            // 
            // buttonZero
            // 
            this.buttonZero.Image = ((System.Drawing.Image)(resources.GetObject("buttonZero.Image")));
            this.buttonZero.Location = new System.Drawing.Point(952, 796);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(173, 152);
            this.buttonZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonZero.TabIndex = 5;
            this.buttonZero.TabStop = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Image = ((System.Drawing.Image)(resources.GetObject("buttonOne.Image")));
            this.buttonOne.Location = new System.Drawing.Point(952, 235);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(173, 152);
            this.buttonOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonOne.TabIndex = 6;
            this.buttonOne.TabStop = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
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
            this.displayZero.Location = new System.Drawing.Point(646, 559);
            this.displayZero.Name = "displayZero";
            this.displayZero.Size = new System.Drawing.Size(57, 63);
            this.displayZero.TabIndex = 8;
            this.displayZero.Text = "0";
            // 
            // displayOne
            // 
            this.displayOne.AutoSize = true;
            this.displayOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.displayOne.Location = new System.Drawing.Point(646, 9);
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
            this.timer1.Interval = 50;
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
            // storeLogs
            // 
            this.storeLogs.Location = new System.Drawing.Point(1284, 155);
            this.storeLogs.Name = "storeLogs";
            this.storeLogs.Size = new System.Drawing.Size(511, 53);
            this.storeLogs.TabIndex = 14;
            this.storeLogs.Text = "Store Logs";
            this.storeLogs.UseVisualStyleBackColor = true;
            this.storeLogs.Click += new System.EventHandler(this.storeLogs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.storeLogs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.control0);
            this.Controls.Add(this.control1);
            this.Controls.Add(this.displayOne);
            this.Controls.Add(this.displayControl);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.elevator);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.displayZero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.Button storeLogs;
    }
}

