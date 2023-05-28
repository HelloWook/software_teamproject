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
    public partial class LoginUI : Form
    {
        string _server = "wook.cgnexsu6jcqf.ap-northeast-2.rds.amazonaws.com"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "new_schema"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "12345678"; //계정 비밀번호
        string _connectionAddress = "";

        public LoginUI()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }
       
        private void LogIn_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //login의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT * FROM User");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        if (UserID_textBox.Text == table["id"].ToString() && UserPW_textBox.Text == table["password"].ToString()) // 아이디 비밀번호 대조해서 맞을시 
                        {
                            MessageBox.Show("환영합니다.");
                            using (DayCalenderUI dayCalenderUI = new DayCalenderUI())
                            {
                                this.Hide();
                                dayCalenderUI.ShowDialog();
                            }
                            this.Close();
                        }

                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            using (LoginUI loginUI = new LoginUI())
            {
                this.Hide();
                loginUI.ShowDialog();
            }
            this.Close();
        }

        private void Membership_Button_Click(object sender, EventArgs e)
        {
            //회원가입 창으로 넘어감
        }
    }
}
