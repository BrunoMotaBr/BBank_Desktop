using System.Windows.Forms;

namespace BBank_Desktop2.Formulario
{
    partial class Form_BuscarPorNome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BuscarPorNome));
            this.listBox_Lista = new System.Windows.Forms.ListBox();
            this.button_Select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Lista
            // 
            this.listBox_Lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Lista.BackColor = System.Drawing.Color.Gold;
            this.listBox_Lista.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox_Lista.FormattingEnabled = true;
            this.listBox_Lista.ItemHeight = 16;
            this.listBox_Lista.Location = new System.Drawing.Point(-1, 46);
            this.listBox_Lista.Name = "listBox_Lista";
            this.listBox_Lista.Size = new System.Drawing.Size(901, 436);
            this.listBox_Lista.TabIndex = 0;
            // 
            // button_Select
            // 
            this.button_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Select.BackColor = System.Drawing.Color.MediumBlue;
            this.button_Select.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Select.Location = new System.Drawing.Point(600, 15);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(301, 25);
            this.button_Select.TabIndex = 1;
            this.button_Select.Text = "button1";
            this.button_Select.UseVisualStyleBackColor = false;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // Form_BuscarPorNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.button_Select);
            this.Controls.Add(this.listBox_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_BuscarPorNome";
            this.Text = "Buscar Por Nome";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox_Lista;
        private Button button_Select;
    }
}