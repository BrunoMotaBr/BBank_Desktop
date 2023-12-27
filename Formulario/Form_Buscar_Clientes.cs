using BBank.Classes;
using Bbank_Bibioteca.Classes;
using Bbank_Bibioteca.DataBase;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BBank.Classes.Cls_Cliente;

namespace BBank_Desktop2.Formulario
{
    public partial class Form_Buscar_Clientes : Form
    {
        public string login;
        public bool resposta = false;
        public Cls_Cliente.Unit valida = new Cls_Cliente.Unit();

        public Form_Buscar_Clientes(string login, Unit cliente)
        {
            this.login = login;
            InitializeComponent();
            labelIn();
            Acao();
            Cls_Cliente.Unit Cliente = new Cls_Cliente.Unit();
            Cliente = cliente;

            comboBox_Sexo.Items.Add("F");
            comboBox_Sexo.Items.Add("M");
            comboBox_Sexo.Items.Add("N/A");

            label_NumAgencia.Text = cliente.agencia;
            label_NumConta.Text = cliente.conta;


            textBox_Cidade.Text = cliente.cidade;
            textBox_CPF.Text = cliente.CPF;
            textBox_Nome.Text = cliente.nome;
            textBox_NomeDaMae.Text = cliente.nomeMae;
            textBox_Rua.Text = cliente.rua;
            textBox_cep.Text = cliente.CEP;
            textBox_telefone.Text = cliente.tel;
            textBox_Bairro.Text = cliente.bairro;
            textBox_Complemento.Text = cliente.complemento;
            textBox_Numero.Text = Convert.ToString(cliente.numero);
            textBox_Renda.Text = Convert.ToString(cliente.rendaFamiliar);

            maskedTextBox_DataNacimento.Text = cliente.dataNacimento;

            comboBox_Sexo.SelectedIndex = cliente.sexo;
            comboBox_Estado.Text = cliente.estado;


        }

        private void Form_Buscar_Clientes_Load(object sender, EventArgs e)
        {
            Form_Pesquisa close = new Form_Pesquisa(login);

        }

        private void button_Alteracao_Click(object sender, EventArgs e)
        {
            Acao();
        }

        private void button_Salvar_Altecacao_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaForm();
                if (resposta)
                {
                    string clienteJason = Cls_Cliente.MontaJson(valida);
                    Cls_Cliente.Unit C = new Cls_Cliente.Unit();
                    C.AlterarFicharioDB("CLIENTE", valida);
                }
                else
                {
                    MessageBox.Show("Erro na leitura do Formulario", "BBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "BBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidaForm()
        {
            int sexo = -1;
            if (comboBox_Sexo.Text == "F")
            {
                sexo = 0;
            }
            else if (comboBox_Sexo.Text == "M")
            {
                sexo = 1;
            }
            else if (comboBox_Sexo.Text == "N/A")
            {
                sexo = 2;
            }
            if (sexo == -1)
            {
                MessageBox.Show("Sexo Invalido ou Vazio", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    valida.tel = textBox_telefone.Text.Trim();
                    valida.nome = textBox_Nome.Text.Trim();
                    valida.estado = comboBox_Estado.Text.Trim();
                    valida.bairro = textBox_Bairro.Text.Trim();
                    valida.cidade = textBox_Cidade.Text.Trim();
                    valida.nomeMae = textBox_NomeDaMae.Text.Trim();
                    valida.CEP = textBox_cep.Text.Trim();
                    valida.CPF = textBox_CPF.Text.Trim();
                    valida.complemento = textBox_Complemento.Text.Trim();
                    valida.dataNacimento = maskedTextBox_DataNacimento.Text.Trim();
                    valida.numero = textBox_Numero.Text;
                    valida.sexo = sexo;
                    valida.rua = textBox_Rua.Text.Trim();
                    valida.agencia = label_NumAgencia.Text.Trim();
                    valida.conta = label_NumConta.Text.Trim();
                    if (Information.IsNumeric(textBox_Renda.Text))
                    {
                        Double vRenda = Convert.ToDouble(textBox_Renda.Text);
                        if (vRenda > 0)
                        {
                            valida.rendaFamiliar = vRenda;
                        }
                        else
                        {
                            valida.rendaFamiliar = 0;
                        }
                    }
                    valida.ValidaClasse();
                    MessageBox.Show("Todos os campos preenchidos com sucesso", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resposta = true;
                }
                catch (ValidationException ex)
                {
                    MessageBox.Show(ex.Message, "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resposta = false;
                }
            }

        }

        private void textBox_cep_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_cep.Text))
            {
                if (textBox_cep.Text.Length == 8)
                {
                    var vjson = Cls_Uteis.GeraJSONCEP(textBox_cep.Text);
                    CEP.Unit Cep = new CEP.Unit();
                    Cep = CEP.DesmontaJson(vjson);
                    textBox_Cidade.Text = Cep.localidade;
                    textBox_Rua.Text = Cep.logradouro;
                    comboBox_Estado.Text = Cep.uf;
                    textBox_Bairro.Text = Cep.bairro;
                }
            }
            else
            {
                MessageBox.Show("Digite um Cep", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void labelIn()
        {
            label_Agencia.Text = "Agencia";
            label_Conta.Text = "Conta";
            label_APPInfo.Text = "Verifique se o cliente já possui acesso ativo ao site e APP!!";
            label_Bairro.Text = "Bairro";
            label_Cep.Text = "CEP";
            label_Cidade.Text = "Cidade";
            label_Complemento.Text = "Complemento";
            label_CPF.Text = "CPF";
            label_DataNacimento.Text = "Data de Nascimento";
            label_Nome.Text = "Nome";
            label_NomeDaMae.Text = "Nome da Mãe";
            label_Numero.Text = "Número";
            label_Renda.Text = "Renda";
            label_Rua.Text = "Rua";
            label_Sexo.Text = "Sexo";
            label_Telefone.Text = "Telefone";
            label_UF.Text = "UF";
        }
        private void Acao()
        {
            button_Excluir.Text = "Excluir Cliente";
            button_Salvar_Altecacao.Text = "Salvar Alteração";
            if (!(textBox_Bairro.Enabled == true))
            {
                button_Alteracao.Text = "Desativar";
                button_Alteracao.BackColor = Color.Red;
                textBox_Bairro.Enabled = true;
                textBox_Cidade.Enabled = true;
                textBox_CPF.Enabled = false;
                maskedTextBox_DataNacimento.Enabled = false;
                textBox_Nome.Enabled = true;
                textBox_NomeDaMae.Enabled = true;
                textBox_Numero.Enabled = true;
                textBox_Renda.Enabled = true;
                textBox_Rua.Enabled = true;
                textBox_cep.Enabled = true;
                textBox_Complemento.Enabled = true;
                textBox_telefone.Enabled = true;
                comboBox_Estado.Enabled = true;
                comboBox_Sexo.Enabled = true;
                Cls_Uteis estados = new Cls_Uteis();
                estados.Comb_est(comboBox_Estado);
                button_Salvar_Altecacao.Enabled = true;
                button_Excluir.Enabled = true;
            }
            else
            {
                button_Alteracao.Text = "Alterar";
                button_Alteracao.BackColor = Color.Blue;
                comboBox_Sexo.Enabled = false;
                textBox_Bairro.Enabled = false;
                textBox_Cidade.Enabled = false;
                textBox_CPF.Enabled = false;
                textBox_cep.Enabled = false;
                textBox_Complemento.Enabled = false;
                textBox_Nome.Enabled = false;
                textBox_NomeDaMae.Enabled = false;
                textBox_Numero.Enabled = false;
                textBox_Renda.Enabled = false;
                textBox_Rua.Enabled = false;
                textBox_telefone.Enabled = false;
                maskedTextBox_DataNacimento.Enabled = false;
                comboBox_Estado.Enabled = false;
                comboBox_Sexo.Enabled = false;
                button_Salvar_Altecacao.Enabled = false;
                button_Excluir.Enabled = false;
            }
        }

        private void button_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente EXCLUIR o cliente: " + textBox_Nome.Text, "Bbank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cls_Cliente.Unit F = new Cls_Cliente.Unit();
                    F.ApagarFicharioDB("CLIENTE", textBox_CPF.Text);
                    MessageBox.Show("Cliente: " + textBox_Nome.Text + " excluido com sucesso! ", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "BBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}