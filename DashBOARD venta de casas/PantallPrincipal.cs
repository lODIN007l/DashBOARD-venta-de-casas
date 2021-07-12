using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBOARD_venta_de_casas
{
    public partial class PantallPrincipal : Form
    {
        public PantallPrincipal()
        {
            InitializeComponent();
            PantallPrincipalUsuario uC = new PantallPrincipalUsuario();
            AgregarCliente(uC);
        }
        private void AgregarCliente(UserControl uc)
        {
            panelCentral.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panelCentral.Controls.Add(uc);
        }
        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btVentaP_Click(object sender, EventArgs e)
        {
            IngresoPropiedadesVenta.frmIngresoVivienda objIngreso = new IngresoPropiedadesVenta.frmIngresoVivienda();
            objIngreso.Show();
        }

        private void btCodigo_Click(object sender, EventArgs e)
        {
            IngresoPropiedadesVenta.frmBuscarModificarVivienda objBuscar = new IngresoPropiedadesVenta.frmBuscarModificarVivienda();
            objBuscar.Show();
        }

        private void btBUbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (btBUbi.SelectedIndex)
            {
                case 1:
                    PantallPrincipalUsuario ojD = new PantallPrincipalUsuario();
                    string comparador=ojD.DatagridViviendas2.Rows[0].Cells[2].Value.ToString();
                    if (btBUbi.SelectedValue.ToString()== comparador)
                    {
                        for (int i=0;i<=19;i++)
                        {

                        }
                    }
                    break;
            }
        }
    }
}
