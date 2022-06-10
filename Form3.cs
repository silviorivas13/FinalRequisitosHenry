using FinalRequisitosHenry.Forms;
using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalRequisitosHenry
{
    public partial class Form3 : Form
    {
        //fields
        private Form currentChildForm;


        public Form3()
        {
            InitializeComponent();
            
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelescritorio.Controls.Add(ChildForm);
            panelescritorio.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnasignaturas_Click(object sender, EventArgs e)
        {

        }

        private void btnasignaturas_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Formasignatura());
        }

        private void btnhorarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formhorario());
        }

        private void btnregistromaterias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRg());
        }
        private void btnpagos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formpagos());
        }
    }
}