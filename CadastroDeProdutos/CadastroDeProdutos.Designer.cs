namespace lab_windowsforms
{
    partial class frmCadastroDeProdutos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroDeProdutos));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.cmbFornecedores = new System.Windows.Forms.ComboBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.grpPrecificacaoEEstoque = new System.Windows.Forms.GroupBox();
            this.txtMargem = new System.Windows.Forms.TextBox();
            this.nudStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.nudPrecoCusto = new System.Windows.Forms.NumericUpDown();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.lblMargem = new System.Windows.Forms.Label();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.grpSituacaoEDetalhes = new System.Windows.Forms.GroupBox();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.chkStatusProduto = new System.Windows.Forms.CheckBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.imgNovo = new System.Windows.Forms.ImageList(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.imgSalvar = new System.Windows.Forms.ImageList(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.imgLimpar = new System.Windows.Forms.ImageList(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.imgExcluir = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbCodigo = new System.Windows.Forms.MaskedTextBox();
            this.nudStockInicial = new System.Windows.Forms.NumericUpDown();
            this.nudPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDadosPrincipais.SuspendLayout();
            this.grpPrecificacaoEEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCusto)).BeginInit();
            this.grpSituacaoEDetalhes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(71)))), ((int)(((byte)(120)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(823, 85);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 25.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(108, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpDadosPrincipais
            // 
            this.grpDadosPrincipais.Controls.Add(this.mtbCodigo);
            this.grpDadosPrincipais.Controls.Add(this.label2);
            this.grpDadosPrincipais.Controls.Add(this.label1);
            this.grpDadosPrincipais.Controls.Add(this.txtDescricao);
            this.grpDadosPrincipais.Controls.Add(this.cmbCategorias);
            this.grpDadosPrincipais.Controls.Add(this.cmbFornecedores);
            this.grpDadosPrincipais.Controls.Add(this.txtNomeProduto);
            this.grpDadosPrincipais.Controls.Add(this.lblDescricao);
            this.grpDadosPrincipais.Controls.Add(this.lblFornecedor);
            this.grpDadosPrincipais.Controls.Add(this.lblNomeProduto);
            this.grpDadosPrincipais.Controls.Add(this.lblCodigo);
            this.grpDadosPrincipais.Controls.Add(this.label3);
            this.grpDadosPrincipais.Controls.Add(this.lblCategoria);
            this.grpDadosPrincipais.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.grpDadosPrincipais.Location = new System.Drawing.Point(12, 107);
            this.grpDadosPrincipais.Name = "grpDadosPrincipais";
            this.grpDadosPrincipais.Size = new System.Drawing.Size(798, 181);
            this.grpDadosPrincipais.TabIndex = 1;
            this.grpDadosPrincipais.TabStop = false;
            this.grpDadosPrincipais.Text = "Dados Principais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(99, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "*";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtDescricao.Location = new System.Drawing.Point(282, 98);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(497, 66);
            this.txtDescricao.TabIndex = 5;
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.Font = new System.Drawing.Font("Arial", 12.25F);
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Items.AddRange(new object[] {
            "Embalagens",
            "Confeitaria",
            "Ingredientes para Panificação",
            "Laticínios",
            "Biscoitos e Bolachas",
            "Salgados",
            "Bebidas",
            "Doces e Sobremesas",
            "Bolos e Tortas",
            "Pães"});
            this.cmbCategorias.Location = new System.Drawing.Point(583, 44);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(196, 26);
            this.cmbCategorias.TabIndex = 3;
            this.cmbCategorias.Text = "Selecione...";
            // 
            // cmbFornecedores
            // 
            this.cmbFornecedores.Font = new System.Drawing.Font("Arial", 12.25F);
            this.cmbFornecedores.FormattingEnabled = true;
            this.cmbFornecedores.Items.AddRange(new object[] {
            "Vigor",
            "Unilever",
            "Coca-Cola",
            "Bauducco",
            "Nestlé"});
            this.cmbFornecedores.Location = new System.Drawing.Point(15, 98);
            this.cmbFornecedores.Name = "cmbFornecedores";
            this.cmbFornecedores.Size = new System.Drawing.Size(238, 26);
            this.cmbFornecedores.TabIndex = 4;
            this.cmbFornecedores.Text = "Selecione...";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProduto.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtNomeProduto.Location = new System.Drawing.Point(195, 45);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(360, 26);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblDescricao.Location = new System.Drawing.Point(278, 79);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(78, 16);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição: ";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblFornecedor.Location = new System.Drawing.Point(12, 79);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(85, 16);
            this.lblFornecedor.TabIndex = 3;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblNomeProduto.Location = new System.Drawing.Point(192, 26);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(121, 16);
            this.lblNomeProduto.TabIndex = 1;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblCodigo.Location = new System.Drawing.Point(12, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(650, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "*";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblCategoria.Location = new System.Drawing.Point(580, 25);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 16);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria: ";
            // 
            // grpPrecificacaoEEstoque
            // 
            this.grpPrecificacaoEEstoque.Controls.Add(this.nudPrecoVenda);
            this.grpPrecificacaoEEstoque.Controls.Add(this.nudStockInicial);
            this.grpPrecificacaoEEstoque.Controls.Add(this.txtMargem);
            this.grpPrecificacaoEEstoque.Controls.Add(this.nudStockMinimo);
            this.grpPrecificacaoEEstoque.Controls.Add(this.nudPrecoCusto);
            this.grpPrecificacaoEEstoque.Controls.Add(this.lblStockMinimo);
            this.grpPrecificacaoEEstoque.Controls.Add(this.lblPrecoVenda);
            this.grpPrecificacaoEEstoque.Controls.Add(this.lblStockInicial);
            this.grpPrecificacaoEEstoque.Controls.Add(this.lblMargem);
            this.grpPrecificacaoEEstoque.Controls.Add(this.lblPrecoCusto);
            this.grpPrecificacaoEEstoque.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.grpPrecificacaoEEstoque.Location = new System.Drawing.Point(12, 294);
            this.grpPrecificacaoEEstoque.Name = "grpPrecificacaoEEstoque";
            this.grpPrecificacaoEEstoque.Size = new System.Drawing.Size(496, 166);
            this.grpPrecificacaoEEstoque.TabIndex = 2;
            this.grpPrecificacaoEEstoque.TabStop = false;
            this.grpPrecificacaoEEstoque.Text = "Precificação e Estoque";
            // 
            // txtMargem
            // 
            this.txtMargem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMargem.Enabled = false;
            this.txtMargem.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtMargem.Location = new System.Drawing.Point(122, 72);
            this.txtMargem.Name = "txtMargem";
            this.txtMargem.Size = new System.Drawing.Size(100, 26);
            this.txtMargem.TabIndex = 5;
            this.txtMargem.Text = "0,00";
            // 
            // nudStockMinimo
            // 
            this.nudStockMinimo.Font = new System.Drawing.Font("Arial", 12.25F);
            this.nudStockMinimo.Location = new System.Drawing.Point(395, 113);
            this.nudStockMinimo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStockMinimo.Name = "nudStockMinimo";
            this.nudStockMinimo.Size = new System.Drawing.Size(85, 26);
            this.nudStockMinimo.TabIndex = 9;
            // 
            // nudPrecoCusto
            // 
            this.nudPrecoCusto.DecimalPlaces = 2;
            this.nudPrecoCusto.Font = new System.Drawing.Font("Arial", 12.25F);
            this.nudPrecoCusto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecoCusto.Location = new System.Drawing.Point(164, 27);
            this.nudPrecoCusto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrecoCusto.Name = "nudPrecoCusto";
            this.nudPrecoCusto.Size = new System.Drawing.Size(74, 26);
            this.nudPrecoCusto.TabIndex = 1;
            this.nudPrecoCusto.ValueChanged += new System.EventHandler(this.nudPrecoCusto_ValueChanged);
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblStockMinimo.Location = new System.Drawing.Point(247, 117);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(95, 16);
            this.lblStockMinimo.TabIndex = 8;
            this.lblStockMinimo.Text = "Stock Mínimo:";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblPrecoVenda.Location = new System.Drawing.Point(247, 31);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(144, 16);
            this.lblPrecoVenda.TabIndex = 2;
            this.lblPrecoVenda.Text = "Preco de Venda (R$):";
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblStockInicial.Location = new System.Drawing.Point(12, 117);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(85, 16);
            this.lblStockInicial.TabIndex = 6;
            this.lblStockInicial.Text = "Stock Inicial:";
            // 
            // lblMargem
            // 
            this.lblMargem.AutoSize = true;
            this.lblMargem.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblMargem.Location = new System.Drawing.Point(12, 76);
            this.lblMargem.Name = "lblMargem";
            this.lblMargem.Size = new System.Drawing.Size(94, 16);
            this.lblMargem.TabIndex = 4;
            this.lblMargem.Text = "Margem (R$):";
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblPrecoCusto.Location = new System.Drawing.Point(12, 32);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(141, 16);
            this.lblPrecoCusto.TabIndex = 0;
            this.lblPrecoCusto.Text = "Preço de Custo (R$):";
            // 
            // grpSituacaoEDetalhes
            // 
            this.grpSituacaoEDetalhes.Controls.Add(this.dtpDataCadastro);
            this.grpSituacaoEDetalhes.Controls.Add(this.lblDataCadastro);
            this.grpSituacaoEDetalhes.Controls.Add(this.chkStatusProduto);
            this.grpSituacaoEDetalhes.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.grpSituacaoEDetalhes.Location = new System.Drawing.Point(525, 294);
            this.grpSituacaoEDetalhes.Name = "grpSituacaoEDetalhes";
            this.grpSituacaoEDetalhes.Size = new System.Drawing.Size(285, 166);
            this.grpSituacaoEDetalhes.TabIndex = 3;
            this.grpSituacaoEDetalhes.TabStop = false;
            this.grpSituacaoEDetalhes.Text = "Situação / Detalhes";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.CalendarFont = new System.Drawing.Font("Arial", 12.25F);
            this.dtpDataCadastro.Font = new System.Drawing.Font("Arial", 12.25F);
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(20, 91);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(200, 26);
            this.dtpDataCadastro.TabIndex = 2;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Arial", 10.25F);
            this.lblDataCadastro.Location = new System.Drawing.Point(17, 72);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(123, 16);
            this.lblDataCadastro.TabIndex = 1;
            this.lblDataCadastro.Text = "Data de Cadastro:";
            // 
            // chkStatusProduto
            // 
            this.chkStatusProduto.AutoSize = true;
            this.chkStatusProduto.Font = new System.Drawing.Font("Arial", 10.25F);
            this.chkStatusProduto.Location = new System.Drawing.Point(20, 34);
            this.chkStatusProduto.Name = "chkStatusProduto";
            this.chkStatusProduto.Size = new System.Drawing.Size(110, 20);
            this.chkStatusProduto.TabIndex = 0;
            this.chkStatusProduto.Text = "Produto Ativo";
            this.chkStatusProduto.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNovo.ImageIndex = 0;
            this.btnNovo.ImageList = this.imgNovo;
            this.btnNovo.Location = new System.Drawing.Point(152, 16);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(122, 49);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "  Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // imgNovo
            // 
            this.imgNovo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNovo.ImageStream")));
            this.imgNovo.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNovo.Images.SetKeyName(0, "simbolo-novo-arquivo.png");
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSalvar.ImageIndex = 1;
            this.btnSalvar.ImageList = this.imgSalvar;
            this.btnSalvar.Location = new System.Drawing.Point(292, 16);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(122, 49);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "  Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // imgSalvar
            // 
            this.imgSalvar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSalvar.ImageStream")));
            this.imgSalvar.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSalvar.Images.SetKeyName(0, "simbolo-novo-arquivo.png");
            this.imgSalvar.Images.SetKeyName(1, "simbolo-salvar.png");
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLimpar.ImageIndex = 1;
            this.btnLimpar.ImageList = this.imgLimpar;
            this.btnLimpar.Location = new System.Drawing.Point(430, 16);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 49);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "  Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // imgLimpar
            // 
            this.imgLimpar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLimpar.ImageStream")));
            this.imgLimpar.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLimpar.Images.SetKeyName(0, "simbolo-novo-arquivo.png");
            this.imgLimpar.Images.SetKeyName(1, "simbolo-limpar.png");
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnExcluir.ImageIndex = 1;
            this.btnExcluir.ImageList = this.imgExcluir;
            this.btnExcluir.Location = new System.Drawing.Point(569, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(122, 49);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "  Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // imgExcluir
            // 
            this.imgExcluir.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgExcluir.ImageStream")));
            this.imgExcluir.TransparentColor = System.Drawing.Color.Transparent;
            this.imgExcluir.Images.SetKeyName(0, "simbolo-novo-arquivo.png");
            this.imgExcluir.Images.SetKeyName(1, "simbolo-excluir.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 85);
            this.panel1.TabIndex = 8;
            // 
            // mtbCodigo
            // 
            this.mtbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCodigo.Enabled = false;
            this.mtbCodigo.Font = new System.Drawing.Font("Arial", 12.25F);
            this.mtbCodigo.Location = new System.Drawing.Point(15, 46);
            this.mtbCodigo.Mask = "000000";
            this.mtbCodigo.Name = "mtbCodigo";
            this.mtbCodigo.Size = new System.Drawing.Size(138, 26);
            this.mtbCodigo.TabIndex = 9;
            this.mtbCodigo.Text = "000000";
            // 
            // nudStockInicial
            // 
            this.nudStockInicial.Font = new System.Drawing.Font("Arial", 12.25F);
            this.nudStockInicial.Location = new System.Drawing.Point(122, 117);
            this.nudStockInicial.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStockInicial.Name = "nudStockInicial";
            this.nudStockInicial.Size = new System.Drawing.Size(74, 26);
            this.nudStockInicial.TabIndex = 10;
            // 
            // nudPrecoVenda
            // 
            this.nudPrecoVenda.DecimalPlaces = 2;
            this.nudPrecoVenda.Font = new System.Drawing.Font("Arial", 12.25F);
            this.nudPrecoVenda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecoVenda.Location = new System.Drawing.Point(395, 28);
            this.nudPrecoVenda.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrecoVenda.Name = "nudPrecoVenda";
            this.nudPrecoVenda.Size = new System.Drawing.Size(74, 26);
            this.nudPrecoVenda.TabIndex = 11;
            this.nudPrecoVenda.ValueChanged += new System.EventHandler(this.nudPrecoVenda_ValueChanged);
            // 
            // frmCadastroDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpSituacaoEDetalhes);
            this.Controls.Add(this.grpPrecificacaoEEstoque);
            this.Controls.Add(this.grpDadosPrincipais);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmCadastroDeProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadastroDeProdutos_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDadosPrincipais.ResumeLayout(false);
            this.grpDadosPrincipais.PerformLayout();
            this.grpPrecificacaoEEstoque.ResumeLayout(false);
            this.grpPrecificacaoEEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCusto)).EndInit();
            this.grpSituacaoEDetalhes.ResumeLayout(false);
            this.grpSituacaoEDetalhes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpDadosPrincipais;
        private System.Windows.Forms.GroupBox grpSituacaoEDetalhes;
        private System.Windows.Forms.CheckBox chkStatusProduto;
        private System.Windows.Forms.GroupBox grpPrecificacaoEEstoque;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.Label lblMargem;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.NumericUpDown nudStockMinimo;
        private System.Windows.Forms.NumericUpDown nudPrecoCusto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtMargem;
        private System.Windows.Forms.ComboBox cmbFornecedores;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ImageList imgNovo;
        private System.Windows.Forms.ImageList imgSalvar;
        private System.Windows.Forms.ImageList imgLimpar;
        private System.Windows.Forms.ImageList imgExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbCodigo;
        private System.Windows.Forms.NumericUpDown nudPrecoVenda;
        private System.Windows.Forms.NumericUpDown nudStockInicial;
    }
}