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
 
    public partial class User_InformationUI : Form
    {
        string _server = "wook.cgnexsu6jcqf.ap-northeast-2.rds.amazonaws.com"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "new_schema"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "12345678"; //계정 비밀번호
        string _connectionAddress = "";
        public User_InformationUI()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {

        }

        private void DayReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_InformationUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT * FROM User");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    UserlistView.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["password"].ToString());
                        item.SubItems.Add(table["name"].ToString());
                        item.SubItems.Add(table["class"].ToString());

                        UserlistView.Items.Add(item);
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void UserlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 종료 
            this.Close();
        }

        private void UserlistView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void UserlistView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void UserlistView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string name = UserlistView.FocusedItem.SubItems[0].Text;
            using (User_DetailsUI detailsUI = new User_DetailsUI())
            {
                detailsUI.TextBoxValue = name;
                this.Hide();
                detailsUI.ShowDialog();
            }
            this.Close();
        }
    }
}
