using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        int cash = 0;
        public LoginUI()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }
       public void Login()
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
                            cash = 1; // 캐시를 1로 지정 
                        }
                        if (cash == 1)
                        {
                            MessageBox.Show("환영합니다.");
                            if ("사장" == table["class"].ToString())
                            {
                                using (DayCalenderUI dayCalender = new DayCalenderUI())
                                {
                                    this.Hide();
                                    dayCalender.ShowDialog();
                                }
                                this.Close();
                            }
                            else
                            {
                                using (S_DayCalenderUI S_DayCalenderUI = new S_DayCalenderUI())
                                {
                                    this.Hide();
                                    S_DayCalenderUI.ShowDialog();
                                }
                                this.Close();
                            }
                        }
                        cash = 0;
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void LogIn_button_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Membership_Button_Click(object sender, EventArgs e)
        {
            using (MembershipUI membershipUI = new MembershipUI())
            {
                this.Hide();
                membershipUI.ShowDialog();
            }
            this.Close();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }
    }
}
