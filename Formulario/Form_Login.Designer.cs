using System.Windows.Forms;

namespace BBank_Desktop2.Formulario

{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.label_User = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_NovoUsu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(106, 185);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(114, 22);
            this.textBox_User.TabIndex = 0;
            // 
            // textBox_Password
            // 
            this.textBox_Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Password.Location = new System.Drawing.Point(106, 235);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(114, 22);
            this.textBox_Password.TabIndex = 1;
            // 
            // button_Open
            // 
            this.button_Open.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_Open.Location = new System.Drawing.Point(119, 290);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(86, 25);
            this.button_Open.TabIndex = 2;
            this.button_Open.Text = "button1";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_User.Location = new System.Drawing.Point(40, 185);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(44, 16);
            this.label_User.TabIndex = 3;
            this.label_User.Text = "label1";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Password.Location = new System.Drawing.Point(40, 235);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(44, 16);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_NovoUsu
            // 
            this.Btn_NovoUsu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_NovoUsu.Location = new System.Drawing.Point(222, 324);
            this.Btn_NovoUsu.Name = "Btn_NovoUsu";
            this.Btn_NovoUsu.Size = new System.Drawing.Size(92, 23);
            this.Btn_NovoUsu.TabIndex = 6;
            this.Btn_NovoUsu.Text = "Cadastro";
            this.Btn_NovoUsu.UseVisualStyleBackColor = true;
            this.Btn_NovoUsu.Click += new System.EventHandler(this.Btn_NovoUsu_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(314, 347);
            this.Controls.Add(this.Btn_NovoUsu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(332, 394);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(332, 394);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Bbank Gerente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_User;
        private TextBox textBox_Password;
        private Button button_Open;
        private Label label_User;
        private Label label_Password;
        private PictureBox pictureBox1;
        private Button Btn_NovoUsu;
    }
}