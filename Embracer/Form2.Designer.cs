namespace Embracer
{
    partial class Form2
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.trackerTabPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainContainerTabControl = new MetroFramework.Controls.MetroTabControl();
            this.timeTrackingTabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.metroTabControl1.SuspendLayout();
            this.mainContainerTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.trackerTabPage);
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(600, 300);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // trackerTabPage
            // 
            this.trackerTabPage.Location = new System.Drawing.Point(4, 35);
            this.trackerTabPage.Name = "trackerTabPage";
            this.trackerTabPage.Padding = new System.Windows.Forms.Padding(25);
            this.trackerTabPage.Size = new System.Drawing.Size(592, 261);
            this.trackerTabPage.TabIndex = 0;
            this.trackerTabPage.Text = "Tracker";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(592, 261);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            // 
            // mainContainerTabControl
            // 
            this.mainContainerTabControl.Controls.Add(this.timeTrackingTabPage);
            this.mainContainerTabControl.Controls.Add(this.tabPage2);
            this.mainContainerTabControl.Controls.Add(this.tabPage3);
            this.mainContainerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainerTabControl.Location = new System.Drawing.Point(20, 60);
            this.mainContainerTabControl.Name = "mainContainerTabControl";
            this.mainContainerTabControl.SelectedIndex = 0;
            this.mainContainerTabControl.Size = new System.Drawing.Size(612, 472);
            this.mainContainerTabControl.TabIndex = 0;
            this.mainContainerTabControl.UseSelectable = true;
            // 
            // timeTrackingTabPage
            // 
            this.timeTrackingTabPage.Location = new System.Drawing.Point(4, 38);
            this.timeTrackingTabPage.Name = "timeTrackingTabPage";
            this.timeTrackingTabPage.Size = new System.Drawing.Size(604, 430);
            this.timeTrackingTabPage.TabIndex = 0;
            this.timeTrackingTabPage.Text = "Time tracking";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(604, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(604, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 552);
            this.Controls.Add(this.mainContainerTabControl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.metroTabControl1.ResumeLayout(false);
            this.mainContainerTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage trackerTabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroTabControl mainContainerTabControl;
        private System.Windows.Forms.TabPage timeTrackingTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}