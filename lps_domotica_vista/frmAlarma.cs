using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lps_domotica_vista
{
    public partial class frmAlarma : Form
    {
        public frmAlarma()
        {
            InitializeComponent();
        }

        private void frmAlarma_Load(object sender, EventArgs e)
        {
            using (IWSAdministracion.WSAdministracionClient cliente = new IWSAdministracion.WSAdministracionClient())
            {
                 //cliente.ListarAlarma().Anexo["ColeccionAlarmas"];
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            using (IWSAdministracion.WSAdministracionClient cliente = new IWSAdministracion.WSAdministracionClient())
            {
                //cliente.AgregarAlarma();
            }
        }

        
    }
}