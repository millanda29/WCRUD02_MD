using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCRUD2_MD2.UI
{
    public partial class Principal : Form
    {
        private static Person Instancia = null;

        public Principal()
        {
            InitializeComponent();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Instancia == null || Instancia.IsDisposed)
            {
                Instancia = Person.ObtenerInstancia();
                Instancia.MdiParent = this;
                Instancia.Show();
            }
            else
            {
                Instancia.BringToFront();
            }
        }
    }
}

