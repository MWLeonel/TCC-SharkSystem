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
    public partial class registrarOrcamentoUC : UserControl
    {
        public registrarOrcamentoUC()
        {
            InitializeComponent();

            lblCon.Text = "";
            lblCad.Text = "";
        }


        private void registrarOrcamentoUC_Load(object sender, EventArgs e)
        {

        }

        private void cklMicroondas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cklGeladeira_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cklMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbGeladeira_OnChange(object sender, EventArgs e)
        {
            if (ckbGeladeira.Checked == true)
            {
                ckbMaquina.Checked = false;
                ckbMicroondas.Checked = false;
                cklGeladeira.BringToFront();
            }

            else if (ckbGeladeira.Checked == false && ckbMaquina.Checked == false && ckbMicroondas.Checked == false)
            {
                panelProdutos.BringToFront();
            }
        }

        private void ckbMaquina_OnChange(object sender, EventArgs e)
        {
            if (ckbMaquina.Checked == true)
            {
                ckbGeladeira.Checked = false;
                ckbMicroondas.Checked = false;
                cklMaquina.BringToFront();
            }

            else if (ckbGeladeira.Checked == false && ckbMaquina.Checked == false && ckbMicroondas.Checked == false)
            {
                panelProdutos.BringToFront();
            }
        }

        private void ckbMicroondas_OnChange(object sender, EventArgs e)
        {
            if (ckbMicroondas.Checked)
            {
                ckbMaquina.Checked = false;
                ckbGeladeira.Checked = false;
                cklMicroondas.BringToFront();

            }
            else if (ckbGeladeira.Checked == false && ckbMaquina.Checked == false && ckbMicroondas.Checked == false)
            {
                panelProdutos.BringToFront();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            panelCadastrar.Location = new Point(14, 51);
            panelCadastrar.Size = new Size(800, 461);
            panelCadastrar.BringToFront();
            btnConsultar.Enabled = true;
            btnCadastrar.Enabled = false;
            lblCon.Text = "";
            lblCad.Text = "____________________________________________";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            panelCadastrar.Location = new Point(14, 51);
            panelCadastrar.Size = new Size(10, 461);
            btnConsultar.Enabled = false;
            btnCadastrar.Enabled = true;
            lblCon.Text = "___________________________________________";
            lblCad.Text = "";
        }
    }
}
