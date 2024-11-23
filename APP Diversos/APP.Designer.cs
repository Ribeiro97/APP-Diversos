namespace APP_Diversos
{
    partial class Diversos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAbas = new System.Windows.Forms.TabControl();
            this.Aba_Conexao = new System.Windows.Forms.TabPage();
            this.btn_LimparConexao = new System.Windows.Forms.Button();
            this.btn_ConectarDatabase = new System.Windows.Forms.Button();
            this.Conexao_Senha = new System.Windows.Forms.TextBox();
            this.Conexao_Banco = new System.Windows.Forms.TextBox();
            this.Conexao_Usuario = new System.Windows.Forms.TextBox();
            this.Conexao_Servidor = new System.Windows.Forms.TextBox();
            this.Conexao_labelSenha = new System.Windows.Forms.Label();
            this.Conexao_labelBanco = new System.Windows.Forms.Label();
            this.Conexao_labelUsuario = new System.Windows.Forms.Label();
            this.Conexao_labelServidor = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.XML_radioSat = new System.Windows.Forms.RadioButton();
            this.checkBox_XML_Homologacao = new System.Windows.Forms.CheckBox();
            this.XML_btnGerar = new System.Windows.Forms.Button();
            this.XML_radioCTe = new System.Windows.Forms.RadioButton();
            this.XML_radioNFSe = new System.Windows.Forms.RadioButton();
            this.XML_radioMDFe = new System.Windows.Forms.RadioButton();
            this.XML_radioNFCe = new System.Windows.Forms.RadioButton();
            this.XML_radioNFe = new System.Windows.Forms.RadioButton();
            this.XML_Empresa = new System.Windows.Forms.NumericUpDown();
            this.XML_Serie = new System.Windows.Forms.NumericUpDown();
            this.XML_Codigo = new System.Windows.Forms.NumericUpDown();
            this.XML_labelEmpresa = new System.Windows.Forms.Label();
            this.XML_labelSerie = new System.Windows.Forms.Label();
            this.XML_labelCodigo = new System.Windows.Forms.Label();
            this.tabAbas.SuspendLayout();
            this.Aba_Conexao.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XML_Empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XML_Serie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XML_Codigo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAbas
            // 
            this.tabAbas.Controls.Add(this.Aba_Conexao);
            this.tabAbas.Controls.Add(this.tabPage2);
            this.tabAbas.Location = new System.Drawing.Point(0, 0);
            this.tabAbas.Name = "tabAbas";
            this.tabAbas.SelectedIndex = 0;
            this.tabAbas.Size = new System.Drawing.Size(347, 227);
            this.tabAbas.TabIndex = 0;
            // 
            // Aba_Conexao
            // 
            this.Aba_Conexao.Controls.Add(this.btn_LimparConexao);
            this.Aba_Conexao.Controls.Add(this.btn_ConectarDatabase);
            this.Aba_Conexao.Controls.Add(this.Conexao_Senha);
            this.Aba_Conexao.Controls.Add(this.Conexao_Banco);
            this.Aba_Conexao.Controls.Add(this.Conexao_Usuario);
            this.Aba_Conexao.Controls.Add(this.Conexao_Servidor);
            this.Aba_Conexao.Controls.Add(this.Conexao_labelSenha);
            this.Aba_Conexao.Controls.Add(this.Conexao_labelBanco);
            this.Aba_Conexao.Controls.Add(this.Conexao_labelUsuario);
            this.Aba_Conexao.Controls.Add(this.Conexao_labelServidor);
            this.Aba_Conexao.Location = new System.Drawing.Point(4, 22);
            this.Aba_Conexao.Name = "Aba_Conexao";
            this.Aba_Conexao.Padding = new System.Windows.Forms.Padding(3);
            this.Aba_Conexao.Size = new System.Drawing.Size(339, 201);
            this.Aba_Conexao.TabIndex = 0;
            this.Aba_Conexao.Text = "Conexão";
            this.Aba_Conexao.UseVisualStyleBackColor = true;
            // 
            // btn_LimparConexao
            // 
            this.btn_LimparConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LimparConexao.Location = new System.Drawing.Point(188, 153);
            this.btn_LimparConexao.Name = "btn_LimparConexao";
            this.btn_LimparConexao.Size = new System.Drawing.Size(75, 23);
            this.btn_LimparConexao.TabIndex = 6;
            this.btn_LimparConexao.Text = "Limpar";
            this.btn_LimparConexao.UseVisualStyleBackColor = true;
            this.btn_LimparConexao.Click += new System.EventHandler(this.Btn_LimparConexao_Click);
            // 
            // btn_ConectarDatabase
            // 
            this.btn_ConectarDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConectarDatabase.Location = new System.Drawing.Point(83, 153);
            this.btn_ConectarDatabase.Name = "btn_ConectarDatabase";
            this.btn_ConectarDatabase.Size = new System.Drawing.Size(75, 23);
            this.btn_ConectarDatabase.TabIndex = 5;
            this.btn_ConectarDatabase.Text = "Conectar";
            this.btn_ConectarDatabase.UseVisualStyleBackColor = true;
            this.btn_ConectarDatabase.Click += new System.EventHandler(this.Btn_ConectarDatabase_Click);
            // 
            // Conexao_Senha
            // 
            this.Conexao_Senha.Location = new System.Drawing.Point(132, 108);
            this.Conexao_Senha.Name = "Conexao_Senha";
            this.Conexao_Senha.Size = new System.Drawing.Size(131, 20);
            this.Conexao_Senha.TabIndex = 4;
            this.Conexao_Senha.UseSystemPasswordChar = true;
            // 
            // Conexao_Banco
            // 
            this.Conexao_Banco.Location = new System.Drawing.Point(132, 82);
            this.Conexao_Banco.Name = "Conexao_Banco";
            this.Conexao_Banco.Size = new System.Drawing.Size(131, 20);
            this.Conexao_Banco.TabIndex = 3;
            // 
            // Conexao_Usuario
            // 
            this.Conexao_Usuario.Location = new System.Drawing.Point(132, 56);
            this.Conexao_Usuario.Name = "Conexao_Usuario";
            this.Conexao_Usuario.Size = new System.Drawing.Size(131, 20);
            this.Conexao_Usuario.TabIndex = 2;
            // 
            // Conexao_Servidor
            // 
            this.Conexao_Servidor.Location = new System.Drawing.Point(132, 30);
            this.Conexao_Servidor.Name = "Conexao_Servidor";
            this.Conexao_Servidor.Size = new System.Drawing.Size(131, 20);
            this.Conexao_Servidor.TabIndex = 1;
            // 
            // Conexao_labelSenha
            // 
            this.Conexao_labelSenha.AutoSize = true;
            this.Conexao_labelSenha.Location = new System.Drawing.Point(85, 111);
            this.Conexao_labelSenha.Name = "Conexao_labelSenha";
            this.Conexao_labelSenha.Size = new System.Drawing.Size(41, 13);
            this.Conexao_labelSenha.TabIndex = 3;
            this.Conexao_labelSenha.Text = "Senha:";
            // 
            // Conexao_labelBanco
            // 
            this.Conexao_labelBanco.AutoSize = true;
            this.Conexao_labelBanco.Location = new System.Drawing.Point(85, 85);
            this.Conexao_labelBanco.Name = "Conexao_labelBanco";
            this.Conexao_labelBanco.Size = new System.Drawing.Size(41, 13);
            this.Conexao_labelBanco.TabIndex = 2;
            this.Conexao_labelBanco.Text = "Banco:";
            // 
            // Conexao_labelUsuario
            // 
            this.Conexao_labelUsuario.AutoSize = true;
            this.Conexao_labelUsuario.Location = new System.Drawing.Point(80, 59);
            this.Conexao_labelUsuario.Name = "Conexao_labelUsuario";
            this.Conexao_labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.Conexao_labelUsuario.TabIndex = 1;
            this.Conexao_labelUsuario.Text = "Usuario:";
            // 
            // Conexao_labelServidor
            // 
            this.Conexao_labelServidor.AutoSize = true;
            this.Conexao_labelServidor.Location = new System.Drawing.Point(46, 37);
            this.Conexao_labelServidor.Name = "Conexao_labelServidor";
            this.Conexao_labelServidor.Size = new System.Drawing.Size(80, 13);
            this.Conexao_labelServidor.TabIndex = 0;
            this.Conexao_labelServidor.Text = "Nome Servidor:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.XML_radioSat);
            this.tabPage2.Controls.Add(this.checkBox_XML_Homologacao);
            this.tabPage2.Controls.Add(this.XML_btnGerar);
            this.tabPage2.Controls.Add(this.XML_radioCTe);
            this.tabPage2.Controls.Add(this.XML_radioNFSe);
            this.tabPage2.Controls.Add(this.XML_radioMDFe);
            this.tabPage2.Controls.Add(this.XML_radioNFCe);
            this.tabPage2.Controls.Add(this.XML_radioNFe);
            this.tabPage2.Controls.Add(this.XML_Empresa);
            this.tabPage2.Controls.Add(this.XML_Serie);
            this.tabPage2.Controls.Add(this.XML_Codigo);
            this.tabPage2.Controls.Add(this.XML_labelEmpresa);
            this.tabPage2.Controls.Add(this.XML_labelSerie);
            this.tabPage2.Controls.Add(this.XML_labelCodigo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(339, 201);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XML";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // XML_radioSat
            // 
            this.XML_radioSat.AutoSize = true;
            this.XML_radioSat.Location = new System.Drawing.Point(129, 129);
            this.XML_radioSat.Name = "XML_radioSat";
            this.XML_radioSat.Size = new System.Drawing.Size(72, 17);
            this.XML_radioSat.TabIndex = 14;
            this.XML_radioSat.TabStop = true;
            this.XML_radioSat.Text = "SAT/MFe";
            this.XML_radioSat.UseVisualStyleBackColor = true;

            // 
            // checkBox_XML_Homologacao
            // 
            this.checkBox_XML_Homologacao.AutoSize = true;
            this.checkBox_XML_Homologacao.Location = new System.Drawing.Point(235, 81);
            this.checkBox_XML_Homologacao.Name = "checkBox_XML_Homologacao";
            this.checkBox_XML_Homologacao.Size = new System.Drawing.Size(92, 17);
            this.checkBox_XML_Homologacao.TabIndex = 13;
            this.checkBox_XML_Homologacao.Text = "Homologação";
            this.checkBox_XML_Homologacao.UseVisualStyleBackColor = true;
            // 
            // XML_btnGerar
            // 
            this.XML_btnGerar.Location = new System.Drawing.Point(235, 27);
            this.XML_btnGerar.Name = "XML_btnGerar";
            this.XML_btnGerar.Size = new System.Drawing.Size(85, 34);
            this.XML_btnGerar.TabIndex = 12;
            this.XML_btnGerar.Text = "Gerar";
            this.XML_btnGerar.UseVisualStyleBackColor = true;
            this.XML_btnGerar.Click += new System.EventHandler(this.XML_btnGerar_Click);
            // 
            // XML_radioCTe
            // 
            this.XML_radioCTe.AutoSize = true;
            this.XML_radioCTe.Location = new System.Drawing.Point(8, 178);
            this.XML_radioCTe.Name = "XML_radioCTe";
            this.XML_radioCTe.Size = new System.Drawing.Size(45, 17);
            this.XML_radioCTe.TabIndex = 11;
            this.XML_radioCTe.TabStop = true;
            this.XML_radioCTe.Text = "CTe";
            this.XML_radioCTe.UseVisualStyleBackColor = true;            
            // 
            // XML_radioNFSe
            // 
            this.XML_radioNFSe.AutoSize = true;
            this.XML_radioNFSe.Location = new System.Drawing.Point(281, 178);
            this.XML_radioNFSe.Name = "XML_radioNFSe";
            this.XML_radioNFSe.Size = new System.Drawing.Size(52, 17);
            this.XML_radioNFSe.TabIndex = 10;
            this.XML_radioNFSe.TabStop = true;
            this.XML_radioNFSe.Text = "NFSe";
            this.XML_radioNFSe.UseVisualStyleBackColor = true;            
            // 
            // XML_radioMDFe
            // 
            this.XML_radioMDFe.AutoSize = true;
            this.XML_radioMDFe.Location = new System.Drawing.Point(132, 178);
            this.XML_radioMDFe.Name = "XML_radioMDFe";
            this.XML_radioMDFe.Size = new System.Drawing.Size(54, 17);
            this.XML_radioMDFe.TabIndex = 9;
            this.XML_radioMDFe.TabStop = true;
            this.XML_radioMDFe.Text = "MDFe";
            this.XML_radioMDFe.UseVisualStyleBackColor = true;            
            // 
            // XML_radioNFCe
            // 
            this.XML_radioNFCe.AutoSize = true;
            this.XML_radioNFCe.Location = new System.Drawing.Point(281, 129);
            this.XML_radioNFCe.Name = "XML_radioNFCe";
            this.XML_radioNFCe.Size = new System.Drawing.Size(52, 17);
            this.XML_radioNFCe.TabIndex = 8;
            this.XML_radioNFCe.TabStop = true;
            this.XML_radioNFCe.Text = "NFCe";
            this.XML_radioNFCe.UseVisualStyleBackColor = true;            
            // 
            // XML_radioNFe
            // 
            this.XML_radioNFe.AutoSize = true;
            this.XML_radioNFe.Location = new System.Drawing.Point(8, 129);
            this.XML_radioNFe.Name = "XML_radioNFe";
            this.XML_radioNFe.Size = new System.Drawing.Size(45, 17);
            this.XML_radioNFe.TabIndex = 7;
            this.XML_radioNFe.TabStop = true;
            this.XML_radioNFe.Text = "NFe";
            this.XML_radioNFe.UseVisualStyleBackColor = true;
            // 
            // XML_Empresa
            // 
            this.XML_Empresa.Location = new System.Drawing.Point(111, 83);
            this.XML_Empresa.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.XML_Empresa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XML_Empresa.Name = "XML_Empresa";
            this.XML_Empresa.Size = new System.Drawing.Size(101, 20);
            this.XML_Empresa.TabIndex = 6;
            this.XML_Empresa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // XML_Serie
            // 
            this.XML_Serie.Location = new System.Drawing.Point(111, 52);
            this.XML_Serie.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.XML_Serie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XML_Serie.Name = "XML_Serie";
            this.XML_Serie.Size = new System.Drawing.Size(101, 20);
            this.XML_Serie.TabIndex = 5;
            this.XML_Serie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // XML_Codigo
            // 
            this.XML_Codigo.Location = new System.Drawing.Point(111, 19);
            this.XML_Codigo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.XML_Codigo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XML_Codigo.Name = "XML_Codigo";
            this.XML_Codigo.Size = new System.Drawing.Size(101, 20);
            this.XML_Codigo.TabIndex = 4;
            this.XML_Codigo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // XML_labelEmpresa
            // 
            this.XML_labelEmpresa.AutoSize = true;
            this.XML_labelEmpresa.Location = new System.Drawing.Point(54, 85);
            this.XML_labelEmpresa.Name = "XML_labelEmpresa";
            this.XML_labelEmpresa.Size = new System.Drawing.Size(51, 13);
            this.XML_labelEmpresa.TabIndex = 2;
            this.XML_labelEmpresa.Text = "Empresa:";
            // 
            // XML_labelSerie
            // 
            this.XML_labelSerie.AutoSize = true;
            this.XML_labelSerie.Location = new System.Drawing.Point(14, 52);
            this.XML_labelSerie.Name = "XML_labelSerie";
            this.XML_labelSerie.Size = new System.Drawing.Size(91, 13);
            this.XML_labelSerie.TabIndex = 1;
            this.XML_labelSerie.Text = "Serie/Codigo Sat:";
            // 
            // XML_labelCodigo
            // 
            this.XML_labelCodigo.AutoSize = true;
            this.XML_labelCodigo.Location = new System.Drawing.Point(62, 19);
            this.XML_labelCodigo.Name = "XML_labelCodigo";
            this.XML_labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.XML_labelCodigo.TabIndex = 0;
            this.XML_labelCodigo.Text = "Código:";
            // 
            // Diversos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 230);
            this.Controls.Add(this.tabAbas);
            this.MaximizeBox = false;
            this.Name = "Diversos";
            this.Text = "App Diversos/OS";
            this.tabAbas.ResumeLayout(false);
            this.Aba_Conexao.ResumeLayout(false);
            this.Aba_Conexao.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XML_Empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XML_Serie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XML_Codigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAbas;
        private System.Windows.Forms.TabPage Aba_Conexao;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Conexao_labelUsuario;
        private System.Windows.Forms.Label Conexao_labelServidor;
        private System.Windows.Forms.TextBox Conexao_Servidor;
        private System.Windows.Forms.Label Conexao_labelSenha;
        private System.Windows.Forms.Label Conexao_labelBanco;
        private System.Windows.Forms.TextBox Conexao_Senha;
        private System.Windows.Forms.TextBox Conexao_Banco;
        private System.Windows.Forms.TextBox Conexao_Usuario;
        private System.Windows.Forms.Button btn_LimparConexao;
        private System.Windows.Forms.Button btn_ConectarDatabase;
        private System.Windows.Forms.Label XML_labelEmpresa;
        private System.Windows.Forms.Label XML_labelSerie;
        private System.Windows.Forms.Label XML_labelCodigo;
        private System.Windows.Forms.NumericUpDown XML_Empresa;
        private System.Windows.Forms.NumericUpDown XML_Serie;
        private System.Windows.Forms.NumericUpDown XML_Codigo;
        private System.Windows.Forms.Button XML_btnGerar;
        private System.Windows.Forms.RadioButton XML_radioCTe;
        private System.Windows.Forms.RadioButton XML_radioNFSe;
        private System.Windows.Forms.RadioButton XML_radioMDFe;
        private System.Windows.Forms.RadioButton XML_radioNFCe;
        private System.Windows.Forms.RadioButton XML_radioNFe;
        private System.Windows.Forms.CheckBox checkBox_XML_Homologacao;
        private System.Windows.Forms.RadioButton XML_radioSat;
    }
}

