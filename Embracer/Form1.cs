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

        public Form1()
        {
            InitializeComponent();
            repository = new Repository();


            activityTimer = new Timer { Interval = 1000 };
            activityTimer.Tick += activityTimer_Tick;
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(newActivityTextBox.Text))
            {
                Activity newActivity = new Activity();
                newActivity.Name = newActivityTextBox.Text;

                repository.AddActivity(newActivity);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Activity> activities = repository.GetActivities().ToList();
            activitiesListBox.DataSource = activities;
            activitiesListBox.ValueMember = "Id";
            activitiesListBox.DisplayMember = "Name";
        }

        private DateTime startTime;

        private DateTime endTime;
        private Int16 interval;
        private Activity currentActivity;
        private Timer activityTimer;

        private void startActivityButton_Click(object sender, EventArgs e)
        {
            currentActivity = activitiesListBox.SelectedItem as Activity;
            interval = 0;

            startTime = DateTime.Now;
            startTimeValueLabel.Text = startTime.ToLongTimeString();
            endTimeValueLabel.Text = Resources.EmptyTime;

            activityTimer.Start();
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
            period.Interval = interval;

            currentActivity.TimePeriod.Add(period);

            repository.UpdateActivity(currentActivity);
        }
    }
}
