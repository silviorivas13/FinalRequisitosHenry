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

namespace FinalRequisitosHenry
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Registro Con Exito");
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; Database = login; User id=Henry; password=123");
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }

            string sql = "insert into users(txtuser2,txtpass3) values ('" + txtuser2.Text + "', '" + txtpass3.Text + "')"; 
            MySqlCommand cmd = new MySqlCommand(sql,con);
            try
            { 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado");
                this.Hide();
                Form1 n1 = new Form1();
                n1.Show();
            }
            catch (MySqlException ex) { MessageBox.Show("Error" + ex.ToString()); }
        }
    }
}
