using Bbank_Bibioteca.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBank_Desktop2.Formulario
{
    public partial class Form_Login : Form
    {
        public bool novoUsuario = false;
        public Form_Login()
        {
            InitializeComponent();
            label_Password.Text = "Senha: ";
            label_User.Text = "Usuario: ";
            button_Open.Text = "Entrar";
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (!novoUsuario)
            {
                Entrar();
            }
            else
            {
                Cadastar();
            }
        }

        private void Btn_NovoUsu_Click(object sender, EventArgs e)
        {
            novoUsuario = true;
            MessageBox.Show("Digite o USUARIO e SENHA e clique em entrar", "BBank", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void Entrar()
        {
            string Usuario = textBox_User.Text;
            string Password = textBox_Password.Text;
            Cls_Funcionario.Unit x = new Cls_Funcionario.Unit();
            if (Usuario == "ADM")
            {
                if (Password == "123")
                {
                    MessageBox.Show("Bem Vindo(a) " + Usuario, "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Text = Usuario;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario Valido\nSenha Invalida", "BBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                x = x.buscarFuncionario(Usuario);
                if(x != null)
                {
                    if (x.Senha.Trim() == Password)
                    {
                        Password = x.Senha;
                        MessageBox.Show("Bem Vindo(a) " + Usuario, "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Text = Usuario;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou Senha Invalidos", "BBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha Invalidos", "BBank", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void Cadastar()
        {
            Cls_Funcionario.Unit x = new Cls_Funcionario.Unit();
            string Usuario = textBox_User.Text;
            string Password = textBox_Password.Text;
            if(Usuario.Trim() == "" || Password.Trim() == "")
            {
                MessageBox.Show("Preencha os campos", "BBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                novoUsuario = x.incluirFuncionario(Usuario, Password);
                if (novoUsuario)
                {
                    MessageBox.Show("Cadastro Realizado com sucesso", "BBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    novoUsuario = false;
                }
            }
        }
    }
}
