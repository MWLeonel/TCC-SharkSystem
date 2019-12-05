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
    public partial class cadastrarFornecedorUC : UserControl
    {
       

        public cadastrarFornecedorUC()
        {

            InitializeComponent();
            this.fornecedorBindingSource.AddNew();
            lblCon.Text = "";
            lblCad.Text = "";
            panelConsultar.Location = new Point(779, 49);
            panelConsultar.Size = new Size(29, 500);
            panelCadastrar.Location = new Point(8, 49);
            panelCadastrar.Size = new Size(20, 500);

        }

        private void cadastrarFornecedorUC_Load(object sender, EventArgs e)
        {
            
        }

        private void chekGel_OnChange(object sender, EventArgs e)
        {
            
            if (chekGel.Checked == true)
            {
                chekMaq.Checked = false;
                chekMic.Checked = false;
                cklGel.BringToFront();
            }

            else if (chekGel.Checked == false && chekMaq.Checked == false && chekMic.Checked == false)
            {
                panelProdutos.BringToFront();
            }
        }


        private void chekMaq_OnChange(object sender, EventArgs e)
        {
            if (chekMaq.Checked == true)
            {
                chekGel.Checked = false;
                chekMic.Checked = false;
                cklMaq.BringToFront();
            }

            else if (chekGel.Checked == false && chekMaq.Checked == false && chekMic.Checked == false)
            {
                panelProdutos.BringToFront();
            }
        }

        private void chekMic_OnChange(object sender, EventArgs e)
        {
            if (chekMic.Checked == true)
            {
                chekGel.Checked = false;
                chekMaq.Checked = false;
                cklMic.BringToFront();
            }

            else if (chekGel.Checked == false && chekMaq.Checked == false && chekMic.Checked == false)
            {
                panelProdutos.BringToFront();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            panelCadastrar.Location = new Point(8, 45);
            panelCadastrar.Size = new Size(801, 500);
            panelCadastrar.BringToFront();
            btnConsultar.Enabled = true;
            btnCadastrar.Enabled = false;
            lblCon.Text = "";
            lblCad.Text = "____________________________________________";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            btnConsultar.Enabled = false;
            btnCadastrar.Enabled = true;
            lblCon.Text = "___________________________________________";
            lblCad.Text = "";
            panelConsultar.Location = new Point(8, 45);
            panelConsultar.Size = new Size(801, 500);
            panelConsultar.BringToFront();
        }
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < cklGel.Items.Count; i++)
            {
                if (cklGel.GetItemCheckState(i) == CheckState.Checked)
                {
                    string a = cklGel.Items[i].ToString();

                }
                
            }

            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            this.fornecedorBindingSource.AddNew();
            numNumero.Value = 0;


            
          }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cklGel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelEdita.Location = new Point(3, 3);
            panelEdita.Size = new Size(798, 498);
            panelEdita.BringToFront();
        }

        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            this.fornecedorBindingSource.AddNew();
            panelEdita.Location = new Point(3, 494);
            panelEdita.Size = new Size(800, 26);
            panelEdita.BringToFront();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            panelEdita.Location = new Point(769, 477);
            panelEdita.Size = new Size(797, 21);
        }

        private void checkGel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGel.Checked == true)
            {
                checkMaq.Checked = false;
                checkMic.Checked = false;
                cGel.BringToFront();
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
                cGel.BringToFront();
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
                cGel.BringToFront();
            }

            else if (checkGel.Checked == false && checkMaq.Checked == false && checkMic.Checked == false)
            {
                panelProd.BringToFront();
            }
        }
    }
}
