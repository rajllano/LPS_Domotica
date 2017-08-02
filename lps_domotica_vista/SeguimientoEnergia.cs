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
    public partial class SeguimientoEnergia : Form
    {
        public SeguimientoEnergia()
        {
            InitializeComponent();
        }

        private void SeguimientoEnergia_Load(object sender, EventArgs e)
        {
            using (IWSEnergia.WSEnergiaClient cliente = new IWSEnergia.WSEnergiaClient())
            {
                cliente.AgregarEnergia("1A", DateTime.Now, 13, 14.6, 123);
                cliente.AgregarEnergia("1A", DateTime.Now, 14, 14.6, 123);
                cliente.AgregarEnergia("1A", DateTime.Now, 15, 14.6, 123);
                cliente.AgregarEnergia("1A", DateTime.Now, 16, 14.6, 123);
                cliente.AgregarEnergia("1A", DateTime.Now, 17, 14.6, 123);
                cliente.AgregarEnergia("1A", DateTime.Now, 18, 14.6, 123);
                cliente.AgregarEnergia("1A", DateTime.Now, 19, 14.6, 123);
                cliente.AgregarEnergia("1A", DateTime.Now, 20, 14.6, 123);

                cliente.AgregarEnergia("1B", DateTime.Now, 13, 17.6, 153);
                cliente.AgregarEnergia("1B", DateTime.Now, 14, 14.6, 153);
                cliente.AgregarEnergia("1B", DateTime.Now, 15, 14.6, 153);
                cliente.AgregarEnergia("1B", DateTime.Now, 16, 14.6, 153);
                cliente.AgregarEnergia("1B", DateTime.Now, 17, 17.6, 153);
                cliente.AgregarEnergia("1B", DateTime.Now, 18, 15.6, 153);
                cliente.AgregarEnergia("1B", DateTime.Now, 19, 18.6, 153);
                cliente.AgregarEnergia("1B", DateTime.Now, 20, 19.6, 153);

                cliente.AgregarEnergia("1C", DateTime.Now, 13, 12.6, 113);
                cliente.AgregarEnergia("1C", DateTime.Now, 14, 13.6, 113);
                cliente.AgregarEnergia("1C", DateTime.Now, 15, 16.6, 113);
                cliente.AgregarEnergia("1C", DateTime.Now, 16, 18.6, 113);
                cliente.AgregarEnergia("1C", DateTime.Now, 17, 11.6, 113);
                cliente.AgregarEnergia("1C", DateTime.Now, 18, 13.6, 113);
                cliente.AgregarEnergia("1C", DateTime.Now, 19, 12.6, 113);
                cliente.AgregarEnergia("1C", DateTime.Now, 20, 10.6, 113);

            }
        }

        private void listarEnergia()
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
    }
}
