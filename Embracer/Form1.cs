using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Embracer.Properties;
using MetroFramework.Forms;

namespace Embracer
{
    public partial class Form1 : MetroForm
    {
        Repository repository;
        private DateTime startTime;

        private DateTime endTime;
        private Int16 interval;
        private Activity currentActivity;
        private Timer activityTimer;

        public Form1()
        {
            InitializeComponent();

            activityHistoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            activitiesListBox.ValueMember = "Id";
            activitiesListBox.DisplayMember = "Name";

            activityTimer = new Timer { Interval = 1000 };
            activityTimer.Tick += activityTimer_Tick;

            repository = new Repository();

            ResetTracker();
            RefreshActivitiesListBox();
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(newActivityTextBox.Text))
            {
                Activity newActivity = new Activity();
                newActivity.Name = newActivityTextBox.Text;
                repository.AddActivity(newActivity);
                RefreshActivitiesListBox();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshHistoryGridView();
        }

        private void startActivityButton_Click(object sender, EventArgs e)
        {
            StartTracker();
        }

        private void activityTimer_Tick(object sender, EventArgs e)
        {
            interval += 1;
            timeLeftValueLabel.Text = interval.ToString();
        }

        private void stopActivityButton_Click(object sender, EventArgs e)
        {
            StopTracker();
        }

        private void StopTracker()
        {

            activityTimer.Stop();
            endTime = DateTime.Now;
            endTimeValueLabel.Text = endTime.ToLongTimeString();
            saveActivityButton.Enabled = true;
        
        }

        private void saveActivityButton_Click(object sender, EventArgs e)
        {
            ReportActivityTime();

        }

        private void ReportActivityTime()
        {
            TimePeriod period = new TimePeriod();
            period.Start = startTime;
            period.Stop = endTime;
            period.Interval = (short)((endTime - endTime).TotalSeconds);

            currentActivity.TimePeriod.Add(period);

            repository.UpdateActivity(currentActivity);

            ResetTracker();
            RefreshHistoryGridView();
        }

        private void activitiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activity selecteActivty = activitiesListBox.SelectedItem as Activity;
            SelectedActivityChanged(selecteActivty);
        }

        private void SelectedActivityChanged(Activity activity)
        {
            activityInProgressLabel.Text = Text = activity.Name;
        }

        private void resetActivityButton_Click(object sender, EventArgs e)
        {
            ResetTracker();
        }

        private void StartTracker()
        {
            startActivityButton.Enabled = false;
            stopActivityButton.Enabled = true;
            pauseActivityButton.Enabled = true;
            resetActivityButton.Enabled = true;

            currentActivity = activitiesListBox.SelectedItem as Activity;
            interval = 0;

            startTime = DateTime.Now;
            startTimeValueLabel.Text = startTime.ToLongTimeString();
            endTimeValueLabel.Text = Resources.EmptyTime;

            activityTimer.Start();
        }
        private void ResetTracker()
        {
            saveActivityButton.Enabled = false;
            resetActivityButton.Enabled = false;
            pauseActivityButton.Enabled = false;
            stopActivityButton.Enabled = false;
            startActivityButton.Enabled = true;
            activityInProgressLabel.Text = Resources.EmptyTime;
            endTimeValueLabel.Text = Resources.EmptyTime;
            timeLeftValueLabel.Text = Resources.EmptyTime;

            interval = 0;
        }

        private void removeActivityButton_Click(object sender, EventArgs e)
        {
            if (activitiesListBox.SelectedItem != null)
            {
                Activity selectedActivity = activitiesListBox.SelectedItem as Activity;
                repository.RemoveActivity(selectedActivity);

                RefreshActivitiesListBox();
            }
        }

        private void RefreshActivitiesListBox()
        {
            List<Activity> activities = repository.GetActivities().ToList();
            activitiesListBox.DataSource = activities;
        }

        private void RefreshHistoryGridView()
        {
            activityHistoryGridView.DataSource = null;
            List<TimePeriod> activitiesHistory = repository.GetActivitiesHistory().ToList();
            activityHistoryGridView.DataSource = activitiesHistory;
        }

        private void activityHistoryGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {//
              //  e.Value = (int)e.Value/60;
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
