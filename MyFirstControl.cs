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
    public partial class MyFirstControl : UserControl
    {
        MySqlConnection conn = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=projectbase;password='root'");
        public MyFirstControl()
        {
            InitializeComponent();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (DaneRodzic.rola == "opiekun")
            {
                cmd.CommandText = "select imie,nazwisko from opiekunowie where idopiekuna='" + DaneRodzic.id + "'";
                label1.Text = DaneRodzic.login;
                label2.Text = DaneRodzic.rola;
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                label6.Text = dt.ToString();
            }
            else if (DaneUczen.rola == "uczeń")
            {
                cmd.CommandText = "select imie,nazwisko from uczniowie where iducznia='" + DaneUczen.id + "'";
                label1.Text = DaneUczen.login;
                label2.Text = DaneUczen.rola;
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                label6.Text = dt.ToString();
            }
            else if (DaneNauczyciel.rola == "nauczyciel")
            {
                cmd.CommandText = "select imie,nazwisko from nauczyciele where idnauczyciela='" + DaneNauczyciel.id + "'";
                label1.Text = DaneNauczyciel.login;
                label2.Text = DaneNauczyciel.rola;
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                label6.Text = dt.ToString();
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("elo");
        }

        private void label5(object sender, EventArgs e)
        {

        }

        public void CreateMyLabel()
        {
            
        }

        private void end_Click(object sender, EventArgs e)
        {

            end.Text = "Już niedługo wakacje!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void MyFirstControl_Load(object sender, EventArgs e)
        {

        }
    }
}
