using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DashBOARD_venta_de_casas
{
    public partial class DashBoardAdmi : Form
    {
        public DashBoardAdmi()
        {
            InitializeComponent();
            //Admi_UC uC = new Admi_UC();
            //AgregarAdmi(uC);
        }

        private void MoverImagen(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imagenSlide.Location = new Point(b.Location.X+22,b.Location.Y-29);
            imagenSlide.SendToBack();

        }
        private void AgregarAdmi(UserControl uc)
        {
            panelContenedor.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panelContenedor.Controls.Add(uc);
        }
        private void btCasas_CheckedChanged(object sender, EventArgs e)
        {
            MoverImagen(sender);
            
            //AgregarAdmi(uC);
        }

        private void btEstadisticas_Click(object sender, EventArgs e)
        {
            Admi_UC uC = new Admi_UC();
            AgregarAdmi(uC);
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCasas_Click(object sender, EventArgs e)
        {
            ListadoDeviviendas uC = new ListadoDeviviendas();
            AgregarAdmi(uC);
        }
    }
}
