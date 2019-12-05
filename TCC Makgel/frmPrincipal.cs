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

    public partial class frmPrincipal : Form
    {



        public frmPrincipal()
        {
            InitializeComponent();
            lblForm.Text = "Inicio";
            panInicio.Location = new Point(189, 31);
            panInicio.Size = new Size(816, 547);
            panInicio.BringToFront();

            


        }

        private void Form_2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdMakgelDataSet.serv' table. You can move, or remove it, as needed.
          //  this.servTableAdapter.Fill(this.bdMakgelDataSet.serv);
            // TODO: This line of code loads data into the 'bdMakgelDataSet.produto_fornecedor' table. You can move, or remove it, as needed.
          //  this.produto_fornecedorTableAdapter.Fill(this.bdMakgelDataSet.produto_fornecedor);
            // TODO: This line of code loads data into the 'bdMakgelDataSet.servico' table. You can move, or remove it, as needed.
            this.servicoTableAdapter.Fill(this.bdMakgelDataSet.servico);
            // TODO: This line of code loads data into the 'bdMakgelDataSet.orcamento' table. You can move, or remove it, as needed.
            this.orcamentoTableAdapter.Fill(this.bdMakgelDataSet.orcamento);
            // TODO: This line of code loads data into the 'bdMakgelDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.bdMakgelDataSet.produto);
            // TODO: This line of code loads data into the 'bdMakgelDataSet.produto_fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.bdMakgelDataSet.fornecedor);
            // TODO: This line of code loads data into the 'bdMakgelDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bdMakgelDataSet.cliente);
            


        }

        //Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Botão Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Tela Home
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            lblForm.Text = "Inicio";
            panInicio.Location = new Point(189, 31);
            panInicio.Size = new Size(816, 547);
            panInicio.BringToFront();

        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin fl = new frmLogin();
                Hide();
                fl.Show();
            }


        }


        //cliente
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        //Fornecedor
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //produto
        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //orcamento
        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //servico
        private void servicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void btnSalvarCli_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            this.clienteBindingSource.AddNew();
            numNumeroCli.Value = 0;
            MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso");

        }

        private void btnEditarCli_Click(object sender, EventArgs e)
        {
            if (pesquisaCliente.Text != "")
            {
                panelEditaCli.Location = new Point(0, 0);
                panelEditaCli.Size = new Size(813, 544);
                panelEditaCli.BringToFront();
            }
            else if (pesquisaCliente.Text == "")
            {
                MessageBox.Show("Selecione um cliente para editar!", "Aviso");
            }

        }

        private void btnSalvarCli2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            panelEditaCli.Location = new Point(0, 466);
            panelEditaCli.Size = new Size(800, 38);

            MessageBox.Show("Cliente alterado com sucesso!", "Aviso");

        }

        private void cancelarCli_Click(object sender, EventArgs e)
        {
            panelEditaCli.Location = new Point(0, 466);
            panelEditaCli.Size = new Size(800, 38);

        }

        private void chekGelFor_OnChange(object sender, EventArgs e)
        {
            if (chekGelFor.Checked == true)
            {
                chekMaqFor.Checked = false;
                chekMicFor.Checked = false;
                cklGelFor.BringToFront();
            }

            else if (chekGelFor.Checked == false && chekMaqFor.Checked == false && chekMicFor.Checked == false)
            {
                panelProdutosFor.BringToFront();
            }
        }

        private void chekMaqFor_OnChange(object sender, EventArgs e)
        {
            if (chekMaqFor.Checked == true)
            {
                chekGelFor.Checked = false;
                chekMicFor.Checked = false;
                cklMaqFor.BringToFront();
            }

            else if (chekGelFor.Checked == false && chekMaqFor.Checked == false && chekMicFor.Checked == false)
            {
                panelProdutosFor.BringToFront();
            }
        }

        private void chekMicFor_OnChange(object sender, EventArgs e)
        {
            if (chekMicFor.Checked == true)
            {
                chekGelFor.Checked = false;
                chekMaqFor.Checked = false;
                cklMicFor.BringToFront();
            }

            else if (chekGelFor.Checked == false && chekMaqFor.Checked == false && chekMicFor.Checked == false)
            {
                panelProdutosFor.BringToFront();
            }
        }

        private void btnSalvarFor_Click(object sender, EventArgs e)
        {

            /* for (int i = 0; i < cklGelFor.Items.Count; i++)
             {
                 if (cklGelFor.GetItemCheckState(i) == CheckState.Checked)
                 {

                     listBox1.Items.Add(cklGelFor.Items[i].ToString());
                 }


             }

             if (cklGelFor.GetItemCheckState(0) == CheckState.Checked)
             {
                 for0.Text = "0";
                 listBox1.Items.Add(cklGelFor.Items[0].ToString());
             }
             if (cklGelFor.GetItemCheckState(1) == CheckState.Checked)
             {
                 for1.Text = "1";
                 listBox1.Items.Add(cklGelFor.Items[1].ToString());
             }
             */

            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            this.fornecedorBindingSource.AddNew();
            numNumero.Value = 0;


            cklGelFor.SetItemChecked(0, false);
            cklGelFor.SetItemChecked(1, false);
            cklGelFor.SetItemChecked(2, false);
            cklGelFor.SetItemChecked(3, false);
            cklGelFor.SetItemChecked(4, false);

            cklMaqFor.SetItemChecked(0, false);
            cklMaqFor.SetItemChecked(1, false);
            cklMaqFor.SetItemChecked(2, false);
            cklMaqFor.SetItemChecked(3, false);
            cklMaqFor.SetItemChecked(4, false);

            cklMicFor.SetItemChecked(0, false);
            cklMicFor.SetItemChecked(1, false);
            cklMicFor.SetItemChecked(2, false);
            cklMicFor.SetItemChecked(3, false);
            cklMicFor.SetItemChecked(4, false);

            MessageBox.Show("Fornecedor cadastrado com sucesso!", "Aviso");
        }

        private void btnEditarFor_Click(object sender, EventArgs e)
        {
            if (pesquisaFornecedor.Text != "")
            {
                panelEditaFor.Location = new Point(0, 0);
                panelEditaFor.Size = new Size(813, 544);
                panelEditaFor.BringToFront();

                if (lgelf0.Text == "0")
                {
                    cGel.SetItemChecked(0, true);
                }
                if (lgelf1.Text == "1")
                {
                    cGel.SetItemChecked(1, true);
                }
                if (lgelf2.Text == "2")
                {
                    cGel.SetItemChecked(2, true);
                }
                if (lgelf3.Text == "3")
                {
                    cGel.SetItemChecked(3, true);
                }
                if (lgelf4.Text == "4")
                {
                    cGel.SetItemChecked(4, true);
                }
                if (lgelf5.Text == "5")
                {
                    cGel.SetItemChecked(5, true);
                }


                if (lmaqf0.Text == "0")
                {
                    cMaq.SetItemChecked(0, true);
                }
                if (lmaqf1.Text == "1")
                {
                    cMaq.SetItemChecked(1, true);
                }
                if (lmaqf2.Text == "2")
                {
                    cMaq.SetItemChecked(2, true);
                }
                if (lmaqf3.Text == "3")
                {
                    cMaq.SetItemChecked(3, true);
                }
                if (lmaqf4.Text == "4")
                {
                    cMaq.SetItemChecked(4, true);
                }


                if (lmicf0.Text == "0")
                {
                    cMic.SetItemChecked(0, true);
                }
                if (lmiqf1.Text == "1")
                {
                    cMic.SetItemChecked(1, true);
                }
                if (lmicf2.Text == "2")
                {
                    cMic.SetItemChecked(2, true);
                }
                if (lmicf3.Text == "3")
                {
                    cMic.SetItemChecked(3, true);
                }
                if (lmicf4.Text == "4")
                {
                    cMic.SetItemChecked(4, true);
                }


            }


            else if (pesquisaFornecedor.Text == "")
            {
                MessageBox.Show("Selecione um fornecedor para editar!", "Aviso");
            }

        }

        private void btnSalvarFor2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            panelEditaFor.Location = new Point(0, 466);
            panelEditaFor.Size = new Size(800, 38);
            MessageBox.Show("Fornecedor alterado com sucesso!", "Aviso");
        }

        private void cancelarFor_Click(object sender, EventArgs e)
        {
            panelEditaFor.Location = new Point(0, 466);
            panelEditaFor.Size = new Size(800, 38);
        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarEst_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            this.produtoBindingSource.AddNew();
            numQuantidade.Value = 0;
            MessageBox.Show("Produto cadastrado com sucesso!", "Aviso");

        }

        private void btnEditarEst_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                panelEditaEst.Location = new Point(0, 0);
                panelEditaEst.Size = new Size(813, 544);
                panelEditaEst.BringToFront();
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Selecione um produto para editar!", "Aviso");
            }

        }

        private void btnSalvarEst2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            panelEditaEst.Location = new Point(0, 517);
            panelEditaEst.Size = new Size(800, 14);
        }


        private void cancelarEst_Click(object sender, EventArgs e)
        {
            panelEditaEst.Location = new Point(0, 466);
            panelEditaEst.Size = new Size(800, 38);
        }

        private void btnSalvarOrc_Click(object sender, EventArgs e)
        {
            textBox25.Text = label72.Text;

            this.Validate();
            this.orcamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            this.orcamentoBindingSource.AddNew();


            cklGelOrc.SetItemChecked(0, false);
            cklGelOrc.SetItemChecked(1, false);
            cklGelOrc.SetItemChecked(2, false);
            cklGelOrc.SetItemChecked(3, false);
            cklGelOrc.SetItemChecked(4, false);

            cklMaqOrc.SetItemChecked(0, false);
            cklMaqOrc.SetItemChecked(1, false);
            cklMaqOrc.SetItemChecked(2, false);
            cklMaqOrc.SetItemChecked(3, false);
            cklMaqOrc.SetItemChecked(4, false);

            cklMicOrc.SetItemChecked(0, false);
            cklMicOrc.SetItemChecked(1, false);
            cklMicOrc.SetItemChecked(2, false);
            cklMicOrc.SetItemChecked(3, false);
            cklMicOrc.SetItemChecked(4, false);

            MessageBox.Show("Orçamento cadastrado com sucesso!", "Aviso");
        }

        private void btnEditarOrc_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text != "")
            {
                panelEditaOrc.Location = new Point(0, 0);
                panelEditaOrc.Size = new Size(813, 544);
                panelEditaOrc.BringToFront();

                if (lgelo0.Text == "0")
                {
                    cGelo.SetItemChecked(0, true);
                }
                if (lgelo1.Text == "1")
                {
                    cGelo.SetItemChecked(1, true);
                }
                if (lgelo2.Text == "2")
                {
                    cGelo.SetItemChecked(2, true);
                }
                if (lgelo3.Text == "3")
                {
                    cGelo.SetItemChecked(3, true);
                }
                if (lgelo4.Text == "4")
                {
                    cGelo.SetItemChecked(4, true);
                }
                


                if (lmaqo0.Text == "0")
                {
                    cMaqo.SetItemChecked(0, true);
                }
                if (lmaqo1.Text == "1")
                {
                    cMaqo.SetItemChecked(1, true);
                }
                if (lmaqo2.Text == "2")
                {
                    cMaqo.SetItemChecked(2, true);
                }
                if (lmaqo3.Text == "3")
                {
                    cMaqo.SetItemChecked(3, true);
                }
                if (lmaqo4.Text == "4")
                {
                    cMaqo.SetItemChecked(4, true);
                }


                if (lmico0.Text == "0")
                {
                    cMico.SetItemChecked(0, true);
                }
                if (lmico1.Text == "1")
                {
                    cMico.SetItemChecked(1, true);
                }
                if (lmico2.Text == "2")
                {
                    cMico.SetItemChecked(2, true);
                }
                if (lmico3.Text == "3")
                {
                    cMico.SetItemChecked(3, true);
                }
                if (lmico4.Text == "4")
                {
                    cMico.SetItemChecked(4, true);
                }
            }

            else if (comboBox7.Text == "")
            {
                MessageBox.Show("Selecione um orçamento para editar!", "Aviso");
            }

        }

        private void btnCancelarOrc_Click(object sender, EventArgs e)
        {
            panelEditaOrc.Location = new Point(0, 466);
            panelEditaOrc.Size = new Size(800, 38);
        }

        private void btnSalvarOrc2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orcamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            panelEditaOrc.Location = new Point(0, 466);
            panelEditaOrc.Size = new Size(800, 38);

            MessageBox.Show("Orçamento alterado com sucesso!", "Aviso");
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior2_Click(object sender, EventArgs e)
        {

        }

        private void ckbGeladeira_OnChange(object sender, EventArgs e)
        {
            if (ckbGeladeira.Checked == true)
            {

                txtProduto.Items.Clear();
                txtProduto.Items.Insert(0, "Borracha de porta");
                txtProduto.Items.Insert(1, "Bimetal");
                txtProduto.Items.Insert(2, "Cabo de força");
                txtProduto.Items.Insert(3, "Compressor");
                txtProduto.Items.Insert(4, "Condensador");
                txtProduto.Items.Insert(5, "Damper");
                txtProduto.Items.Insert(6, "Evaporador");
                txtProduto.Items.Insert(7, "Filtro");
                txtProduto.Items.Insert(8, "Gás");
                txtProduto.Items.Insert(9, "Gaveta");
                txtProduto.Items.Insert(10, "Isolação");
                txtProduto.Items.Insert(11, "Interrupitor de porta");
                txtProduto.Items.Insert(12, "Jogo de pés");
                txtProduto.Items.Insert(13, "Lâmpada");
                txtProduto.Items.Insert(14, "Motor");
                txtProduto.Items.Insert(15, "Placa de Interface");
                txtProduto.Items.Insert(16, "Placa de potência");
                txtProduto.Items.Insert(17, "Resistência");
                txtProduto.Items.Insert(18, "Sensor de temperatura");
                txtProduto.Items.Insert(19, "Termostrato");
                txtProduto.BringToFront();

                ckbMaquina.Checked = false;
                ckbMicroondas.Checked = false;

            }

            else if (ckbGeladeira.Checked == false && ckbMaquina.Checked == false && ckbMicroondas.Checked == false)
            {

            }
        }

        private void ckbMaquina_OnChange(object sender, EventArgs e)
        {
            if (ckbMaquina.Checked == true)
            {
                ckbGeladeira.Checked = false;
                ckbMicroondas.Checked = false;


                txtProduto.Items.Clear();
                txtProduto.Items.Insert(0, "Atuador de freio");
                txtProduto.Items.Insert(1, "Automático");
                txtProduto.Items.Insert(2, "Batedor");
                txtProduto.BringToFront();
            }

            else if (ckbGeladeira.Checked == false && ckbMaquina.Checked == false && ckbMicroondas.Checked == false)
            {

            }
        }

        private void ckbMicroondas_OnChange(object sender, EventArgs e)
        {
            if (ckbMicroondas.Checked)
            {
                ckbMaquina.Checked = false;
                ckbGeladeira.Checked = false;

                txtProduto.Items.Clear();
                txtProduto.Items.Insert(0, "Cabo de força");
                txtProduto.Items.Insert(1, "Capacitor");
                txtProduto.Items.Insert(2, "Chicote de Fios");
                txtProduto.BringToFront();

            }
            else if (ckbGeladeira.Checked == false && ckbMaquina.Checked == false && ckbMicroondas.Checked == false)
            {

            }
        }



        private void picBox_Click(object sender, EventArgs e)
        {

        }

        private void txtValorOrc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void chekGelOrc_OnChange(object sender, EventArgs e)
        {
            
        }


        private void chekMicOrc_OnChange(object sender, EventArgs e)
        {
            if (chekMicOrc.Checked == true)
            {
                chekGelOrc.Checked = false;
                chekMaqOrc.Checked = false;
                cklMicOrc.BringToFront();
            }

            else if (chekGelFor.Checked == false && chekMaqFor.Checked == false && chekMicFor.Checked == false)
            {
                panelProdutosOrc.BringToFront();

            }
        }

        private void chekMaqOrc_OnChange(object sender, EventArgs e)
        {
            if (chekMaqOrc.Checked == true)
            {
                chekGelOrc.Checked = false;
                chekMicOrc.Checked = false;
                cklMaqOrc.BringToFront();
            }

            else if (chekGelFor.Checked == false && chekMaqFor.Checked == false && chekMicFor.Checked == false)
            {
                panelProdutosOrc.BringToFront();
            }
        }

        private void btnGerarServ_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text != "")
            {
                tdefeito.Text = label62.Text;
                tcliente.Text = label63.Text;
                tcpf.Text = label70.Text;
                tgarantia.Text = label74.Text;
                tvalor.Text = label59.Text;
                tpagamento.Text = label60.Text;

                panServico.Location = new Point(189, 30);
                panServico.Size = new Size(813, 544);
                panServico.BringToFront();
                lblForm.Text = "Cadastro de serviço";

                panCadastrarSer.Location = new Point(0, 0);
                panCadastrarSer.Size = new Size(813, 544);
                panCadastrarSer.BringToFront();

                if (contSer.Text != "1")
                {
                    this.servicoBindingSource.AddNew();
                    contSer.Text = "1";
                }

                if (lgelo0.Text == "0")
                {
                    cklGelSer.SetItemChecked(0, true);
                }
                if (lgelo1.Text == "1")
                {
                    cklGelSer.SetItemChecked(1, true);
                }
                if (lgelo2.Text == "2")
                {
                    cklGelSer.SetItemChecked(2, true);
                }
                if (lgelo3.Text == "3")
                {
                    cklGelSer.SetItemChecked(3, true);
                }
                if (lgelo4.Text == "4")
                {
                    cklGelSer.SetItemChecked(4, true);
                }



                if (lmaqo0.Text == "0")
                {
                    cklMaqSer.SetItemChecked(0, true);
                }
                if (lmaqo1.Text == "1")
                {
                    cklMaqSer.SetItemChecked(1, true);
                }
                if (lmaqo2.Text == "2")
                {
                    cklMaqSer.SetItemChecked(2, true);
                }
                if (lmaqo3.Text == "3")
                {
                    cklMaqSer.SetItemChecked(3, true);
                }
                if (lmaqo4.Text == "4")
                {
                    cklMaqSer.SetItemChecked(4, true);
                }


                if (lmico0.Text == "0")
                {
                    cklMicSer.SetItemChecked(0, true);
                }
                if (lmico1.Text == "1")
                {
                    cklMicSer.SetItemChecked(1, true);
                }
                if (lmico2.Text == "2")
                {
                    cklMicSer.SetItemChecked(2, true);
                }
                if (lmico3.Text == "3")
                {
                    cklMicSer.SetItemChecked(3, true);
                }
                if (lmico4.Text == "4")
                {
                    cklMicSer.SetItemChecked(4, true);
                }



            }
            else if (comboBox7.Text == "")
            {
                MessageBox.Show("Para gerar serviço selecione um orçamento!", "Aviso");
            }

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panCliente.Location = new Point(189, 30);
            panCliente.Size = new Size(813, 544);
            panCliente.BringToFront();
            lblForm.Text = "Cadastro de cliente";

            panelCadastrarCli.Location = new Point(0, 0);
            panelCadastrarCli.Size = new Size(813, 544);
            panelCadastrarCli.BringToFront();

            if (contCli.Text != "1")
            {
                this.clienteBindingSource.AddNew();
                contCli.Text = "1";
            }


        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panCliente.Location = new Point(189, 30);
            panCliente.Size = new Size(813, 544);
            panCliente.BringToFront();
            lblForm.Text = "Consulta de cliente";

            panelConsultarCli.Location = new Point(0, 0);
            panelConsultarCli.Size = new Size(813, 544);
            panelConsultarCli.BringToFront();

            panelEditaCli.Size = new Size(800, 14);
            panelEditaCli.Location = new Point(0, 530);

            panel74.BringToFront();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panFornecedor.Location = new Point(189, 30);
            panFornecedor.Size = new Size(813, 544);
            panFornecedor.BringToFront();
            lblForm.Text = "Cadastro de fornecedor";

            panelCadastrarFor.Location = new Point(0, 0);
            panelCadastrarFor.Size = new Size(813, 544);
            panelCadastrarFor.BringToFront();

            if (contFor.Text != "1")
            {
                this.fornecedorBindingSource.AddNew();
                contFor.Text = "1";
            }


        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panFornecedor.Location = new Point(189, 30);
            panFornecedor.Size = new Size(813, 544);
            panFornecedor.BringToFront();
            lblForm.Text = "Consulta de fornecedor";

            panelConsultarFor.Location = new Point(0, 0);
            panelConsultarFor.Size = new Size(813, 544);
            panelConsultarFor.BringToFront();

            panelEditaFor.Size = new Size(800, 14);
            panelEditaFor.Location = new Point(0, 530);

            panel73.BringToFront();


        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panEstoque.Location = new Point(189, 30);
            panEstoque.Size = new Size(813, 544);
            panEstoque.BringToFront();
            lblForm.Text = "Cadastro de produto";

            panelCadastrarEst.Location = new Point(0, 0);
            panelCadastrarEst.Size = new Size(813, 544);
            panelCadastrarEst.BringToFront();

            if (contEst.Text != "1")
            {
                this.produtoBindingSource.AddNew();
                contEst.Text = "1";
            }
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panEstoque.Location = new Point(189, 30);
            panEstoque.Size = new Size(813, 544);
            panEstoque.BringToFront();
            lblForm.Text = "Consulta de estoque";

            panelConsultarEst.Location = new Point(0, 0);
            panelConsultarEst.Size = new Size(813, 544);
            panelConsultarEst.BringToFront();

            panelEditaEst.Size = new Size(800, 14);
            panelEditaEst.Location = new Point(0, 530);

            panel75.BringToFront();


        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            panOrcamento.Location = new Point(189, 30);
            panOrcamento.Size = new Size(813, 544);
            panOrcamento.BringToFront();
            lblForm.Text = "Cadastro de orçamento";

            panelCadastrarOrc.Location = new Point(0, 0);
            panelCadastrarOrc.Size = new Size(813, 544);
            panelCadastrarOrc.BringToFront();



            if (contOrc.Text != "1")
            {
                this.orcamentoBindingSource.AddNew();
                contOrc.Text = "1";
            }

            

        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            panOrcamento.Location = new Point(189, 30);
            panOrcamento.Size = new Size(813, 544);
            panOrcamento.BringToFront();
            lblForm.Text = "Consulta de orçamento";

            panelConsultarOrc.Location = new Point(0, 0);
            panelConsultarOrc.Size = new Size(813, 544);
            panelConsultarOrc.BringToFront();

            panelEditaOrc.Size = new Size(800, 14);
            panelEditaOrc.Location = new Point(0, 530);

            panel76.BringToFront();

        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            panServico.Location = new Point(189, 30);
            panServico.Size = new Size(813, 544);
            panServico.BringToFront();
            lblForm.Text = "Consulta de Serviço";

            panelConsultarSer.Location = new Point(0, 0);
            panelConsultarSer.Size = new Size(813, 544);
            panelConsultarSer.BringToFront();

            panelEditaSer.Size = new Size(800, 14);
            panelEditaSer.Location = new Point(0, 530);

            panel78.BringToFront();
            

            


        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocalServico.Text == "Residência")
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

        private void btnSalvarSer_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);
            this.servicoBindingSource.AddNew();
            MessageBox.Show("Serviço cadastrado com sucesso!", "Aviso");


            tcliente.Text = "";
            tcpf.Text = "";
            tdefeito.Text = "";
            tpagamento.Text = "";
            tvalor.Text = "";

            cklGelSer.SetItemChecked(0, false);
            cklGelSer.SetItemChecked(1, false);
            cklGelSer.SetItemChecked(2, false);
            cklGelSer.SetItemChecked(3, false);
            cklGelSer.SetItemChecked(4, false);

            cklMaqSer.SetItemChecked(0, false);
            cklMaqSer.SetItemChecked(1, false);
            cklMaqSer.SetItemChecked(2, false);
            cklMaqSer.SetItemChecked(3, false);
            cklMaqSer.SetItemChecked(4, false);

            cklMicSer.SetItemChecked(0, false);
            cklMicSer.SetItemChecked(1, false);
            cklMicSer.SetItemChecked(2, false);
            cklMicSer.SetItemChecked(3, false);
            cklMicSer.SetItemChecked(4, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dtGarantia_onValueChanged(object sender, EventArgs e)
        {

        }

        private void dategarantia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chekGelSer_OnChange(object sender, EventArgs e)
        {
            ttcliente.Text = tcliente.Text;
            ttcpf.Text = tcpf.Text;
            ttdefeito.Text = tdefeito.Text;
            ttgarantia.Text = tgarantia.Text;
            ttpagamento.Text = tpagamento.Text;
            ttvalor.Text = tvalor.Text;

            if (cklGelSer.GetItemCheckState(0) == CheckState.Checked)
            {
                gels0.Text = "0";
            }
            else
            {
                gels0.Text = "";
            }

            if (cklGelSer.GetItemCheckState(1) == CheckState.Checked)
            {

                gels1.Text = "1";
            }
            else
            {
                gels1.Text = "";
            }
            if (cklGelSer.GetItemCheckState(2) == CheckState.Checked)
            {
                gels2.Text = "2";
            }
            else
            {
                gels2.Text = "";
            }
            if (cklGelSer.GetItemCheckState(3) == CheckState.Checked)
            {
                gels3.Text = "3";
            }
            else
            {
                gels3.Text = "";
            }
            if (cklGelSer.GetItemCheckState(4) == CheckState.Checked)
            {
                gels4.Text = "4";
            }
            else
            {
                gelo4.Text = "";
            }


            if (chekGelSer.Checked == true)
            {
                chekMaqSer.Checked = false;
                chekMicSer.Checked = false;
                cklGelSer.BringToFront();
            }

            else if (chekGelSer.Checked == false && chekMaqSer.Checked == false && chekMicSer.Checked == false)
            {
                panelProdutosSer.BringToFront();
            }
        }

        private void btnEditarSer_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text != "")
            {
                panelEditaSer.Location = new Point(0, 0);
                panelEditaSer.Size = new Size(813, 544);
                panelEditaSer.BringToFront();
                
                if (lgels0.Text == "0")
                {
                    cgels.SetItemChecked(0, true);
                }
                if (lgels1.Text == "1")
                {
                    cgels.SetItemChecked(1, true);
                }
                if (lgels2.Text == "2")
                {
                    cgels.SetItemChecked(2, true);
                }
                if (lgels3.Text == "3")
                {
                    cgels.SetItemChecked(3, true);
                }
                if (lgels4.Text == "4")
                {
                    cgels.SetItemChecked(4, true);
                }


                if (lmaqs0.Text == "0")
                {
                    cmaqs.SetItemChecked(0, true);
                }
                if (lmaqs1.Text == "1")
                {
                    cmaqs.SetItemChecked(1, true);
                }
                if (lmaqs2.Text == "2")
                {
                    cmaqs.SetItemChecked(2, true);
                }
                if (lmaqs3.Text == "3")
                {
                    cmaqs.SetItemChecked(3, true);
                }
                if (lmaqs4.Text == "4")
                {
                    cmaqs.SetItemChecked(4, true);
                }


                if (lmics0.Text == "0")
                {
                    cmics.SetItemChecked(0, true);
                }
                if (lmics1.Text == "1")
                {
                    cmics.SetItemChecked(1, true);
                }
                if (lmics2.Text == "2")
                {
                    cmics.SetItemChecked(2, true);
                }
                if (lmics3.Text == "3")
                {
                    cmics.SetItemChecked(3, true);
                }
                if (lmics4.Text == "4")
                {
                    cmics.SetItemChecked(4, true);
                }
                
            }
            else if (comboBox5.Text == "")
            {
                MessageBox.Show("Selecione um serviço para editar!", "Aviso");
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel50_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void panelConsultarOrc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void consultarToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalvarSer2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdMakgelDataSet);

            panelEditaSer.Location = new Point(0, 517);
            panelEditaSer.Size = new Size(800, 14);

            MessageBox.Show("Serviço alterado com sucesso!", "Aviso");
        }

        private void btnCancelarSer_Click(object sender, EventArgs e)
        {
            panelEditaSer.Location = new Point(0, 517);
            panelEditaSer.Size = new Size(800, 14);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.Text == "Residência")
            {
                daservico.Enabled = true;
                daretiro.Enabled = false;
                daentrega.Enabled = false;
            }
            else if (comboBox8.Text == "Loja")
            {
                daretiro.Enabled = true;
                daentrega.Enabled = true;
                daservico.Enabled = false;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void chekMaqSer_OnChange(object sender, EventArgs e)
        {
            if (cklMaqSer.GetItemCheckState(0) == CheckState.Checked)
            {
                maqs0.Text = "0";
            }
            else
            {
                maqs0.Text = "";
            }

            if (cklMaqSer.GetItemCheckState(1) == CheckState.Checked)
            {

                maqs1.Text = "1";
            }
            else
            {
                maqs1.Text = "";
            }
            if (cklMaqSer.GetItemCheckState(2) == CheckState.Checked)
            {
                maqs2.Text = "2";
            }
            else
            {
                maqs2.Text = "";
            }
            if (cklMaqSer.GetItemCheckState(3) == CheckState.Checked)
            {
                maqs3.Text = "3";
            }
            else
            {
                maqs3.Text = "";
            }
            if (cklMaqSer.GetItemCheckState(4) == CheckState.Checked)
            {
                maqs4.Text = "4";
            }
            else
            {
                maqo4.Text = "";
            }


            if (chekMaqSer.Checked == true)
            {
                chekGelSer.Checked = false;
                chekMicSer.Checked = false;
                cklMaqSer.BringToFront();
            }

            else if (chekGelSer.Checked == false && chekMaqSer.Checked == false && chekMicSer.Checked == false)
            {
                panelProdutosSer.BringToFront();
            }
        }

        private void chekMicSer_OnChange(object sender, EventArgs e)
        {
            if (cklMicSer.GetItemCheckState(0) == CheckState.Checked)
            {
                mics0.Text = "0";
            }
            else
            {
                mics0.Text = "";
            }

            if (cklMicSer.GetItemCheckState(1) == CheckState.Checked)
            {
                mics1.Text = "1";
            }
            else
            {
                mics1.Text = "";
            }
            if (cklMicSer.GetItemCheckState(2) == CheckState.Checked)
            {
                mics2.Text = "2";
            }
            else
            {
                mics2.Text = "";
            }
            if (cklMicSer.GetItemCheckState(3) == CheckState.Checked)
            {
                mics3.Text = "3";
            }
            else
            {
                mics3.Text = "";
            }
            if (cklMicSer.GetItemCheckState(4) == CheckState.Checked)
            {
                mics4.Text = "4";
            }
            else
            {
                mico4.Text = "";
            }

            if (chekMicSer.Checked == true)
            {
                chekGelSer.Checked = false;
                chekMaqSer.Checked = false;
                cklMicSer.BringToFront();
            }

            else if (chekGelSer.Checked == false && chekMaqSer.Checked == false && chekMicSer.Checked == false)
            {
                panelProdutosSer.BringToFront();
            }
        }

        private void chekGelOrc_OnChange_1(object sender, EventArgs e)
        {

        }

        private void chekMaqOrc_OnChange_1(object sender, EventArgs e)
        {
            if (chekMaqOrc.Checked == true)
            {
                chekGelOrc.Checked = false;
                chekMicOrc.Checked = false;
                cklMaqOrc.BringToFront();
            }

            else if (chekGelFor.Checked == false && chekMaqFor.Checked == false && chekMicFor.Checked == false)
            {
                panelProdutosOrc.BringToFront();
            }
        }

        private void chekGelOrc_OnChange_2(object sender, EventArgs e)
        {
            if (chekGelOrc.Checked == true)
            {
                chekMaqOrc.Checked = false;
                chekMicOrc.Checked = false;
                cklGelOrc.BringToFront();
            }

            else if (chekGelFor.Checked == false && chekMaqFor.Checked == false && chekMicFor.Checked == false)
            {
                panelProdutosOrc.BringToFront();
            }
        }

        private void checkGel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMic.Checked == true)
            {
                checkMaq.Checked = false;
                checkGel.Checked = false;
                cMic.BringToFront();
            }

            else if (checkGel.Checked == false && checkMaq.Checked == false && checkMic.Checked == false)
            {
                panProdForE.BringToFront();
            }
        }

        private void checkMaq_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMaq.Checked == true)
            {
                checkGel.Checked = false;
                checkMic.Checked = false;
                cMaq.BringToFront();
            }

            else if (checkGel.Checked == false && checkMaq.Checked == false && checkMic.Checked == false)
            {
                panProdForE.BringToFront();
            }
        }

        private void checkMic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMic.Checked == true)
            {
                checkMaq.Checked = false;
                checkGel.Checked = false;
                cMic.BringToFront();
            }

            else if (checkGel.Checked == false && checkMaq.Checked == false && checkMic.Checked == false)
            {
                panProdForE.BringToFront();
            }
        }

        private void cklMaqFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cklMaqFor.GetItemCheckState(0) == CheckState.Checked)
            {
                maqf0.Text = "0";
            }
            else
            {
                maqf0.Text = "";
            }
            if (cklMaqFor.GetItemCheckState(1) == CheckState.Checked)
            {
                maqf1.Text = "1";
            }
            else
            {
                maqf1.Text = "";
            }
            if (cklMaqFor.GetItemCheckState(2) == CheckState.Checked)
            {
                maqf2.Text = "2";
            }
            else
            {
                maqf2.Text = "";
            }
            if (cklMaqFor.GetItemCheckState(3) == CheckState.Checked)
            {
                maqf3.Text = "3";
            }
            else
            {
                maqf3.Text = "";
            }
            if (cklMaqFor.GetItemCheckState(4) == CheckState.Checked)
            {
                maqf4.Text = "4";
            }
            else
            {
                maqf4.Text = "";
            }
        }

        private void cklGelFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cklGelFor.GetItemCheckState(0) == CheckState.Checked)
            {
                gelf0.Text = "0";
            }
            else
            {
                gelf0.Text = "";
            }

            if (cklGelFor.GetItemCheckState(1) == CheckState.Checked)
            {
                gelf1.Text = "1";
            }
            else
            {
                gelf1.Text = "";
            }
            if (cklGelFor.GetItemCheckState(2) == CheckState.Checked)
            {
                gelf2.Text = "2";
            }
            else
            {
                gelf2.Text = "";
            }
            if (cklGelFor.GetItemCheckState(3) == CheckState.Checked)
            {
                gelf3.Text = "3";
            }
            else
            {
                gelf3.Text = "";
            }
            if (cklGelFor.GetItemCheckState(4) == CheckState.Checked)
            {
                gelf4.Text = "4";
            }
            else
            {
                gelf4.Text = "";
            }


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (pesquisaFornecedor.Text != "")
            {
                panel73.SendToBack();

                listGelFor.Items.Clear();
                if (lgelf0.Text == "0")
                {
                    listGelFor.Items.Add(cklGelFor.Items[0].ToString());
                }
                if (lgelf1.Text == "1")
                {
                    listGelFor.Items.Add(cklGelFor.Items[1].ToString());
                }
                if (lgelf2.Text == "2")
                {
                    listGelFor.Items.Add(cklGelFor.Items[2].ToString());
                }
                if (lgelf3.Text == "3")
                {
                    listGelFor.Items.Add(cklGelFor.Items[3].ToString());
                }
                if (lgelf4.Text == "4")
                {
                    listGelFor.Items.Add(cklGelFor.Items[4].ToString());
                }
                if (lgelf5.Text == "5")
                {
                    listGelFor.Items.Add(cklGelFor.Items[5].ToString());
                }


                listMaqFor.Items.Clear();
                if (lmaqf0.Text == "0")
                {
                    listMaqFor.Items.Add(cklMaqFor.Items[0].ToString());
                }
                if (lmaqf1.Text == "1")
                {
                    listMaqFor.Items.Add(cklMaqFor.Items[1].ToString());
                }
                if (lmaqf2.Text == "2")
                {
                    listMaqFor.Items.Add(cklMaqFor.Items[2].ToString());
                }
                if (lmaqf3.Text == "3")
                {
                    listMaqFor.Items.Add(cklMaqFor.Items[3].ToString());
                }
                if (lmaqf4.Text == "4")
                {
                    listMaqFor.Items.Add(cklMaqFor.Items[4].ToString());
                }


                listMicFor.Items.Clear();
                if (lmicf0.Text == "0")
                {
                    listMicFor.Items.Add(cklMicFor.Items[0].ToString());
                }
                if (lmiqf1.Text == "1")
                {
                    listMicFor.Items.Add(cklMicFor.Items[1].ToString());
                }
                if (lmicf2.Text == "2")
                {
                    listMicFor.Items.Add(cklMicFor.Items[2].ToString());
                }
                if (lmicf3.Text == "3")
                {
                    listMicFor.Items.Add(cklMicFor.Items[3].ToString());
                }
                if (lmicf4.Text == "4")
                {
                    listMicFor.Items.Add(cklMicFor.Items[4].ToString());
                }
            }
            else if (pesquisaFornecedor.Text == "")
            {
                MessageBox.Show("Escolha um fornecedor para consultar!", "Aviso");
            }
            
        }

        private void cklMicFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cklMicFor.GetItemCheckState(0) == CheckState.Checked)
            {
                micf0.Text = "0";
            }
            else
            {
                micf0.Text = "";
            }
            if (cklMicFor.GetItemCheckState(1) == CheckState.Checked)
            {
                micf1.Text = "1";
            }
            else
            {
                micf1.Text = "";
            }
            if (cklMicFor.GetItemCheckState(2) == CheckState.Checked)
            {
                micf2.Text = "2";
            }
            else
            {
                micf2.Text = "";
            }
            if (cklMicFor.GetItemCheckState(3) == CheckState.Checked)
            {
                micf3.Text = "3";
            }
            else
            {
                micf3.Text = "";
            }
            if (cklMicFor.GetItemCheckState(4) == CheckState.Checked)
            {
                micf4.Text = "4";
            }
            else
            {
                micf4.Text = "";
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (pesquisaCliente.Text != "")
            {
                panel74.SendToBack();
            }
            else if (pesquisaCliente.Text == "")
            {
                MessageBox.Show("Escolha um cliente para consultar!", "Aviso");
            }
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                panel75.SendToBack();
            }
            else if(comboBox2.Text == "")
            {
                MessageBox.Show("Escolha um produto para consultar!", "Aviso");
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text != "")
            {
                panel76.SendToBack();

                listGelOrc.Items.Clear();
                if (lgelo0.Text == "0")
                {
                    listGelOrc.Items.Add(cklGelOrc.Items[0].ToString());
                }
                if (lgelo1.Text == "1")
                {
                    listGelOrc.Items.Add(cklGelOrc.Items[1].ToString());
                }
                if (lgelo2.Text == "2")
                {
                    listGelOrc.Items.Add(cklGelOrc.Items[2].ToString());
                }
                if (lgelo3.Text == "3")
                {
                    listGelOrc.Items.Add(cklGelOrc.Items[3].ToString());
                }
                if (lgelo4.Text == "4")
                {
                    listGelOrc.Items.Add(cklGelOrc.Items[4].ToString());
                }



                listMaqOrc.Items.Clear();
                if (lmaqo0.Text == "0")
                {
                    listMaqOrc.Items.Add(cklMaqOrc.Items[0].ToString());
                }
                if (lmaqo1.Text == "1")
                {
                    listMaqOrc.Items.Add(cklMaqOrc.Items[1].ToString());
                }
                if (lmaqo2.Text == "2")
                {
                    listMaqOrc.Items.Add(cklMaqOrc.Items[2].ToString());
                }
                if (lmaqo3.Text == "3")
                {
                    listMaqOrc.Items.Add(cklMaqOrc.Items[3].ToString());
                }
                if (lmaqo4.Text == "4")
                {
                    listMaqOrc.Items.Add(cklMaqOrc.Items[4].ToString());
                }


                listMicOrc.Items.Clear();
                if (lmico0.Text == "0")
                {
                    listMicOrc.Items.Add(cklMicOrc.Items[0].ToString());
                }
                if (lmico1.Text == "1")
                {
                    listMicOrc.Items.Add(cklMicOrc.Items[1].ToString());
                }
                if (lmico2.Text == "2")
                {
                    listMicOrc.Items.Add(cklMicOrc.Items[2].ToString());
                }
                if (lmico3.Text == "3")
                {
                    listMicOrc.Items.Add(cklMicOrc.Items[3].ToString());
                }
                if (lmico4.Text == "4")
                {
                    listMicOrc.Items.Add(cklMicOrc.Items[4].ToString());
                }
            }
            else if (comboBox7.Text == "")
            {
                MessageBox.Show("Escolha um orçamento para consultar!", "Aviso");
            }

            
        }

        private void cklMicOrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cklMicOrc.GetItemCheckState(0) == CheckState.Checked)
            {
                mico0.Text = "0";
            }
            else
            {
                mico0.Text = "";
            }
            if (cklMicOrc.GetItemCheckState(1) == CheckState.Checked)
            {
                mico1.Text = "1";
            }
            else
            {
                mico1.Text = "";
            }
            if (cklMicOrc.GetItemCheckState(2) == CheckState.Checked)
            {
                mico2.Text = "2";
            }
            else
            {
                mico2.Text = "";
            }
            if (cklMicOrc.GetItemCheckState(3) == CheckState.Checked)
            {
                mico3.Text = "3";
            }
            else
            {
                mico3.Text = "";
            }
            if (cklMicOrc.GetItemCheckState(4) == CheckState.Checked)
            {
                mico4.Text = "4";
            }
            else
            {
                mico4.Text = "";
            }


        }

        private void cklMaqOrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cklMaqOrc.GetItemCheckState(0) == CheckState.Checked)
            {
                maqo0.Text = "0";
            }
            else
            {
                maqo0.Text = "";
            }
            if (cklMaqOrc.GetItemCheckState(1) == CheckState.Checked)
            {
                maqo1.Text = "1";
            }
            else
            {
                maqo1.Text = "";
            }
            if (cklMaqOrc.GetItemCheckState(2) == CheckState.Checked)
            {
                maqo2.Text = "2";
            }
            else
            {
                maqo2.Text = "";
            }
            if (cklMaqOrc.GetItemCheckState(3) == CheckState.Checked)
            {
                maqo3.Text = "3";
            }
            else
            {
                maqo3.Text = "";
            }
            if (cklMaqOrc.GetItemCheckState(4) == CheckState.Checked)
            {
                maqo4.Text = "4";
            }
            else
            {
                maqo4.Text = "";
            }
        }

        private void cklGelOrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cklGelOrc.GetItemCheckState(0) == CheckState.Checked)
            {
                gelo0.Text = "0";
            }
            else
            {
                gelo0.Text = "";
            }

            if (cklGelOrc.GetItemCheckState(1) == CheckState.Checked) { 
            
                gelo1.Text = "1";
            }
            else
            {
                gelo1.Text = "";
            }
            if (cklGelOrc.GetItemCheckState(2) == CheckState.Checked)
            {
                gelo2.Text = "2";
            }
            else
            {
                gelo2.Text = "";
            }
            if (cklGelOrc.GetItemCheckState(3) == CheckState.Checked)
            {
                gelo3.Text = "3";
            }
            else
            {
                gelo3.Text = "";
            }
            if (cklGelOrc.GetItemCheckState(4) == CheckState.Checked)
            {
                gelo4.Text = "4";
            }
            else
            {
                gelo4.Text = "";
            }

        }

        private void checkGelo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGelo.Checked == true)
            {
                checkMaqo.Checked = false;
                checkMico.Checked = false;
                cGelo.BringToFront();
            }

            else if (checkGelo.Checked == false && checkMaqo.Checked == false && checkMico.Checked == false)
            {
                panProdOrcE.BringToFront();
            }
        }

        private void checkMaqo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMaqo.Checked == true)
            {
                checkGelo.Checked = false;
                checkMico.Checked = false;
                cMaqo.BringToFront();
            }

            else if (checkGelo.Checked == false && checkMaqo.Checked == false && checkMico.Checked == false)
            {
                panProdOrcE.BringToFront();
            }
        }

        private void checkMico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMico.Checked == true)
            {
                checkMaqo.Checked = false;
                checkGelo.Checked = false;
                cMico.BringToFront();
            }

            else if (checkGelo.Checked == false && checkMaqo.Checked == false && checkMico.Checked == false)
            {
                panProdOrcE.BringToFront();
            }
        }

        private void panelCadastrarOrc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text != "")
            {
                panel78.SendToBack();
                
                listGelSer.Items.Clear();
                if (lgels0.Text == "0")
                {
                    listGelSer.Items.Add(cklGelSer.Items[0].ToString());
                }
                if (lgels1.Text == "1")
                {
                    listGelSer.Items.Add(cklGelSer.Items[1].ToString());
                }
                if (lgels2.Text == "2")
                {
                    listGelSer.Items.Add(cklGelSer.Items[2].ToString());
                }
                if (lgels3.Text == "3")
                {
                    listGelSer.Items.Add(cklGelSer.Items[3].ToString());
                }
                if (lgels4.Text == "4")
                {
                    listGelSer.Items.Add(cklGelSer.Items[4].ToString());
                }


                listMaqSer.Items.Clear();
                if (lmaqs0.Text == "0")
                {
                    listMaqSer.Items.Add(cklMaqSer.Items[0].ToString());
                }
                if (lmaqs1.Text == "1")
                {
                    listMaqSer.Items.Add(cklMaqSer.Items[1].ToString());
                }
                if (lmaqs2.Text == "2")
                {
                    listMaqSer.Items.Add(cklMaqSer.Items[2].ToString());
                }
                if (lmaqs3.Text == "3")
                {
                    listMaqSer.Items.Add(cklMaqSer.Items[3].ToString());
                }
                if (lmaqs4.Text == "4")
                {
                    listMaqSer.Items.Add(cklMaqSer.Items[4].ToString());
                }


                listMicSer.Items.Clear();
                if (lmics0.Text == "0")
                {
                    listMicSer.Items.Add(cklMicSer.Items[0].ToString());
                }
                if (lmics1.Text == "1")
                {
                    listMicSer.Items.Add(cklMicSer.Items[1].ToString());
                }
                if (lmics2.Text == "2")
                {
                    listMicSer.Items.Add(cklMicSer.Items[2].ToString());
                }
                if (lmics3.Text == "3")
                {
                    listMicSer.Items.Add(cklMicSer.Items[3].ToString());
                }
                if (lmics4.Text == "4")
                {
                    listMicSer.Items.Add(cklMicSer.Items[4].ToString());
                }
                
            }
            else if (comboBox5.Text == "")
            {
                MessageBox.Show("Escolha um serviço para consultar!", "Aviso");
            }
        }

        private void cklGelSer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cklGelSer.GetItemCheckState(0) == CheckState.Checked)
            {
                gels0.Text = "0";
            }
            else
            {
                gels0.Text = "";
            }

            if (cklGelSer.GetItemCheckState(1) == CheckState.Checked)
            {

                gels1.Text = "1";
            }
            else
            {
                gels1.Text = "";
            }
            if (cklGelSer.GetItemCheckState(2) == CheckState.Checked)
            {
                gels2.Text = "2";
            }
            else
            {
                gels2.Text = "";
            }
            if (cklGelSer.GetItemCheckState(3) == CheckState.Checked)
            {
                gels3.Text = "3";
            }
            else
            {
                gels3.Text = "";
            }
            if (cklGelSer.GetItemCheckState(4) == CheckState.Checked)
            {
                gels4.Text = "4";
            }
            else
            {
                gelo4.Text = "";
            }
        }

        private void cklMaqSer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cklMaqSer.GetItemCheckState(0) == CheckState.Checked)
            {
                maqs0.Text = "0";
            }
            else
            {
                maqs0.Text = "";
            }

            if (cklMaqSer.GetItemCheckState(1) == CheckState.Checked)
            {

                maqs1.Text = "1";
            }
            else
            {
                maqs1.Text = "";
            }
            if (cklMaqSer.GetItemCheckState(2) == CheckState.Checked)
            {
                maqs2.Text = "2";
            }
            else
            {
                maqs2.Text = "";
            }
            if (cklMaqSer.GetItemCheckState(3) == CheckState.Checked)
            {
                maqs3.Text = "3";
            }
            else
            {
                maqs3.Text = "";
            }
            if (cklMaqSer.GetItemCheckState(4) == CheckState.Checked)
            {
                maqs4.Text = "4";
            }
            else
            {
                maqo4.Text = "";
            }
        }

        private void cklMicSer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cklMicSer.GetItemCheckState(0) == CheckState.Checked)
            {
                mics0.Text = "0";
            }
            else
            {
                mics0.Text = "";
            }

            if (cklMicSer.GetItemCheckState(1) == CheckState.Checked)
            {
                mics1.Text = "1";
            }
            else
            {
                mics1.Text = "";
            }
            if (cklMicSer.GetItemCheckState(2) == CheckState.Checked)
            {
                mics2.Text = "2";
            }
            else
            {
                mics2.Text = "";
            }
            if (cklMicSer.GetItemCheckState(3) == CheckState.Checked)
            {
                mics3.Text = "3";
            }
            else
            {
                mics3.Text = "";
            }
            if (cklMicSer.GetItemCheckState(4) == CheckState.Checked)
            {
                mics4.Text = "4";
            }
            else
            {
                mico4.Text = "";
            }
        }

        private void checkmics_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmics.Checked == true)
            {
                checkmaqs.Checked = false;
                checkgels.Checked = false;
                cmics.BringToFront();
            }

            else if (checkgels.Checked == false && checkmaqs.Checked == false && checkmics.Checked == false)
            {
                panProdSerE.BringToFront();
            }
        }

        private void checkmaqs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmaqs.Checked == true)
            {
                checkgels.Checked = false;
                checkmics.Checked = false;
                cmaqs.BringToFront();
            }

            else if (checkgels.Checked == false && checkmaqs.Checked == false && checkmics.Checked == false)
            {
                panProdSerE.BringToFront();
            }
        }

        private void checkgels_CheckedChanged(object sender, EventArgs e)
        {
            if (checkgels.Checked == true)
            {
                checkmaqs.Checked = false;
                checkmics.Checked = false;
                cgels.BringToFront();
            }

            else if (checkgels.Checked == false && checkmaqs.Checked == false && checkmics.Checked == false)
            {
                panProdSerE.BringToFront();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            double  calc = Convert.ToDouble(txtValorUnitario.Text)* Convert.ToDouble(numQuantidade.Text);
            txtValorTotal.Text = Convert.ToString(calc);
        }
    }
}
