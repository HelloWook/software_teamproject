namespace soft_team9
{
    partial class DayCalenderUI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayCalenderUI));
            this.day = new System.Windows.Forms.DateTimePicker();
            this.Schedule_ListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.ScheduleAddButton = new System.Windows.Forms.Button();
            this.ScheduleModifyButton = new System.Windows.Forms.Button();
            this.ScheduleDeleteButton = new System.Windows.Forms.Button();
            this.MonthReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.CalendarFont = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day.CalendarMonthBackground = System.Drawing.Color.White;
            this.day.CustomFormat = "yyyy-MM-dd";
            this.day.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.day.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.day.Location = new System.Drawing.Point(23, 23);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(200, 46);
            this.day.TabIndex = 0;
            // 
            // Schedule_ListBox
            // 
            this.Schedule_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Schedule_ListBox.FormattingEnabled = true;
            this.Schedule_ListBox.ItemHeight = 12;
            this.Schedule_ListBox.Location = new System.Drawing.Point(23, 84);
            this.Schedule_ListBox.Name = "Schedule_ListBox";
            this.Schedule_ListBox.Size = new System.Drawing.Size(727, 458);
            this.Schedule_ListBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(756, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 160);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(775, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(775, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "직급:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(818, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(818, 198);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 17);
            this.name.TabIndex = 5;
            this.name.Text = "label3";
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.BackColor = System.Drawing.Color.White;
            this.LogOutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutbutton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LogOutbutton.Location = new System.Drawing.Point(756, 258);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(131, 37);
            this.LogOutbutton.TabIndex = 7;
            this.LogOutbutton.Text = "로그아웃";
            this.LogOutbutton.UseVisualStyleBackColor = false;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // ScheduleAddButton
            // 
            this.ScheduleAddButton.BackColor = System.Drawing.Color.MistyRose;
            this.ScheduleAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleAddButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScheduleAddButton.Location = new System.Drawing.Point(757, 336);
            this.ScheduleAddButton.Name = "ScheduleAddButton";
            this.ScheduleAddButton.Size = new System.Drawing.Size(131, 37);
            this.ScheduleAddButton.TabIndex = 8;
            this.ScheduleAddButton.Text = "스케줄 등록";
            this.ScheduleAddButton.UseVisualStyleBackColor = false;
            this.ScheduleAddButton.Click += new System.EventHandler(this.ScheduleAddButton_Click);
            // 
            // ScheduleModifyButton
            // 
            this.ScheduleModifyButton.BackColor = System.Drawing.Color.MistyRose;
            this.ScheduleModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleModifyButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScheduleModifyButton.Location = new System.Drawing.Point(757, 379);
            this.ScheduleModifyButton.Name = "ScheduleModifyButton";
            this.ScheduleModifyButton.Size = new System.Drawing.Size(131, 37);
            this.ScheduleModifyButton.TabIndex = 9;
            this.ScheduleModifyButton.Text = "스케줄 수정";
            this.ScheduleModifyButton.UseVisualStyleBackColor = false;
            this.ScheduleModifyButton.Click += new System.EventHandler(this.ScheduleModifyButton_Click);
            // 
            // ScheduleDeleteButton
            // 
            this.ScheduleDeleteButton.BackColor = System.Drawing.Color.MistyRose;
            this.ScheduleDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleDeleteButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScheduleDeleteButton.Location = new System.Drawing.Point(757, 422);
            this.ScheduleDeleteButton.Name = "ScheduleDeleteButton";
            this.ScheduleDeleteButton.Size = new System.Drawing.Size(131, 37);
            this.ScheduleDeleteButton.TabIndex = 10;
            this.ScheduleDeleteButton.Text = "스케줄 삭제";
            this.ScheduleDeleteButton.UseVisualStyleBackColor = false;
            this.ScheduleDeleteButton.Click += new System.EventHandler(this.ScheduleDeleteButton_Click);
            // 
            // MonthReturnButton
            // 
            this.MonthReturnButton.BackColor = System.Drawing.Color.White;
            this.MonthReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthReturnButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MonthReturnButton.Location = new System.Drawing.Point(757, 505);
            this.MonthReturnButton.Name = "MonthReturnButton";
            this.MonthReturnButton.Size = new System.Drawing.Size(131, 37);
            this.MonthReturnButton.TabIndex = 11;
            this.MonthReturnButton.Text = "나가기";
            this.MonthReturnButton.UseVisualStyleBackColor = false;
            this.MonthReturnButton.Click += new System.EventHandler(this.MonthReturnButton_Click);
            // 
            // DayCalenderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 562);
            this.Controls.Add(this.MonthReturnButton);
            this.Controls.Add(this.ScheduleDeleteButton);
            this.Controls.Add(this.ScheduleModifyButton);
            this.Controls.Add(this.ScheduleAddButton);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Schedule_ListBox);
            this.Controls.Add(this.day);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DayCalenderUI";
            this.Text = "DayCalenderUI";
            this.Load += new System.EventHandler(this.DayCalenderUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker day;
        private System.Windows.Forms.ListBox Schedule_ListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.Button ScheduleAddButton;
        private System.Windows.Forms.Button ScheduleModifyButton;
        private System.Windows.Forms.Button ScheduleDeleteButton;
        private System.Windows.Forms.Button MonthReturnButton;
    }
}

