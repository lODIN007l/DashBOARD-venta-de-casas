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
    public partial class PantallPrincipalUsuario : UserControl
    {
        public PantallPrincipalUsuario()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            CompraDatos objCompra = new CompraDatos();
            objCompra.ShowDialog();
            MemberwiseClone();
        }

        private void btSesion_Click(object sender, EventArgs e)
        {
            Login objL = new Login();
            objL.Show();
        }

        private void PantallPrincipalUsuario_Load(object sender, EventArgs e)
        {
            dataSet11.Clear();
            dataSet11.ReadXml(Application.StartupPath + "tviviendas.xml");

            lbP1.Text = DatagridViviendas2.Rows[0].Cells[6].Value.ToString();
            lbU1.Text = DatagridViviendas2.Rows[0].Cells[2].Value.ToString();
            lbD1.Text = DatagridViviendas2.Rows[0].Cells[3].Value.ToString();
            lbH1.Text = DatagridViviendas2.Rows[0].Cells[4].Value.ToString();
            lbDe1.Text = DatagridViviendas2.Rows[0].Cells[5].Value.ToString();
            byte[] imageBuffer = (byte[])DatagridViviendas2.Rows[0].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);//
            pViv1.Image = Image.FromStream(ms);//le asignas al pictureBox
            //segundo 
            lbP2.Text = DatagridViviendas2.Rows[1].Cells[6].Value.ToString();
            lbU2.Text = DatagridViviendas2.Rows[1].Cells[2].Value.ToString();
            lbD2.Text = DatagridViviendas2.Rows[1].Cells[3].Value.ToString();
            lbH2.Text = DatagridViviendas2.Rows[1].Cells[4].Value.ToString();
            lbDe2.Text = DatagridViviendas2.Rows[1].Cells[5].Value.ToString();
            byte[] imageBuffer2 = (byte[])DatagridViviendas2.Rows[1].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms2 = new System.IO.MemoryStream(imageBuffer2);//
            pViv2.Image = Image.FromStream(ms2);//le asignas al pictureBox
            //tercero 
            lbP3.Text = DatagridViviendas2.Rows[2].Cells[6].Value.ToString();
            lbU3.Text = DatagridViviendas2.Rows[2].Cells[2].Value.ToString();
            lbD3.Text = DatagridViviendas2.Rows[2].Cells[3].Value.ToString();
            lbH3.Text = DatagridViviendas2.Rows[2].Cells[4].Value.ToString();
            lbDe3.Text = DatagridViviendas2.Rows[2].Cells[5].Value.ToString();
            byte[] imageBuffer3 = (byte[])DatagridViviendas2.Rows[2].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms3 = new System.IO.MemoryStream(imageBuffer3);//
            pViv3.Image = Image.FromStream(ms3);//le asignas al pictureBox
            //cuarto
            lbP4.Text = DatagridViviendas2.Rows[3].Cells[6].Value.ToString();
            lbU4.Text = DatagridViviendas2.Rows[3].Cells[2].Value.ToString();
            lbD4.Text = DatagridViviendas2.Rows[3].Cells[3].Value.ToString();
            lbH4.Text = DatagridViviendas2.Rows[3].Cells[4].Value.ToString();
            lbDe4.Text = DatagridViviendas2.Rows[3].Cells[5].Value.ToString();
            byte[] imageBuffer4 = (byte[])DatagridViviendas2.Rows[3].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms4 = new System.IO.MemoryStream(imageBuffer4);//
            pViv4.Image = Image.FromStream(ms4);//le asignas al pictureBox
            //quinto
            lbP5.Text = DatagridViviendas2.Rows[4].Cells[6].Value.ToString();
            lbU5.Text = DatagridViviendas2.Rows[4].Cells[2].Value.ToString();
            lbD5.Text = DatagridViviendas2.Rows[4].Cells[3].Value.ToString();
            lbH5.Text = DatagridViviendas2.Rows[4].Cells[4].Value.ToString();
            lbDe5.Text = DatagridViviendas2.Rows[4].Cells[5].Value.ToString();
            byte[] imageBuffer5 = (byte[])DatagridViviendas2.Rows[4].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms5 = new System.IO.MemoryStream(imageBuffer5);//
            pViv5.Image = Image.FromStream(ms5);//le asignas al pictureBox
            //sexto
            lbP6.Text = DatagridViviendas2.Rows[5].Cells[6].Value.ToString();
            lbU6.Text = DatagridViviendas2.Rows[5].Cells[2].Value.ToString();
            lbD6.Text = DatagridViviendas2.Rows[5].Cells[3].Value.ToString();
            lbH6.Text = DatagridViviendas2.Rows[5].Cells[4].Value.ToString();
            lbDe6.Text = DatagridViviendas2.Rows[5].Cells[5].Value.ToString();
            byte[] imageBuffer6 = (byte[])DatagridViviendas2.Rows[5].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms6 = new System.IO.MemoryStream(imageBuffer6);//
            pViv6.Image = Image.FromStream(ms6);//le asignas al pictureBox




            //pbxFoto.Image = Image.FromFile(ofd.FileName);
            //Image img = Image.FromFile(ofd.FileName);
            //ImageConverter ic = new ImageConverter();
            //byte[] pngImage = DatagridViviendas2.Rows[0].Cells[5].Value.ToString() ;
            //arr = (byte[])ic.ConvertTo(img, typeof(byte[]));
            //pViv1.Image = ic.ConvertTo(DatagridViviendas2.Rows[0].Cells[5].Value);
            //falta agregar la imagen 

        }

        private void btPag1_Click(object sender, EventArgs e)
        {
            
            lbP1.Text = DatagridViviendas2.Rows[0].Cells[6].Value.ToString();
            lbU1.Text = DatagridViviendas2.Rows[0].Cells[2].Value.ToString();
            lbD1.Text = DatagridViviendas2.Rows[0].Cells[3].Value.ToString();
            lbH1.Text = DatagridViviendas2.Rows[0].Cells[4].Value.ToString();
            lbDe1.Text = DatagridViviendas2.Rows[0].Cells[5].Value.ToString();
            byte[] imageBuffer = (byte[])DatagridViviendas2.Rows[0].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);//
            pViv1.Image = Image.FromStream(ms);//le asignas al pictureBox
            
            //segundo 

            lbP2.Text = DatagridViviendas2.Rows[1].Cells[6].Value.ToString();
            lbU2.Text = DatagridViviendas2.Rows[1].Cells[2].Value.ToString();
            lbD2.Text = DatagridViviendas2.Rows[1].Cells[3].Value.ToString();
            lbH2.Text = DatagridViviendas2.Rows[1].Cells[4].Value.ToString();
            lbDe2.Text = DatagridViviendas2.Rows[1].Cells[5].Value.ToString();
            byte[] imageBuffer2 = (byte[])DatagridViviendas2.Rows[1].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms2 = new System.IO.MemoryStream(imageBuffer2);//
            pViv2.Image = Image.FromStream(ms2);//le asignas al pictureBox
            //tercero 
            lbP3.Text = DatagridViviendas2.Rows[2].Cells[6].Value.ToString();
            lbU3.Text = DatagridViviendas2.Rows[2].Cells[2].Value.ToString();
            lbD3.Text = DatagridViviendas2.Rows[2].Cells[3].Value.ToString();
            lbH3.Text = DatagridViviendas2.Rows[2].Cells[4].Value.ToString();
            lbDe3.Text = DatagridViviendas2.Rows[2].Cells[5].Value.ToString();
            byte[] imageBuffer3 = (byte[])DatagridViviendas2.Rows[2].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms3 = new System.IO.MemoryStream(imageBuffer3);//
            pViv3.Image = Image.FromStream(ms3);//le asignas al pictureBox
            //cuarto
            lbP4.Text = DatagridViviendas2.Rows[3].Cells[6].Value.ToString();
            lbU4.Text = DatagridViviendas2.Rows[3].Cells[2].Value.ToString();
            lbD4.Text = DatagridViviendas2.Rows[3].Cells[3].Value.ToString();
            lbH4.Text = DatagridViviendas2.Rows[3].Cells[4].Value.ToString();
            lbDe4.Text = DatagridViviendas2.Rows[3].Cells[5].Value.ToString();
            byte[] imageBuffer4 = (byte[])DatagridViviendas2.Rows[3].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms4 = new System.IO.MemoryStream(imageBuffer4);//
            pViv4.Image = Image.FromStream(ms4);//le asignas al pictureBox
            //quinto
            lbP5.Text = DatagridViviendas2.Rows[4].Cells[6].Value.ToString();
            lbU5.Text = DatagridViviendas2.Rows[4].Cells[2].Value.ToString();
            lbD5.Text = DatagridViviendas2.Rows[4].Cells[3].Value.ToString();
            lbH5.Text = DatagridViviendas2.Rows[4].Cells[4].Value.ToString();
            lbDe5.Text = DatagridViviendas2.Rows[4].Cells[5].Value.ToString();
            byte[] imageBuffer5 = (byte[])DatagridViviendas2.Rows[4].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms5 = new System.IO.MemoryStream(imageBuffer5);//
            pViv5.Image = Image.FromStream(ms5);//le asignas al pictureBox
            //sexto
            lbP6.Text = DatagridViviendas2.Rows[5].Cells[6].Value.ToString();
            lbU6.Text = DatagridViviendas2.Rows[5].Cells[2].Value.ToString();
            lbD6.Text = DatagridViviendas2.Rows[5].Cells[3].Value.ToString();
            lbH6.Text = DatagridViviendas2.Rows[5].Cells[4].Value.ToString();
            lbDe6.Text = DatagridViviendas2.Rows[5].Cells[5].Value.ToString();
            byte[] imageBuffer6 = (byte[])DatagridViviendas2.Rows[5].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms6 = new System.IO.MemoryStream(imageBuffer6);//
            pViv6.Image = Image.FromStream(ms6);//le asignas al pictureBox


        }

        private void btPag2_Click(object sender, EventArgs e)
        {
            lbP1.Text = DatagridViviendas2.Rows[6].Cells[6].Value.ToString();
            lbU1.Text = DatagridViviendas2.Rows[6].Cells[2].Value.ToString();
            lbD1.Text = DatagridViviendas2.Rows[6].Cells[3].Value.ToString();
            lbH1.Text = DatagridViviendas2.Rows[6].Cells[4].Value.ToString();
            lbDe1.Text = DatagridViviendas2.Rows[6].Cells[5].Value.ToString();
            byte[] imageBuffer7 = (byte[])DatagridViviendas2.Rows[6].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms7 = new System.IO.MemoryStream(imageBuffer7);//
            pViv6.Image = Image.FromStream(ms7);//le asignas al pictureBox

            //segundo 

            lbP2.Text = DatagridViviendas2.Rows[7].Cells[6].Value.ToString();
            lbU2.Text = DatagridViviendas2.Rows[7].Cells[2].Value.ToString();
            lbD2.Text = DatagridViviendas2.Rows[7].Cells[3].Value.ToString();
            lbH2.Text = DatagridViviendas2.Rows[7].Cells[4].Value.ToString();
            lbDe2.Text = DatagridViviendas2.Rows[7].Cells[5].Value.ToString();
            byte[] imageBuffer8 = (byte[])DatagridViviendas2.Rows[7].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms8 = new System.IO.MemoryStream(imageBuffer8);//
            pViv2.Image = Image.FromStream(ms8);//le asignas al pictureBox
            //tercero 
            lbP3.Text = DatagridViviendas2.Rows[8].Cells[6].Value.ToString();
            lbU3.Text = DatagridViviendas2.Rows[8].Cells[2].Value.ToString();
            lbD3.Text = DatagridViviendas2.Rows[8].Cells[3].Value.ToString();
            lbH3.Text = DatagridViviendas2.Rows[8].Cells[4].Value.ToString();
            lbDe3.Text = DatagridViviendas2.Rows[8].Cells[5].Value.ToString();
            byte[] imageBuffer9 = (byte[])DatagridViviendas2.Rows[8].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms9 = new System.IO.MemoryStream(imageBuffer9);//
            pViv3.Image = Image.FromStream(ms9);//le asignas al pictureBox
            //cuarto
            lbP4.Text = DatagridViviendas2.Rows[9].Cells[6].Value.ToString();
            lbU4.Text = DatagridViviendas2.Rows[9].Cells[2].Value.ToString();
            lbD4.Text = DatagridViviendas2.Rows[9].Cells[3].Value.ToString();
            lbH4.Text = DatagridViviendas2.Rows[9].Cells[4].Value.ToString();
            lbDe4.Text = DatagridViviendas2.Rows[9].Cells[5].Value.ToString();
            byte[] imageBuffer10 = (byte[])DatagridViviendas2.Rows[9].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms10 = new System.IO.MemoryStream(imageBuffer10);//
            pViv4.Image = Image.FromStream(ms10);//le asignas al pictureBox
            //quinto
            lbP5.Text = DatagridViviendas2.Rows[10].Cells[6].Value.ToString();
            lbU5.Text = DatagridViviendas2.Rows[10].Cells[2].Value.ToString();
            lbD5.Text = DatagridViviendas2.Rows[10].Cells[3].Value.ToString();
            lbH5.Text = DatagridViviendas2.Rows[10].Cells[4].Value.ToString();
            lbDe5.Text = DatagridViviendas2.Rows[10].Cells[5].Value.ToString();
            byte[] imageBuffer11 = (byte[])DatagridViviendas2.Rows[10].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms11 = new System.IO.MemoryStream(imageBuffer11);//
            pViv5.Image = Image.FromStream(ms11);//le asignas al pictureBox
            //sexto
            lbP6.Text = DatagridViviendas2.Rows[11].Cells[6].Value.ToString();
            lbU6.Text = DatagridViviendas2.Rows[11].Cells[2].Value.ToString();
            lbD6.Text = DatagridViviendas2.Rows[11].Cells[3].Value.ToString();
            lbH6.Text = DatagridViviendas2.Rows[11].Cells[4].Value.ToString();
            lbDe6.Text = DatagridViviendas2.Rows[11].Cells[5].Value.ToString();
            byte[] imageBuffer12 = (byte[])DatagridViviendas2.Rows[11].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms12 = new System.IO.MemoryStream(imageBuffer12);//
            pViv6.Image = Image.FromStream(ms12);//le asignas al pictureBox

        }

        private void btPag3_Click(object sender, EventArgs e)
        {
            lbP1.Text = DatagridViviendas2.Rows[13].Cells[6].Value.ToString();
            lbU1.Text = DatagridViviendas2.Rows[13].Cells[2].Value.ToString();
            lbD1.Text = DatagridViviendas2.Rows[13].Cells[3].Value.ToString();
            lbH1.Text = DatagridViviendas2.Rows[13].Cells[4].Value.ToString();
            lbDe1.Text = DatagridViviendas2.Rows[13].Cells[5].Value.ToString();
            byte[] imageBuffer = (byte[])DatagridViviendas2.Rows[13].Cells[7].Value; //almacenas la imagen de la datagrib
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);//
            pViv6.Image = Image.FromStream(ms);//le asignas al pictureBox
            //segundo 

            lbP2.Text = DatagridViviendas2.Rows[14].Cells[6].Value.ToString();
            lbU2.Text = DatagridViviendas2.Rows[14].Cells[2].Value.ToString();
            lbD2.Text = DatagridViviendas2.Rows[14].Cells[3].Value.ToString();
            lbH2.Text = DatagridViviendas2.Rows[14].Cells[4].Value.ToString();
            lbDe2.Text = DatagridViviendas2.Rows[14].Cells[5].Value.ToString();
            //tercero 
            lbP3.Text = DatagridViviendas2.Rows[15].Cells[6].Value.ToString();
            lbU3.Text = DatagridViviendas2.Rows[15].Cells[2].Value.ToString();
            lbD3.Text = DatagridViviendas2.Rows[15].Cells[3].Value.ToString();
            lbH3.Text = DatagridViviendas2.Rows[15].Cells[4].Value.ToString();
            lbDe3.Text = DatagridViviendas2.Rows[15].Cells[5].Value.ToString();
            //cuarto
            lbP4.Text = DatagridViviendas2.Rows[16].Cells[6].Value.ToString();
            lbU4.Text = DatagridViviendas2.Rows[16].Cells[2].Value.ToString();
            lbD4.Text = DatagridViviendas2.Rows[16].Cells[3].Value.ToString();
            lbH4.Text = DatagridViviendas2.Rows[16].Cells[4].Value.ToString();
            lbDe4.Text = DatagridViviendas2.Rows[16].Cells[5].Value.ToString();
            //quinto
            lbP5.Text = DatagridViviendas2.Rows[17].Cells[6].Value.ToString();
            lbU5.Text = DatagridViviendas2.Rows[17].Cells[2].Value.ToString();
            lbD5.Text = DatagridViviendas2.Rows[17].Cells[3].Value.ToString();
            lbH5.Text = DatagridViviendas2.Rows[17].Cells[4].Value.ToString();
            lbDe5.Text = DatagridViviendas2.Rows[17].Cells[5].Value.ToString();
            //sexto
            lbP6.Text = DatagridViviendas2.Rows[18].Cells[6].Value.ToString();
            lbU6.Text = DatagridViviendas2.Rows[18].Cells[2].Value.ToString();
            lbD6.Text = DatagridViviendas2.Rows[18].Cells[3].Value.ToString();
            lbH6.Text = DatagridViviendas2.Rows[18].Cells[4].Value.ToString();
            lbDe6.Text = DatagridViviendas2.Rows[18].Cells[5].Value.ToString();
            
        }
    }
}
