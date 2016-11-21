using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdimarCM_Aplicada_1_P2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Re = new Form1();
            Re.MdiParent = this.MdiParent;
            Re.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Consulta Re = new Consulta();
            Re.MdiParent = this.MdiParent;
            Re.Show();
        }
    }
    }

