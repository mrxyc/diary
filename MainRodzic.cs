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
    public partial class MainRodzic : Form
    {
        public MainRodzic()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new Log().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frekUczen1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocenyUczen1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plan1.BringToFront();
        }
    }
}
