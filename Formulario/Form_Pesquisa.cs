using BBank.Classes;
using Bbank_Bibioteca.DataBase;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BBank.Classes.Cls_Cliente;

namespace BBank_Desktop2.Formulario
{
    public partial class Form_Pesquisa : Form
    {
        public Unit c = new Unit();
        public string login;
        public string idSelect = "";

        public Form_Pesquisa(string login)
        {
            this.login = login;
            InitializeComponent();
            label_Busca.Text = "Digite o CPF do cliente";
            button_Buscar.Text = "Buscar";
            button_Nome.Text = "Buscar por nome";
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            Busque();
        }

        private void button_Nome_Click(object sender, EventArgs e)
        {
            Cls_Cliente.Unit F = new Cls_Cliente.Unit();
            try
            {
                var  buscarTodos = F.BuscarFicharioDBTodosDB("CLIENTE");
                Form_BuscarPorNome open = new Form_BuscarPorNome(buscarTodos);
                open.ShowDialog();
                if (open.DialogResult == DialogResult.OK)
                {
                    idSelect = open.idSelect;
                    textBox_Busca.Text = idSelect;
                    Busque();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }
        private void Busque()
        {
            try
            {
                if (textBox_Busca.Text.Trim() != "")
                {
                    Cls_Cliente.Unit C = new Cls_Cliente.Unit();
                    Unit conteudo = C.BuscarFicharioDB(textBox_Busca.Text, "CLIENTE");
                    if (conteudo != null)
                    {
                        Form_Buscar_Clientes F = new Form_Buscar_Clientes(login, conteudo);
                        F.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Digite o CPF ou busque por nome.", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
