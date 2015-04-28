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

namespace Embracer
{
    public partial class Form1 : Form
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
            List<TimePeriod> activitiesHistory = repository.GetActivitiesHistory().ToList();
            activityHistoryGridView.DataSource = activitiesHistory;
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
            activityTimer.Stop();
            endTime = DateTime.Now;
            endTimeValueLabel.Text = endTime.ToLongTimeString();
        }

        private void saveActivityButton_Click(object sender, EventArgs e)
        {
            TimePeriod period = new TimePeriod();
            period.Start = startTime;
            period.Stop = endTime;
            period.Interval = (startTime - endTime).Minutes;

            currentActivity.TimePeriod.Add(period);

            repository.UpdateActivity(currentActivity);
        }

        private void activitiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            startTimeValueLabel.Text = Resources.EmptyTime;
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
    }
}
