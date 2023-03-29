using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm_program
{
    public partial class alarm_mainform : Form
    {
        public alarm_mainform()
        {
            InitializeComponent();
        }

        private void alarm_mainform_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_tick_Tick(object sender, EventArgs e)
        {
            alarmtext.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
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
    }
}
