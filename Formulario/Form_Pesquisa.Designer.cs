namespace BBank_Desktop2.Formulario
{
    partial class Form_Pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pesquisa));
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_Busca = new System.Windows.Forms.TextBox();
            this.label_Busca = new System.Windows.Forms.Label();
            this.button_Nome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Buscar
            // 
            this.button_Buscar.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Buscar.Location = new System.Drawing.Point(303, 47);
            this.button_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(139, 23);
            this.button_Buscar.TabIndex = 4;
            this.button_Buscar.Text = "button1";
            this.button_Buscar.UseVisualStyleBackColor = false;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // textBox_Busca
            // 
            this.textBox_Busca.Location = new System.Drawing.Point(11, 47);
            this.textBox_Busca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Busca.Name = "textBox_Busca";
            this.textBox_Busca.Size = new System.Drawing.Size(285, 22);
            this.textBox_Busca.TabIndex = 5;
            // 
            // label_Busca
            // 
            this.label_Busca.AutoSize = true;
            this.label_Busca.BackColor = System.Drawing.Color.Transparent;
            this.label_Busca.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_Busca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_Busca.Location = new System.Drawing.Point(11, 21);
            this.label_Busca.Name = "label_Busca";
            this.label_Busca.Size = new System.Drawing.Size(59, 23);
            this.label_Busca.TabIndex = 6;
            this.label_Busca.Text = "label1";
            // 
            // button_Nome
            // 
            this.button_Nome.Location = new System.Drawing.Point(14, 85);
            this.button_Nome.Name = "button_Nome";
            this.button_Nome.Size = new System.Drawing.Size(186, 25);
            this.button_Nome.TabIndex = 7;
            this.button_Nome.Text = "button1";
            this.button_Nome.UseVisualStyleBackColor = true;
            this.button_Nome.Click += new System.EventHandler(this.button_Nome_Click);
            // 
            // Form_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(672, 114);
            this.Controls.Add(this.button_Nome);
            this.Controls.Add(this.label_Busca);
            this.Controls.Add(this.textBox_Busca);
            this.Controls.Add(this.button_Buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(690, 161);
            this.MinimumSize = new System.Drawing.Size(690, 161);
            this.Name = "Form_Pesquisa";
            this.Text = "Pesquisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

         

        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_Nome;
        private System.Windows.Forms.TextBox textBox_Busca;
        private System.Windows.Forms.Label label_Busca;
    }
}