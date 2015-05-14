using System.Windows.Forms;
using MetroFramework.Controls;

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
            this.activityHistoryGridView = new System.Windows.Forms.DataGridView();
            this.timeTrackerPanel = new MetroFramework.Controls.MetroPanel();
            this.inProgressLabel = new MetroLabel();
            this.startTimeLabel = new MetroLabel();
            this.startActivityButton = new MetroButton();
            this.timeLeftValueLabel = new MetroLabel();
            this.resetActivityButton = new MetroButton();
            this.saveActivityButton = new MetroButton();
            this.pauseActivityButton = new MetroButton();
            this.stopActivityButton = new MetroButton();
            this.startTimeValueLabel = new MetroLabel();
            this.endTimeValueLabel = new MetroLabel();
            this.timeLeftLabel = new MetroLabel();
            this.activityInProgressLabel = new MetroLabel();
            this.endTimeLabel = new MetroLabel();
            this.activitiesListPanel = new MetroFramework.Controls.MetroPanel();
            this.whatAreYouDoingLabel = new MetroLabel();
            this.activitiesListBox = new ListBox();
            this.newActivityTextBox = new MetroTextBox();
            this.removeActivityButton = new MetroButton();
            this.addActivityButton = new MetroButton();
            this.mainContainerTabControl = new MetroFramework.Controls.MetroTabControl();
            this.timeTrackingTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tasksTabPage = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryGridView)).BeginInit();
            this.timeTrackerPanel.SuspendLayout();
            this.activitiesListPanel.SuspendLayout();
            this.mainContainerTabControl.SuspendLayout();
            this.timeTrackingTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // activityHistoryGridView
            // 
            this.activityHistoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activityHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityHistoryGridView.Location = new System.Drawing.Point(590, 4);
            this.activityHistoryGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activityHistoryGridView.Name = "activityHistoryGridView";
            this.activityHistoryGridView.Size = new System.Drawing.Size(541, 487);
            this.activityHistoryGridView.TabIndex = 0;
            this.activityHistoryGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.activityHistoryGridView_CellFormatting);
            // 
            // timeTrackerPanel
            // 
            this.timeTrackerPanel.Controls.Add(this.inProgressLabel);
            this.timeTrackerPanel.Controls.Add(this.startTimeLabel);
            this.timeTrackerPanel.Controls.Add(this.startActivityButton);
            this.timeTrackerPanel.Controls.Add(this.timeLeftValueLabel);
            this.timeTrackerPanel.Controls.Add(this.resetActivityButton);
            this.timeTrackerPanel.Controls.Add(this.saveActivityButton);
            this.timeTrackerPanel.Controls.Add(this.pauseActivityButton);
            this.timeTrackerPanel.Controls.Add(this.stopActivityButton);
            this.timeTrackerPanel.Controls.Add(this.startTimeValueLabel);
            this.timeTrackerPanel.Controls.Add(this.endTimeValueLabel);
            this.timeTrackerPanel.Controls.Add(this.timeLeftLabel);
            this.timeTrackerPanel.Controls.Add(this.activityInProgressLabel);
            this.timeTrackerPanel.Controls.Add(this.endTimeLabel);
            this.timeTrackerPanel.HorizontalScrollbarBarColor = true;
            this.timeTrackerPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.timeTrackerPanel.HorizontalScrollbarSize = 8;
            this.timeTrackerPanel.Location = new System.Drawing.Point(309, 4);
            this.timeTrackerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeTrackerPanel.Name = "timeTrackerPanel";
            this.timeTrackerPanel.Size = new System.Drawing.Size(275, 487);
            this.timeTrackerPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeTrackerPanel.TabIndex = 14;
            this.timeTrackerPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timeTrackerPanel.VerticalScrollbarBarColor = true;
            this.timeTrackerPanel.VerticalScrollbarHighlightOnWheel = false;
            this.timeTrackerPanel.VerticalScrollbarSize = 9;
            // 
            // inProgressLabel
            // 
            this.inProgressLabel.AutoSize = true;
            this.inProgressLabel.ForeColor = System.Drawing.Color.White;
            this.inProgressLabel.Location = new System.Drawing.Point(20, 25);
            this.inProgressLabel.Name = "inProgressLabel";
            this.inProgressLabel.Size = new System.Drawing.Size(62, 17);
            this.inProgressLabel.TabIndex = 13;
            this.inProgressLabel.Text = "W trakcie";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.startTimeLabel.Location = new System.Drawing.Point(20, 59);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(35, 17);
            this.startTimeLabel.TabIndex = 12;
            this.startTimeLabel.Text = "Start";
            // 
            // startActivityButton
            // 
            this.startActivityButton.Location = new System.Drawing.Point(189, 166);
            this.startActivityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startActivityButton.Name = "startActivityButton";
            this.startActivityButton.Size = new System.Drawing.Size(78, 30);
            this.startActivityButton.TabIndex = 8;
            this.startActivityButton.Text = "Start";
            this.startActivityButton.UseVisualStyleBackColor = true;
            this.startActivityButton.Click += new System.EventHandler(this.startActivityButton_Click);
            // 
            // timeLeftValueLabel
            // 
            this.timeLeftValueLabel.AutoSize = true;
            this.timeLeftValueLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.timeLeftValueLabel.Location = new System.Drawing.Point(103, 127);
            this.timeLeftValueLabel.Name = "timeLeftValueLabel";
            this.timeLeftValueLabel.Size = new System.Drawing.Size(31, 17);
            this.timeLeftValueLabel.TabIndex = 12;
            this.timeLeftValueLabel.Text = "--:--";
            // 
            // resetActivityButton
            // 
            this.resetActivityButton.Location = new System.Drawing.Point(23, 209);
            this.resetActivityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetActivityButton.Name = "resetActivityButton";
            this.resetActivityButton.Size = new System.Drawing.Size(78, 30);
            this.resetActivityButton.TabIndex = 10;
            this.resetActivityButton.Text = "Reset";
            this.resetActivityButton.UseVisualStyleBackColor = true;
            this.resetActivityButton.Click += new System.EventHandler(this.resetActivityButton_Click);
            // 
            // saveActivityButton
            // 
            this.saveActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveActivityButton.Location = new System.Drawing.Point(189, 207);
            this.saveActivityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveActivityButton.Name = "saveActivityButton";
            this.saveActivityButton.Size = new System.Drawing.Size(78, 30);
            this.saveActivityButton.TabIndex = 10;
            this.saveActivityButton.Text = "Zapisz";
            this.saveActivityButton.UseVisualStyleBackColor = true;
            this.saveActivityButton.Click += new System.EventHandler(this.saveActivityButton_Click);
            // 
            // pauseActivityButton
            // 
            this.pauseActivityButton.Location = new System.Drawing.Point(106, 166);
            this.pauseActivityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pauseActivityButton.Name = "pauseActivityButton";
            this.pauseActivityButton.Size = new System.Drawing.Size(78, 30);
            this.pauseActivityButton.TabIndex = 9;
            this.pauseActivityButton.Text = "Pauza";
            this.pauseActivityButton.UseVisualStyleBackColor = true;
            this.pauseActivityButton.Click += new System.EventHandler(this.stopActivityButton_Click);
            // 
            // stopActivityButton
            // 
            this.stopActivityButton.Location = new System.Drawing.Point(23, 166);
            this.stopActivityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopActivityButton.Name = "stopActivityButton";
            this.stopActivityButton.Size = new System.Drawing.Size(78, 30);
            this.stopActivityButton.TabIndex = 9;
            this.stopActivityButton.Text = "Stop";
            this.stopActivityButton.UseVisualStyleBackColor = true;
            this.stopActivityButton.Click += new System.EventHandler(this.stopActivityButton_Click);
            // 
            // startTimeValueLabel
            // 
            this.startTimeValueLabel.AutoSize = true;
            this.startTimeValueLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.startTimeValueLabel.Location = new System.Drawing.Point(103, 59);
            this.startTimeValueLabel.Name = "startTimeValueLabel";
            this.startTimeValueLabel.Size = new System.Drawing.Size(31, 17);
            this.startTimeValueLabel.TabIndex = 12;
            this.startTimeValueLabel.Text = "--:--";
            // 
            // endTimeValueLabel
            // 
            this.endTimeValueLabel.AutoSize = true;
            this.endTimeValueLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.endTimeValueLabel.Location = new System.Drawing.Point(103, 94);
            this.endTimeValueLabel.Name = "endTimeValueLabel";
            this.endTimeValueLabel.Size = new System.Drawing.Size(31, 17);
            this.endTimeValueLabel.TabIndex = 12;
            this.endTimeValueLabel.Text = "--:--";
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.timeLeftLabel.Location = new System.Drawing.Point(20, 127);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(62, 17);
            this.timeLeftLabel.TabIndex = 12;
            this.timeLeftLabel.Text = "Upłynęło:";
            // 
            // activityInProgressLabel
            // 
            this.activityInProgressLabel.AutoSize = true;
            this.activityInProgressLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.activityInProgressLabel.Location = new System.Drawing.Point(103, 25);
            this.activityInProgressLabel.Name = "activityInProgressLabel";
            this.activityInProgressLabel.Size = new System.Drawing.Size(13, 17);
            this.activityInProgressLabel.TabIndex = 12;
            this.activityInProgressLabel.Text = "-";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.endTimeLabel.Location = new System.Drawing.Point(20, 93);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(47, 17);
            this.endTimeLabel.TabIndex = 12;
            this.endTimeLabel.Text = "Koniec";
            // 
            // activitiesListPanel
            // 
            this.activitiesListPanel.Controls.Add(this.whatAreYouDoingLabel);
            this.activitiesListPanel.Controls.Add(this.activitiesListBox);
            this.activitiesListPanel.Controls.Add(this.newActivityTextBox);
            this.activitiesListPanel.Controls.Add(this.removeActivityButton);
            this.activitiesListPanel.Controls.Add(this.addActivityButton);
            this.activitiesListPanel.HorizontalScrollbarBarColor = true;
            this.activitiesListPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.activitiesListPanel.HorizontalScrollbarSize = 8;
            this.activitiesListPanel.Location = new System.Drawing.Point(0, 4);
            this.activitiesListPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activitiesListPanel.Name = "activitiesListPanel";
            this.activitiesListPanel.Size = new System.Drawing.Size(303, 487);
            this.activitiesListPanel.Style = MetroFramework.MetroColorStyle.Orange;
            this.activitiesListPanel.TabIndex = 13;
            this.activitiesListPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.activitiesListPanel.VerticalScrollbarBarColor = true;
            this.activitiesListPanel.VerticalScrollbarHighlightOnWheel = false;
            this.activitiesListPanel.VerticalScrollbarSize = 9;
            // 
            // whatAreYouDoingLabel
            // 
            this.whatAreYouDoingLabel.AutoSize = true;
            this.whatAreYouDoingLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.whatAreYouDoingLabel.Location = new System.Drawing.Point(19, 21);
            this.whatAreYouDoingLabel.Name = "whatAreYouDoingLabel";
            this.whatAreYouDoingLabel.Size = new System.Drawing.Size(116, 17);
            this.whatAreYouDoingLabel.TabIndex = 0;
            this.whatAreYouDoingLabel.Text = "Co będziesz robił?";
            // 
            // activitiesListBox
            // 
            this.activitiesListBox.FormattingEnabled = true;
            this.activitiesListBox.ItemHeight = 17;
            this.activitiesListBox.Location = new System.Drawing.Point(19, 54);
            this.activitiesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activitiesListBox.Name = "activitiesListBox";
            this.activitiesListBox.Size = new System.Drawing.Size(265, 242);
            this.activitiesListBox.TabIndex = 1;
            this.activitiesListBox.SelectedIndexChanged += new System.EventHandler(this.activitiesListBox_SelectedIndexChanged);
            // 
            // newActivityTextBox
            // 
            this.newActivityTextBox.Location = new System.Drawing.Point(19, 310);
            this.newActivityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newActivityTextBox.Name = "newActivityTextBox";
            this.newActivityTextBox.Size = new System.Drawing.Size(160, 25);
            this.newActivityTextBox.TabIndex = 2;
            this.newActivityTextBox.Text = "Nie ma na liście? Nazwij i";
            // 
            // removeActivityButton
            // 
            this.removeActivityButton.Location = new System.Drawing.Point(187, 16);
            this.removeActivityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeActivityButton.Name = "removeActivityButton";
            this.removeActivityButton.Size = new System.Drawing.Size(98, 26);
            this.removeActivityButton.TabIndex = 3;
            this.removeActivityButton.Text = "Usuń";
            this.removeActivityButton.UseVisualStyleBackColor = true;
            this.removeActivityButton.Click += new System.EventHandler(this.removeActivityButton_Click);
            // 
            // addActivityButton
            // 
            this.addActivityButton.Location = new System.Drawing.Point(187, 305);
            this.addActivityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(98, 35);
            this.addActivityButton.TabIndex = 3;
            this.addActivityButton.Text = "Dodaj";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // mainContainerTabControl
            // 
            this.mainContainerTabControl.Controls.Add(this.timeTrackingTabPage);
            this.mainContainerTabControl.Controls.Add(this.tasksTabPage);
            this.mainContainerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainerTabControl.Location = new System.Drawing.Point(20, 60);
            this.mainContainerTabControl.Name = "mainContainerTabControl";
            this.mainContainerTabControl.SelectedIndex = 0;
            this.mainContainerTabControl.Size = new System.Drawing.Size(1135, 533);
            this.mainContainerTabControl.TabIndex = 1;
            this.mainContainerTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainContainerTabControl.UseSelectable = true;
            // 
            // timeTrackingTabPage
            // 
            this.timeTrackingTabPage.Controls.Add(this.activityHistoryGridView);
            this.timeTrackingTabPage.Controls.Add(this.timeTrackerPanel);
            this.timeTrackingTabPage.Controls.Add(this.activitiesListPanel);
            this.timeTrackingTabPage.HorizontalScrollbarBarColor = true;
            this.timeTrackingTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.timeTrackingTabPage.HorizontalScrollbarSize = 4;
            this.timeTrackingTabPage.Location = new System.Drawing.Point(4, 38);
            this.timeTrackingTabPage.Name = "timeTrackingTabPage";
            this.timeTrackingTabPage.Size = new System.Drawing.Size(1127, 491);
            this.timeTrackingTabPage.Style = MetroFramework.MetroColorStyle.Green;
            this.timeTrackingTabPage.TabIndex = 0;
            this.timeTrackingTabPage.Text = "Time tracking";
            this.timeTrackingTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timeTrackingTabPage.VerticalScrollbarBarColor = true;
            this.timeTrackingTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.timeTrackingTabPage.VerticalScrollbarSize = 6;
            // 
            // tasksTabPage
            // 
            this.tasksTabPage.HorizontalScrollbarBarColor = true;
            this.tasksTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.tasksTabPage.HorizontalScrollbarSize = 6;
            this.tasksTabPage.Location = new System.Drawing.Point(4, 38);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Size = new System.Drawing.Size(1127, 491);
            this.tasksTabPage.Style = MetroFramework.MetroColorStyle.Lime;
            this.tasksTabPage.TabIndex = 1;
            this.tasksTabPage.Text = "Tasks";
            this.tasksTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tasksTabPage.VerticalScrollbarBarColor = true;
            this.tasksTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.tasksTabPage.VerticalScrollbarSize = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 613);
            this.Controls.Add(this.mainContainerTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ogarniętość to doskonałość";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryGridView)).EndInit();
            this.timeTrackerPanel.ResumeLayout(false);
            this.timeTrackerPanel.PerformLayout();
            this.activitiesListPanel.ResumeLayout(false);
            this.activitiesListPanel.PerformLayout();
            this.mainContainerTabControl.ResumeLayout(false);
            this.timeTrackingTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView activityHistoryGridView;
        private MetroPanel timeTrackerPanel;
        private System.Windows.Forms.Label startTimeLabel;
        private MetroButton startActivityButton;
        private MetroLabel timeLeftValueLabel;
        private MetroButton stopActivityButton;
        private MetroLabel endTimeValueLabel;
        private MetroButton saveActivityButton;
        private MetroLabel timeLeftLabel;
        private MetroLabel activityInProgressLabel;
        private MetroLabel endTimeLabel;
        private MetroPanel activitiesListPanel;
        private MetroLabel whatAreYouDoingLabel;
        private System.Windows.Forms.ListBox activitiesListBox;
        private MetroTextBox newActivityTextBox;
        private MetroButton addActivityButton;
        private MetroLabel inProgressLabel;
        private MetroButton resetActivityButton;
        private MetroButton pauseActivityButton;
        private MetroButton removeActivityButton;
        private System.Windows.Forms.Label startTimeValueLabel;
        private MetroFramework.Controls.MetroTabControl mainContainerTabControl;
        private MetroFramework.Controls.MetroTabPage timeTrackingTabPage;
        private MetroFramework.Controls.MetroTabPage tasksTabPage;
    }
}

