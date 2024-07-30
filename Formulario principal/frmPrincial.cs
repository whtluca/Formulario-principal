using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_principal
{
    public partial class frmPrincial : Form
    {
        public frmPrincial()
        {
            InitializeComponent();
        }

        private void frmPrincial_Load(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos p = new frmProdutos();
            p.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes c = new frmClientes();
            c.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias ca = new frmCategorias();
            ca.ShowDialog();
        }
    }
}
