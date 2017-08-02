using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domotica_WcfService;

namespace lps_domotica_vista
{
    public partial class frmAlarma : Form
    {
        public frmAlarma()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            /*using (WSAdministracion.WSWSAdministracionClient cliente = new WSAdministracion.WSWSAdministracionClient())
            {
                cliente.Agregar();
            }*/
        }
    }
}