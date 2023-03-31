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
    public partial class join_membership_form : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "login"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connectionAddress = "";
        public join_membership_form()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table에 name, phone column 데이터를 삽입합니다. id는 자동으로 증가합니다.
                    string insertQuery = string.Format("INSERT INTO login (id, password, name, position) VALUES ('{0}', '{1}', '{2}', '{3}');", id.Text, password.Text, name.Text, position.Text);
                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    MessageBox.Show("회원가입을 축하드립니다.");
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login_form newform = new login_form();
            newform.ShowDialog();
        }

        private void join_membership_form_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
