using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace schooldiary
{
    public partial class OcenyUczen : UserControl
    {
        MySqlConnection conn = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=projectbase;password='root'");
        public OcenyUczen()
        {
            InitializeComponent();

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ocena from oceny where uczniowie_iducznia='" + DaneUczen.id + "'and zajecia_idzajec=901";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            label13.Text = dt.ToString();
            conn.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //conn.Open();
            //string q = "SELECT * FROM oceny WHERE uczniowie_iducznia=1;";
            //MySqlCommand query = new MySqlCommand(q, conn);
            //MySqlDataReader dr = query.ExecuteReader();
            //label12.Text = dr["ocena"].ToString();
            //conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
