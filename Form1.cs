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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();

            string nombre, contraseña;
            nombre = txtuser.Text;
            contraseña = txtpass.Text;
            MySqlConnection con  = new MySqlConnection("server = 127.0.0.1; Database = login; User id=Henry; password=123");
            try
            {
                con.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            string sql = " select txtuser,txtpass from users where txtuser = '" + nombre + "'AND txtpass = '" + contraseña + "' ";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido" + nombre);
            }
            else
            {
                MessageBox.Show("No existe Usuario");
            }
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario") {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == ""){
                txtuser.Text = "Usuario";
                txtuser.ForeColor= Color.DimGray;

            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == "Contraseña"){
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if( txtpass.Text == "") {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }

    }
}
