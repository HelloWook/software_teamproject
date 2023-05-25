namespace soft_team9
{
    partial class MembershipUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembershipUI));
            this.MemberShipRANK_combobox = new System.Windows.Forms.ComboBox();
            this.MemberCancle_Button = new System.Windows.Forms.Button();
            this.MemberShipJoin_Button = new System.Windows.Forms.Button();
            this.MemberShipName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.User_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberShipID_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MemberShipPW_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberShipRANK_combobox
            // 
            this.MemberShipRANK_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MemberShipRANK_combobox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemberShipRANK_combobox.FormattingEnabled = true;
            this.MemberShipRANK_combobox.Items.AddRange(new object[] {
            "사장",
            "부장",
            "차장",
            "과장",
            "대리",
            "주임 ",
            "사원"});
            this.MemberShipRANK_combobox.Location = new System.Drawing.Point(234, 135);
            this.MemberShipRANK_combobox.Name = "MemberShipRANK_combobox";
            this.MemberShipRANK_combobox.Size = new System.Drawing.Size(162, 29);
            this.MemberShipRANK_combobox.TabIndex = 17;
            this.MemberShipRANK_combobox.SelectedIndexChanged += new System.EventHandler(this.MemberShipRANK_combobox_SelectedIndexChanged);
            // 
            // MemberCancle_Button
            // 
            this.MemberCancle_Button.BackColor = System.Drawing.Color.White;
            this.MemberCancle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberCancle_Button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemberCancle_Button.Location = new System.Drawing.Point(310, 191);
            this.MemberCancle_Button.Name = "MemberCancle_Button";
            this.MemberCancle_Button.Size = new System.Drawing.Size(86, 34);
            this.MemberCancle_Button.TabIndex = 16;
            this.MemberCancle_Button.Text = "취소";
            this.MemberCancle_Button.UseVisualStyleBackColor = false;
            this.MemberCancle_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // MemberShipJoin_Button
            // 
            this.MemberShipJoin_Button.BackColor = System.Drawing.Color.White;
            this.MemberShipJoin_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberShipJoin_Button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemberShipJoin_Button.Location = new System.Drawing.Point(204, 191);
            this.MemberShipJoin_Button.Name = "MemberShipJoin_Button";
            this.MemberShipJoin_Button.Size = new System.Drawing.Size(86, 34);
            this.MemberShipJoin_Button.TabIndex = 15;
            this.MemberShipJoin_Button.Text = "가입";
            this.MemberShipJoin_Button.UseVisualStyleBackColor = false;
            this.MemberShipJoin_Button.Click += new System.EventHandler(this.MemberShipJoin_Button_Click);
            // 
            // MemberShipName_textBox
            // 
            this.MemberShipName_textBox.BackColor = System.Drawing.Color.White;
            this.MemberShipName_textBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemberShipName_textBox.Location = new System.Drawing.Point(234, 12);
            this.MemberShipName_textBox.Name = "MemberShipName_textBox";
            this.MemberShipName_textBox.Size = new System.Drawing.Size(162, 29);
            this.MemberShipName_textBox.TabIndex = 13;
            this.MemberShipName_textBox.TextChanged += new System.EventHandler(this.UserName_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(182, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "직급:";
            // 
            // User_pictureBox
            // 
            this.User_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User_pictureBox.BackgroundImage")));
            this.User_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_pictureBox.Location = new System.Drawing.Point(41, 12);
            this.User_pictureBox.Name = "User_pictureBox";
            this.User_pictureBox.Size = new System.Drawing.Size(121, 152);
            this.User_pictureBox.TabIndex = 11;
            this.User_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(182, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "이름:";
            // 
            // MemberShipID_textBox
            // 
            this.MemberShipID_textBox.BackColor = System.Drawing.Color.White;
            this.MemberShipID_textBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemberShipID_textBox.Location = new System.Drawing.Point(234, 52);
            this.MemberShipID_textBox.Name = "MemberShipID_textBox";
            this.MemberShipID_textBox.Size = new System.Drawing.Size(162, 29);
            this.MemberShipID_textBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(197, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID:";
            // 
            // MemberShipPW_textBox
            // 
            this.MemberShipPW_textBox.BackColor = System.Drawing.Color.White;
            this.MemberShipPW_textBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemberShipPW_textBox.Location = new System.Drawing.Point(234, 92);
            this.MemberShipPW_textBox.Name = "MemberShipPW_textBox";
            this.MemberShipPW_textBox.Size = new System.Drawing.Size(162, 29);
            this.MemberShipPW_textBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(188, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "PW:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MembershipUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 250);
            this.Controls.Add(this.MemberShipPW_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MemberShipID_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MemberShipRANK_combobox);
            this.Controls.Add(this.MemberCancle_Button);
            this.Controls.Add(this.MemberShipJoin_Button);
            this.Controls.Add(this.MemberShipName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User_pictureBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MembershipUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembershipUI";
            this.Load += new System.EventHandler(this.MembershipUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MemberShipRANK_combobox;
        private System.Windows.Forms.Button MemberCancle_Button;
        private System.Windows.Forms.Button MemberShipJoin_Button;
        private System.Windows.Forms.TextBox MemberShipName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox User_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MemberShipID_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MemberShipPW_textBox;
        private System.Windows.Forms.Label label4;
    }
}