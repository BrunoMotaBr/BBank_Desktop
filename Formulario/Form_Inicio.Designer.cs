using System.Windows.Forms;

namespace BBank_Desktop2.Formulario

{
    partial class Form_Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inicio));
            this.button_one = new System.Windows.Forms.Button();
            this.button_two = new System.Windows.Forms.Button();
            this.button_three = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Data = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_one
            // 
            this.button_one.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_one.Location = new System.Drawing.Point(12, 262);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(248, 25);
            this.button_one.TabIndex = 0;
            this.button_one.Text = "Cadastrar Cliente";
            this.button_one.UseVisualStyleBackColor = true;
            this.button_one.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_two
            // 
            this.button_two.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_two.Location = new System.Drawing.Point(323, 262);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(248, 25);
            this.button_two.TabIndex = 1;
            this.button_two.Text = "Buscar Clientes";
            this.button_two.UseVisualStyleBackColor = true;
            this.button_two.Click += new System.EventHandler(this.button_two_Click);
            // 
            // button_three
            // 
            this.button_three.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_three.Location = new System.Drawing.Point(633, 262);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(248, 25);
            this.button_three.TabIndex = 2;
            this.button_three.Text = "Simular Emprestimo";
            this.button_three.UseVisualStyleBackColor = true;
            this.button_three.Click += new System.EventHandler(this.button_three_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(790, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.BackColor = System.Drawing.Color.Transparent;
            this.label_Data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Data.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Data.Location = new System.Drawing.Point(12, 9);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(70, 28);
            this.label_Data.TabIndex = 6;
            this.label_Data.Text = "label2";
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(14, 62);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(44, 16);
            this.label_User.TabIndex = 7;
            this.label_User.Text = "label1";
            // 
            // Form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(896, 346);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_three);
            this.Controls.Add(this.button_two);
            this.Controls.Add(this.button_one);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_one;
        private Button button_two;
        private Button button_three;
        private PictureBox pictureBox2;
        private Label label_Data;
        private Label label_User;
    }
}