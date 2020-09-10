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
    public partial class MainUczen : Form
    {
        public MainUczen()
        {
            InitializeComponent();
            myFirstControl1.BringToFront();
        }

        private void frekUczen1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frekUczen1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocenyUczen1.BringToFront();
        }

        private void plan1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            plan1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Log().Show();
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            myFirstControl1.BringToFront();
        }
    }
}
