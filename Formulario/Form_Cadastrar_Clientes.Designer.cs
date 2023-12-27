using System.Windows.Forms;

namespace BBank_Desktop2.Formulario

{
    partial class Form_Cadastrar_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastrar_Clientes));
            this.button_Cep = new System.Windows.Forms.Button();
            this.groupBox_Endereco = new System.Windows.Forms.GroupBox();
            this.textBox_Bairro = new System.Windows.Forms.TextBox();
            this.label_Bairro = new System.Windows.Forms.Label();
            this.textBox_Complemento = new System.Windows.Forms.TextBox();
            this.label_Complemento = new System.Windows.Forms.Label();
            this.label_Estado = new System.Windows.Forms.Label();
            this.comboBox_Estado = new System.Windows.Forms.ComboBox();
            this.checkBox_Cep = new System.Windows.Forms.CheckBox();
            this.textBox_Numero = new System.Windows.Forms.TextBox();
            this.label_Numero = new System.Windows.Forms.Label();
            this.textBox_Cidade = new System.Windows.Forms.TextBox();
            this.label_Cidade = new System.Windows.Forms.Label();
            this.textBox_Rua = new System.Windows.Forms.TextBox();
            this.label_Rua = new System.Windows.Forms.Label();
            this.label_CEP = new System.Windows.Forms.Label();
            this.textBox_CEP = new System.Windows.Forms.TextBox();
            this.groupBox_Dados_Pessoais = new System.Windows.Forms.GroupBox();
            this.label_Valida_CPF = new System.Windows.Forms.Label();
            this.textBox_CPF = new System.Windows.Forms.TextBox();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_Data_Nascimento = new System.Windows.Forms.Label();
            this.maskedTextBox_Data_Nascimento = new System.Windows.Forms.MaskedTextBox();
            this.label_Renda_Familiar = new System.Windows.Forms.Label();
            this.textBox_Renda = new System.Windows.Forms.TextBox();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.label_Tel = new System.Windows.Forms.Label();
            this.label_Sexo = new System.Windows.Forms.Label();
            this.textBox_Nome_da_Mae = new System.Windows.Forms.TextBox();
            this.comboBox_Sexo = new System.Windows.Forms.ComboBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.label_Nome_da_Mae = new System.Windows.Forms.Label();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.label_Data = new System.Windows.Forms.Label();
            this.groupBox_Conta_Agencia = new System.Windows.Forms.GroupBox();
            this.label_Agencia1 = new System.Windows.Forms.Label();
            this.label_Conta1 = new System.Windows.Forms.Label();
            this.label_Conta = new System.Windows.Forms.Label();
            this.label_Agencia = new System.Windows.Forms.Label();
            this.button_Gerar_Conta = new System.Windows.Forms.Button();
            this.button_finalizar = new System.Windows.Forms.Button();
            this.groupBox_Endereco.SuspendLayout();
            this.groupBox_Dados_Pessoais.SuspendLayout();
            this.groupBox_Conta_Agencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Cep
            // 
            this.button_Cep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cep.ForeColor = System.Drawing.Color.Black;
            this.button_Cep.Location = new System.Drawing.Point(165, 23);
            this.button_Cep.Name = "button_Cep";
            this.button_Cep.Size = new System.Drawing.Size(101, 25);
            this.button_Cep.TabIndex = 0;
            this.button_Cep.Text = "Buscar CEP";
            this.button_Cep.UseVisualStyleBackColor = true;
            this.button_Cep.Click += new System.EventHandler(this.button_Cep_Click);
            // 
            // groupBox_Endereco
            // 
            this.groupBox_Endereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Endereco.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Endereco.Controls.Add(this.textBox_Bairro);
            this.groupBox_Endereco.Controls.Add(this.label_Bairro);
            this.groupBox_Endereco.Controls.Add(this.textBox_Complemento);
            this.groupBox_Endereco.Controls.Add(this.label_Complemento);
            this.groupBox_Endereco.Controls.Add(this.label_Estado);
            this.groupBox_Endereco.Controls.Add(this.comboBox_Estado);
            this.groupBox_Endereco.Controls.Add(this.checkBox_Cep);
            this.groupBox_Endereco.Controls.Add(this.textBox_Numero);
            this.groupBox_Endereco.Controls.Add(this.label_Numero);
            this.groupBox_Endereco.Controls.Add(this.textBox_Cidade);
            this.groupBox_Endereco.Controls.Add(this.label_Cidade);
            this.groupBox_Endereco.Controls.Add(this.textBox_Rua);
            this.groupBox_Endereco.Controls.Add(this.label_Rua);
            this.groupBox_Endereco.Controls.Add(this.label_CEP);
            this.groupBox_Endereco.Controls.Add(this.textBox_CEP);
            this.groupBox_Endereco.Controls.Add(this.button_Cep);
            this.groupBox_Endereco.ForeColor = System.Drawing.Color.White;
            this.groupBox_Endereco.Location = new System.Drawing.Point(426, 4);
            this.groupBox_Endereco.Name = "groupBox_Endereco";
            this.groupBox_Endereco.Size = new System.Drawing.Size(474, 141);
            this.groupBox_Endereco.TabIndex = 1;
            this.groupBox_Endereco.TabStop = false;
            this.groupBox_Endereco.Text = "Endereço";
            // 
            // textBox_Bairro
            // 
            this.textBox_Bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Bairro.ForeColor = System.Drawing.Color.Black;
            this.textBox_Bairro.Location = new System.Drawing.Point(272, 105);
            this.textBox_Bairro.Name = "textBox_Bairro";
            this.textBox_Bairro.Size = new System.Drawing.Size(74, 22);
            this.textBox_Bairro.TabIndex = 15;
            // 
            // label_Bairro
            // 
            this.label_Bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Bairro.AutoSize = true;
            this.label_Bairro.ForeColor = System.Drawing.Color.White;
            this.label_Bairro.Location = new System.Drawing.Point(222, 108);
            this.label_Bairro.Name = "label_Bairro";
            this.label_Bairro.Size = new System.Drawing.Size(43, 16);
            this.label_Bairro.TabIndex = 14;
            this.label_Bairro.Text = "Bairro";
            // 
            // textBox_Complemento
            // 
            this.textBox_Complemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Complemento.ForeColor = System.Drawing.Color.Black;
            this.textBox_Complemento.Location = new System.Drawing.Point(133, 105);
            this.textBox_Complemento.Name = "textBox_Complemento";
            this.textBox_Complemento.Size = new System.Drawing.Size(74, 22);
            this.textBox_Complemento.TabIndex = 13;
            // 
            // label_Complemento
            // 
            this.label_Complemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Complemento.AutoSize = true;
            this.label_Complemento.ForeColor = System.Drawing.Color.White;
            this.label_Complemento.Location = new System.Drawing.Point(19, 108);
            this.label_Complemento.Name = "label_Complemento";
            this.label_Complemento.Size = new System.Drawing.Size(91, 16);
            this.label_Complemento.TabIndex = 12;
            this.label_Complemento.Text = "Complemento";
            // 
            // label_Estado
            // 
            this.label_Estado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Estado.AutoSize = true;
            this.label_Estado.ForeColor = System.Drawing.Color.White;
            this.label_Estado.Location = new System.Drawing.Point(363, 108);
            this.label_Estado.Name = "label_Estado";
            this.label_Estado.Size = new System.Drawing.Size(44, 16);
            this.label_Estado.TabIndex = 11;
            this.label_Estado.Text = "label2";
            // 
            // comboBox_Estado
            // 
            this.comboBox_Estado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Estado.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Estado.FormattingEnabled = true;
            this.comboBox_Estado.Location = new System.Drawing.Point(399, 105);
            this.comboBox_Estado.Name = "comboBox_Estado";
            this.comboBox_Estado.Size = new System.Drawing.Size(68, 24);
            this.comboBox_Estado.TabIndex = 10;
            // 
            // checkBox_Cep
            // 
            this.checkBox_Cep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Cep.AutoSize = true;
            this.checkBox_Cep.ForeColor = System.Drawing.Color.White;
            this.checkBox_Cep.Location = new System.Drawing.Point(13, 68);
            this.checkBox_Cep.Name = "checkBox_Cep";
            this.checkBox_Cep.Size = new System.Drawing.Size(95, 20);
            this.checkBox_Cep.TabIndex = 9;
            this.checkBox_Cep.Text = "checkBox1";
            this.checkBox_Cep.UseVisualStyleBackColor = true;
            this.checkBox_Cep.CheckedChanged += new System.EventHandler(this.checkBox_CPF_CheckedChanged);
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Numero.ForeColor = System.Drawing.Color.Black;
            this.textBox_Numero.Location = new System.Drawing.Point(181, 64);
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.Size = new System.Drawing.Size(100, 22);
            this.textBox_Numero.TabIndex = 8;
            // 
            // label_Numero
            // 
            this.label_Numero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Numero.AutoSize = true;
            this.label_Numero.ForeColor = System.Drawing.Color.White;
            this.label_Numero.Location = new System.Drawing.Point(114, 68);
            this.label_Numero.Name = "label_Numero";
            this.label_Numero.Size = new System.Drawing.Size(44, 16);
            this.label_Numero.TabIndex = 7;
            this.label_Numero.Text = "label3";
            // 
            // textBox_Cidade
            // 
            this.textBox_Cidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Cidade.ForeColor = System.Drawing.Color.Black;
            this.textBox_Cidade.Location = new System.Drawing.Point(349, 64);
            this.textBox_Cidade.Name = "textBox_Cidade";
            this.textBox_Cidade.Size = new System.Drawing.Size(118, 22);
            this.textBox_Cidade.TabIndex = 6;
            // 
            // label_Cidade
            // 
            this.label_Cidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Cidade.AutoSize = true;
            this.label_Cidade.ForeColor = System.Drawing.Color.White;
            this.label_Cidade.Location = new System.Drawing.Point(288, 68);
            this.label_Cidade.Name = "label_Cidade";
            this.label_Cidade.Size = new System.Drawing.Size(44, 16);
            this.label_Cidade.TabIndex = 5;
            this.label_Cidade.Text = "label2";
            // 
            // textBox_Rua
            // 
            this.textBox_Rua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Rua.ForeColor = System.Drawing.Color.Black;
            this.textBox_Rua.Location = new System.Drawing.Point(322, 23);
            this.textBox_Rua.Name = "textBox_Rua";
            this.textBox_Rua.Size = new System.Drawing.Size(145, 22);
            this.textBox_Rua.TabIndex = 4;
            // 
            // label_Rua
            // 
            this.label_Rua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Rua.AutoSize = true;
            this.label_Rua.ForeColor = System.Drawing.Color.White;
            this.label_Rua.Location = new System.Drawing.Point(272, 28);
            this.label_Rua.Name = "label_Rua";
            this.label_Rua.Size = new System.Drawing.Size(44, 16);
            this.label_Rua.TabIndex = 3;
            this.label_Rua.Text = "label1";
            // 
            // label_CEP
            // 
            this.label_CEP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CEP.AutoSize = true;
            this.label_CEP.ForeColor = System.Drawing.Color.White;
            this.label_CEP.Location = new System.Drawing.Point(7, 28);
            this.label_CEP.Name = "label_CEP";
            this.label_CEP.Size = new System.Drawing.Size(37, 16);
            this.label_CEP.TabIndex = 2;
            this.label_CEP.Text = "CEP:";
            // 
            // textBox_CEP
            // 
            this.textBox_CEP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CEP.ForeColor = System.Drawing.Color.Black;
            this.textBox_CEP.Location = new System.Drawing.Point(43, 23);
            this.textBox_CEP.Name = "textBox_CEP";
            this.textBox_CEP.Size = new System.Drawing.Size(114, 22);
            this.textBox_CEP.TabIndex = 1;
            // 
            // groupBox_Dados_Pessoais
            // 
            this.groupBox_Dados_Pessoais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Dados_Pessoais.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Valida_CPF);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_CPF);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_CPF);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Data_Nascimento);
            this.groupBox_Dados_Pessoais.Controls.Add(this.maskedTextBox_Data_Nascimento);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Renda_Familiar);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_Renda);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_Tel);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Tel);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Sexo);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_Nome_da_Mae);
            this.groupBox_Dados_Pessoais.Controls.Add(this.comboBox_Sexo);
            this.groupBox_Dados_Pessoais.Controls.Add(this.textBox_Nome);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Nome_da_Mae);
            this.groupBox_Dados_Pessoais.Controls.Add(this.label_Nome);
            this.groupBox_Dados_Pessoais.ForeColor = System.Drawing.Color.White;
            this.groupBox_Dados_Pessoais.Location = new System.Drawing.Point(14, 4);
            this.groupBox_Dados_Pessoais.Name = "groupBox_Dados_Pessoais";
            this.groupBox_Dados_Pessoais.Size = new System.Drawing.Size(406, 250);
            this.groupBox_Dados_Pessoais.TabIndex = 2;
            this.groupBox_Dados_Pessoais.TabStop = false;
            this.groupBox_Dados_Pessoais.Text = "Dados Pessoais";
            // 
            // label_Valida_CPF
            // 
            this.label_Valida_CPF.AutoSize = true;
            this.label_Valida_CPF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_Valida_CPF.Location = new System.Drawing.Point(266, 218);
            this.label_Valida_CPF.Name = "label_Valida_CPF";
            this.label_Valida_CPF.Size = new System.Drawing.Size(51, 20);
            this.label_Valida_CPF.TabIndex = 24;
            this.label_Valida_CPF.Text = "label1";
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Location = new System.Drawing.Point(38, 213);
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(221, 22);
            this.textBox_CPF.TabIndex = 23;
            this.textBox_CPF.Leave += new System.EventHandler(this.textBox_CPF_Leave);
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Location = new System.Drawing.Point(7, 217);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(27, 16);
            this.label_CPF.TabIndex = 22;
            this.label_CPF.Text = "Tel";
            // 
            // label_Data_Nascimento
            // 
            this.label_Data_Nascimento.AutoSize = true;
            this.label_Data_Nascimento.Location = new System.Drawing.Point(7, 186);
            this.label_Data_Nascimento.Name = "label_Data_Nascimento";
            this.label_Data_Nascimento.Size = new System.Drawing.Size(111, 16);
            this.label_Data_Nascimento.TabIndex = 21;
            this.label_Data_Nascimento.Text = "Data Nascimento";
            // 
            // maskedTextBox_Data_Nascimento
            // 
            this.maskedTextBox_Data_Nascimento.Location = new System.Drawing.Point(155, 182);
            this.maskedTextBox_Data_Nascimento.Mask = "99/99/9999";
            this.maskedTextBox_Data_Nascimento.Name = "maskedTextBox_Data_Nascimento";
            this.maskedTextBox_Data_Nascimento.Size = new System.Drawing.Size(69, 22);
            this.maskedTextBox_Data_Nascimento.TabIndex = 20;
            // 
            // label_Renda_Familiar
            // 
            this.label_Renda_Familiar.AutoSize = true;
            this.label_Renda_Familiar.Location = new System.Drawing.Point(7, 145);
            this.label_Renda_Familiar.Name = "label_Renda_Familiar";
            this.label_Renda_Familiar.Size = new System.Drawing.Size(99, 16);
            this.label_Renda_Familiar.TabIndex = 19;
            this.label_Renda_Familiar.Text = "Renda Familiar";
            // 
            // textBox_Renda
            // 
            this.textBox_Renda.Location = new System.Drawing.Point(134, 142);
            this.textBox_Renda.Name = "textBox_Renda";
            this.textBox_Renda.Size = new System.Drawing.Size(125, 22);
            this.textBox_Renda.TabIndex = 18;
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Location = new System.Drawing.Point(38, 105);
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(221, 22);
            this.textBox_Tel.TabIndex = 17;
            // 
            // label_Tel
            // 
            this.label_Tel.AutoSize = true;
            this.label_Tel.Location = new System.Drawing.Point(7, 108);
            this.label_Tel.Name = "label_Tel";
            this.label_Tel.Size = new System.Drawing.Size(27, 16);
            this.label_Tel.TabIndex = 16;
            this.label_Tel.Text = "Tel";
            // 
            // label_Sexo
            // 
            this.label_Sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Sexo.AutoSize = true;
            this.label_Sexo.Location = new System.Drawing.Point(280, 108);
            this.label_Sexo.Name = "label_Sexo";
            this.label_Sexo.Size = new System.Drawing.Size(44, 16);
            this.label_Sexo.TabIndex = 13;
            this.label_Sexo.Text = "label2";
            // 
            // textBox_Nome_da_Mae
            // 
            this.textBox_Nome_da_Mae.Location = new System.Drawing.Point(111, 61);
            this.textBox_Nome_da_Mae.Name = "textBox_Nome_da_Mae";
            this.textBox_Nome_da_Mae.Size = new System.Drawing.Size(270, 22);
            this.textBox_Nome_da_Mae.TabIndex = 15;
            // 
            // comboBox_Sexo
            // 
            this.comboBox_Sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Sexo.FormattingEnabled = true;
            this.comboBox_Sexo.Location = new System.Drawing.Point(330, 105);
            this.comboBox_Sexo.Name = "comboBox_Sexo";
            this.comboBox_Sexo.Size = new System.Drawing.Size(68, 24);
            this.comboBox_Sexo.TabIndex = 12;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(57, 23);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(324, 22);
            this.textBox_Nome.TabIndex = 13;
            // 
            // label_Nome_da_Mae
            // 
            this.label_Nome_da_Mae.AutoSize = true;
            this.label_Nome_da_Mae.Location = new System.Drawing.Point(7, 64);
            this.label_Nome_da_Mae.Name = "label_Nome_da_Mae";
            this.label_Nome_da_Mae.Size = new System.Drawing.Size(93, 16);
            this.label_Nome_da_Mae.TabIndex = 14;
            this.label_Nome_da_Mae.Text = "Nome da Mãe";
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(7, 28);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(44, 16);
            this.label_Nome.TabIndex = 12;
            this.label_Nome.Text = "label1";
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.BackColor = System.Drawing.Color.Transparent;
            this.label_User.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_User.ForeColor = System.Drawing.Color.White;
            this.label_User.Location = new System.Drawing.Point(21, 316);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(96, 37);
            this.label_User.TabIndex = 3;
            this.label_User.Text = "label1";
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.BackColor = System.Drawing.Color.Transparent;
            this.label_Data.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_Data.ForeColor = System.Drawing.Color.White;
            this.label_Data.Location = new System.Drawing.Point(21, 273);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(96, 37);
            this.label_Data.TabIndex = 4;
            this.label_Data.Text = "label1";
            // 
            // groupBox_Conta_Agencia
            // 
            this.groupBox_Conta_Agencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Conta_Agencia.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Conta_Agencia.Controls.Add(this.label_Agencia1);
            this.groupBox_Conta_Agencia.Controls.Add(this.label_Conta1);
            this.groupBox_Conta_Agencia.Controls.Add(this.label_Conta);
            this.groupBox_Conta_Agencia.Controls.Add(this.label_Agencia);
            this.groupBox_Conta_Agencia.Controls.Add(this.button_Gerar_Conta);
            this.groupBox_Conta_Agencia.ForeColor = System.Drawing.Color.White;
            this.groupBox_Conta_Agencia.Location = new System.Drawing.Point(427, 149);
            this.groupBox_Conta_Agencia.Name = "groupBox_Conta_Agencia";
            this.groupBox_Conta_Agencia.Size = new System.Drawing.Size(467, 101);
            this.groupBox_Conta_Agencia.TabIndex = 5;
            this.groupBox_Conta_Agencia.TabStop = false;
            this.groupBox_Conta_Agencia.Text = "Conta/Agencia";
            // 
            // label_Agencia1
            // 
            this.label_Agencia1.AutoSize = true;
            this.label_Agencia1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Agencia1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Agencia1.Location = new System.Drawing.Point(19, 60);
            this.label_Agencia1.Name = "label_Agencia1";
            this.label_Agencia1.Size = new System.Drawing.Size(83, 32);
            this.label_Agencia1.TabIndex = 9;
            this.label_Agencia1.Text = "label4";
            // 
            // label_Conta1
            // 
            this.label_Conta1.AutoSize = true;
            this.label_Conta1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Conta1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Conta1.Location = new System.Drawing.Point(19, 20);
            this.label_Conta1.Name = "label_Conta1";
            this.label_Conta1.Size = new System.Drawing.Size(83, 32);
            this.label_Conta1.TabIndex = 8;
            this.label_Conta1.Text = "label3";
            // 
            // label_Conta
            // 
            this.label_Conta.AutoSize = true;
            this.label_Conta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Conta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_Conta.Location = new System.Drawing.Point(133, 20);
            this.label_Conta.Name = "label_Conta";
            this.label_Conta.Size = new System.Drawing.Size(83, 32);
            this.label_Conta.TabIndex = 7;
            this.label_Conta.Text = "label1";
            // 
            // label_Agencia
            // 
            this.label_Agencia.AutoSize = true;
            this.label_Agencia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Agencia.ForeColor = System.Drawing.Color.Olive;
            this.label_Agencia.Location = new System.Drawing.Point(133, 60);
            this.label_Agencia.Name = "label_Agencia";
            this.label_Agencia.Size = new System.Drawing.Size(83, 32);
            this.label_Agencia.TabIndex = 6;
            this.label_Agencia.Text = "label1";
            // 
            // button_Gerar_Conta
            // 
            this.button_Gerar_Conta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Gerar_Conta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Gerar_Conta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Gerar_Conta.Location = new System.Drawing.Point(363, 65);
            this.button_Gerar_Conta.Name = "button_Gerar_Conta";
            this.button_Gerar_Conta.Size = new System.Drawing.Size(86, 25);
            this.button_Gerar_Conta.TabIndex = 0;
            this.button_Gerar_Conta.Text = "button1";
            this.button_Gerar_Conta.UseVisualStyleBackColor = true;
            this.button_Gerar_Conta.Click += new System.EventHandler(this.button_Gerar_Conta_Click);
            // 
            // button_finalizar
            // 
            this.button_finalizar.BackColor = System.Drawing.Color.Gold;
            this.button_finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_finalizar.Font = new System.Drawing.Font("SimSun", 15.75F);
            this.button_finalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_finalizar.Location = new System.Drawing.Point(585, 287);
            this.button_finalizar.Name = "button_finalizar";
            this.button_finalizar.Size = new System.Drawing.Size(309, 61);
            this.button_finalizar.TabIndex = 6;
            this.button_finalizar.Text = "button1";
            this.button_finalizar.UseVisualStyleBackColor = false;
            this.button_finalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Cadastrar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(914, 359);
            this.Controls.Add(this.button_finalizar);
            this.Controls.Add(this.groupBox_Conta_Agencia);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.groupBox_Dados_Pessoais);
            this.Controls.Add(this.groupBox_Endereco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Cadastrar_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Clientes";
            this.groupBox_Endereco.ResumeLayout(false);
            this.groupBox_Endereco.PerformLayout();
            this.groupBox_Dados_Pessoais.ResumeLayout(false);
            this.groupBox_Dados_Pessoais.PerformLayout();
            this.groupBox_Conta_Agencia.ResumeLayout(false);
            this.groupBox_Conta_Agencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Cep;
        private GroupBox groupBox_Endereco;
        private TextBox textBox_Complemento;
        private Label label_Complemento;
        private Label label_Estado;
        private ComboBox comboBox_Estado;
        private CheckBox checkBox_Cep;
        private TextBox textBox_Numero;
        private Label label_Numero;
        private TextBox textBox_Cidade;
        private Label label_Cidade;
        private TextBox textBox_Rua;
        private Label label_Rua;
        private Label label_CEP;
        private TextBox textBox_CEP;
        private GroupBox groupBox_Dados_Pessoais;
        private Label label_Renda_Familiar;
        private TextBox textBox_Renda;
        private TextBox textBox_Tel;
        private Label label_Tel;
        private Label label_Sexo;
        private TextBox textBox_Nome_da_Mae;
        private ComboBox comboBox_Sexo;
        private TextBox textBox_Nome;
        private Label label_Nome_da_Mae;
        private Label label_Nome;
        private Label label_Data_Nascimento;
        private MaskedTextBox maskedTextBox_Data_Nascimento;
        private Label label_User;
        private Label label_Data;
        private Label label_Valida_CPF;
        private TextBox textBox_CPF;
        private Label label_CPF;
        private GroupBox groupBox_Conta_Agencia;
        private Label label_Agencia1;
        private Label label_Conta1;
        private Label label_Conta;
        private Label label_Agencia;
        private Button button_Gerar_Conta;
        private Button button_finalizar;
        private TextBox textBox_Bairro;
        private Label label_Bairro;
    }
}