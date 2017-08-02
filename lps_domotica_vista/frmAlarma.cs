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
            //cargarListarAlarmas();
            using (IWSAdministracion.WSAdministracionClient cliente = new IWSAdministracion.WSAdministracionClient())
            {

                //cliente.AgregarAlarma("1","Alarma 1", DateTime.Now, );
            }
        }

        private void cargarListarAlarmas()
        {
            using (IWSAdministracion.WSAdministracionClient cliente = new IWSAdministracion.WSAdministracionClient())
            {
                StringBuilder CertBuilder = new StringBuilder();
                // Recorre los pares           
                foreach (KeyValuePair<string, object> Par in cliente.ListarAlarma().Anexo)
                {
                    CertBuilder.AppendLine(string.Format("{0}:{1}", Par.Key, Par.Value));
                    Console.WriteLine(Par.Key + " - " + Par.Value);
                }
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