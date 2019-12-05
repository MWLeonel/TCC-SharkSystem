using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Makgel
{
    public partial class cadastrarClienteUC : UserControl
    {

        public cadastrarClienteUC()
        {
            InitializeComponent();

            this.clienteBindingSource.AddNew();

            panelCobre.Location = new Point(7, 43);
            panelCobre.Size = new Size(803, 523);
            panelCobre.BringToFront();
            numNumero.Value = 0;
            panelCadastrar.Location = new Point(7, 43);
            panelCadastrar.Size = new Size(65, 506);
            panelConsultar.Location = new Point(760, 194);
            panelConsultar.Size = new Size(50, 372);
            lblCon.Text = "";
            lblCad.Text = "";
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            this.clienteBindingSource.AddNew();
            numNumero.Value = 0;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            panelCadastrar.Location = new Point(7,43);
            panelCadastrar.Size = new Size(803, 523);
            panelCadastrar.BringToFront();
            btnConsultar.Enabled = true;
            btnCadastrar.Enabled = false;
            lblCon.Text = "";
            lblCad.Text = "____________________________________________";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            panelConsultar.Location = new Point(7, 43);
            panelConsultar.Size = new Size(803, 523);
            panelConsultar.BringToFront();
            btnConsultar.Enabled = false;
            btnCadastrar.Enabled = true;
            lblCon.Text = "___________________________________________";
            lblCad.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelEdita.Location = new Point(3, 3);
            panelEdita.Size = new Size(800, 517);
            panelEdita.BringToFront();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            panelEdita.Location = new Point(769, 499);
            panelEdita.Size = new Size(34, 21);
        }


        private void btnSalvar2_Click(object sender, EventArgs e)
        {


            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            this.clienteBindingSource.AddNew();
            panelEdita.Location = new Point(3, 494);
            panelEdita.Size = new Size(800, 26);
            panelEdita.BringToFront();
        }

        private void gpCliente_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
