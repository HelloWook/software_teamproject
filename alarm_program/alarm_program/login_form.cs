using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace alarm_program
{
    public partial class login_form : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "login"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connectionAddress = "";
        public login_form()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void alarm_mainform_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_tick_Tick(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // 로그인버튼 클릭시 작동 
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT * FROM login");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    while (table.Read())
                    {
                        if (textBox1.Text == table["id"].ToString() && textBox2.Text == table["password"].ToString()) // 아이디 비밀번호 대조 
                        {
                            MessageBox.Show("환영합니다.");
                        }
                        else
                        {
                            if(textBox1.Text != table["id"].ToString()) // 아이디가 틀렸을시 
                            {
                                MessageBox.Show("아이디가 틀렸습니다."); 
                            }
                            else if (textBox1.Text != table["password"].ToString()) // 비밀번호가 틀렸을시 
                            {
                                MessageBox.Show("비밀번호가 틀렸습니다.");
                            }
                        }
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            join_membership_form newform = new join_membership_form();
            newform.ShowDialog();
        }
    }
}
