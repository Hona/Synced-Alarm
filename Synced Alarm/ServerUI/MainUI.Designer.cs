namespace ServerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.btnPostClient = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpecificMessage = new System.Windows.Forms.TextBox();
            this.rbTextToSpeech = new System.Windows.Forms.RadioButton();
            this.rbSound = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSpecificAlarm = new System.Windows.Forms.Button();
            this.dtpSpecificAlarm = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAddAlarmAtStartTime = new System.Windows.Forms.CheckBox();
            this.btnAddIntervalTimes = new System.Windows.Forms.Button();
            this.dtpStopTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAlarmInterval = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AlarmsListTab = new System.Windows.Forms.TabPage();
            this.lvAlarmsList = new System.Windows.Forms.ListView();
            this.chAlarmTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAlarmMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSound = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lowerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlarmInterval)).BeginInit();
            this.AlarmsListTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lowerPanel
            // 
            this.lowerPanel.Controls.Add(this.btnPostClient);
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowerPanel.Location = new System.Drawing.Point(0, 417);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(784, 44);
            this.lowerPanel.TabIndex = 0;
            // 
            // btnPostClient
            // 
            this.btnPostClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPostClient.Location = new System.Drawing.Point(0, 0);
            this.btnPostClient.Name = "btnPostClient";
            this.btnPostClient.Size = new System.Drawing.Size(784, 44);
            this.btnPostClient.TabIndex = 0;
            this.btnPostClient.Text = "Post Client";
            this.btnPostClient.UseVisualStyleBackColor = true;
            this.btnPostClient.Click += new System.EventHandler(this.btnPostClient_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.tabSettings);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 417);
            this.mainPanel.TabIndex = 1;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.GeneralTab);
            this.tabSettings.Controls.Add(this.AlarmsListTab);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(784, 417);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Click += new System.EventHandler(this.tabSettings_Click);
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.label10);
            this.GeneralTab.Controls.Add(this.label4);
            this.GeneralTab.Controls.Add(this.txtSpecificMessage);
            this.GeneralTab.Controls.Add(this.rbTextToSpeech);
            this.GeneralTab.Controls.Add(this.rbSound);
            this.GeneralTab.Controls.Add(this.label3);
            this.GeneralTab.Controls.Add(this.btnAddSpecificAlarm);
            this.GeneralTab.Controls.Add(this.dtpSpecificAlarm);
            this.GeneralTab.Controls.Add(this.label2);
            this.GeneralTab.Controls.Add(this.label9);
            this.GeneralTab.Controls.Add(this.cbAddAlarmAtStartTime);
            this.GeneralTab.Controls.Add(this.btnAddIntervalTimes);
            this.GeneralTab.Controls.Add(this.dtpStopTime);
            this.GeneralTab.Controls.Add(this.dtpStartTime);
            this.GeneralTab.Controls.Add(this.label8);
            this.GeneralTab.Controls.Add(this.label7);
            this.GeneralTab.Controls.Add(this.nudAlarmInterval);
            this.GeneralTab.Controls.Add(this.label6);
            this.GeneralTab.Controls.Add(this.label5);
            this.GeneralTab.Controls.Add(this.label1);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Size = new System.Drawing.Size(776, 391);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 111);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(98, 40);
            this.label10.TabIndex = 28;
            this.label10.Text = "Text to Speech :Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Alarm Mode:";
            // 
            // txtSpecificMessage
            // 
            this.txtSpecificMessage.Location = new System.Drawing.Point(415, 94);
            this.txtSpecificMessage.Multiline = true;
            this.txtSpecificMessage.Name = "txtSpecificMessage";
            this.txtSpecificMessage.Size = new System.Drawing.Size(206, 67);
            this.txtSpecificMessage.TabIndex = 26;
            // 
            // rbTextToSpeech
            // 
            this.rbTextToSpeech.AutoSize = true;
            this.rbTextToSpeech.Location = new System.Drawing.Point(475, 71);
            this.rbTextToSpeech.Name = "rbTextToSpeech";
            this.rbTextToSpeech.Size = new System.Drawing.Size(98, 17);
            this.rbTextToSpeech.TabIndex = 25;
            this.rbTextToSpeech.TabStop = true;
            this.rbTextToSpeech.Text = "Text to Speech";
            this.rbTextToSpeech.UseVisualStyleBackColor = true;
            this.rbTextToSpeech.CheckedChanged += new System.EventHandler(this.SpecificControls_Changed);
            // 
            // rbSound
            // 
            this.rbSound.AutoSize = true;
            this.rbSound.Location = new System.Drawing.Point(413, 71);
            this.rbSound.Name = "rbSound";
            this.rbSound.Size = new System.Drawing.Size(56, 17);
            this.rbSound.TabIndex = 24;
            this.rbSound.TabStop = true;
            this.rbSound.Text = "Sound";
            this.rbSound.UseVisualStyleBackColor = true;
            this.rbSound.CheckedChanged += new System.EventHandler(this.SpecificControls_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Alarm Time: ";
            // 
            // btnAddSpecificAlarm
            // 
            this.btnAddSpecificAlarm.Location = new System.Drawing.Point(413, 193);
            this.btnAddSpecificAlarm.Name = "btnAddSpecificAlarm";
            this.btnAddSpecificAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnAddSpecificAlarm.TabIndex = 22;
            this.btnAddSpecificAlarm.Text = "Add Alarm";
            this.btnAddSpecificAlarm.UseVisualStyleBackColor = true;
            this.btnAddSpecificAlarm.Click += new System.EventHandler(this.btnAddSpecificAlarm_Click);
            // 
            // dtpSpecificAlarm
            // 
            this.dtpSpecificAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSpecificAlarm.Location = new System.Drawing.Point(415, 167);
            this.dtpSpecificAlarm.Name = "dtpSpecificAlarm";
            this.dtpSpecificAlarm.Size = new System.Drawing.Size(119, 20);
            this.dtpSpecificAlarm.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add Alarm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Add Alarm at Start time:";
            // 
            // cbAddAlarmAtStartTime
            // 
            this.cbAddAlarmAtStartTime.AutoSize = true;
            this.cbAddAlarmAtStartTime.Location = new System.Drawing.Point(157, 147);
            this.cbAddAlarmAtStartTime.Name = "cbAddAlarmAtStartTime";
            this.cbAddAlarmAtStartTime.Size = new System.Drawing.Size(15, 14);
            this.cbAddAlarmAtStartTime.TabIndex = 16;
            this.cbAddAlarmAtStartTime.UseVisualStyleBackColor = true;
            // 
            // btnAddIntervalTimes
            // 
            this.btnAddIntervalTimes.Location = new System.Drawing.Point(123, 164);
            this.btnAddIntervalTimes.Name = "btnAddIntervalTimes";
            this.btnAddIntervalTimes.Size = new System.Drawing.Size(75, 23);
            this.btnAddIntervalTimes.TabIndex = 15;
            this.btnAddIntervalTimes.Text = "Add Alarms";
            this.btnAddIntervalTimes.UseVisualStyleBackColor = true;
            this.btnAddIntervalTimes.Click += new System.EventHandler(this.btnAddIntervalTimes_Click);
            // 
            // dtpStopTime
            // 
            this.dtpStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStopTime.Location = new System.Drawing.Point(157, 120);
            this.dtpStopTime.Name = "dtpStopTime";
            this.dtpStopTime.Size = new System.Drawing.Size(119, 20);
            this.dtpStopTime.TabIndex = 14;
            this.dtpStopTime.ValueChanged += new System.EventHandler(this.nudIntervalBasedAlarm_ValueChanged);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(157, 96);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(119, 20);
            this.dtpStartTime.TabIndex = 13;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.nudIntervalBasedAlarm_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Stop Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Start Time:";
            // 
            // nudAlarmInterval
            // 
            this.nudAlarmInterval.Location = new System.Drawing.Point(157, 72);
            this.nudAlarmInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAlarmInterval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudAlarmInterval.Name = "nudAlarmInterval";
            this.nudAlarmInterval.Size = new System.Drawing.Size(120, 20);
            this.nudAlarmInterval.TabIndex = 9;
            this.nudAlarmInterval.ValueChanged += new System.EventHandler(this.nudIntervalBasedAlarm_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Interval (Minutes):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Add Interval-based Alarms:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose general settings:";
            // 
            // AlarmsListTab
            // 
            this.AlarmsListTab.Controls.Add(this.lvAlarmsList);
            this.AlarmsListTab.Location = new System.Drawing.Point(4, 22);
            this.AlarmsListTab.Name = "AlarmsListTab";
            this.AlarmsListTab.Size = new System.Drawing.Size(776, 391);
            this.AlarmsListTab.TabIndex = 3;
            this.AlarmsListTab.Text = "Alarms List";
            this.AlarmsListTab.UseVisualStyleBackColor = true;
            // 
            // lvAlarmsList
            // 
            this.lvAlarmsList.CheckBoxes = true;
            this.lvAlarmsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAlarmTime,
            this.chAlarmMode,
            this.chSound,
            this.chMessage});
            this.lvAlarmsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAlarmsList.Location = new System.Drawing.Point(0, 0);
            this.lvAlarmsList.Name = "lvAlarmsList";
            this.lvAlarmsList.Size = new System.Drawing.Size(776, 391);
            this.lvAlarmsList.TabIndex = 0;
            this.lvAlarmsList.UseCompatibleStateImageBehavior = false;
            this.lvAlarmsList.View = System.Windows.Forms.View.Details;
            this.lvAlarmsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvAlarmsList_ItemCheck);
            // 
            // chAlarmTime
            // 
            this.chAlarmTime.Text = "Alarm Time";
            this.chAlarmTime.Width = 142;
            // 
            // chAlarmMode
            // 
            this.chAlarmMode.Text = "Alarm Mode";
            this.chAlarmMode.Width = 92;
            // 
            // chSound
            // 
            this.chSound.Text = "Sound";
            // 
            // chMessage
            // 
            this.chMessage.Text = "Message (If any)";
            this.chMessage.Width = 543;
            // 
            // chTime
            // 
            this.chTime.Text = "";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.lowerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "Alarm Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.lowerPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.GeneralTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlarmInterval)).EndInit();
            this.AlarmsListTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnPostClient;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbAddAlarmAtStartTime;
        private System.Windows.Forms.Button btnAddIntervalTimes;
        private System.Windows.Forms.DateTimePicker dtpStopTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAlarmInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage AlarmsListTab;
        private System.Windows.Forms.ListView lvAlarmsList;
        private System.Windows.Forms.ColumnHeader chAlarmTime;
        private System.Windows.Forms.ColumnHeader chAlarmMode;
        private System.Windows.Forms.ColumnHeader chSound;
        private System.Windows.Forms.ColumnHeader chMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddSpecificAlarm;
        private System.Windows.Forms.DateTimePicker dtpSpecificAlarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpecificMessage;
        private System.Windows.Forms.RadioButton rbTextToSpeech;
        private System.Windows.Forms.RadioButton rbSound;
    }
}