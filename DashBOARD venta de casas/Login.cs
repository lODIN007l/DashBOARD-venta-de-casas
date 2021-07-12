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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" & txtContraseña.Text == "12345")
            {
                //FrmAdmin objAdmin = new FrmAdmin() //Se dirige a la pantalla de inicio del admin
                //objAdmin.Show();
                DashBoardAdmi objD = new DashBoardAdmi();
                objD.ShowDialog();
                this.Close();
                //MessageBox.Show("Ingreso");
                
               
            }
            else
            {
                MessageBox.Show("Solo el administrador puede ingresar");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
        }
        private void SoloLetrasYNumeros(KeyPressEventArgs e)
        //esta funcion valida que solo se permitan presionar numeros y letras dentro del evento keypress
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasYNumeros(e);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasYNumeros(e);
        }
    }
}
