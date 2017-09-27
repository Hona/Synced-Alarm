namespace ClientUI
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lblTimeUntilNextAlarm = new System.Windows.Forms.Label();
            this.lblAlarmList = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.niClientTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            this.cmsTrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.lblTimeUntilNextAlarm);
            this.MainPanel.Controls.Add(this.lblAlarmList);
            this.MainPanel.Controls.Add(this.lblTime);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(814, 414);
            this.MainPanel.TabIndex = 0;
            // 
            // lblTimeUntilNextAlarm
            // 
            this.lblTimeUntilNextAlarm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTimeUntilNextAlarm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeUntilNextAlarm.Location = new System.Drawing.Point(0, 0);
            this.lblTimeUntilNextAlarm.Name = "lblTimeUntilNextAlarm";
            this.lblTimeUntilNextAlarm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTimeUntilNextAlarm.Size = new System.Drawing.Size(98, 414);
            this.lblTimeUntilNextAlarm.TabIndex = 2;
            this.lblTimeUntilNextAlarm.Text = "00:00";
            this.lblTimeUntilNextAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlarmList
            // 
            this.lblAlarmList.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAlarmList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmList.Location = new System.Drawing.Point(680, 0);
            this.lblAlarmList.Name = "lblAlarmList";
            this.lblAlarmList.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.lblAlarmList.Size = new System.Drawing.Size(134, 414);
            this.lblAlarmList.TabIndex = 1;
            this.lblAlarmList.Text = "00:00";
            this.lblAlarmList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(814, 414);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // niClientTray
            // 
            this.niClientTray.ContextMenuStrip = this.cmsTrayIcon;
            this.niClientTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niClientTray.Icon")));
            this.niClientTray.Text = "MenuUI";
            // 
            // cmsTrayIcon
            // 
            this.cmsTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.fullscreenToolStripMenuItem});
            this.cmsTrayIcon.Name = "cmsTrayIcon";
            this.cmsTrayIcon.Size = new System.Drawing.Size(128, 48);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 414);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(790, 161);
            this.Name = "MainUI";
            this.Text = "Synced Alarm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainUI_KeyDown);
            this.MainPanel.ResumeLayout(false);
            this.cmsTrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAlarmList;
        private System.Windows.Forms.Label lblTimeUntilNextAlarm;
        private System.Windows.Forms.NotifyIcon niClientTray;
        private System.Windows.Forms.ContextMenuStrip cmsTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
    }
}