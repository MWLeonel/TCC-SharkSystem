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
    public partial class registrarServicoUC : UserControl
    {
        public registrarServicoUC()
        {
            InitializeComponent();
            lblCon.Text = "";
            lblCad.Text = "";
        }

        private void registrarServicoUC_Load(object sender, EventArgs e)
        {
          
        }

        private void cmbLocalServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLocalServico.Text == "Residência")
            {
                dtDataServico.Enabled = true;
                dtDataRetiro.Enabled = false;
                dtDataEntrega.Enabled = false;


            }
            else if (cmbLocalServico.Text == "Loja")
            {
                dtDataRetiro.Enabled = true;
                dtDataEntrega.Enabled = true;
                dtDataServico.Enabled = false;

            }
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ckbGeladeira_OnChange_1(object sender, EventArgs e)
        {
            if (ckbGeladeira.Checked == true)
            {
                ckbMaquina.Checked = false;
                ckbMicroondas.Checked = false;
                cklGeladeira.BringToFront();
            }

            else if (ckbGeladeira.Checked == false && ckbMaquina.Checked == false && ckbMicroondas.Checked == false)
            {
                panel1.BringToFront();
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
                panel1.BringToFront();
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
                panel1.BringToFront();
            }
        }

        private void cklMicroondas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            panelCadastrar2.Location = new Point(9, 51);
            panelCadastrar2.Size = new Size(802, 483);
            panelCadastrar2.BringToFront();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            panelCadastrar.Location = new Point(9, 51);
            panelCadastrar.Size = new Size(802, 483);
            panelCadastrar.BringToFront();
            btnConsultar.Enabled = true;
            btnCadastrar.Enabled = false;
            lblCon.Text = "";
            lblCad.Text = "____________________________________________";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            panelCadastrar.Location = new Point(9, 51);
            panelCadastrar.Size = new Size(17, 483);
            panelCadastrar2.Location = new Point(796, 51);
            panelCadastrar2.Size = new Size(17, 483);
            btnConsultar.Enabled = false;
            btnCadastrar.Enabled = true;
            lblCon.Text = "___________________________________________";
            lblCad.Text = "";
        }

        private void btnAnterior2_Click(object sender, EventArgs e)
        {
            panelCadastrar.Location = new Point(9, 51);
            panelCadastrar.Size = new Size(802, 483);
            panelCadastrar.BringToFront();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }
    }
}
