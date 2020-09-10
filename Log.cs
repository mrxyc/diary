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
using MySql.Data;


namespace schooldiary
{
    public partial class Log : Form
    {
        int i;
        MySqlConnection conn = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=projectbase;password='root'");

        public Log()
        {
            InitializeComponent();
        }

 
        private void label1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("W pierwszym polu należy wprowadzić login, w drugim wygenerowane hasło. " +
                "W przypadku problemów skontaktuj się z admi" +
                "nistratorem strony.");
        }

        private void button1_Click(object sender, EventArgs e)
        {        
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loguj_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    if (textBox1.Text == "" && textBox2.Text == "")
                    {
                        MessageBox.Show("Nie wprowadzono loginu lub hasła! Spróbuj ponownie.");
                    }

                    else
                    {
                        i = 0;
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select iducznia from uczniowie where login='" + textBox1.Text + "' and haslo='" + textBox2.Text + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);

                        i = Convert.ToInt32(dt.Rows.Count.ToString());

                        if (i == 0)
                        {
                            MessageBox.Show("Wprowadziłeś błędne dane.");
                        }

                        else
                        {

                            DaneUczen.id = dt.ToString();

                            DaneUczen.login = textBox1.Text;
                            DaneUczen.rola = "uczeń";
                            cmd.CommandText = "select klasy_idklasy from uczniowie where login='" + textBox1.Text + "' and haslo='" + textBox2.Text + "'";
                            cmd.ExecuteNonQuery();                          
                            new MainUczen().Show();                          
                            this.Hide();
                        }

                    }

                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            else if (radioButton2.Checked)
            {
                try
                {
                    if (textBox1.Text == "" && textBox2.Text == "")
                    {
                        MessageBox.Show("Nie wprowadzono loginu lub hasła! Spróbuj ponownie.");
                    }

                    else
                    {
                        i = 0;
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select idnauczyciela from nauczyciele where login='" + textBox1.Text + "' and haslo='" + textBox2.Text + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);

                        i = Convert.ToInt32(dt.Rows.Count.ToString());

                        if (i == 0)
                        {
                            MessageBox.Show("Wprowadziłeś błędne dane.");
                        }

                        else
                        {
                            DaneNauczyciel.id = dt.ToString();
                            DaneNauczyciel.login = textBox1.Text;
                            DaneNauczyciel.rola = "nauczyciel";
                            new Main().Show();
                            this.Hide();
                        }

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            else if(radioButton3.Checked)
            {
                try
                {
                    if (textBox1.Text == "" && textBox2.Text == "")
                    {
                        MessageBox.Show("Nie wprowadzono loginu lub hasła! Spróbuj ponownie.");
                    }

                    else
                    {
                        i = 0;
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select idopiekuna from opiekunowie where login='" + textBox1.Text + "' and haslo='" + textBox2.Text + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);

                        i = Convert.ToInt32(dt.Rows.Count.ToString());

                        if (i == 0)
                        {
                            MessageBox.Show("Wprowadziłeś błędne dane.");
                        }

                        else
                        {
                            DaneRodzic.id = dt.ToString();
                            DaneRodzic.login = textBox1.Text;
                            DaneRodzic.rola = "opiekun";
                            new MainRodzic().Show();
                            this.Hide();

                        }

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                conn.Close();
            }

            else
            {
                MessageBox.Show("Wybierz jako kto chcesz się zalogować!");
            }
        }
    }
}
