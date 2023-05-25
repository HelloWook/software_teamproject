namespace soft_team9
{
    partial class User_DetailsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_DetailsUI));
            this.label1 = new System.Windows.Forms.Label();
            this.User_pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserModify_Button = new System.Windows.Forms.Button();
            this.UserDelete_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.UserRank_Combobox = new System.Windows.Forms.ComboBox();
            this.UserName_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(150, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름:";
            // 
            // User_pictureBox
            // 
            this.User_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User_pictureBox.BackgroundImage")));
            this.User_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.User_pictureBox.Name = "User_pictureBox";
            this.User_pictureBox.Size = new System.Drawing.Size(121, 152);
            this.User_pictureBox.TabIndex = 1;
            this.User_pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(150, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "직급:";
            // 
            // UserModify_Button
            // 
            this.UserModify_Button.BackColor = System.Drawing.Color.White;
            this.UserModify_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserModify_Button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserModify_Button.Location = new System.Drawing.Point(12, 179);
            this.UserModify_Button.Name = "UserModify_Button";
            this.UserModify_Button.Size = new System.Drawing.Size(86, 34);
            this.UserModify_Button.TabIndex = 5;
            this.UserModify_Button.Text = "수정";
            this.UserModify_Button.UseVisualStyleBackColor = false;
            // 
            // UserDelete_Button
            // 
            this.UserDelete_Button.BackColor = System.Drawing.Color.White;
            this.UserDelete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDelete_Button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserDelete_Button.Location = new System.Drawing.Point(143, 179);
            this.UserDelete_Button.Name = "UserDelete_Button";
            this.UserDelete_Button.Size = new System.Drawing.Size(86, 34);
            this.UserDelete_Button.TabIndex = 6;
            this.UserDelete_Button.Text = "삭제";
            this.UserDelete_Button.UseVisualStyleBackColor = false;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.White;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cancel_Button.Location = new System.Drawing.Point(276, 179);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(86, 34);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "취소";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // UserRank_Combobox
            // 
            this.UserRank_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserRank_Combobox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserRank_Combobox.FormattingEnabled = true;
            this.UserRank_Combobox.Items.AddRange(new object[] {
            "사장",
            "부장",
            "차장",
            "과장",
            "대리",
            "주임 ",
            "사원\\"});
            this.UserRank_Combobox.Location = new System.Drawing.Point(202, 97);
            this.UserRank_Combobox.Name = "UserRank_Combobox";
            this.UserRank_Combobox.Size = new System.Drawing.Size(140, 29);
            this.UserRank_Combobox.TabIndex = 9;
            // 
            // UserName_textBox
            // 
            this.UserName_textBox.BackColor = System.Drawing.Color.White;
            this.UserName_textBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserName_textBox.Location = new System.Drawing.Point(202, 50);
            this.UserName_textBox.Name = "UserName_textBox";
            this.UserName_textBox.Size = new System.Drawing.Size(140, 29);
            this.UserName_textBox.TabIndex = 3;
            // 
            // User_DetailsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(374, 225);
            this.Controls.Add(this.UserRank_Combobox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.UserDelete_Button);
            this.Controls.Add(this.UserModify_Button);
            this.Controls.Add(this.UserName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User_pictureBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_DetailsUI";
            this.Text = "User_DetailsUI";
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox User_pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UserModify_Button;
        private System.Windows.Forms.Button UserDelete_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.ComboBox UserRank_Combobox;
        private System.Windows.Forms.TextBox UserName_textBox;
    }
}