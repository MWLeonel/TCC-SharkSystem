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
    public partial class entradaEstoqueUC : UserControl
    {
        
        public entradaEstoqueUC()
        {
            InitializeComponent();
            lblCon.Text = "";
            lblCad.Text = "";

        }
 


        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }



      

        private void ckbGeladeira_OnChange(object sender, EventArgs e)
        {
            if (ckbGeladeira.Checked==true)
            {
                ckbMaquina.Checked = false;
                ckbMicroondas.Checked = false;
                cmbGeladeira.BringToFront();
                txtProduto.BringToFront();
                cmbGeladeira.Enabled = true;
                cmbMaquina.Text = "";
                cmbMaquina.Enabled = false;
                cmbMicroondas.Text = "";
                cmbMicroondas.Enabled = false;
            }
            
            else if (ckbGeladeira.Checked == false && ckbMaquina.Checked == false && ckbMicroondas.Checked == false)
            {
                cmbEsconde.BringToFront();
            }

        }

        private void ckbMaquina_OnChange(object sender, EventArgs e)
        {
            if (ckbMaquina.Checked==true)
            {
                ckbGeladeira.Checked = false;
                ckbMicroondas.Checked = false;
                cmbMaquina.BringToFront();
                txtProduto.BringToFront();
                cmbMaquina.Enabled = true;
                cmbMicroondas.Text = "";
                cmbMicroondas.Enabled = false;
                cmbGeladeira.Text = "";
                cmbGeladeira.Enabled = false;
            }

            else if (ckbGeladeira.Checked == false && ckbMaquina.Checked == false && ckbMicroondas.Checked == false)
            {
                cmbEsconde.BringToFront();
            }

        }

        private void ckbMicroondas_OnChange(object sender, EventArgs e)
        {
            if (ckbMicroondas.Checked)
            {
                ckbMaquina.Checked = false;
                ckbGeladeira.Checked = false;
                cmbMicroondas.BringToFront();
                txtProduto.BringToFront();
                cmbMicroondas.Enabled = true;
                cmbMaquina.Text = "";
                cmbMaquina.Enabled = false;
                cmbGeladeira.Text = "";
                cmbGeladeira.Enabled = false;

            }
            else if (ckbGeladeira.Checked == false && ckbMaquina.Checked == false && ckbMicroondas.Checked == false)
            {
                cmbEsconde.BringToFront();
            }


        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            txtValorUnitario.Text = "";
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            

            

        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            panelCadastrar.Location = new Point(11, 48);
            panelCadastrar.Size = new Size(802, 473);
            panelCadastrar.BringToFront();
            btnConsultar.Enabled = true;
            btnCadastrar.Enabled = false;
            lblCon.Text = "";
            lblCad.Text = "____________________________________________";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            panelCadastrar.Location = new Point(12, 48);
            panelCadastrar.Size = new Size(72, 473);
            btnConsultar.Enabled = false;
            btnCadastrar.Enabled = true;
            lblCon.Text = "___________________________________________";
            lblCad.Text = "";

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slGel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void slMic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkGel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGel.Checked == true)
            {
                checkMaq.Checked = false;
                checkMic.Checked = false;
                slGel.BringToFront();
                slGel.Enabled = true;
                slMaq.Text = "";
                slMaq.Enabled = false;
                slMic.Text = "";
                slMic.Enabled = false;
            }

            else if (checkGel.Checked == false && checkMaq.Checked == false && checkMic.Checked == false)
            {
                panelProd.BringToFront();
            }

        }

        private void checkMaq_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMaq.Checked == true)
            {
                checkGel.Checked = false;
                checkMic.Checked = false;
                slMaq.BringToFront();
                slMaq.Enabled = true;
                slGel.Text = "";
                slGel.Enabled = false;
                slMic.Text = "";
                slMic.Enabled = false;
            }

            else if (checkGel.Checked == false && checkMaq.Checked == false && checkMic.Checked == false)
            {
                panelProd.BringToFront();
            }
        }

        private void checkMic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMic.Checked == true)
            {
                checkMaq.Checked = false;
                checkGel.Checked = false;
                slMic.BringToFront();
                slMic.Enabled = true;
                slMaq.Text = "";
                slMaq.Enabled = false;
                slGel.Text = "";
                slGel.Enabled = false;
            }

            else if (checkGel.Checked == false && checkMaq.Checked == false && checkMic.Checked == false)
            {
                panelProd.BringToFront();
            }
        }
    }
}
