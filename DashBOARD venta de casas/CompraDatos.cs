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
    public partial class CompraDatos : Form
    {
        public CompraDatos()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra Realiada ,se envio un informe a su correo ");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Compra Cancelada");
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
