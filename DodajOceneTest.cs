using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace schooldiary
{
    public partial class DodajOceneTest : Form
    {
        MySqlConnection conn = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=projectbase;password='root'");
        public DodajOceneTest()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = new Random();
            int idd = id.Next(100, 1000);
            DateTime localDate = DateTime.Now;
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into `oceny`(`idoceny`,`ocena`,`uczniowie_iducznia`,`zaco',`nauczyciele_idnauczyciela`) values(`" + idd + "`,`" + listBox1.SelectedItem + "`,`" + textBox1.Text + "`,`"+textBox2.Text+"`,901`";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dodano pomyślnie.");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
