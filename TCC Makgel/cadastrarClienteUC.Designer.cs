namespace TCC_Makgel
{
    partial class cadastrarClienteUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrarClienteUC));
            this.btnSalvar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdMakgelDataSet = new TCC_Makgel.bdMakgelDataSet();
            this.clienteTableAdapter = new TCC_Makgel.bdMakgelDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new TCC_Makgel.bdMakgelDataSetTableAdapters.TableAdapterManager();
            this.lblNº = new System.Windows.Forms.Label();
            this.numNumero = new System.Windows.Forms.NumericUpDown();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panelCadastrar = new System.Windows.Forms.Panel();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pesquisaCliente = new System.Windows.Forms.ComboBox();
            this.panelConsultar = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelEdita = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalvar2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gpCliente = new System.Windows.Forms.GroupBox();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bdComplemento = new System.Windows.Forms.Label();
            this.bdNumero = new System.Windows.Forms.Label();
            this.bdBairro = new System.Windows.Forms.Label();
            this.bdEndereco = new System.Windows.Forms.Label();
            this.bdTelefone = new System.Windows.Forms.Label();
            this.bdCpf = new System.Windows.Forms.Label();
            this.bdNome = new System.Windows.Forms.Label();
            this.complemento = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelCobre = new System.Windows.Forms.Panel();
            this.lblCad = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bdMakgelDataSet1 = new TCC_Makgel.bdMakgelDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMakgelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero)).BeginInit();
            this.panelCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelEdita.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdMakgelDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.BorderRadius = 7;
            this.btnSalvar.ButtonText = "Salvar";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalvar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalvar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Iconimage")));
            this.btnSalvar.Iconimage_right = null;
            this.btnSalvar.Iconimage_right_Selected = null;
            this.btnSalvar.Iconimage_Selected = null;
            this.btnSalvar.IconMarginLeft = 0;
            this.btnSalvar.IconMarginRight = 0;
            this.btnSalvar.IconRightVisible = true;
            this.btnSalvar.IconRightZoom = 0D;
            this.btnSalvar.IconVisible = true;
            this.btnSalvar.IconZoom = 90D;
            this.btnSalvar.IsTab = false;
            this.btnSalvar.Location = new System.Drawing.Point(540, 418);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSalvar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalvar.selected = false;
            this.btnSalvar.Size = new System.Drawing.Size(127, 42);
            this.btnSalvar.TabIndex = 124;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Textcolor = System.Drawing.Color.White;
            this.btnSalvar.TextFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.bdMakgelDataSet;
            // 
            // bdMakgelDataSet
            // 
            this.bdMakgelDataSet.DataSetName = "bdMakgelDataSet";
            this.bdMakgelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.produto_fornecedorTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TCC_Makgel.bdMakgelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblNº
            // 
            this.lblNº.AutoSize = true;
            this.lblNº.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNº.ForeColor = System.Drawing.Color.White;
            this.lblNº.Location = new System.Drawing.Point(149, 283);
            this.lblNº.Name = "lblNº";
            this.lblNº.Size = new System.Drawing.Size(39, 27);
            this.lblNº.TabIndex = 109;
            this.lblNº.Text = "N°";
            // 
            // numNumero
            // 
            this.numNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numNumero.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "numero", true));
            this.numNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumero.Location = new System.Drawing.Point(149, 310);
            this.numNumero.Name = "numNumero";
            this.numNumero.Size = new System.Drawing.Size(110, 25);
            this.numNumero.TabIndex = 168;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "telefone", true));
            this.txtTelefone.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefone.Location = new System.Drawing.Point(333, 151);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(142, 29);
            this.txtTelefone.TabIndex = 169;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(281, 283);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(75, 27);
            this.lblBairro.TabIndex = 111;
            this.lblBairro.Text = "Bairro";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereço.ForeColor = System.Drawing.Color.White;
            this.lblEndereço.Location = new System.Drawing.Point(144, 211);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(115, 27);
            this.lblEndereço.TabIndex = 108;
            this.lblEndereço.Text = "Endereço";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cpf", true));
            this.txtCpf.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCpf.Location = new System.Drawing.Point(149, 151);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(146, 29);
            this.txtCpf.TabIndex = 170;
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.ForeColor = System.Drawing.Color.White;
            this.lblComp.Location = new System.Drawing.Point(147, 346);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(162, 27);
            this.lblComp.TabIndex = 112;
            this.lblComp.Text = "Complemento";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.White;
            this.lblCpf.Location = new System.Drawing.Point(148, 124);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(60, 27);
            this.lblCpf.TabIndex = 106;
            this.lblCpf.Text = "CPF";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "complemento", true));
            this.txtComplemento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(149, 372);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(521, 26);
            this.txtComplemento.TabIndex = 123;
            // 
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cd_cliente", true));
            this.cd_clienteTextBox.Location = new System.Drawing.Point(625, 53);
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.Size = new System.Drawing.Size(45, 20);
            this.cd_clienteTextBox.TabIndex = 172;
            // 
            // txtEndereço
            // 
            this.txtEndereço.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereço.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "endereco", true));
            this.txtEndereço.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereço.Location = new System.Drawing.Point(149, 241);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(521, 26);
            this.txtEndereço.TabIndex = 118;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(328, 121);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(102, 27);
            this.lblTelefone.TabIndex = 105;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "bairro", true));
            this.txtBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(286, 309);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(384, 26);
            this.txtBairro.TabIndex = 120;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(625, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 20);
            this.panel1.TabIndex = 173;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nome", true));
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(149, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(521, 26);
            this.txtNome.TabIndex = 104;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(144, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 27);
            this.lblNome.TabIndex = 103;
            this.lblNome.Text = "Nome";
            // 
            // panelCadastrar
            // 
            this.panelCadastrar.Controls.Add(this.lblNome);
            this.panelCadastrar.Controls.Add(this.lblNº);
            this.panelCadastrar.Controls.Add(this.numNumero);
            this.panelCadastrar.Controls.Add(this.txtTelefone);
            this.panelCadastrar.Controls.Add(this.txtNome);
            this.panelCadastrar.Controls.Add(this.lblBairro);
            this.panelCadastrar.Controls.Add(this.panel1);
            this.panelCadastrar.Controls.Add(this.lblEndereço);
            this.panelCadastrar.Controls.Add(this.txtBairro);
            this.panelCadastrar.Controls.Add(this.btnSalvar);
            this.panelCadastrar.Controls.Add(this.lblTelefone);
            this.panelCadastrar.Controls.Add(this.txtCpf);
            this.panelCadastrar.Controls.Add(this.txtEndereço);
            this.panelCadastrar.Controls.Add(this.lblComp);
            this.panelCadastrar.Controls.Add(this.cd_clienteTextBox);
            this.panelCadastrar.Controls.Add(this.lblCpf);
            this.panelCadastrar.Controls.Add(this.txtComplemento);
            this.panelCadastrar.Location = new System.Drawing.Point(7, 46);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(55, 503);
            this.panelCadastrar.TabIndex = 174;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Activecolor = System.Drawing.Color.Gray;
            this.btnConsultar.BackColor = System.Drawing.Color.Gray;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.BorderRadius = 2;
            this.btnConsultar.ButtonText = "Consultar";
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultar.Iconimage = null;
            this.btnConsultar.Iconimage_right = null;
            this.btnConsultar.Iconimage_right_Selected = null;
            this.btnConsultar.Iconimage_Selected = null;
            this.btnConsultar.IconMarginLeft = 0;
            this.btnConsultar.IconMarginRight = 0;
            this.btnConsultar.IconRightVisible = true;
            this.btnConsultar.IconRightZoom = 0D;
            this.btnConsultar.IconVisible = true;
            this.btnConsultar.IconZoom = 90D;
            this.btnConsultar.IsTab = false;
            this.btnConsultar.Location = new System.Drawing.Point(414, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Normalcolor = System.Drawing.Color.Gray;
            this.btnConsultar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsultar.selected = false;
            this.btnConsultar.Size = new System.Drawing.Size(396, 30);
            this.btnConsultar.TabIndex = 176;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultar.Textcolor = System.Drawing.Color.White;
            this.btnConsultar.TextFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 180;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 185;
            this.label2.Text = "N°";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "numero", true));
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(14, 213);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 26);
            this.numericUpDown1.TabIndex = 191;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.White;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "telefone", true));
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(194, 93);
            this.maskedTextBox1.Mask = "(99) 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(142, 29);
            this.maskedTextBox1.TabIndex = 192;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nome", true));
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(519, 26);
            this.textBox1.TabIndex = 181;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 186;
            this.label3.Text = "Bairro";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(718, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 20);
            this.panel2.TabIndex = 195;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 27);
            this.label4.TabIndex = 184;
            this.label4.Text = "Endereço";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "bairro", true));
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(147, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 26);
            this.textBox2.TabIndex = 189;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(189, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 182;
            this.label5.Text = "Telefone";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.White;
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cpf", true));
            this.maskedTextBox2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maskedTextBox2.Location = new System.Drawing.Point(13, 93);
            this.maskedTextBox2.Mask = "000.000.000-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(143, 29);
            this.maskedTextBox2.TabIndex = 193;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "endereco", true));
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(14, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(519, 26);
            this.textBox3.TabIndex = 188;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 27);
            this.label6.TabIndex = 187;
            this.label6.Text = "Complemento";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cd_cliente", true));
            this.textBox4.Location = new System.Drawing.Point(718, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(45, 20);
            this.textBox4.TabIndex = 194;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 27);
            this.label7.TabIndex = 183;
            this.label7.Text = "CPF";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "complemento", true));
            this.textBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(14, 279);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(519, 26);
            this.textBox5.TabIndex = 190;
            // 
            // pesquisaCliente
            // 
            this.pesquisaCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pesquisaCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pesquisaCliente.DataSource = this.clienteBindingSource;
            this.pesquisaCliente.DisplayMember = "nome";
            this.pesquisaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaCliente.FormattingEnabled = true;
            this.pesquisaCliente.Location = new System.Drawing.Point(168, 33);
            this.pesquisaCliente.Name = "pesquisaCliente";
            this.pesquisaCliente.Size = new System.Drawing.Size(429, 33);
            this.pesquisaCliente.TabIndex = 195;
            this.pesquisaCliente.ValueMember = "cd_cliente";
            // 
            // panelConsultar
            // 
            this.panelConsultar.Controls.Add(this.bunifuImageButton1);
            this.panelConsultar.Controls.Add(this.panelEdita);
            this.panelConsultar.Controls.Add(this.gpCliente);
            this.panelConsultar.Controls.Add(this.pesquisaCliente);
            this.panelConsultar.Location = new System.Drawing.Point(773, 46);
            this.panelConsultar.Name = "panelConsultar";
            this.panelConsultar.Size = new System.Drawing.Size(37, 520);
            this.panelConsultar.TabIndex = 196;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(34)))), ((int)(((byte)(66)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(603, 33);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 200;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 0;
            // 
            // panelEdita
            // 
            this.panelEdita.Controls.Add(this.panel2);
            this.panelEdita.Controls.Add(this.textBox4);
            this.panelEdita.Controls.Add(this.panel3);
            this.panelEdita.Location = new System.Drawing.Point(0, 485);
            this.panelEdita.Name = "panelEdita";
            this.panelEdita.Size = new System.Drawing.Size(803, 35);
            this.panelEdita.TabIndex = 197;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.cancelar);
            this.panel3.Controls.Add(this.btnSalvar2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.maskedTextBox2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.maskedTextBox1);
            this.panel3.Location = new System.Drawing.Point(125, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 380);
            this.panel3.TabIndex = 199;
            // 
            // cancelar
            // 
            this.cancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelar.BorderRadius = 7;
            this.cancelar.ButtonText = "Cancelar";
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.DisabledColor = System.Drawing.Color.Gray;
            this.cancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.cancelar.Iconimage = null;
            this.cancelar.Iconimage_right = null;
            this.cancelar.Iconimage_right_Selected = null;
            this.cancelar.Iconimage_Selected = null;
            this.cancelar.IconMarginLeft = 0;
            this.cancelar.IconMarginRight = 0;
            this.cancelar.IconRightVisible = true;
            this.cancelar.IconRightZoom = 0D;
            this.cancelar.IconVisible = true;
            this.cancelar.IconZoom = 90D;
            this.cancelar.IsTab = false;
            this.cancelar.Location = new System.Drawing.Point(273, 322);
            this.cancelar.Name = "cancelar";
            this.cancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelar.selected = false;
            this.cancelar.Size = new System.Drawing.Size(127, 42);
            this.cancelar.TabIndex = 197;
            this.cancelar.Text = "Cancelar";
            this.cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelar.Textcolor = System.Drawing.Color.White;
            this.cancelar.TextFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // btnSalvar2
            // 
            this.btnSalvar2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar2.BorderRadius = 7;
            this.btnSalvar2.ButtonText = "Salvar";
            this.btnSalvar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar2.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalvar2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalvar2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalvar2.Iconimage")));
            this.btnSalvar2.Iconimage_right = null;
            this.btnSalvar2.Iconimage_right_Selected = null;
            this.btnSalvar2.Iconimage_Selected = null;
            this.btnSalvar2.IconMarginLeft = 0;
            this.btnSalvar2.IconMarginRight = 0;
            this.btnSalvar2.IconRightVisible = true;
            this.btnSalvar2.IconRightZoom = 0D;
            this.btnSalvar2.IconVisible = true;
            this.btnSalvar2.IconZoom = 90D;
            this.btnSalvar2.IsTab = false;
            this.btnSalvar2.Location = new System.Drawing.Point(406, 322);
            this.btnSalvar2.Name = "btnSalvar2";
            this.btnSalvar2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSalvar2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalvar2.selected = false;
            this.btnSalvar2.Size = new System.Drawing.Size(127, 42);
            this.btnSalvar2.TabIndex = 198;
            this.btnSalvar2.Text = "Salvar";
            this.btnSalvar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar2.Textcolor = System.Drawing.Color.White;
            this.btnSalvar2.TextFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar2.Click += new System.EventHandler(this.btnSalvar2_Click);
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.btnEditar);
            this.gpCliente.Controls.Add(this.bdComplemento);
            this.gpCliente.Controls.Add(this.bdNumero);
            this.gpCliente.Controls.Add(this.bdBairro);
            this.gpCliente.Controls.Add(this.bdEndereco);
            this.gpCliente.Controls.Add(this.bdTelefone);
            this.gpCliente.Controls.Add(this.bdCpf);
            this.gpCliente.Controls.Add(this.bdNome);
            this.gpCliente.Controls.Add(this.complemento);
            this.gpCliente.Controls.Add(this.cpf);
            this.gpCliente.Controls.Add(this.telefone);
            this.gpCliente.Controls.Add(this.endereco);
            this.gpCliente.Controls.Add(this.bairro);
            this.gpCliente.Controls.Add(this.numero);
            this.gpCliente.Controls.Add(this.nome);
            this.gpCliente.ForeColor = System.Drawing.Color.White;
            this.gpCliente.Location = new System.Drawing.Point(60, 82);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.Size = new System.Drawing.Size(684, 305);
            this.gpCliente.TabIndex = 199;
            this.gpCliente.TabStop = false;
            this.gpCliente.Enter += new System.EventHandler(this.gpCliente_Enter);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 2;
            this.btnEditar.ButtonText = "Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = null;
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 90D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(24, 256);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(80, 33);
            this.btnEditar.TabIndex = 198;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // bdComplemento
            // 
            this.bdComplemento.AutoSize = true;
            this.bdComplemento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "complemento", true));
            this.bdComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdComplemento.ForeColor = System.Drawing.Color.White;
            this.bdComplemento.Location = new System.Drawing.Point(155, 220);
            this.bdComplemento.Name = "bdComplemento";
            this.bdComplemento.Size = new System.Drawing.Size(0, 24);
            this.bdComplemento.TabIndex = 13;
            // 
            // bdNumero
            // 
            this.bdNumero.AutoSize = true;
            this.bdNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "numero", true));
            this.bdNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdNumero.ForeColor = System.Drawing.Color.White;
            this.bdNumero.Location = new System.Drawing.Point(104, 155);
            this.bdNumero.Name = "bdNumero";
            this.bdNumero.Size = new System.Drawing.Size(0, 24);
            this.bdNumero.TabIndex = 12;
            // 
            // bdBairro
            // 
            this.bdBairro.AutoSize = true;
            this.bdBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "bairro", true));
            this.bdBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdBairro.ForeColor = System.Drawing.Color.White;
            this.bdBairro.Location = new System.Drawing.Point(85, 188);
            this.bdBairro.Name = "bdBairro";
            this.bdBairro.Size = new System.Drawing.Size(0, 24);
            this.bdBairro.TabIndex = 11;
            // 
            // bdEndereco
            // 
            this.bdEndereco.AutoSize = true;
            this.bdEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "endereco", true));
            this.bdEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdEndereco.ForeColor = System.Drawing.Color.White;
            this.bdEndereco.Location = new System.Drawing.Point(118, 119);
            this.bdEndereco.Name = "bdEndereco";
            this.bdEndereco.Size = new System.Drawing.Size(0, 24);
            this.bdEndereco.TabIndex = 10;
            // 
            // bdTelefone
            // 
            this.bdTelefone.AutoSize = true;
            this.bdTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "telefone", true));
            this.bdTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdTelefone.ForeColor = System.Drawing.Color.White;
            this.bdTelefone.Location = new System.Drawing.Point(107, 85);
            this.bdTelefone.Name = "bdTelefone";
            this.bdTelefone.Size = new System.Drawing.Size(0, 24);
            this.bdTelefone.TabIndex = 9;
            // 
            // bdCpf
            // 
            this.bdCpf.AutoSize = true;
            this.bdCpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cpf", true));
            this.bdCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdCpf.ForeColor = System.Drawing.Color.White;
            this.bdCpf.Location = new System.Drawing.Point(70, 52);
            this.bdCpf.Name = "bdCpf";
            this.bdCpf.Size = new System.Drawing.Size(0, 24);
            this.bdCpf.TabIndex = 8;
            // 
            // bdNome
            // 
            this.bdNome.AutoSize = true;
            this.bdNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nome", true));
            this.bdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdNome.ForeColor = System.Drawing.Color.White;
            this.bdNome.Location = new System.Drawing.Point(86, 18);
            this.bdNome.Name = "bdNome";
            this.bdNome.Size = new System.Drawing.Size(0, 24);
            this.bdNome.TabIndex = 7;
            // 
            // complemento
            // 
            this.complemento.AutoSize = true;
            this.complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complemento.ForeColor = System.Drawing.Color.Silver;
            this.complemento.Location = new System.Drawing.Point(20, 220);
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(134, 24);
            this.complemento.TabIndex = 6;
            this.complemento.Text = "Complemento:";
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.ForeColor = System.Drawing.Color.Silver;
            this.cpf.Location = new System.Drawing.Point(20, 52);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(52, 24);
            this.cpf.TabIndex = 5;
            this.cpf.Text = "CPF:";
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.ForeColor = System.Drawing.Color.Silver;
            this.telefone.Location = new System.Drawing.Point(20, 85);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(90, 24);
            this.telefone.TabIndex = 4;
            this.telefone.Text = "Telefone:";
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.ForeColor = System.Drawing.Color.Silver;
            this.endereco.Location = new System.Drawing.Point(20, 119);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(99, 24);
            this.endereco.TabIndex = 3;
            this.endereco.Text = "Endereço:";
            // 
            // bairro
            // 
            this.bairro.AutoSize = true;
            this.bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro.ForeColor = System.Drawing.Color.Silver;
            this.bairro.Location = new System.Drawing.Point(23, 188);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(64, 24);
            this.bairro.TabIndex = 2;
            this.bairro.Text = "Bairro:";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.ForeColor = System.Drawing.Color.Silver;
            this.numero.Location = new System.Drawing.Point(20, 155);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(84, 24);
            this.numero.TabIndex = 1;
            this.numero.Text = "Numero:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.Color.Silver;
            this.nome.Location = new System.Drawing.Point(20, 18);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(67, 24);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Activecolor = System.Drawing.Color.Gray;
            this.btnCadastrar.BackColor = System.Drawing.Color.Gray;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.BorderRadius = 2;
            this.btnCadastrar.ButtonText = "Cadastrar";
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Iconimage = null;
            this.btnCadastrar.Iconimage_right = null;
            this.btnCadastrar.Iconimage_right_Selected = null;
            this.btnCadastrar.Iconimage_Selected = null;
            this.btnCadastrar.IconMarginLeft = 0;
            this.btnCadastrar.IconMarginRight = 0;
            this.btnCadastrar.IconRightVisible = true;
            this.btnCadastrar.IconRightZoom = 0D;
            this.btnCadastrar.IconVisible = true;
            this.btnCadastrar.IconZoom = 90D;
            this.btnCadastrar.IsTab = false;
            this.btnCadastrar.Location = new System.Drawing.Point(7, 7);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Normalcolor = System.Drawing.Color.Gray;
            this.btnCadastrar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.selected = false;
            this.btnCadastrar.Size = new System.Drawing.Size(401, 30);
            this.btnCadastrar.TabIndex = 196;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Textcolor = System.Drawing.Color.White;
            this.btnCadastrar.TextFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panelCobre
            // 
            this.panelCobre.Location = new System.Drawing.Point(815, 19);
            this.panelCobre.Name = "panelCobre";
            this.panelCobre.Size = new System.Drawing.Size(10, 18);
            this.panelCobre.TabIndex = 200;
            // 
            // lblCad
            // 
            this.lblCad.AutoSize = true;
            this.lblCad.BackColor = System.Drawing.Color.Transparent;
            this.lblCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCad.ForeColor = System.Drawing.Color.Silver;
            this.lblCad.Location = new System.Drawing.Point(5, 23);
            this.lblCad.Name = "lblCad";
            this.lblCad.Size = new System.Drawing.Size(405, 20);
            this.lblCad.TabIndex = 200;
            this.lblCad.Text = "____________________________________________";
            this.lblCad.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.Transparent;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.ForeColor = System.Drawing.Color.Silver;
            this.lblCon.Location = new System.Drawing.Point(413, 23);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(396, 20);
            this.lblCon.TabIndex = 201;
            this.lblCon.Text = "___________________________________________";
            // 
            // bdMakgelDataSet1
            // 
            this.bdMakgelDataSet1.DataSetName = "bdMakgelDataSet";
            this.bdMakgelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastrarClienteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(34)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.panelCobre);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panelConsultar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.panelCadastrar);
            this.Controls.Add(this.lblCad);
            this.Controls.Add(this.lblCon);
            this.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.Name = "cadastrarClienteUC";
            this.Size = new System.Drawing.Size(828, 569);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMakgelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero)).EndInit();
            this.panelCadastrar.ResumeLayout(false);
            this.panelCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelEdita.ResumeLayout(false);
            this.panelEdita.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdMakgelDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnSalvar;
        private bdMakgelDataSet bdMakgelDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private bdMakgelDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private bdMakgelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblNº;
        private System.Windows.Forms.NumericUpDown numNumero;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox cd_clienteTextBox;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panelCadastrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox pesquisaCliente;
        private System.Windows.Forms.Panel panelConsultar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrar;
        private System.Windows.Forms.Panel panelEdita;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private System.Windows.Forms.GroupBox gpCliente;
        private System.Windows.Forms.Label bdComplemento;
        private System.Windows.Forms.Label bdNumero;
        private System.Windows.Forms.Label bdBairro;
        private System.Windows.Forms.Label bdEndereco;
        private System.Windows.Forms.Label bdTelefone;
        private System.Windows.Forms.Label bdCpf;
        private System.Windows.Forms.Label bdNome;
        private System.Windows.Forms.Label complemento;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.Label bairro;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label nome;
        private Bunifu.Framework.UI.BunifuFlatButton cancelar;
        private System.Windows.Forms.Panel panelCobre;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalvar2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCad;
        private System.Windows.Forms.Label lblCon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private bdMakgelDataSet bdMakgelDataSet1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
