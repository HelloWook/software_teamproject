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
    public partial class DayCalenderUI : Form
    {
        string _server = "wook.cgnexsu6jcqf.ap-northeast-2.rds.amazonaws.com"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "new_schema"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "12345678"; //계정 비밀번호
        string _connectionAddress = "";
        string copy_content, copy_title = null;
         

        public DayCalenderUI()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

        }

        void view()
        {
           
            Schedule_listview.Clear();
            Schedule_listview.GridLines = true;
            Schedule_listview.View = View.Details;

            Schedule_listview.Columns.Add("id");
            Schedule_listview.Columns.Add("제목");
            Schedule_listview.Columns.Add("알람여부");

            ListViewItem Item;

            String id, title, alarm, content;
            
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT id, title, alarm, detail FROM Schedule");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    while (table.Read())
                    {
                        id = table["id"].ToString();
                        title = table["title"].ToString();
                        alarm = table["alarm"].ToString();
                        content = table["detail"].ToString();
                     
                        copy_title = title;
                        copy_content = content;

                        Item = new ListViewItem(id);

                        Item.SubItems.Add(title);
                        Item.SubItems.Add(alarm);
                        
                        Schedule_listview.Items.Add(Item);
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            using (LoginUI loginUI1 = new LoginUI())
            {
                this.Hide();
                loginUI1.ShowDialog();
            }
            this.Close();
        }

        private void ScheduleAddButton_Click(object sender, EventArgs e)
        {
            DetailedScheduleUI scheduleUI = new DetailedScheduleUI();
            scheduleUI.ShowDialog();
        }

        private void ScheduleModifyButton_Click(object sender, EventArgs e)
        {
            if (Schedule_listview.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("스케줄을 수정하시겠습니까?", "스케줄 수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DetailedScheduleUI scheduleUI = new DetailedScheduleUI();
                    scheduleUI.ShowDialog();
                }
                else
                {
                    MessageBox.Show("스케줄 수정이 취소되었습니다.");
                }
            }
        }

        private void ScheduleDeleteButton_Click(object sender, EventArgs e)
        {
            if(Schedule_listview.SelectedItems.Count != 0)
            {
                if(MessageBox.Show("스케줄을 삭제하시겠습니까?","스케줄 삭제",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                        {
                            mysql.Open();
                            int pos = Schedule_listview.SelectedItems[0].Index;
                            int index = Convert.ToInt32(Schedule_listview.Items[pos].Text);
           
                            string deleteQuery = string.Format("DELETE FROM Schedule WHERE id={0};", index);

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
                else
                {
                    MessageBox.Show("스케줄 삭제가 취소되었습니다.");
                }
            }
            
        }

        private void MonthReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DayCalenderUI_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM User");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                    while (table.Read())
                    {
                        name.Text = table["name"].ToString();
                        label4.Text = table["class"].ToString();
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            view();
        }
        private void day_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Schedule_listview_DoubleClick(object sender, EventArgs e)
        {
            DetailedScheduleUI scheduleUI = new DetailedScheduleUI(copy_title,copy_content);
            scheduleUI.Show();
        }
    }
}
