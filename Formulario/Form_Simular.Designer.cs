using System.Windows.Forms;

namespace BBank_Desktop2.Formulario
{
    partial class Form_Simular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Simular));
            this.checkBox_Carro = new System.Windows.Forms.CheckBox();
            this.checkBox_Casa = new System.Windows.Forms.CheckBox();
            this.comboBox_Quantidade = new System.Windows.Forms.ComboBox();
            this.label_Parcelas = new System.Windows.Forms.Label();
            this.textBox_Valor = new System.Windows.Forms.TextBox();
            this.label_Valor = new System.Windows.Forms.Label();
            this.textBox_CPF = new System.Windows.Forms.TextBox();
            this.label_CPF = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Simular = new System.Windows.Forms.Button();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.groupBox_Tipo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_Carro
            // 
            this.checkBox_Carro.AutoSize = true;
            this.checkBox_Carro.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Carro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_Carro.Location = new System.Drawing.Point(6, 61);
            this.checkBox_Carro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Carro.Name = "checkBox_Carro";
            this.checkBox_Carro.Size = new System.Drawing.Size(95, 20);
            this.checkBox_Carro.TabIndex = 5;
            this.checkBox_Carro.Text = "checkBox2";
            this.checkBox_Carro.UseVisualStyleBackColor = false;
            this.checkBox_Carro.CheckedChanged += new System.EventHandler(this.checkBox_Carro_CheckedChanged);
            // 
            // checkBox_Casa
            // 
            this.checkBox_Casa.AutoSize = true;
            this.checkBox_Casa.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Casa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_Casa.Location = new System.Drawing.Point(6, 37);
            this.checkBox_Casa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Casa.Name = "checkBox_Casa";
            this.checkBox_Casa.Size = new System.Drawing.Size(95, 20);
            this.checkBox_Casa.TabIndex = 6;
            this.checkBox_Casa.Text = "checkBox3";
            this.checkBox_Casa.UseVisualStyleBackColor = false;
            this.checkBox_Casa.CheckedChanged += new System.EventHandler(this.checkBox_Casa_CheckedChanged);
            // 
            // comboBox_Quantidade
            // 
            this.comboBox_Quantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox_Quantidade.FormattingEnabled = true;
            this.comboBox_Quantidade.Location = new System.Drawing.Point(298, 49);
            this.comboBox_Quantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Quantidade.Name = "comboBox_Quantidade";
            this.comboBox_Quantidade.Size = new System.Drawing.Size(64, 24);
            this.comboBox_Quantidade.TabIndex = 7;
            // 
            // label_Parcelas
            // 
            this.label_Parcelas.AutoSize = true;
            this.label_Parcelas.BackColor = System.Drawing.Color.Transparent;
            this.label_Parcelas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Parcelas.Location = new System.Drawing.Point(299, 20);
            this.label_Parcelas.Name = "label_Parcelas";
            this.label_Parcelas.Size = new System.Drawing.Size(44, 16);
            this.label_Parcelas.TabIndex = 8;
            this.label_Parcelas.Text = "label2";
            // 
            // textBox_Valor
            // 
            this.textBox_Valor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Valor.Location = new System.Drawing.Point(157, 49);
            this.textBox_Valor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Valor.Name = "textBox_Valor";
            this.textBox_Valor.Size = new System.Drawing.Size(125, 22);
            this.textBox_Valor.TabIndex = 9;
            // 
            // label_Valor
            // 
            this.label_Valor.AutoSize = true;
            this.label_Valor.BackColor = System.Drawing.Color.Transparent;
            this.label_Valor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Valor.Location = new System.Drawing.Point(154, 20);
            this.label_Valor.Name = "label_Valor";
            this.label_Valor.Size = new System.Drawing.Size(44, 16);
            this.label_Valor.TabIndex = 10;
            this.label_Valor.Text = "label3";
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_CPF.Location = new System.Drawing.Point(157, 98);
            this.textBox_CPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(205, 22);
            this.textBox_CPF.TabIndex = 11;
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.BackColor = System.Drawing.Color.Transparent;
            this.label_CPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_CPF.Location = new System.Drawing.Point(154, 77);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(44, 16);
            this.label_CPF.TabIndex = 12;
            this.label_CPF.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button_Simular
            // 
            this.button_Simular.Location = new System.Drawing.Point(237, 140);
            this.button_Simular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Simular.Name = "button_Simular";
            this.button_Simular.Size = new System.Drawing.Size(125, 23);
            this.button_Simular.TabIndex = 14;
            this.button_Simular.Text = "Simular";
            this.button_Simular.UseVisualStyleBackColor = true;
            this.button_Simular.Click += new System.EventHandler(this.button_Simular_Click);
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Resultado.Location = new System.Drawing.Point(12, 209);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(98, 32);
            this.label_Resultado.TabIndex = 15;
            this.label_Resultado.Text = "label5";
            // 
            // groupBox_Tipo
            // 
            this.groupBox_Tipo.Controls.Add(this.checkBox_Casa);
            this.groupBox_Tipo.Controls.Add(this.checkBox_Carro);
            this.groupBox_Tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_Tipo.Location = new System.Drawing.Point(15, 12);
            this.groupBox_Tipo.Name = "groupBox_Tipo";
            this.groupBox_Tipo.Size = new System.Drawing.Size(114, 108);
            this.groupBox_Tipo.TabIndex = 16;
            this.groupBox_Tipo.TabStop = false;
            this.groupBox_Tipo.Text = "groupBox1";
            // 
            // Form_Simular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.groupBox_Tipo);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.button_Simular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_CPF);
            this.Controls.Add(this.textBox_CPF);
            this.Controls.Add(this.label_Valor);
            this.Controls.Add(this.textBox_Valor);
            this.Controls.Add(this.label_Parcelas);
            this.Controls.Add(this.comboBox_Quantidade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(818, 407);
            this.MinimumSize = new System.Drawing.Size(818, 407);
            this.Name = "Form_Simular";
            this.Text = "Simular";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_Tipo.ResumeLayout(false);
            this.groupBox_Tipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox checkBox_Carro;
        private CheckBox checkBox_Casa;
        private ComboBox comboBox_Quantidade;
        private Label label_Parcelas;
        private TextBox textBox_Valor;
        private Label label_Valor;
        private TextBox textBox_CPF;
        private Label label_CPF;
        private PictureBox pictureBox1;
        private Button button_Simular;
        private Label label_Resultado;
        private GroupBox groupBox_Tipo;
    }
}