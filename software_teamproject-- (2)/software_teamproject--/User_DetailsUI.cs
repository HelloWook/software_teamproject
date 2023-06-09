﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soft_team9
{
    public partial class User_DetailsUI : Form
    {
        string _server = "wook.cgnexsu6jcqf.ap-northeast-2.rds.amazonaws.com"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "new_schema"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "12345678"; //계정 비밀번호
        string _connectionAddress = "";
        public string TextBoxValue { get; set; }

        public void UserInformationModify()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table의 특정 id의 name column과 phone column 데이터를 수정합니다.
                    string updateQuery = string.Format("UPDATE User SET class = '{1}' WHERE id='{0}';", UserName_textBox.Text, UserRank_Combobox.Text);

                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Faild to Update data.");
                    UserName_textBox.Text = "";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public void UserInformationDelete()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table에서 특정 id의 데이터를 삭제합니다.
                    string deleteQuery = string.Format("DELETE FROM User WHERE id='{0}';", UserName_textBox.Text);


                    MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public User_DetailsUI()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            using (User_InformationUI User_InformationUI = new User_InformationUI())
            {
                this.Hide();
                User_InformationUI.ShowDialog();
            }
            this.Close();
        }

        private void User_DetailsUI_Load(object sender, EventArgs e)
        {
            UserName_textBox.Text = TextBoxValue;

        }

        private void UserModify_Button_Click(object sender, EventArgs e)
        {
            UserInformationModify();
        }

        private void UserDelete_Button_Click(object sender, EventArgs e)
        {
            UserInformationDelete();
        }

        private void UserName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserRank_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
