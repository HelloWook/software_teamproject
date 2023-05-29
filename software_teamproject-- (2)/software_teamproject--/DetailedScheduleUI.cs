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
        public DetailedScheduleUI()
        {
            InitializeComponent();
        }

        private void Check_Button_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {

        }

        private void DayReturnButton_Click(object sender, EventArgs e)
        {
            S_DayCalenderUI dayCalenderUI = new S_DayCalenderUI();
            dayCalenderUI.Show();
        }

        private void Repetition_On_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
