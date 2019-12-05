namespace TCC_Makgel
{
    partial class registrarOrcamentoUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrarOrcamentoUC));
            this.lblServicos = new System.Windows.Forms.Label();
            this.lblMicroondas = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ckbMaquina = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblMaquina = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ckbMicroondas = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblGeladeira = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ckbGeladeira = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.cklGeladeira = new System.Windows.Forms.CheckedListBox();
            this.cklMicroondas = new System.Windows.Forms.CheckedListBox();
            this.cklMaquina = new System.Windows.Forms.CheckedListBox();
            this.txtDefeito = new System.Windows.Forms.TextBox();
            this.lblDefeito = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdMakgelDataSet = new TCC_Makgel.bdMakgelDataSet();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblValorOrcamento = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFormadePagamento = new System.Windows.Forms.Label();
            this.cmbFormaPag = new System.Windows.Forms.ComboBox();
            this.dtGarantia = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panelCadastrar = new System.Windows.Forms.Panel();
            this.txtValorOrcamento = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblCad = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new TCC_Makgel.bdMakgelDataSetTableAdapters.clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMakgelDataSet)).BeginInit();
            this.panelCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicos.Location = new System.Drawing.Point(414, 5);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(84, 22);
            this.lblServicos.TabIndex = 10;
            this.lblServicos.Text = "Serviços";
            // 
            // lblMicroondas
            // 
            this.lblMicroondas.AutoSize = true;
            this.lblMicroondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicroondas.ForeColor = System.Drawing.Color.White;
            this.lblMicroondas.Location = new System.Drawing.Point(633, 28);
            this.lblMicroondas.Name = "lblMicroondas";
            this.lblMicroondas.Size = new System.Drawing.Size(81, 17);
            this.lblMicroondas.TabIndex = 161;
            this.lblMicroondas.Text = "Microondas";
            // 
            // ckbMaquina
            // 
            this.ckbMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckbMaquina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ckbMaquina.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckbMaquina.Checked = false;
            this.ckbMaquina.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.ckbMaquina.ForeColor = System.Drawing.Color.White;
            this.ckbMaquina.Location = new System.Drawing.Point(511, 29);
            this.ckbMaquina.Name = "ckbMaquina";
            this.ckbMaquina.Size = new System.Drawing.Size(20, 20);
            this.ckbMaquina.TabIndex = 160;
            this.ckbMaquina.OnChange += new System.EventHandler(this.ckbMaquina_OnChange);
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaquina.ForeColor = System.Drawing.Color.White;
            this.lblMaquina.Location = new System.Drawing.Point(531, 29);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(76, 17);
            this.lblMaquina.TabIndex = 159;
            this.lblMaquina.Text = "Lavadoura";
            // 
            // ckbMicroondas
            // 
            this.ckbMicroondas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckbMicroondas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ckbMicroondas.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckbMicroondas.Checked = false;
            this.ckbMicroondas.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.ckbMicroondas.ForeColor = System.Drawing.Color.White;
            this.ckbMicroondas.Location = new System.Drawing.Point(612, 28);
            this.ckbMicroondas.Name = "ckbMicroondas";
            this.ckbMicroondas.Size = new System.Drawing.Size(20, 20);
            this.ckbMicroondas.TabIndex = 162;
            this.ckbMicroondas.OnChange += new System.EventHandler(this.ckbMicroondas_OnChange);
            // 
            // lblGeladeira
            // 
            this.lblGeladeira.AutoSize = true;
            this.lblGeladeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeladeira.ForeColor = System.Drawing.Color.White;
            this.lblGeladeira.Location = new System.Drawing.Point(435, 30);
            this.lblGeladeira.Name = "lblGeladeira";
            this.lblGeladeira.Size = new System.Drawing.Size(70, 17);
            this.lblGeladeira.TabIndex = 158;
            this.lblGeladeira.Text = "Geladeira";
            // 
            // ckbGeladeira
            // 
            this.ckbGeladeira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckbGeladeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ckbGeladeira.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckbGeladeira.Checked = false;
            this.ckbGeladeira.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.ckbGeladeira.ForeColor = System.Drawing.Color.White;
            this.ckbGeladeira.Location = new System.Drawing.Point(414, 30);
            this.ckbGeladeira.Name = "ckbGeladeira";
            this.ckbGeladeira.Size = new System.Drawing.Size(20, 20);
            this.ckbGeladeira.TabIndex = 166;
            this.ckbGeladeira.OnChange += new System.EventHandler(this.ckbGeladeira_OnChange);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(16, 5);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(69, 22);
            this.lblCliente.TabIndex = 209;
            this.lblCliente.Text = "Cliente";
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.Color.White;
            this.panelProdutos.Location = new System.Drawing.Point(414, 59);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(349, 319);
            this.panelProdutos.TabIndex = 165;
            // 
            // cklGeladeira
            // 
            this.cklGeladeira.BackColor = System.Drawing.Color.White;
            this.cklGeladeira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cklGeladeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklGeladeira.FormattingEnabled = true;
            this.cklGeladeira.Items.AddRange(new object[] {
            "Serviços de geladeira"});
            this.cklGeladeira.Location = new System.Drawing.Point(412, 59);
            this.cklGeladeira.Name = "cklGeladeira";
            this.cklGeladeira.Size = new System.Drawing.Size(351, 317);
            this.cklGeladeira.TabIndex = 157;
            this.cklGeladeira.SelectedIndexChanged += new System.EventHandler(this.cklGeladeira_SelectedIndexChanged);
            // 
            // cklMicroondas
            // 
            this.cklMicroondas.BackColor = System.Drawing.Color.White;
            this.cklMicroondas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cklMicroondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklMicroondas.FormattingEnabled = true;
            this.cklMicroondas.Items.AddRange(new object[] {
            "Serviços de Microondas"});
            this.cklMicroondas.Location = new System.Drawing.Point(412, 59);
            this.cklMicroondas.Name = "cklMicroondas";
            this.cklMicroondas.Size = new System.Drawing.Size(351, 317);
            this.cklMicroondas.TabIndex = 164;
            this.cklMicroondas.SelectedIndexChanged += new System.EventHandler(this.cklMicroondas_SelectedIndexChanged);
            // 
            // cklMaquina
            // 
            this.cklMaquina.BackColor = System.Drawing.Color.White;
            this.cklMaquina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cklMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklMaquina.FormattingEnabled = true;
            this.cklMaquina.Items.AddRange(new object[] {
            "Serviços de maquina"});
            this.cklMaquina.Location = new System.Drawing.Point(412, 59);
            this.cklMaquina.Name = "cklMaquina";
            this.cklMaquina.Size = new System.Drawing.Size(351, 317);
            this.cklMaquina.TabIndex = 163;
            this.cklMaquina.SelectedIndexChanged += new System.EventHandler(this.cklMaquina_SelectedIndexChanged);
            // 
            // txtDefeito
            // 
            this.txtDefeito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDefeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefeito.Location = new System.Drawing.Point(16, 96);
            this.txtDefeito.Multiline = true;
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(351, 97);
            this.txtDefeito.TabIndex = 231;
            // 
            // lblDefeito
            // 
            this.lblDefeito.AutoSize = true;
            this.lblDefeito.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefeito.Location = new System.Drawing.Point(16, 71);
            this.lblDefeito.Name = "lblDefeito";
            this.lblDefeito.Size = new System.Drawing.Size(72, 22);
            this.lblDefeito.TabIndex = 228;
            this.lblDefeito.Text = "Defeito";
            // 
            // cbxCliente
            // 
            this.cbxCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCliente.DataSource = this.clienteBindingSource;
            this.cbxCliente.DisplayMember = "nome";
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(19, 28);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(351, 24);
            this.cbxCliente.TabIndex = 234;
            this.cbxCliente.ValueMember = "cd_cliente";
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
            this.btnSalvar.Location = new System.Drawing.Point(636, 397);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSalvar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalvar.selected = false;
            this.btnSalvar.Size = new System.Drawing.Size(127, 42);
            this.btnSalvar.TabIndex = 125;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Textcolor = System.Drawing.Color.White;
            this.btnSalvar.TextFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblValorOrcamento
            // 
            this.lblValorOrcamento.AutoSize = true;
            this.lblValorOrcamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorOrcamento.Location = new System.Drawing.Point(17, 343);
            this.lblValorOrcamento.Name = "lblValorOrcamento";
            this.lblValorOrcamento.Size = new System.Drawing.Size(179, 22);
            this.lblValorOrcamento.TabIndex = 225;
            this.lblValorOrcamento.Text = "Valor do Orçamento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 22);
            this.label14.TabIndex = 227;
            this.label14.Text = "Tempo de Garantia";
            // 
            // lblFormadePagamento
            // 
            this.lblFormadePagamento.AutoSize = true;
            this.lblFormadePagamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormadePagamento.ForeColor = System.Drawing.Color.White;
            this.lblFormadePagamento.Location = new System.Drawing.Point(17, 279);
            this.lblFormadePagamento.Name = "lblFormadePagamento";
            this.lblFormadePagamento.Size = new System.Drawing.Size(192, 22);
            this.lblFormadePagamento.TabIndex = 229;
            this.lblFormadePagamento.Text = "Forma de pagamento";
            // 
            // cmbFormaPag
            // 
            this.cmbFormaPag.DisplayMember = "Dinheiro";
            this.cmbFormaPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPag.FormattingEnabled = true;
            this.cmbFormaPag.Items.AddRange(new object[] {
            "Dinheiro",
            "Cheque",
            "Cartão de débito",
            "Cartão de crédito 1x",
            "Cartão de crédito 2x",
            "Cartão de crédito 3x"});
            this.cmbFormaPag.Location = new System.Drawing.Point(19, 304);
            this.cmbFormaPag.Name = "cmbFormaPag";
            this.cmbFormaPag.Size = new System.Drawing.Size(347, 26);
            this.cmbFormaPag.TabIndex = 230;
            // 
            // dtGarantia
            // 
            this.dtGarantia.BackColor = System.Drawing.Color.White;
            this.dtGarantia.BorderRadius = 0;
            this.dtGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGarantia.ForeColor = System.Drawing.Color.Black;
            this.dtGarantia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtGarantia.FormatCustom = null;
            this.dtGarantia.Location = new System.Drawing.Point(17, 237);
            this.dtGarantia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGarantia.Name = "dtGarantia";
            this.dtGarantia.Size = new System.Drawing.Size(350, 27);
            this.dtGarantia.TabIndex = 233;
            this.dtGarantia.Value = new System.DateTime(2019, 8, 29, 16, 13, 47, 345);
            // 
            // panelCadastrar
            // 
            this.panelCadastrar.Controls.Add(this.txtValorOrcamento);
            this.panelCadastrar.Controls.Add(this.lblServicos);
            this.panelCadastrar.Controls.Add(this.btnSalvar);
            this.panelCadastrar.Controls.Add(this.cbxCliente);
            this.panelCadastrar.Controls.Add(this.txtDefeito);
            this.panelCadastrar.Controls.Add(this.dtGarantia);
            this.panelCadastrar.Controls.Add(this.lblDefeito);
            this.panelCadastrar.Controls.Add(this.lblCliente);
            this.panelCadastrar.Controls.Add(this.lblGeladeira);
            this.panelCadastrar.Controls.Add(this.cmbFormaPag);
            this.panelCadastrar.Controls.Add(this.lblMaquina);
            this.panelCadastrar.Controls.Add(this.lblFormadePagamento);
            this.panelCadastrar.Controls.Add(this.ckbMaquina);
            this.panelCadastrar.Controls.Add(this.lblMicroondas);
            this.panelCadastrar.Controls.Add(this.label14);
            this.panelCadastrar.Controls.Add(this.ckbMicroondas);
            this.panelCadastrar.Controls.Add(this.ckbGeladeira);
            this.panelCadastrar.Controls.Add(this.lblValorOrcamento);
            this.panelCadastrar.Controls.Add(this.panelProdutos);
            this.panelCadastrar.Controls.Add(this.cklMicroondas);
            this.panelCadastrar.Controls.Add(this.cklMaquina);
            this.panelCadastrar.Controls.Add(this.cklGeladeira);
            this.panelCadastrar.Location = new System.Drawing.Point(14, 51);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(10, 461);
            this.panelCadastrar.TabIndex = 235;
            // 
            // txtValorOrcamento
            // 
            this.txtValorOrcamento.BackColor = System.Drawing.Color.White;
            this.txtValorOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorOrcamento.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorOrcamento.ForeColor = System.Drawing.Color.Black;
            this.txtValorOrcamento.Location = new System.Drawing.Point(19, 368);
            this.txtValorOrcamento.Mask = "$ ";
            this.txtValorOrcamento.Name = "txtValorOrcamento";
            this.txtValorOrcamento.Size = new System.Drawing.Size(347, 29);
            this.txtValorOrcamento.TabIndex = 235;
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
            this.btnCadastrar.Location = new System.Drawing.Point(12, 8);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Normalcolor = System.Drawing.Color.Gray;
            this.btnCadastrar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.selected = false;
            this.btnCadastrar.Size = new System.Drawing.Size(401, 30);
            this.btnCadastrar.TabIndex = 237;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Textcolor = System.Drawing.Color.White;
            this.btnCadastrar.TextFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.btnConsultar.Location = new System.Drawing.Point(419, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Normalcolor = System.Drawing.Color.Gray;
            this.btnConsultar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnConsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsultar.selected = false;
            this.btnConsultar.Size = new System.Drawing.Size(396, 30);
            this.btnConsultar.TabIndex = 236;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultar.Textcolor = System.Drawing.Color.White;
            this.btnConsultar.TextFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblCad
            // 
            this.lblCad.AutoSize = true;
            this.lblCad.BackColor = System.Drawing.Color.Transparent;
            this.lblCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCad.ForeColor = System.Drawing.Color.Silver;
            this.lblCad.Location = new System.Drawing.Point(10, 24);
            this.lblCad.Name = "lblCad";
            this.lblCad.Size = new System.Drawing.Size(405, 20);
            this.lblCad.TabIndex = 238;
            this.lblCad.Text = "____________________________________________";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.Transparent;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.ForeColor = System.Drawing.Color.Silver;
            this.lblCon.Location = new System.Drawing.Point(418, 24);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(396, 20);
            this.lblCon.TabIndex = 239;
            this.lblCon.Text = "___________________________________________";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // registrarOrcamentoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(34)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblCad);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.panelCadastrar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "registrarOrcamentoUC";
            this.Size = new System.Drawing.Size(824, 526);
            this.Load += new System.EventHandler(this.registrarOrcamentoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMakgelDataSet)).EndInit();
            this.panelCadastrar.ResumeLayout(false);
            this.panelCadastrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblServicos;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMicroondas;
        private Bunifu.Framework.UI.BunifuCheckbox ckbMaquina;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMaquina;
        private Bunifu.Framework.UI.BunifuCheckbox ckbMicroondas;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGeladeira;
        private Bunifu.Framework.UI.BunifuCheckbox ckbGeladeira;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.CheckedListBox cklGeladeira;
        private System.Windows.Forms.CheckedListBox cklMicroondas;
        private System.Windows.Forms.CheckedListBox cklMaquina;
        private System.Windows.Forms.TextBox txtDefeito;
        private System.Windows.Forms.Label lblDefeito;
        private System.Windows.Forms.ComboBox cbxCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalvar;
        private System.Windows.Forms.Label lblValorOrcamento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblFormadePagamento;
        private System.Windows.Forms.ComboBox cmbFormaPag;
        private Bunifu.Framework.UI.BunifuDatepicker dtGarantia;
        private System.Windows.Forms.Panel panelCadastrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultar;
        private System.Windows.Forms.Label lblCad;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.MaskedTextBox txtValorOrcamento;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private bdMakgelDataSet bdMakgelDataSet;
        private bdMakgelDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
    }
}
