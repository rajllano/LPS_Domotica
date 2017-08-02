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
    public partial class MDIParent1 : Form
    {
        public MDIParent1()
        {
            InitializeComponent();
        }
        
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotificaciones  Forma = new frmNotificaciones();
            Forma.MdiParent = this;
            Forma.Show();
            Forma.WindowState = FormWindowState.Normal;
        }

        private void dispositivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDispositivo Forma = new frmDispositivo();
            Forma.MdiParent = this;
            Forma.Show();
            Forma.WindowState = FormWindowState.Normal;
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAlarma  Forma = new frmAlarma();
            Forma.MdiParent = this;
            Forma.Show();
            Forma.WindowState = FormWindowState.Normal;
        }

        private void seguimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeguimientoEnergia  Forma = new SeguimientoEnergia();
            Forma.MdiParent = this;
            Forma.Show();
            Forma.WindowState = FormWindowState.Normal;
        }
    }
}
