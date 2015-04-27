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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(854, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aktywności";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(469, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 277);
            this.panel5.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.startTimeLabel);
            this.panel4.Controls.Add(this.startActivityButton);
            this.panel4.Controls.Add(this.timeLeftValueLabel);
            this.panel4.Controls.Add(this.stopActivityButton);
            this.panel4.Controls.Add(this.endTimeValueLabel);
            this.panel4.Controls.Add(this.saveActivityButton);
            this.panel4.Controls.Add(this.timeLeftLabel);
            this.panel4.Controls.Add(this.startTimeValueLabel);
            this.panel4.Controls.Add(this.endTimeLabel);
            this.panel4.Location = new System.Drawing.Point(240, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 277);
            this.panel4.TabIndex = 14;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(32, 16);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(93, 13);
            this.startTimeLabel.TabIndex = 12;
            this.startTimeLabel.Text = "Czas rozpoczęcia:";
            // 
            // startActivityButton
            // 
            this.startActivityButton.Location = new System.Drawing.Point(35, 204);
            this.startActivityButton.Name = "startActivityButton";
            this.startActivityButton.Size = new System.Drawing.Size(75, 23);
            this.startActivityButton.TabIndex = 8;
            this.startActivityButton.Text = "Start";
            this.startActivityButton.UseVisualStyleBackColor = true;
            this.startActivityButton.Click += new System.EventHandler(this.startActivityButton_Click);
            // 
            // timeLeftValueLabel
            // 
            this.timeLeftValueLabel.AutoSize = true;
            this.timeLeftValueLabel.Location = new System.Drawing.Point(131, 66);
            this.timeLeftValueLabel.Name = "timeLeftValueLabel";
            this.timeLeftValueLabel.Size = new System.Drawing.Size(22, 13);
            this.timeLeftValueLabel.TabIndex = 12;
            this.timeLeftValueLabel.Text = "--:--";
            // 
            // stopActivityButton
            // 
            this.stopActivityButton.Location = new System.Drawing.Point(116, 204);
            this.stopActivityButton.Name = "stopActivityButton";
            this.stopActivityButton.Size = new System.Drawing.Size(75, 23);
            this.stopActivityButton.TabIndex = 9;
            this.stopActivityButton.Text = "Stop";
            this.stopActivityButton.UseVisualStyleBackColor = true;
            this.stopActivityButton.Click += new System.EventHandler(this.stopActivityButton_Click);
            // 
            // endTimeValueLabel
            // 
            this.endTimeValueLabel.AutoSize = true;
            this.endTimeValueLabel.Location = new System.Drawing.Point(131, 41);
            this.endTimeValueLabel.Name = "endTimeValueLabel";
            this.endTimeValueLabel.Size = new System.Drawing.Size(22, 13);
            this.endTimeValueLabel.TabIndex = 12;
            this.endTimeValueLabel.Text = "--:--";
            // 
            // saveActivityButton
            // 
            this.saveActivityButton.Location = new System.Drawing.Point(116, 237);
            this.saveActivityButton.Name = "saveActivityButton";
            this.saveActivityButton.Size = new System.Drawing.Size(75, 23);
            this.saveActivityButton.TabIndex = 10;
            this.saveActivityButton.Text = "Zapisz";
            this.saveActivityButton.UseVisualStyleBackColor = true;
            this.saveActivityButton.Click += new System.EventHandler(this.saveActivityButton_Click);
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Location = new System.Drawing.Point(32, 66);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(55, 13);
            this.timeLeftLabel.TabIndex = 12;
            this.timeLeftLabel.Text = "Upłynęło:";
            // 
            // startTimeValueLabel
            // 
            this.startTimeValueLabel.AutoSize = true;
            this.startTimeValueLabel.Location = new System.Drawing.Point(131, 16);
            this.startTimeValueLabel.Name = "startTimeValueLabel";
            this.startTimeValueLabel.Size = new System.Drawing.Size(22, 13);
            this.startTimeValueLabel.TabIndex = 12;
            this.startTimeValueLabel.Text = "--:--";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(32, 41);
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
            this.panel3.Location = new System.Drawing.Point(11, 6);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Location = new System.Drawing.Point(638, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 11;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 292);
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
            this.panel1.Size = new System.Drawing.Size(854, 61);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 379);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
    }
}

