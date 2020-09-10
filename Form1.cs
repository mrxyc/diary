using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schooldiary
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            frekUczen1.BringToFront();
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MainPage.Height;
            myFirstControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            ocenyUczen1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            plan1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Log().Show();
        }
    }
}