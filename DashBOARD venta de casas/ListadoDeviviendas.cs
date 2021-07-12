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
    public partial class ListadoDeviviendas : UserControl
    {
        public ListadoDeviviendas()
        {
            InitializeComponent();
           
        }

        private void ListadoDeviviendas_Load(object sender, EventArgs e)
        {
            dataSet1.Clear();
            dataSet1.ReadXml(Application.StartupPath + "tviviendas.xml");
        }
    }
}
