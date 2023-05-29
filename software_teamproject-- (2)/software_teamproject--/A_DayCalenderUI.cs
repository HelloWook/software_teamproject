using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        
        LoginUI loginUI;

        public DayCalenderUI()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }
        private void DayCalenderUI_Load(object sender, EventArgs e)
        {
            int i = 0;           
            String[] Announcement_Title = new String[100];
            String[] Announcement_Location = new String[100];
            string[] Announcement_Inform = new String[100];

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();

                    string selectQuery = "SELECT * FROM Announcement";
                    
                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    string selectedDate = day.Value.ToString();

                    while (table.Read())
                    {                   
                        if(selectedDate == table["day"].ToString())
                        {
                            Announcement_Title[i] = table["title"].ToString();
                            Announcement_Location[i] = table["location"].ToString();
                            Announcement_Inform[i] = $"{Announcement_Title[i]} , 장소: {Announcement_Location[i]}";

                            Announcement_ListBox.Items.Add(Announcement_Inform);
                            i++;
                        }                       
                    }                   
                    table.Close();                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("실패");
                Console.WriteLine(ex.ToString());
            }
        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            // 로그아웃 하시겠습니까 ? 메시지창 띄운 다음 확인버튼 누르면 창 
            if (MessageBox.Show("로그아웃하시겠습니까?", "Logout", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                LoginUI loginUI = new LoginUI();
                loginUI.Show();
            }
        }
                
        private void User_inform_Button_Click(object sender, EventArgs e)
        {
            using (User_InformationUI userinfoUI = new User_InformationUI())
            {
                this.Hide();
                userinfoUI.ShowDialog();
            }
            this.Close();
        }

        private void AnnouncementAddButton_Click(object sender, EventArgs e)
        {
            // 현재 창은 닫고, 수정하는 창 띄어줌
            this.Close();
            DetailedScheduleUI detailedScheduleUI = new DetailedScheduleUI();
            detailedScheduleUI.Show();
        }

        private void AnnouncementButton_Click(object sender, EventArgs e)
        {
            // 현재 창은 닫고, 수정하는 창 띄어줌
            this.Close();
            DetailedScheduleUI detailedScheduleUI = new DetailedScheduleUI();
            detailedScheduleUI.Show();
        }
        public void Announcement_Delete()
        {
            if (MessageBox.Show("삭제하시겠습니까?", "Schedule Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    using (MySqlConnection mysql = new MySqlConnection(_connectionAddress)) // db에서 해당하는 내용 삭제
                    {
                        mysql.Open();
                        int pos = Announcement_ListBox.SelectedIndex;
                        string DeleteQuery = string.Format("DELETE FROM Announcement WHERE id = {0}", Announcement_ListBox.SelectedIndex);

                        MySqlCommand command = new MySqlCommand(DeleteQuery, mysql);
                        if (command.ExecuteNonQuery() != 1)
                            MessageBox.Show("공지사항 삭제에 실패하였습니다!");

                        Announcement_ListBox.Items.RemoveAt(Announcement_ListBox.SelectedIndex); // 화면상에서도 내용 삭제
                        MessageBox.Show("공지사항이 삭제되었습니다.", "Announcement Delete", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void AnnouncementDeleteButton_Click(object sender, EventArgs e)
        {
            Announcement_Delete();
        }

        private void MonthReturnButton_Click(object sender, EventArgs e)
        {
            this.Close(); //창 닫기(종료)
        }

    }
}