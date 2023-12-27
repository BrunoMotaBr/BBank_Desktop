using System.Windows.Forms;

namespace BBank_Desktop2.Formulario

{
    partial class Form_Buscar_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Buscar_Clientes));
            this.groupBox_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_DataNacimento = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Renda = new System.Windows.Forms.TextBox();
            this.textBox_CPF = new System.Windows.Forms.TextBox();
            this.textBox_telefone = new System.Windows.Forms.TextBox();
            this.textBox_NomeDaMae = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.label_Sexo = new System.Windows.Forms.Label();
            this.comboBox_Sexo = new System.Windows.Forms.ComboBox();
            this.label_DataNacimento = new System.Windows.Forms.Label();
            this.label_Renda = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_NomeDaMae = new System.Windows.Forms.Label();
            this.label_Telefone = new System.Windows.Forms.Label();
            this.groupBox_Endereco = new System.Windows.Forms.GroupBox();
            this.label_Cep = new System.Windows.Forms.Label();
            this.textBox_Complemento = new System.Windows.Forms.TextBox();
            this.label_Complemento = new System.Windows.Forms.Label();
            this.textBox_cep = new System.Windows.Forms.TextBox();
            this.textBox_Numero = new System.Windows.Forms.TextBox();
            this.textBox_Cidade = new System.Windows.Forms.TextBox();
            this.textBox_Bairro = new System.Windows.Forms.TextBox();
            this.textBox_Rua = new System.Windows.Forms.TextBox();
            this.label_Numero = new System.Windows.Forms.Label();
            this.label_UF = new System.Windows.Forms.Label();
            this.comboBox_Estado = new System.Windows.Forms.ComboBox();
            this.label_Rua = new System.Windows.Forms.Label();
            this.label_Bairro = new System.Windows.Forms.Label();
            this.label_Cidade = new System.Windows.Forms.Label();
            this.label_APPInfo = new System.Windows.Forms.Label();
            this.button_Salvar_Altecacao = new System.Windows.Forms.Button();
            this.button_Alteracao = new System.Windows.Forms.Button();
            this.label_Conta = new System.Windows.Forms.Label();
            this.label_Agencia = new System.Windows.Forms.Label();
            this.label_NumAgencia = new System.Windows.Forms.Label();
            this.label_NumConta = new System.Windows.Forms.Label();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.groupBox_DadosPessoais.SuspendLayout();
            this.groupBox_Endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DadosPessoais
            // 
            this.groupBox_DadosPessoais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_DadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_DadosPessoais.Controls.Add(this.maskedTextBox_DataNacimento);
            this.groupBox_DadosPessoais.Controls.Add(this.textBox_Renda);
            this.groupBox_DadosPessoais.Controls.Add(this.textBox_CPF);
            this.groupBox_DadosPessoais.Controls.Add(this.textBox_telefone);
            this.groupBox_DadosPessoais.Controls.Add(this.textBox_NomeDaMae);
            this.groupBox_DadosPessoais.Controls.Add(this.textBox_Nome);
            this.groupBox_DadosPessoais.Controls.Add(this.label_Sexo);
            this.groupBox_DadosPessoais.Controls.Add(this.comboBox_Sexo);
            this.groupBox_DadosPessoais.Controls.Add(this.label_DataNacimento);
            this.groupBox_DadosPessoais.Controls.Add(this.label_Renda);
            this.groupBox_DadosPessoais.Controls.Add(this.label_CPF);
            this.groupBox_DadosPessoais.Controls.Add(this.label_Nome);
            this.groupBox_DadosPessoais.Controls.Add(this.label_NomeDaMae);
            this.groupBox_DadosPessoais.Controls.Add(this.label_Telefone);
            this.groupBox_DadosPessoais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_DadosPessoais.Location = new System.Drawing.Point(11, 36);
            this.groupBox_DadosPessoais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_DadosPessoais.Name = "groupBox_DadosPessoais";
            this.groupBox_DadosPessoais.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_DadosPessoais.Size = new System.Drawing.Size(375, 297);
            this.groupBox_DadosPessoais.TabIndex = 0;
            this.groupBox_DadosPessoais.TabStop = false;
            this.groupBox_DadosPessoais.Text = "Dados Pessoais";
            // 
            // maskedTextBox_DataNacimento
            // 
            this.maskedTextBox_DataNacimento.Location = new System.Drawing.Point(234, 208);
            this.maskedTextBox_DataNacimento.Mask = "00/00/0000";
            this.maskedTextBox_DataNacimento.Name = "maskedTextBox_DataNacimento";
            this.maskedTextBox_DataNacimento.Size = new System.Drawing.Size(77, 22);
            this.maskedTextBox_DataNacimento.TabIndex = 36;
            // 
            // textBox_Renda
            // 
            this.textBox_Renda.Location = new System.Drawing.Point(16, 207);
            this.textBox_Renda.Name = "textBox_Renda";
            this.textBox_Renda.Size = new System.Drawing.Size(211, 22);
            this.textBox_Renda.TabIndex = 35;
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Location = new System.Drawing.Point(16, 163);
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(295, 22);
            this.textBox_CPF.TabIndex = 34;
            // 
            // textBox_telefone
            // 
            this.textBox_telefone.Location = new System.Drawing.Point(16, 121);
            this.textBox_telefone.Name = "textBox_telefone";
            this.textBox_telefone.Size = new System.Drawing.Size(295, 22);
            this.textBox_telefone.TabIndex = 33;
            // 
            // textBox_NomeDaMae
            // 
            this.textBox_NomeDaMae.Location = new System.Drawing.Point(16, 79);
            this.textBox_NomeDaMae.Name = "textBox_NomeDaMae";
            this.textBox_NomeDaMae.Size = new System.Drawing.Size(295, 22);
            this.textBox_NomeDaMae.TabIndex = 32;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(16, 36);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(233, 22);
            this.textBox_Nome.TabIndex = 31;
            // 
            // label_Sexo
            // 
            this.label_Sexo.AutoSize = true;
            this.label_Sexo.Location = new System.Drawing.Point(256, 17);
            this.label_Sexo.Name = "label_Sexo";
            this.label_Sexo.Size = new System.Drawing.Size(44, 16);
            this.label_Sexo.TabIndex = 30;
            this.label_Sexo.Text = "label1";
            // 
            // comboBox_Sexo
            // 
            this.comboBox_Sexo.FormattingEnabled = true;
            this.comboBox_Sexo.Location = new System.Drawing.Point(256, 36);
            this.comboBox_Sexo.Name = "comboBox_Sexo";
            this.comboBox_Sexo.Size = new System.Drawing.Size(55, 24);
            this.comboBox_Sexo.TabIndex = 29;
            // 
            // label_DataNacimento
            // 
            this.label_DataNacimento.AutoSize = true;
            this.label_DataNacimento.Location = new System.Drawing.Point(234, 190);
            this.label_DataNacimento.Name = "label_DataNacimento";
            this.label_DataNacimento.Size = new System.Drawing.Size(44, 16);
            this.label_DataNacimento.TabIndex = 28;
            this.label_DataNacimento.Text = "label6";
            // 
            // label_Renda
            // 
            this.label_Renda.AutoSize = true;
            this.label_Renda.Location = new System.Drawing.Point(15, 190);
            this.label_Renda.Name = "label_Renda";
            this.label_Renda.Size = new System.Drawing.Size(44, 16);
            this.label_Renda.TabIndex = 26;
            this.label_Renda.Text = "label4";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Location = new System.Drawing.Point(15, 144);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(44, 16);
            this.label_CPF.TabIndex = 24;
            this.label_CPF.Text = "label1";
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(15, 18);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(44, 16);
            this.label_Nome.TabIndex = 16;
            this.label_Nome.Text = "label2";
            // 
            // label_NomeDaMae
            // 
            this.label_NomeDaMae.AutoSize = true;
            this.label_NomeDaMae.Location = new System.Drawing.Point(15, 60);
            this.label_NomeDaMae.Name = "label_NomeDaMae";
            this.label_NomeDaMae.Size = new System.Drawing.Size(44, 16);
            this.label_NomeDaMae.TabIndex = 14;
            this.label_NomeDaMae.Text = "label1";
            // 
            // label_Telefone
            // 
            this.label_Telefone.AutoSize = true;
            this.label_Telefone.Location = new System.Drawing.Point(15, 102);
            this.label_Telefone.Name = "label_Telefone";
            this.label_Telefone.Size = new System.Drawing.Size(44, 16);
            this.label_Telefone.TabIndex = 12;
            this.label_Telefone.Text = "label5";
            // 
            // groupBox_Endereco
            // 
            this.groupBox_Endereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox_Endereco.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Endereco.Controls.Add(this.label_Cep);
            this.groupBox_Endereco.Controls.Add(this.textBox_Complemento);
            this.groupBox_Endereco.Controls.Add(this.label_Complemento);
            this.groupBox_Endereco.Controls.Add(this.textBox_cep);
            this.groupBox_Endereco.Controls.Add(this.textBox_Numero);
            this.groupBox_Endereco.Controls.Add(this.textBox_Cidade);
            this.groupBox_Endereco.Controls.Add(this.textBox_Bairro);
            this.groupBox_Endereco.Controls.Add(this.textBox_Rua);
            this.groupBox_Endereco.Controls.Add(this.label_Numero);
            this.groupBox_Endereco.Controls.Add(this.label_UF);
            this.groupBox_Endereco.Controls.Add(this.comboBox_Estado);
            this.groupBox_Endereco.Controls.Add(this.label_Rua);
            this.groupBox_Endereco.Controls.Add(this.label_Bairro);
            this.groupBox_Endereco.Controls.Add(this.label_Cidade);
            this.groupBox_Endereco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_Endereco.Location = new System.Drawing.Point(433, 36);
            this.groupBox_Endereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Endereco.Name = "groupBox_Endereco";
            this.groupBox_Endereco.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Endereco.Size = new System.Drawing.Size(375, 217);
            this.groupBox_Endereco.TabIndex = 17;
            this.groupBox_Endereco.TabStop = false;
            this.groupBox_Endereco.Text = "Endereço";
            // 
            // label_Cep
            // 
            this.label_Cep.AutoSize = true;
            this.label_Cep.Location = new System.Drawing.Point(166, 60);
            this.label_Cep.Name = "label_Cep";
            this.label_Cep.Size = new System.Drawing.Size(51, 16);
            this.label_Cep.TabIndex = 32;
            this.label_Cep.Text = "label11";
            // 
            // textBox_Complemento
            // 
            this.textBox_Complemento.Location = new System.Drawing.Point(15, 163);
            this.textBox_Complemento.Name = "textBox_Complemento";
            this.textBox_Complemento.Size = new System.Drawing.Size(297, 22);
            this.textBox_Complemento.TabIndex = 31;
            // 
            // label_Complemento
            // 
            this.label_Complemento.AutoSize = true;
            this.label_Complemento.Location = new System.Drawing.Point(15, 147);
            this.label_Complemento.Name = "label_Complemento";
            this.label_Complemento.Size = new System.Drawing.Size(51, 16);
            this.label_Complemento.TabIndex = 30;
            this.label_Complemento.Text = "label10";
            // 
            // textBox_cep
            // 
            this.textBox_cep.Location = new System.Drawing.Point(166, 74);
            this.textBox_cep.Name = "textBox_cep";
            this.textBox_cep.Size = new System.Drawing.Size(146, 22);
            this.textBox_cep.TabIndex = 29;
            this.textBox_cep.Leave += new System.EventHandler(this.textBox_cep_Leave);
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Location = new System.Drawing.Point(239, 119);
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.Size = new System.Drawing.Size(77, 22);
            this.textBox_Numero.TabIndex = 28;
            // 
            // textBox_Cidade
            // 
            this.textBox_Cidade.Location = new System.Drawing.Point(15, 119);
            this.textBox_Cidade.Name = "textBox_Cidade";
            this.textBox_Cidade.Size = new System.Drawing.Size(143, 22);
            this.textBox_Cidade.TabIndex = 27;
            // 
            // textBox_Bairro
            // 
            this.textBox_Bairro.Location = new System.Drawing.Point(15, 74);
            this.textBox_Bairro.Name = "textBox_Bairro";
            this.textBox_Bairro.Size = new System.Drawing.Size(143, 22);
            this.textBox_Bairro.TabIndex = 26;
            // 
            // textBox_Rua
            // 
            this.textBox_Rua.Location = new System.Drawing.Point(15, 32);
            this.textBox_Rua.Name = "textBox_Rua";
            this.textBox_Rua.Size = new System.Drawing.Size(297, 22);
            this.textBox_Rua.TabIndex = 25;
            // 
            // label_Numero
            // 
            this.label_Numero.AutoSize = true;
            this.label_Numero.Location = new System.Drawing.Point(239, 102);
            this.label_Numero.Name = "label_Numero";
            this.label_Numero.Size = new System.Drawing.Size(51, 16);
            this.label_Numero.TabIndex = 20;
            this.label_Numero.Text = "label12";
            // 
            // label_UF
            // 
            this.label_UF.AutoSize = true;
            this.label_UF.Location = new System.Drawing.Point(166, 102);
            this.label_UF.Name = "label_UF";
            this.label_UF.Size = new System.Drawing.Size(51, 16);
            this.label_UF.TabIndex = 18;
            this.label_UF.Text = "label12";
            // 
            // comboBox_Estado
            // 
            this.comboBox_Estado.FormattingEnabled = true;
            this.comboBox_Estado.Location = new System.Drawing.Point(166, 119);
            this.comboBox_Estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Estado.Name = "comboBox_Estado";
            this.comboBox_Estado.Size = new System.Drawing.Size(67, 24);
            this.comboBox_Estado.TabIndex = 17;
            // 
            // label_Rua
            // 
            this.label_Rua.AutoSize = true;
            this.label_Rua.Location = new System.Drawing.Point(15, 18);
            this.label_Rua.Name = "label_Rua";
            this.label_Rua.Size = new System.Drawing.Size(51, 16);
            this.label_Rua.TabIndex = 16;
            this.label_Rua.Text = "label10";
            // 
            // label_Bairro
            // 
            this.label_Bairro.AutoSize = true;
            this.label_Bairro.Location = new System.Drawing.Point(15, 60);
            this.label_Bairro.Name = "label_Bairro";
            this.label_Bairro.Size = new System.Drawing.Size(51, 16);
            this.label_Bairro.TabIndex = 14;
            this.label_Bairro.Text = "label11";
            // 
            // label_Cidade
            // 
            this.label_Cidade.AutoSize = true;
            this.label_Cidade.Location = new System.Drawing.Point(15, 102);
            this.label_Cidade.Name = "label_Cidade";
            this.label_Cidade.Size = new System.Drawing.Size(51, 16);
            this.label_Cidade.TabIndex = 12;
            this.label_Cidade.Text = "label12";
            // 
            // label_APPInfo
            // 
            this.label_APPInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_APPInfo.AutoSize = true;
            this.label_APPInfo.BackColor = System.Drawing.Color.Transparent;
            this.label_APPInfo.ForeColor = System.Drawing.Color.Black;
            this.label_APPInfo.Location = new System.Drawing.Point(27, 7);
            this.label_APPInfo.Name = "label_APPInfo";
            this.label_APPInfo.Size = new System.Drawing.Size(44, 16);
            this.label_APPInfo.TabIndex = 18;
            this.label_APPInfo.Text = "label1";
            // 
            // button_Salvar_Altecacao
            // 
            this.button_Salvar_Altecacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Salvar_Altecacao.BackColor = System.Drawing.Color.Chartreuse;
            this.button_Salvar_Altecacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Salvar_Altecacao.Location = new System.Drawing.Point(439, 270);
            this.button_Salvar_Altecacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Salvar_Altecacao.Name = "button_Salvar_Altecacao";
            this.button_Salvar_Altecacao.Size = new System.Drawing.Size(144, 23);
            this.button_Salvar_Altecacao.TabIndex = 23;
            this.button_Salvar_Altecacao.Text = "button1";
            this.button_Salvar_Altecacao.UseVisualStyleBackColor = false;
            this.button_Salvar_Altecacao.Click += new System.EventHandler(this.button_Salvar_Altecacao_Click);
            // 
            // button_Alteracao
            // 
            this.button_Alteracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Alteracao.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Alteracao.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.button_Alteracao.ForeColor = System.Drawing.Color.White;
            this.button_Alteracao.Location = new System.Drawing.Point(735, 3);
            this.button_Alteracao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Alteracao.Name = "button_Alteracao";
            this.button_Alteracao.Size = new System.Drawing.Size(94, 29);
            this.button_Alteracao.TabIndex = 24;
            this.button_Alteracao.Text = "button1";
            this.button_Alteracao.UseVisualStyleBackColor = false;
            this.button_Alteracao.Click += new System.EventHandler(this.button_Alteracao_Click);
            // 
            // label_Conta
            // 
            this.label_Conta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Conta.AutoSize = true;
            this.label_Conta.BackColor = System.Drawing.Color.Transparent;
            this.label_Conta.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label_Conta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Conta.Location = new System.Drawing.Point(638, 260);
            this.label_Conta.Name = "label_Conta";
            this.label_Conta.Size = new System.Drawing.Size(65, 32);
            this.label_Conta.TabIndex = 25;
            this.label_Conta.Text = "label";
            // 
            // label_Agencia
            // 
            this.label_Agencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Agencia.AutoSize = true;
            this.label_Agencia.BackColor = System.Drawing.Color.Transparent;
            this.label_Agencia.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label_Agencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Agencia.Location = new System.Drawing.Point(638, 305);
            this.label_Agencia.Name = "label_Agencia";
            this.label_Agencia.Size = new System.Drawing.Size(65, 32);
            this.label_Agencia.TabIndex = 26;
            this.label_Agencia.Text = "label";
            // 
            // label_NumAgencia
            // 
            this.label_NumAgencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NumAgencia.AutoSize = true;
            this.label_NumAgencia.BackColor = System.Drawing.Color.Transparent;
            this.label_NumAgencia.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label_NumAgencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_NumAgencia.Location = new System.Drawing.Point(738, 305);
            this.label_NumAgencia.Name = "label_NumAgencia";
            this.label_NumAgencia.Size = new System.Drawing.Size(65, 32);
            this.label_NumAgencia.TabIndex = 28;
            this.label_NumAgencia.Text = "label";
            // 
            // label_NumConta
            // 
            this.label_NumConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NumConta.AutoSize = true;
            this.label_NumConta.BackColor = System.Drawing.Color.Transparent;
            this.label_NumConta.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label_NumConta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_NumConta.Location = new System.Drawing.Point(738, 260);
            this.label_NumConta.Name = "label_NumConta";
            this.label_NumConta.Size = new System.Drawing.Size(65, 32);
            this.label_NumConta.TabIndex = 27;
            this.label_NumConta.Text = "label";
            // 
            // button_Excluir
            // 
            this.button_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Excluir.BackColor = System.Drawing.Color.Red;
            this.button_Excluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Excluir.Location = new System.Drawing.Point(439, 303);
            this.button_Excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Excluir.Name = "button_Excluir";
            this.button_Excluir.Size = new System.Drawing.Size(144, 23);
            this.button_Excluir.TabIndex = 29;
            this.button_Excluir.Text = "button1";
            this.button_Excluir.UseVisualStyleBackColor = false;
            this.button_Excluir.Click += new System.EventHandler(this.button_Excluir_Click);
            // 
            // Form_Buscar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(841, 342);
            this.Controls.Add(this.button_Excluir);
            this.Controls.Add(this.label_NumAgencia);
            this.Controls.Add(this.label_NumConta);
            this.Controls.Add(this.label_Agencia);
            this.Controls.Add(this.label_Conta);
            this.Controls.Add(this.button_Alteracao);
            this.Controls.Add(this.button_Salvar_Altecacao);
            this.Controls.Add(this.label_APPInfo);
            this.Controls.Add(this.groupBox_Endereco);
            this.Controls.Add(this.groupBox_DadosPessoais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Buscar_Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form_Buscar_Clientes_Load);
            this.groupBox_DadosPessoais.ResumeLayout(false);
            this.groupBox_DadosPessoais.PerformLayout();
            this.groupBox_Endereco.ResumeLayout(false);
            this.groupBox_Endereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox_DadosPessoais;
        private Label label_Nome;
        private Label label_NomeDaMae;
        private Label label_Telefone;
        private GroupBox groupBox_Endereco;
        private Label label_Rua;
        private Label label_Bairro;
        private Label label_Cidade;
        private Label label_Numero;
        private Label label_UF;
        private ComboBox comboBox_Estado;
        private Label label_CPF;
        private Label label_DataNacimento;
        private Label label_Renda;
        private Label label_APPInfo;
        private Button button_Salvar_Altecacao;
        private Button button_Alteracao;
        private ComboBox comboBox_Sexo;
        private Label label_Sexo;
        private TextBox textBox_NomeDaMae;
        private TextBox textBox_Nome;
        private TextBox textBox_Numero;
        private TextBox textBox_Cidade;
        private TextBox textBox_Bairro;
        private TextBox textBox_Rua;
        private MaskedTextBox maskedTextBox_DataNacimento;
        private TextBox textBox_Renda;
        private TextBox textBox_CPF;
        private TextBox textBox_telefone;
        private TextBox textBox_cep;
        private TextBox textBox_Complemento;
        private Label label_Complemento;
        private Label label_Cep;
        private Label label_Conta;
        private Label label_Agencia;
        private Label label_NumAgencia;
        private Label label_NumConta;
        private Button button_Excluir;
    }
}