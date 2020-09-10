using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schooldiary
{
    public partial class OcenyNaucz : UserControl
    {
        public OcenyNaucz()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DodajOceneTest().Show();
        }
    }
}
