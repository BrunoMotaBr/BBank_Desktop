using Bbank_Bibioteca.Classes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BBank.Classes.Cls_Cliente;

namespace BBank_Desktop2.Formulario
{
    public partial class Form_Cadastrar_Clientes : Form
    {
        public String login;
        public string CPF = " ";
        public bool resposta, respostaCPF = true;
        public Unit valida = new Unit();
        public bool validaConta = false;
        public Form_Cadastrar_Clientes(String userNuber)
        {
            Cls_Uteis estados = new Cls_Uteis();
            InitializeComponent();
            IniForm();
            LimparForm();
            estados.Comb_est(comboBox_Estado);

            label_User.Text = login;
            login = userNuber;

            comboBox_Sexo.Items.Add("F");
            comboBox_Sexo.Items.Add("M");
            comboBox_Sexo.Items.Add("N/A");

        }

        private void textBox_CPF_Leave(object sender, EventArgs e)
        {
            if (Cls_Uteis.Valida_CPF(textBox_CPF.Text))
            {
                CPF = textBox_CPF.Text;
                label_Valida_CPF.Text = "Válido";
                label_Valida_CPF.ForeColor = Color.Green;
                textBox_CPF.ForeColor = Color.Black;
                respostaCPF = true;
            }
            else
            {
                label_Valida_CPF.Text = "Inválido";
                label_Valida_CPF.ForeColor = Color.Red;
                textBox_CPF.ForeColor = Color.Red;
                respostaCPF = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (resposta)
                {
                    ValidaForm();
                    if (resposta)
                    {
                        valida.IncluirFicharioDB("CLIENTE");
                        LimparForm();
                        MessageBox.Show("Cliente: " + valida.nome + " incluso com sucesso!!!", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Gere a conta e agencia antes", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void button_Gerar_Conta_Click(object sender, EventArgs e)
        {
            ValidaForm();
        }

        private void button_Cep_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_CEP.Text))
            {
                if (textBox_CEP.Text.Length == 8)
                {
                    var vjson = Cls_Uteis.GeraJSONCEP(textBox_CEP.Text);
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

        private void checkBox_CPF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Cep.Checked)
            {
                textBox_Cidade.Enabled = true;
                textBox_Rua.Enabled = true;
                comboBox_Estado.Enabled = true;
                textBox_Bairro.Enabled = true;
            }
            else
            {
                textBox_Cidade.Enabled = false;
                textBox_Rua.Enabled = false;
                comboBox_Estado.Enabled = false;
                textBox_Bairro.Enabled = false;
            }

        }
        private void LimparForm()
        {
            textBox_Bairro.Text = "";
            textBox_CEP.Text = "";
            textBox_Cidade.Text = "";
            textBox_Complemento.Text = "";
            textBox_CPF.Text = "";
            textBox_Nome.Text = "";
            textBox_Nome_da_Mae.Text = "";
            textBox_Numero.Text = "";
            textBox_Renda.Text = "";
            textBox_Rua.Text = "";
            textBox_Tel.Text = "";
            maskedTextBox_Data_Nascimento.Text = "";
            comboBox_Estado.Text = "";
            comboBox_Sexo.Text = "";
            label_Valida_CPF.Text = " ";
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
            if (respostaCPF)
            {
                if (sexo == -1)
                {
                    MessageBox.Show("Sexo Invalido ou Vazio", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        valida.tel = textBox_Tel.Text.Trim();
                        valida.nome = textBox_Nome.Text.Trim();
                        valida.estado = comboBox_Estado.Text.Trim();
                        valida.bairro = textBox_Bairro.Text.Trim();
                        valida.cidade = textBox_Cidade.Text.Trim();
                        valida.nomeMae = textBox_Nome_da_Mae.Text.Trim();
                        valida.CEP = textBox_CEP.Text.Trim();
                        valida.CPF = CPF.Trim();
                        valida.complemento = textBox_Complemento.Text.Trim();
                        valida.dataNacimento = maskedTextBox_Data_Nascimento.Text.Trim();
                        valida.numero = textBox_Numero.Text.Trim();
                        valida.sexo = sexo;
                        valida.rua = textBox_Rua.Text.Trim();
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
                        if (!validaConta)
                        {
                            var quantidade = valida.Conta();
                            if (quantidade != null)
                            {
                                Random randNum = new Random();
                                int contaTemp = quantidade.Count() + randNum.Next(100);
                                if (contaTemp < 10)
                                {
                                    valida.conta = "000" + contaTemp.ToString();

                                }
                                else if (contaTemp < 100)
                                {
                                    valida.conta = "00" + contaTemp.ToString();
                                }
                                else if (contaTemp < 1000)
                                {
                                    valida.conta = "0" + contaTemp.ToString();
                                }
                                else
                                {
                                    valida.conta = contaTemp.ToString();
                                }
                            }
                            else
                            {
                                valida.conta = "0001";
                                validaConta = true;
                            }
                            label_Conta.Text = valida.conta;
                            label_Agencia.Text = "0001";
                            valida.agencia = label_Agencia.Text;
                            validaConta = true;
                        }
                        else
                        {
                            valida.ValidaClasse();
                            MessageBox.Show("Todos os campos preenchidos com sucesso", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resposta = true;

                        }
                    }
                    catch (ValidationException ex)
                    {
                        MessageBox.Show(ex.Message, "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resposta = false;
                    }
                }
            }
        }

        public void IniForm()
        {
            DateTime dataEntrada = DateTime.Now;
            label_Data.Text = dataEntrada.Day.ToString() + "/" + dataEntrada.Month.ToString() + "/" + dataEntrada.Year.ToString();
            checkBox_Cep.Text = "Sem Cep";
            label_Valida_CPF.Text = "";
            label_Agencia.Text = "";
            label_Agencia1.Text = "Agencia";
            label_CEP.Text = "CEP";
            label_Cidade.Text = "Cidade";
            label_Complemento.Text = "Complemento";
            label_Conta.Text = "";
            label_Conta1.Text = "Conta";
            label_CPF.Text = "CPF";
            label_Data_Nascimento.Text = "Data de Nascimento";
            label_Estado.Text = "UF";
            label_Nome.Text = "Nome";
            label_Nome_da_Mae.Text = "Nome da Mãe";
            label_Numero.Text = "Número";
            label_Renda_Familiar.Text = "Renda Familiar";
            label_Rua.Text = "Rua";
            label_Sexo.Text = "Sexo";
            label_Tel.Text = "Tel";
            button_Gerar_Conta.Text = "Gerar conta";
            button_finalizar.Text = "Finalizar";
            textBox_Cidade.Enabled = false;
            textBox_Rua.Enabled = false;
            comboBox_Estado.Enabled = false;
            textBox_Bairro.Enabled = false;
        }
    }
}