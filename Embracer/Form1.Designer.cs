namespace Embracer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.activityHistoryGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startActivityButton = new System.Windows.Forms.Button();
            this.timeLeftValueLabel = new System.Windows.Forms.Label();
            this.stopActivityButton = new System.Windows.Forms.Button();
            this.endTimeValueLabel = new System.Windows.Forms.Label();
            this.saveActivityButton = new System.Windows.Forms.Button();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.startTimeValueLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.whatAreYouDoingLabel = new System.Windows.Forms.Label();
            this.activitiesListBox = new System.Windows.Forms.ListBox();
            this.newActivityTextBox = new System.Windows.Forms.TextBox();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.timePeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportTimeLabel = new System.Windows.Forms.Label();
            this.pauseActivityButton = new System.Windows.Forms.Button();
            this.resetActivityButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timePeriodBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aktywności";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.activityHistoryGridView);
            this.panel5.Location = new System.Drawing.Point(512, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(391, 277);
            this.panel5.TabIndex = 15;
            // 
            // activityHistoryGridView
            // 
            this.activityHistoryGridView.AutoGenerateColumns = false;
            this.activityHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityHistoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.stopDataGridViewTextBoxColumn,
            this.intervalDataGridViewTextBoxColumn,
            this.activityDataGridViewTextBoxColumn});
            this.activityHistoryGridView.DataSource = this.timePeriodBindingSource;
            this.activityHistoryGridView.Location = new System.Drawing.Point(14, 16);
            this.activityHistoryGridView.Name = "activityHistoryGridView";
            this.activityHistoryGridView.Size = new System.Drawing.Size(374, 244);
            this.activityHistoryGridView.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.reportTimeLabel);
            this.panel4.Controls.Add(this.startTimeLabel);
            this.panel4.Controls.Add(this.startActivityButton);
            this.panel4.Controls.Add(this.timeLeftValueLabel);
            this.panel4.Controls.Add(this.resetActivityButton);
            this.panel4.Controls.Add(this.saveActivityButton);
            this.panel4.Controls.Add(this.pauseActivityButton);
            this.panel4.Controls.Add(this.stopActivityButton);
            this.panel4.Controls.Add(this.endTimeValueLabel);
            this.panel4.Controls.Add(this.timeLeftLabel);
            this.panel4.Controls.Add(this.startTimeValueLabel);
            this.panel4.Controls.Add(this.endTimeLabel);
            this.panel4.Location = new System.Drawing.Point(261, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 200);
            this.panel4.TabIndex = 14;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(17, 48);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(93, 13);
            this.startTimeLabel.TabIndex = 12;
            this.startTimeLabel.Text = "Czas rozpoczęcia:";
            // 
            // startActivityButton
            // 
            this.startActivityButton.Location = new System.Drawing.Point(162, 127);
            this.startActivityButton.Name = "startActivityButton";
            this.startActivityButton.Size = new System.Drawing.Size(67, 23);
            this.startActivityButton.TabIndex = 8;
            this.startActivityButton.Text = "Start";
            this.startActivityButton.UseVisualStyleBackColor = true;
            this.startActivityButton.Click += new System.EventHandler(this.startActivityButton_Click);
            // 
            // timeLeftValueLabel
            // 
            this.timeLeftValueLabel.AutoSize = true;
            this.timeLeftValueLabel.Location = new System.Drawing.Point(159, 98);
            this.timeLeftValueLabel.Name = "timeLeftValueLabel";
            this.timeLeftValueLabel.Size = new System.Drawing.Size(22, 13);
            this.timeLeftValueLabel.TabIndex = 12;
            this.timeLeftValueLabel.Text = "--:--";
            // 
            // stopActivityButton
            // 
            this.stopActivityButton.Location = new System.Drawing.Point(20, 127);
            this.stopActivityButton.Name = "stopActivityButton";
            this.stopActivityButton.Size = new System.Drawing.Size(67, 23);
            this.stopActivityButton.TabIndex = 9;
            this.stopActivityButton.Text = "Stop";
            this.stopActivityButton.UseVisualStyleBackColor = true;
            this.stopActivityButton.Click += new System.EventHandler(this.stopActivityButton_Click);
            // 
            // endTimeValueLabel
            // 
            this.endTimeValueLabel.AutoSize = true;
            this.endTimeValueLabel.Location = new System.Drawing.Point(159, 73);
            this.endTimeValueLabel.Name = "endTimeValueLabel";
            this.endTimeValueLabel.Size = new System.Drawing.Size(22, 13);
            this.endTimeValueLabel.TabIndex = 12;
            this.endTimeValueLabel.Text = "--:--";
            // 
            // saveActivityButton
            // 
            this.saveActivityButton.Location = new System.Drawing.Point(162, 158);
            this.saveActivityButton.Name = "saveActivityButton";
            this.saveActivityButton.Size = new System.Drawing.Size(67, 23);
            this.saveActivityButton.TabIndex = 10;
            this.saveActivityButton.Text = "Zapisz";
            this.saveActivityButton.UseVisualStyleBackColor = true;
            this.saveActivityButton.Click += new System.EventHandler(this.saveActivityButton_Click);
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Location = new System.Drawing.Point(17, 98);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(55, 13);
            this.timeLeftLabel.TabIndex = 12;
            this.timeLeftLabel.Text = "Upłynęło:";
            // 
            // startTimeValueLabel
            // 
            this.startTimeValueLabel.AutoSize = true;
            this.startTimeValueLabel.Location = new System.Drawing.Point(159, 48);
            this.startTimeValueLabel.Name = "startTimeValueLabel";
            this.startTimeValueLabel.Size = new System.Drawing.Size(22, 13);
            this.startTimeValueLabel.TabIndex = 12;
            this.startTimeValueLabel.Text = "--:--";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(17, 73);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(96, 13);
            this.endTimeLabel.TabIndex = 12;
            this.endTimeLabel.Text = "Czas zakończenia:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.whatAreYouDoingLabel);
            this.panel3.Controls.Add(this.activitiesListBox);
            this.panel3.Controls.Add(this.newActivityTextBox);
            this.panel3.Controls.Add(this.addActivityButton);
            this.panel3.Location = new System.Drawing.Point(32, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 277);
            this.panel3.TabIndex = 13;
            // 
            // whatAreYouDoingLabel
            // 
            this.whatAreYouDoingLabel.AutoSize = true;
            this.whatAreYouDoingLabel.Location = new System.Drawing.Point(16, 16);
            this.whatAreYouDoingLabel.Name = "whatAreYouDoingLabel";
            this.whatAreYouDoingLabel.Size = new System.Drawing.Size(94, 13);
            this.whatAreYouDoingLabel.TabIndex = 0;
            this.whatAreYouDoingLabel.Text = "Co będziesz robił?";
            // 
            // activitiesListBox
            // 
            this.activitiesListBox.FormattingEnabled = true;
            this.activitiesListBox.Location = new System.Drawing.Point(16, 41);
            this.activitiesListBox.Name = "activitiesListBox";
            this.activitiesListBox.Size = new System.Drawing.Size(190, 186);
            this.activitiesListBox.TabIndex = 1;
            this.activitiesListBox.SelectedIndexChanged += new System.EventHandler(this.activitiesListBox_SelectedIndexChanged);
            // 
            // newActivityTextBox
            // 
            this.newActivityTextBox.Location = new System.Drawing.Point(16, 237);
            this.newActivityTextBox.Name = "newActivityTextBox";
            this.newActivityTextBox.Size = new System.Drawing.Size(112, 20);
            this.newActivityTextBox.TabIndex = 2;
            this.newActivityTextBox.Text = "Nie ma na liście?";
            // 
            // addActivityButton
            // 
            this.addActivityButton.Location = new System.Drawing.Point(131, 233);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(75, 27);
            this.addActivityButton.TabIndex = 3;
            this.addActivityButton.Text = "Dodaj";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 61);
            this.panel1.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(211, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(433, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "OGARNIĘTOŚĆ TO DOSKONAŁOŚĆ";
            // 
            // timePeriodBindingSource
            // 
            this.timePeriodBindingSource.DataSource = typeof(Embracer.TimePeriod);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Data";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            // 
            // stopDataGridViewTextBoxColumn
            // 
            this.stopDataGridViewTextBoxColumn.DataPropertyName = "Stop";
            this.stopDataGridViewTextBoxColumn.HeaderText = "Stop";
            this.stopDataGridViewTextBoxColumn.Name = "stopDataGridViewTextBoxColumn";
            this.stopDataGridViewTextBoxColumn.Visible = false;
            // 
            // intervalDataGridViewTextBoxColumn
            // 
            this.intervalDataGridViewTextBoxColumn.DataPropertyName = "Interval";
            this.intervalDataGridViewTextBoxColumn.HeaderText = "Czas";
            this.intervalDataGridViewTextBoxColumn.Name = "intervalDataGridViewTextBoxColumn";
            // 
            // activityDataGridViewTextBoxColumn
            // 
            this.activityDataGridViewTextBoxColumn.DataPropertyName = "Activity";
            this.activityDataGridViewTextBoxColumn.HeaderText = "Activity";
            this.activityDataGridViewTextBoxColumn.Name = "activityDataGridViewTextBoxColumn";
            // 
            // reportTimeLabel
            // 
            this.reportTimeLabel.AutoSize = true;
            this.reportTimeLabel.Location = new System.Drawing.Point(17, 19);
            this.reportTimeLabel.Name = "reportTimeLabel";
            this.reportTimeLabel.Size = new System.Drawing.Size(47, 13);
            this.reportTimeLabel.TabIndex = 13;
            this.reportTimeLabel.Text = "Raportuj";
            // 
            // pauseActivityButton
            // 
            this.pauseActivityButton.Location = new System.Drawing.Point(91, 127);
            this.pauseActivityButton.Name = "pauseActivityButton";
            this.pauseActivityButton.Size = new System.Drawing.Size(67, 23);
            this.pauseActivityButton.TabIndex = 9;
            this.pauseActivityButton.Text = "Pauza";
            this.pauseActivityButton.UseVisualStyleBackColor = true;
            this.pauseActivityButton.Click += new System.EventHandler(this.stopActivityButton_Click);
            // 
            // resetActivityButton
            // 
            this.resetActivityButton.Location = new System.Drawing.Point(91, 158);
            this.resetActivityButton.Name = "resetActivityButton";
            this.resetActivityButton.Size = new System.Drawing.Size(67, 23);
            this.resetActivityButton.TabIndex = 10;
            this.resetActivityButton.Text = "Zapisz";
            this.resetActivityButton.UseVisualStyleBackColor = true;
            this.resetActivityButton.Click += new System.EventHandler(this.saveActivityButton_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(262, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 71);
            this.panel6.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Location = new System.Drawing.Point(355, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(19, 69);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 408);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timePeriodBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView activityHistoryGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Button startActivityButton;
        private System.Windows.Forms.Label timeLeftValueLabel;
        private System.Windows.Forms.Button stopActivityButton;
        private System.Windows.Forms.Label endTimeValueLabel;
        private System.Windows.Forms.Button saveActivityButton;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label startTimeValueLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label whatAreYouDoingLabel;
        private System.Windows.Forms.ListBox activitiesListBox;
        private System.Windows.Forms.TextBox newActivityTextBox;
        private System.Windows.Forms.Button addActivityButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timePeriodBindingSource;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label reportTimeLabel;
        private System.Windows.Forms.Button resetActivityButton;
        private System.Windows.Forms.Button pauseActivityButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

