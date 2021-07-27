namespace ComparaArquivos
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.panel1 = new System.Windows.Forms.Panel();
			this.chkAgrupar = new System.Windows.Forms.CheckBox();
			this.chkMostrarArquivosIguais = new System.Windows.Forms.CheckBox();
			this.txtNDiferencas = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chkPararAposNDiferencas = new System.Windows.Forms.CheckBox();
			this.lblVerificandoArquivo = new System.Windows.Forms.Label();
			this.btnSelecionarArquivoB = new System.Windows.Forms.Button();
			this.txtFiltroB = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSelecionarCaminhoB = new System.Windows.Forms.Button();
			this.btnSelecionarArquivoA = new System.Windows.Forms.Button();
			this.chkIncluiSubDir = new System.Windows.Forms.CheckBox();
			this.txtFiltroA = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.prgProgresso = new System.Windows.Forms.ProgressBar();
			this.btnComparar = new System.Windows.Forms.Button();
			this.imgBotoes = new System.Windows.Forms.ImageList(this.components);
			this.btnSelecionarCaminhoA = new System.Windows.Forms.Button();
			this.txtCaminhoB = new System.Windows.Forms.TextBox();
			this.txtCaminhoA = new System.Windows.Forms.TextBox();
			this.lblCaminhoB = new System.Windows.Forms.Label();
			this.lblCaminhoA = new System.Windows.Forms.Label();
			this.tvwDiferencas = new System.Windows.Forms.TreeView();
			this.lblTotalDiferencas = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.spcDiferencas = new System.Windows.Forms.SplitContainer();
			this.txtDetalhes = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.formPlacement = new Componentes.FormPlacement();
			this.panel1.SuspendLayout();
			this.spcDiferencas.Panel1.SuspendLayout();
			this.spcDiferencas.Panel2.SuspendLayout();
			this.spcDiferencas.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chkAgrupar);
			this.panel1.Controls.Add(this.chkMostrarArquivosIguais);
			this.panel1.Controls.Add(this.txtNDiferencas);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.chkPararAposNDiferencas);
			this.panel1.Controls.Add(this.lblVerificandoArquivo);
			this.panel1.Controls.Add(this.btnSelecionarArquivoB);
			this.panel1.Controls.Add(this.txtFiltroB);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.btnSelecionarCaminhoB);
			this.panel1.Controls.Add(this.btnSelecionarArquivoA);
			this.panel1.Controls.Add(this.chkIncluiSubDir);
			this.panel1.Controls.Add(this.txtFiltroA);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.prgProgresso);
			this.panel1.Controls.Add(this.btnComparar);
			this.panel1.Controls.Add(this.btnSelecionarCaminhoA);
			this.panel1.Controls.Add(this.txtCaminhoB);
			this.panel1.Controls.Add(this.txtCaminhoA);
			this.panel1.Controls.Add(this.lblCaminhoB);
			this.panel1.Controls.Add(this.lblCaminhoA);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(805, 241);
			this.panel1.TabIndex = 0;
			// 
			// chkAgrupar
			// 
			this.chkAgrupar.AutoSize = true;
			this.chkAgrupar.Location = new System.Drawing.Point(228, 154);
			this.chkAgrupar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkAgrupar.Name = "chkAgrupar";
			this.chkAgrupar.Size = new System.Drawing.Size(129, 20);
			this.chkAgrupar.TabIndex = 23;
			this.chkAgrupar.Text = "Exibir em grupos";
			this.chkAgrupar.UseVisualStyleBackColor = true;
			// 
			// chkMostrarArquivosIguais
			// 
			this.chkMostrarArquivosIguais.AutoSize = true;
			this.chkMostrarArquivosIguais.Location = new System.Drawing.Point(16, 154);
			this.chkMostrarArquivosIguais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkMostrarArquivosIguais.Name = "chkMostrarArquivosIguais";
			this.chkMostrarArquivosIguais.Size = new System.Drawing.Size(168, 20);
			this.chkMostrarArquivosIguais.TabIndex = 22;
			this.chkMostrarArquivosIguais.Text = "Mostrar arquivos iguais";
			this.chkMostrarArquivosIguais.UseVisualStyleBackColor = true;
			// 
			// txtNDiferencas
			// 
			this.txtNDiferencas.Location = new System.Drawing.Point(325, 122);
			this.txtNDiferencas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNDiferencas.Mask = "00000";
			this.txtNDiferencas.Name = "txtNDiferencas";
			this.txtNDiferencas.PromptChar = ' ';
			this.txtNDiferencas.Size = new System.Drawing.Size(72, 22);
			this.txtNDiferencas.TabIndex = 21;
			this.txtNDiferencas.Text = "100";
			this.txtNDiferencas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtNDiferencas.ValidatingType = typeof(int);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(403, 127);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "diferenças encontradas";
			// 
			// chkPararAposNDiferencas
			// 
			this.chkPararAposNDiferencas.AutoSize = true;
			this.chkPararAposNDiferencas.Location = new System.Drawing.Point(228, 126);
			this.chkPararAposNDiferencas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkPararAposNDiferencas.Name = "chkPararAposNDiferencas";
			this.chkPararAposNDiferencas.Size = new System.Drawing.Size(96, 20);
			this.chkPararAposNDiferencas.TabIndex = 18;
			this.chkPararAposNDiferencas.Text = "Parar após";
			this.chkPararAposNDiferencas.UseVisualStyleBackColor = true;
			this.chkPararAposNDiferencas.CheckedChanged += new System.EventHandler(this.chkPararAposNDiferencas_CheckedChanged);
			// 
			// lblVerificandoArquivo
			// 
			this.lblVerificandoArquivo.AutoSize = true;
			this.lblVerificandoArquivo.Location = new System.Drawing.Point(167, 206);
			this.lblVerificandoArquivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVerificandoArquivo.Name = "lblVerificandoArquivo";
			this.lblVerificandoArquivo.Size = new System.Drawing.Size(16, 16);
			this.lblVerificandoArquivo.TabIndex = 17;
			this.lblVerificandoArquivo.Text = "...";
			// 
			// btnSelecionarArquivoB
			// 
			this.btnSelecionarArquivoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelecionarArquivoB.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarArquivoB.Image")));
			this.btnSelecionarArquivoB.Location = new System.Drawing.Point(568, 86);
			this.btnSelecionarArquivoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSelecionarArquivoB.Name = "btnSelecionarArquivoB";
			this.btnSelecionarArquivoB.Size = new System.Drawing.Size(32, 25);
			this.btnSelecionarArquivoB.TabIndex = 9;
			this.toolTip1.SetToolTip(this.btnSelecionarArquivoB, "Selecionar Arquivo");
			this.btnSelecionarArquivoB.UseVisualStyleBackColor = true;
			this.btnSelecionarArquivoB.Click += new System.EventHandler(this.btnSelecionarArquivoB_Click);
			// 
			// txtFiltroB
			// 
			this.txtFiltroB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFiltroB.Location = new System.Drawing.Point(621, 86);
			this.txtFiltroB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtFiltroB.Name = "txtFiltroB";
			this.txtFiltroB.Size = new System.Drawing.Size(167, 22);
			this.txtFiltroB.TabIndex = 11;
			this.txtFiltroB.Text = "*.*";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Maroon;
			this.label6.Location = new System.Drawing.Point(617, 66);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Filtro";
			// 
			// btnSelecionarCaminhoB
			// 
			this.btnSelecionarCaminhoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelecionarCaminhoB.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarCaminhoB.Image")));
			this.btnSelecionarCaminhoB.Location = new System.Drawing.Point(537, 86);
			this.btnSelecionarCaminhoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSelecionarCaminhoB.Name = "btnSelecionarCaminhoB";
			this.btnSelecionarCaminhoB.Size = new System.Drawing.Size(32, 25);
			this.btnSelecionarCaminhoB.TabIndex = 8;
			this.toolTip1.SetToolTip(this.btnSelecionarCaminhoB, "Selecionar Pasta");
			this.btnSelecionarCaminhoB.UseVisualStyleBackColor = true;
			this.btnSelecionarCaminhoB.Click += new System.EventHandler(this.btnSelecionarCaminhoB_Click);
			// 
			// btnSelecionarArquivoA
			// 
			this.btnSelecionarArquivoA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelecionarArquivoA.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarArquivoA.Image")));
			this.btnSelecionarArquivoA.Location = new System.Drawing.Point(568, 31);
			this.btnSelecionarArquivoA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSelecionarArquivoA.Name = "btnSelecionarArquivoA";
			this.btnSelecionarArquivoA.Size = new System.Drawing.Size(32, 25);
			this.btnSelecionarArquivoA.TabIndex = 3;
			this.toolTip1.SetToolTip(this.btnSelecionarArquivoA, "Selecionar Arquivo");
			this.btnSelecionarArquivoA.UseVisualStyleBackColor = true;
			this.btnSelecionarArquivoA.Click += new System.EventHandler(this.btnSelecionarArquivoA_Click);
			// 
			// chkIncluiSubDir
			// 
			this.chkIncluiSubDir.AutoSize = true;
			this.chkIncluiSubDir.Checked = true;
			this.chkIncluiSubDir.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIncluiSubDir.Location = new System.Drawing.Point(17, 126);
			this.chkIncluiSubDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkIncluiSubDir.Name = "chkIncluiSubDir";
			this.chkIncluiSubDir.Size = new System.Drawing.Size(144, 20);
			this.chkIncluiSubDir.TabIndex = 12;
			this.chkIncluiSubDir.Text = "Incluir subdiretórios";
			this.chkIncluiSubDir.UseVisualStyleBackColor = true;
			// 
			// txtFiltroA
			// 
			this.txtFiltroA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFiltroA.Location = new System.Drawing.Point(621, 32);
			this.txtFiltroA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtFiltroA.Name = "txtFiltroA";
			this.txtFiltroA.Size = new System.Drawing.Size(167, 22);
			this.txtFiltroA.TabIndex = 5;
			this.txtFiltroA.Text = "*.*";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(617, 11);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Filtro";
			// 
			// prgProgresso
			// 
			this.prgProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.prgProgresso.Location = new System.Drawing.Point(171, 187);
			this.prgProgresso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.prgProgresso.Name = "prgProgresso";
			this.prgProgresso.Size = new System.Drawing.Size(619, 15);
			this.prgProgresso.TabIndex = 16;
			// 
			// btnComparar
			// 
			this.btnComparar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnComparar.ImageKey = "comparar";
			this.btnComparar.ImageList = this.imgBotoes;
			this.btnComparar.Location = new System.Drawing.Point(16, 187);
			this.btnComparar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnComparar.Name = "btnComparar";
			this.btnComparar.Size = new System.Drawing.Size(127, 28);
			this.btnComparar.TabIndex = 15;
			this.btnComparar.Text = "Comparar";
			this.btnComparar.UseVisualStyleBackColor = true;
			this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
			// 
			// imgBotoes
			// 
			this.imgBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBotoes.ImageStream")));
			this.imgBotoes.TransparentColor = System.Drawing.Color.Transparent;
			this.imgBotoes.Images.SetKeyName(0, "comparar");
			this.imgBotoes.Images.SetKeyName(1, "stop");
			// 
			// btnSelecionarCaminhoA
			// 
			this.btnSelecionarCaminhoA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelecionarCaminhoA.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarCaminhoA.Image")));
			this.btnSelecionarCaminhoA.Location = new System.Drawing.Point(537, 31);
			this.btnSelecionarCaminhoA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSelecionarCaminhoA.Name = "btnSelecionarCaminhoA";
			this.btnSelecionarCaminhoA.Size = new System.Drawing.Size(32, 25);
			this.btnSelecionarCaminhoA.TabIndex = 2;
			this.toolTip1.SetToolTip(this.btnSelecionarCaminhoA, "Selecionar Pasta");
			this.btnSelecionarCaminhoA.UseVisualStyleBackColor = true;
			this.btnSelecionarCaminhoA.Click += new System.EventHandler(this.btnSelecionarCaminhoA_Click);
			// 
			// txtCaminhoB
			// 
			this.txtCaminhoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCaminhoB.Location = new System.Drawing.Point(16, 86);
			this.txtCaminhoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtCaminhoB.Name = "txtCaminhoB";
			this.txtCaminhoB.ReadOnly = true;
			this.txtCaminhoB.Size = new System.Drawing.Size(512, 22);
			this.txtCaminhoB.TabIndex = 7;
			this.txtCaminhoB.TabStop = false;
			// 
			// txtCaminhoA
			// 
			this.txtCaminhoA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCaminhoA.Location = new System.Drawing.Point(16, 31);
			this.txtCaminhoA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtCaminhoA.Name = "txtCaminhoA";
			this.txtCaminhoA.ReadOnly = true;
			this.txtCaminhoA.Size = new System.Drawing.Size(512, 22);
			this.txtCaminhoA.TabIndex = 1;
			this.txtCaminhoA.TabStop = false;
			// 
			// lblCaminhoB
			// 
			this.lblCaminhoB.AutoSize = true;
			this.lblCaminhoB.ForeColor = System.Drawing.Color.Maroon;
			this.lblCaminhoB.Location = new System.Drawing.Point(12, 66);
			this.lblCaminhoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCaminhoB.Name = "lblCaminhoB";
			this.lblCaminhoB.Size = new System.Drawing.Size(72, 16);
			this.lblCaminhoB.TabIndex = 6;
			this.lblCaminhoB.Text = "Caminho B";
			// 
			// lblCaminhoA
			// 
			this.lblCaminhoA.AutoSize = true;
			this.lblCaminhoA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblCaminhoA.Location = new System.Drawing.Point(12, 11);
			this.lblCaminhoA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCaminhoA.Name = "lblCaminhoA";
			this.lblCaminhoA.Size = new System.Drawing.Size(72, 16);
			this.lblCaminhoA.TabIndex = 0;
			this.lblCaminhoA.Text = "Caminho A";
			// 
			// tvwDiferencas
			// 
			this.tvwDiferencas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tvwDiferencas.Location = new System.Drawing.Point(16, 31);
			this.tvwDiferencas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tvwDiferencas.Name = "tvwDiferencas";
			this.tvwDiferencas.Size = new System.Drawing.Size(427, 271);
			this.tvwDiferencas.TabIndex = 1;
			this.tvwDiferencas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwDiferencas_AfterSelect);
			// 
			// lblTotalDiferencas
			// 
			this.lblTotalDiferencas.AutoSize = true;
			this.lblTotalDiferencas.Location = new System.Drawing.Point(12, 11);
			this.lblTotalDiferencas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTotalDiferencas.Name = "lblTotalDiferencas";
			this.lblTotalDiferencas.Size = new System.Drawing.Size(150, 16);
			this.lblTotalDiferencas.TabIndex = 0;
			this.lblTotalDiferencas.Text = "Diferenças encontradas";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 11);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Detalhes";
			// 
			// spcDiferencas
			// 
			this.spcDiferencas.BackColor = System.Drawing.SystemColors.Control;
			this.spcDiferencas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcDiferencas.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.spcDiferencas.Location = new System.Drawing.Point(0, 241);
			this.spcDiferencas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.spcDiferencas.Name = "spcDiferencas";
			// 
			// spcDiferencas.Panel1
			// 
			this.spcDiferencas.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.spcDiferencas.Panel1.Controls.Add(this.tvwDiferencas);
			this.spcDiferencas.Panel1.Controls.Add(this.lblTotalDiferencas);
			// 
			// spcDiferencas.Panel2
			// 
			this.spcDiferencas.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.spcDiferencas.Panel2.Controls.Add(this.txtDetalhes);
			this.spcDiferencas.Panel2.Controls.Add(this.label4);
			this.spcDiferencas.Size = new System.Drawing.Size(805, 317);
			this.spcDiferencas.SplitterDistance = 448;
			this.spcDiferencas.SplitterWidth = 5;
			this.spcDiferencas.TabIndex = 1;
			// 
			// txtDetalhes
			// 
			this.txtDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDetalhes.Location = new System.Drawing.Point(4, 31);
			this.txtDetalhes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDetalhes.Multiline = true;
			this.txtDetalhes.Name = "txtDetalhes";
			this.txtDetalhes.Size = new System.Drawing.Size(331, 271);
			this.txtDetalhes.TabIndex = 1;
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			// 
			// formPlacement
			// 
			this.formPlacement.Form = this;
			this.formPlacement.SalvaEstadoJanela = true;
			this.formPlacement.OnLerValores += new Componentes.FormPlacement.LerEventHandler(this.formPlacement_OnLerValores);
			this.formPlacement.OnSalvarValores += new Componentes.FormPlacement.SalvarEventHandler(this.formPlacement_OnSalvarValores);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 558);
			this.Controls.Add(this.spcDiferencas);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormMain";
			this.Text = "Comparador de Arquivos";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.spcDiferencas.Panel1.ResumeLayout(false);
			this.spcDiferencas.Panel1.PerformLayout();
			this.spcDiferencas.Panel2.ResumeLayout(false);
			this.spcDiferencas.Panel2.PerformLayout();
			this.spcDiferencas.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblCaminhoB;
		private System.Windows.Forms.Label lblCaminhoA;
		private System.Windows.Forms.Button btnSelecionarCaminhoA;
		private System.Windows.Forms.TextBox txtCaminhoB;
		private System.Windows.Forms.TextBox txtCaminhoA;
		private System.Windows.Forms.Button btnComparar;
		private System.Windows.Forms.TreeView tvwDiferencas;
		private System.Windows.Forms.Label lblTotalDiferencas;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.SplitContainer spcDiferencas;
		private System.Windows.Forms.TextBox txtDetalhes;
		private System.Windows.Forms.ProgressBar prgProgresso;
		private System.Windows.Forms.TextBox txtFiltroA;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkIncluiSubDir;
		private System.Windows.Forms.Button btnSelecionarArquivoA;
		private System.Windows.Forms.Button btnSelecionarArquivoB;
		private System.Windows.Forms.TextBox txtFiltroB;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnSelecionarCaminhoB;
		private System.Windows.Forms.ToolTip toolTip1;
		private Componentes.FormPlacement formPlacement;
		private System.Windows.Forms.Label lblVerificandoArquivo;
		private System.Windows.Forms.CheckBox chkPararAposNDiferencas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox txtNDiferencas;
		private System.Windows.Forms.CheckBox chkMostrarArquivosIguais;
		private System.Windows.Forms.CheckBox chkAgrupar;
		private System.Windows.Forms.ImageList imgBotoes;
	}
}

