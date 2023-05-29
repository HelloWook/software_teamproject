namespace soft_team9
{
    partial class DetailedScheduleUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedScheduleUI));
            this.Detailed_day = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AlarmAdd_Button = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Alarm_Delete_Button = new System.Windows.Forms.Button();
            this.AlarmDateTime_Hour = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Alarm_offButton = new System.Windows.Forms.Button();
            this.Alarm_onButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.Repetition_Off_Button = new System.Windows.Forms.Button();
            this.Repetition_On_Button = new System.Windows.Forms.Button();
            this.AlarmName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Schedule_summary = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.ScheduleContents_textBox = new System.Windows.Forms.TextBox();
            this.ScheduleLocation_textBox = new System.Windows.Forms.TextBox();
            this.ScheduleTitle_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.DayReturnButton = new System.Windows.Forms.Button();
            this.Check_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmDateTime_Hour)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Detailed_day
            // 
            this.Detailed_day.CalendarFont = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Detailed_day.CalendarMonthBackground = System.Drawing.Color.White;
            this.Detailed_day.CustomFormat = "yyyy-MM-dd";
            this.Detailed_day.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Detailed_day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Detailed_day.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Detailed_day.Location = new System.Drawing.Point(27, 23);
            this.Detailed_day.Name = "Detailed_day";
            this.Detailed_day.Size = new System.Drawing.Size(200, 46);
            this.Detailed_day.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ScheduleLocation_textBox);
            this.panel1.Controls.Add(this.ScheduleTitle_textBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(23, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 458);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.linkLabel2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.AlarmAdd_Button);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Controls.Add(this.Alarm_Delete_Button);
            this.panel3.Controls.Add(this.AlarmDateTime_Hour);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(364, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 411);
            this.panel3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(106, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "< 알람 설정 >";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel2.Location = new System.Drawing.Point(4, 21);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(349, 12);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "                                                                                 " +
    "     ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "시간:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(189, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = ":";
            // 
            // AlarmAdd_Button
            // 
            this.AlarmAdd_Button.BackColor = System.Drawing.Color.White;
            this.AlarmAdd_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlarmAdd_Button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AlarmAdd_Button.Location = new System.Drawing.Point(45, 353);
            this.AlarmAdd_Button.Name = "AlarmAdd_Button";
            this.AlarmAdd_Button.Size = new System.Drawing.Size(67, 29);
            this.AlarmAdd_Button.TabIndex = 22;
            this.AlarmAdd_Button.Text = "저장";
            this.AlarmAdd_Button.UseVisualStyleBackColor = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown2.Location = new System.Drawing.Point(227, 82);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(95, 29);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Alarm_Delete_Button
            // 
            this.Alarm_Delete_Button.BackColor = System.Drawing.Color.White;
            this.Alarm_Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alarm_Delete_Button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Alarm_Delete_Button.Location = new System.Drawing.Point(148, 353);
            this.Alarm_Delete_Button.Name = "Alarm_Delete_Button";
            this.Alarm_Delete_Button.Size = new System.Drawing.Size(67, 29);
            this.Alarm_Delete_Button.TabIndex = 23;
            this.Alarm_Delete_Button.Text = "삭제";
            this.Alarm_Delete_Button.UseVisualStyleBackColor = false;
            // 
            // AlarmDateTime_Hour
            // 
            this.AlarmDateTime_Hour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AlarmDateTime_Hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlarmDateTime_Hour.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AlarmDateTime_Hour.Location = new System.Drawing.Point(74, 82);
            this.AlarmDateTime_Hour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.AlarmDateTime_Hour.Name = "AlarmDateTime_Hour";
            this.AlarmDateTime_Hour.Size = new System.Drawing.Size(95, 29);
            this.AlarmDateTime_Hour.TabIndex = 17;
            this.AlarmDateTime_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(255, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Alarm_offButton);
            this.panel4.Controls.Add(this.Alarm_onButton);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.Repetition_Off_Button);
            this.panel4.Controls.Add(this.Repetition_On_Button);
            this.panel4.Controls.Add(this.AlarmName);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(6, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 136);
            this.panel4.TabIndex = 21;
            // 
            // Alarm_offButton
            // 
            this.Alarm_offButton.BackColor = System.Drawing.Color.White;
            this.Alarm_offButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Alarm_offButton.BackgroundImage")));
            this.Alarm_offButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alarm_offButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alarm_offButton.Location = new System.Drawing.Point(300, 9);
            this.Alarm_offButton.Name = "Alarm_offButton";
            this.Alarm_offButton.Size = new System.Drawing.Size(34, 33);
            this.Alarm_offButton.TabIndex = 6;
            this.Alarm_offButton.UseVisualStyleBackColor = false;
            // 
            // Alarm_onButton
            // 
            this.Alarm_onButton.BackColor = System.Drawing.Color.White;
            this.Alarm_onButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Alarm_onButton.BackgroundImage")));
            this.Alarm_onButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alarm_onButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alarm_onButton.Location = new System.Drawing.Point(262, 9);
            this.Alarm_onButton.Name = "Alarm_onButton";
            this.Alarm_onButton.Size = new System.Drawing.Size(32, 33);
            this.Alarm_onButton.TabIndex = 5;
            this.Alarm_onButton.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(3, 39);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(337, 12);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "                                                                                 " +
    "  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(3, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "알람 on/ off:";
            // 
            // Repetition_Off_Button
            // 
            this.Repetition_Off_Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Repetition_Off_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repetition_Off_Button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Repetition_Off_Button.Location = new System.Drawing.Point(280, 101);
            this.Repetition_Off_Button.Name = "Repetition_Off_Button";
            this.Repetition_Off_Button.Size = new System.Drawing.Size(54, 28);
            this.Repetition_Off_Button.TabIndex = 7;
            this.Repetition_Off_Button.Text = "OFF";
            this.Repetition_Off_Button.UseVisualStyleBackColor = false;
            // 
            // Repetition_On_Button
            // 
            this.Repetition_On_Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Repetition_On_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repetition_On_Button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Repetition_On_Button.Location = new System.Drawing.Point(214, 101);
            this.Repetition_On_Button.Name = "Repetition_On_Button";
            this.Repetition_On_Button.Size = new System.Drawing.Size(54, 28);
            this.Repetition_On_Button.TabIndex = 6;
            this.Repetition_On_Button.Text = "ON";
            this.Repetition_On_Button.UseVisualStyleBackColor = false;
            this.Repetition_On_Button.Click += new System.EventHandler(this.Repetition_On_Button_Click);
            // 
            // AlarmName
            // 
            this.AlarmName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AlarmName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlarmName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AlarmName.Location = new System.Drawing.Point(57, 63);
            this.AlarmName.Name = "AlarmName";
            this.AlarmName.Size = new System.Drawing.Size(278, 20);
            this.AlarmName.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(5, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "다시 알림:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(5, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "레이블:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Schedule_summary);
            this.panel2.Controls.Add(this.linkLabel3);
            this.panel2.Controls.Add(this.ScheduleContents_textBox);
            this.panel2.Location = new System.Drawing.Point(3, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 411);
            this.panel2.TabIndex = 9;
            // 
            // Schedule_summary
            // 
            this.Schedule_summary.AutoSize = true;
            this.Schedule_summary.BackColor = System.Drawing.Color.White;
            this.Schedule_summary.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Schedule_summary.Location = new System.Drawing.Point(6, 5);
            this.Schedule_summary.Name = "Schedule_summary";
            this.Schedule_summary.Size = new System.Drawing.Size(52, 21);
            this.Schedule_summary.TabIndex = 2;
            this.Schedule_summary.Text = "내용: ";
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel3.Location = new System.Drawing.Point(3, 21);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(349, 12);
            this.linkLabel3.TabIndex = 26;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "                                                                                 " +
    "     ";
            // 
            // ScheduleContents_textBox
            // 
            this.ScheduleContents_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScheduleContents_textBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScheduleContents_textBox.Location = new System.Drawing.Point(-1, 36);
            this.ScheduleContents_textBox.Multiline = true;
            this.ScheduleContents_textBox.Name = "ScheduleContents_textBox";
            this.ScheduleContents_textBox.Size = new System.Drawing.Size(357, 374);
            this.ScheduleContents_textBox.TabIndex = 3;
            // 
            // ScheduleLocation_textBox
            // 
            this.ScheduleLocation_textBox.BackColor = System.Drawing.Color.White;
            this.ScheduleLocation_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScheduleLocation_textBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScheduleLocation_textBox.Location = new System.Drawing.Point(405, 7);
            this.ScheduleLocation_textBox.Name = "ScheduleLocation_textBox";
            this.ScheduleLocation_textBox.Size = new System.Drawing.Size(313, 22);
            this.ScheduleLocation_textBox.TabIndex = 8;
            this.ScheduleLocation_textBox.Text = "장소";
            // 
            // ScheduleTitle_textBox
            // 
            this.ScheduleTitle_textBox.BackColor = System.Drawing.Color.White;
            this.ScheduleTitle_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScheduleTitle_textBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScheduleTitle_textBox.Location = new System.Drawing.Point(47, 7);
            this.ScheduleTitle_textBox.Name = "ScheduleTitle_textBox";
            this.ScheduleTitle_textBox.Size = new System.Drawing.Size(313, 22);
            this.ScheduleTitle_textBox.TabIndex = 7;
            this.ScheduleTitle_textBox.Text = "스케줄 제목";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(363, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "장소: ";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.MistyRose;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(5, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(52, 21);
            this.Title.TabIndex = 1;
            this.Title.Text = "제목: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Location = new System.Drawing.Point(-1, -1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(727, 37);
            this.textBox1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(819, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(819, 198);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 17);
            this.name.TabIndex = 10;
            this.name.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(776, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "직급:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(776, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "이름:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(756, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 160);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.BackColor = System.Drawing.Color.White;
            this.LogOutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutbutton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LogOutbutton.Location = new System.Drawing.Point(756, 250);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(131, 37);
            this.LogOutbutton.TabIndex = 12;
            this.LogOutbutton.Text = "로그아웃";
            this.LogOutbutton.UseVisualStyleBackColor = false;
            // 
            // DayReturnButton
            // 
            this.DayReturnButton.BackColor = System.Drawing.Color.White;
            this.DayReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayReturnButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DayReturnButton.Location = new System.Drawing.Point(757, 505);
            this.DayReturnButton.Name = "DayReturnButton";
            this.DayReturnButton.Size = new System.Drawing.Size(131, 37);
            this.DayReturnButton.TabIndex = 13;
            this.DayReturnButton.Text = "나가기";
            this.DayReturnButton.UseVisualStyleBackColor = false;
            this.DayReturnButton.Click += new System.EventHandler(this.DayReturnButton_Click);
            // 
            // Check_Button
            // 
            this.Check_Button.BackColor = System.Drawing.Color.MistyRose;
            this.Check_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_Button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Check_Button.Location = new System.Drawing.Point(757, 419);
            this.Check_Button.Name = "Check_Button";
            this.Check_Button.Size = new System.Drawing.Size(131, 37);
            this.Check_Button.TabIndex = 14;
            this.Check_Button.Text = "완료";
            this.Check_Button.UseVisualStyleBackColor = false;
            this.Check_Button.Click += new System.EventHandler(this.Check_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.MistyRose;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cancel_Button.Location = new System.Drawing.Point(757, 462);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(131, 37);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "취소";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // DetailedScheduleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 562);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Check_Button);
            this.Controls.Add(this.DayReturnButton);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Detailed_day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailedScheduleUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailedScheduleUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmDateTime_Hour)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Detailed_day;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.Button DayReturnButton;
        private System.Windows.Forms.Button Check_Button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ScheduleContents_textBox;
        private System.Windows.Forms.Label Schedule_summary;
        private System.Windows.Forms.TextBox ScheduleLocation_textBox;
        private System.Windows.Forms.TextBox ScheduleTitle_textBox;
        private System.Windows.Forms.Button Alarm_offButton;
        private System.Windows.Forms.Button Alarm_onButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AlarmAdd_Button;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button Alarm_Delete_Button;
        private System.Windows.Forms.NumericUpDown AlarmDateTime_Hour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Repetition_Off_Button;
        private System.Windows.Forms.Button Repetition_On_Button;
        private System.Windows.Forms.TextBox AlarmName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}