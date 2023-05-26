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
      
        public DayCalenderUI()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }
        private void DayCalenderUI_Load(object sender, EventArgs e)
        {
            int i = 0;
            String[] Schedule_Title = new String[100];
            String[] Schedule_Location = new String[100];
            string Schedule_inform;

            String[] Announcement_Title = new String[100];
            String[] Announcement_Location = new String[100];
            string Announcement_Inform;
            
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();

                    string selectQuery1 = "SELECT * FROM Schedule";
                    string selectQuery2 = "SELECT + FROM Announcement";

                    MySqlCommand command1 = new MySqlCommand(selectQuery1, mysql);
                    MySqlDataReader table1 = command1.ExecuteReader();
                    MySqlCommand command2 = new MySqlCommand(selectQuery2, mysql);
                    MySqlDataReader table2 = command2.ExecuteReader();

                    while (table1.Read() && table2.Read())
                    {
                        Schedule_Title[i] = table1["title"].ToString();
                        Schedule_Location[i] = table1["location"].ToString();
                        Schedule_inform = $"{Schedule_Title[i]} , 장소: {Schedule_Location[i]}";
                        Announcement_Title[i] = table2["title"].ToString();
                        Announcement_Location[i] = table2["location"].ToString();
                        Announcement_Inform = $"{Announcement_Title[i]} , 장소: {Announcement_Location[i]}";

                        
                        Schedule_ListBox.Items.Add(Schedule_inform);
                        i++;
                    }
                    //만약 user의 직급이 일반사원이라면 table1과 table2의 내용을 시간순서에 맞게 출력함
                    
                    //만약 user의 직급이 관리자라면 table2의 내용을 리스트 박스에 출력함
                    table1.Close();
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
            // 로그아웃 하시겠습니까 ? 메시지창 띄운 다음 확인버튼 누르면 창 변경  
         
            if(MessageBox.Show("로그아웃하시겠습니까?", "Logout", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                LoginUI loginUI = new LoginUI();
                loginUI.Show();
            }                               
        }

        private void ScheduleAddButton_Click(object sender, EventArgs e)
        {
            // 현재 창은 닫고, 수정하는 창 띄어줌
            this.Close();           
            DetailedScheduleUI detailedScheduleUI = new DetailedScheduleUI();
            detailedScheduleUI.Show();
        }

        private void ScheduleModifyButton_Click(object sender, EventArgs e)
        {
            // 현재 창은 닫고, 수정하는 창 띄어줌
            this.Close();          
            DetailedScheduleUI detailedScheduleUI = new DetailedScheduleUI();
            detailedScheduleUI.Show();
        }

        private void ScheduleDeleteButton_Click(object sender, EventArgs e)
        {
            //해당 내용 삭세
            //db에도 해당 내용 삭제
        }

        private void MonthReturnButton_Click(object sender, EventArgs e)
        {
            this.Close(); //창 닫기(종료)
        }
    }
}
