using MySql.Data.MySqlClient;
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
    public partial class DetailedScheduleUI : Form
    {
        string _server = "wook.cgnexsu6jcqf.ap-northeast-2.rds.amazonaws.com"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "new_schema"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "12345678"; //계정 비밀번호
        string _connectionAddress = "";
        

        public DetailedScheduleUI()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        public DetailedScheduleUI(string title, string content)
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            ScheduleTitle_textBox.Text = title;
            ScheduleContents_textBox.Text = content;
        }

        private void Check_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();                
                    string insertQuery = string.Format("INSERT INTO Schedule (title, detail, day) VALUES ('{0}', '{1}','{2}');", ScheduleTitle_textBox.Text, ScheduleContents_textBox.Text,Detailed_day.Value.ToString());  
                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    
                    if(command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Succeed to insert data.");
                    else if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");
               
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DayReturnButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Repetition_On_Button_Click(object sender, EventArgs e)
        {

        }

        internal void ShowDialog(string copy_title, string copy_content)
        {
            throw new NotImplementedException();
        }
    }
}
