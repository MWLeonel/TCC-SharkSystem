using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Makgel
{
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdMakgelDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bdMakgelDataSet.cliente);

        }
    }
}
