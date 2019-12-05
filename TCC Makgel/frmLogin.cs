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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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

        //Botão Login
        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEnter;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "adm" && txtSenha.Text == "123")
            {
                frmPrincipal fp = new frmPrincipal();
                Hide();
                fp.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido !");
                txtUsuario.Focus();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "adm" && txtSenha.Text == "123")
            {
                frmPrincipal fp = new frmPrincipal();
                Hide();
                fp.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido !");
                txtUsuario.Focus();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            escondeTelaUC1.BringToFront();
            panelLogin.SendToBack();
            panelCadastro.BringToFront();
            lblCadastroUsuario.BringToFront();
        }

        private void lblFazerLogin_Click(object sender, EventArgs e)
        {
            escondeTelaUC1.SendToBack();
            panelLogin.BringToFront();
            lblLogin.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
