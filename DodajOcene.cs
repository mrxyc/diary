using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Globalization;

namespace schooldiary
{
    public partial class DodajOcene : Form
    {
        MySqlConnection conn = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=projectbase;password='root'");
        private object rnd;
        int iducznia;

        public DodajOcene()
        {
            InitializeComponent();
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            var id = new Random();
            int idd= id.Next(100, 1000);
            DateTime localDate = DateTime.Now;
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into `oceny`(`idoceny`,`ocena`,`uczniowie_iducznia`,`zajecia_idzajec`) values(`"+idd+"`,`"+listBox1.SelectedItem+"`,`"+id+"`,`901`";

                cmd.ExecuteNonQuery();
   
                MessageBox.Show("Dodano pomyślnie.");
                conn.Close();
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void refresh_Click(object sender, EventArgs e)
        //{
        //    conn.Open();
        //    MySqlDataAdapter adapter;
        //    DataTable table = new DataTable();
        //    adapter = new MySqlDataAdapter("SELECT * FROM uczniowie", conn);
        //    adapter.Fill(table);
        //    listBox2.DataSource = table;
        //    listBox2.DisplayMember = "imie"+" "+"nazwisko";
        //    //listBox2.ValueMember = "nazwisko";

        //}
        private void refresh_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string   idk;
            if ((listBox2.SelectedItem).ToString() == "1A")
            {
                cmd.CommandText = "SELECT * FROM uczniowie WHERE klasy_idklasy=1";
            }
            else if ((listBox2.SelectedItem).ToString() == "1B")
            {
                cmd.CommandText = "SELECT * FROM uczniowie WHERE klasy_idklasy=2";
            }
            else if ((listBox2.SelectedItem).ToString() == "2A")
            {
                cmd.CommandText = "SELECT * FROM uczniowie WHERE klasy_idklasy=3";
            }
            else if ((listBox2.SelectedItem).ToString() == "2B")
            {
                cmd.CommandText = "SELECT * FROM uczniowie WHERE klasy_idklasy=4";
            }
            else if ((listBox2.SelectedItem).ToString() == "3A")
            {
                cmd.CommandText = "SELECT * FROM uczniowie WHERE klasy_idklasy=5";
            }
            else if ((listBox2.SelectedItem).ToString() == "3B")
            {
                cmd.CommandText = "SELECT * FROM uczniowie WHERE klasy_idklasy=6";
            }
            else if ((listBox2.SelectedItem).ToString() == "")
            {
                MessageBox.Show("Wybierz klasę!");
            }
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["iducznia"].ToString() + " " + dr["imie"].ToString() + " " + dr["nazwisko"].ToString());
                listView1.Items.Add(listitem);
                string id = dr["iducznia"].ToString();

            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>1)
            {
                MessageBox.Show("WYBIERZ JEDNEGO UCZNIA!");
            }
            else
            {
                int i = 0;
                string curItem = listBox1.SelectedItem.ToString();
               
            }
        }

      
    }
}
