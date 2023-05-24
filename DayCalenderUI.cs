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
        public DayCalenderUI()
        {
            InitializeComponent();
        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            // 로그아웃 하시겠습니까 ? 메시지창 띄운 다음 확인버튼 누르면 창 변경  
            DialogResult result = MessageBox.Show("로그아웃하시겠습니까?", "Logout", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
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
