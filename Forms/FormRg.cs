using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{       
    public partial class FormRg : Form
    {
        double precio = 0;
        public FormRg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("C");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboMaterias.Text = "(Seleccione materias)";
            cboTipo.Text = "(Seleccione un tipo )";
            txtHoras.Clear();
            lblPrecio.Text=(0).ToString("C");
            cboMaterias.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string materias = cboMaterias.Text;

            if (materias.Equals("Calculo")) precio = 100000;
            if (materias.Equals("Fisica")) precio = 200000;
            if (materias.Equals("Programacion")) precio = 300000;
            if (materias.Equals("Biologia")) precio = 400000;
            if (materias.Equals("Escritura")) precio = 500000;
            if (materias.Equals("Ecologia")) precio = 500000;
            if (materias.Equals("Codigo Limpio")) precio = 700000;
            if (materias.Equals("Programacion  Codigo limpio  Calculo")) precio =400000;
            if (materias.Equals("Fisica Biologia  Escritura")) precio = 400000;
            if (materias.Equals("Biologia  Ecologia ")) precio = 300000;
            if (materias.Equals("Calculo fisica Programacion  biologia")) precio = 500000;
            if (materias.Equals("Escritura Ecologia Codigo limpio")) precio = 300000;

            lblPrecio.Text = precio.ToString("C");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboMaterias.SelectedIndex == -1)
                MessageBox.Show("Debes seleccionar una materia...!!!!");
            else if (txtHoras.Text == "")
                MessageBox.Show("Debes ingresar las horas...!!!");
            else if(cboTipo.SelectedIndex == -1 )
                MessageBox.Show("Debes seleccionar un metodo de pago...!!!!");
            else
            {
                string materias = cboMaterias.Text;
                int horas = Convert.ToInt32(txtHoras.Text);
                string tipo = cboTipo.Text;

                double subtotal = horas * precio;

                double descuento = 0, recargo =0;
                if (tipo.Equals("Contado"))
                    descuento = 0.05 * subtotal;
                else
                    recargo = 0.1 * subtotal;
                double precioFinal = subtotal - descuento + recargo;

                ListViewItem fila = new ListViewItem(materias);
                fila.SubItems.Add(horas.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(precioFinal.ToString());

                lvVenta.Items.Add(fila);
                button2_Click(sender, e);



            }


        }
    }
}
