using BBank.Classes;
using Microsoft.VisualBasic;
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
    public partial class Form_Simular : Form
    {
    
        public String login;
        public Form_Simular(string login)
        {
            InitializeComponent();
            this.login = login;
            label_Resultado.Text = "";
            label_CPF.Text = "CPF";
            label_Parcelas.Text = "Parcelas";
            label_Valor.Text = "Valor";
            textBox_Valor.Text = "0";
            comboBox_Quantidade.Enabled = false;
            checkBox_Casa.Text= "Casa";
            checkBox_Carro.Text = "Carro";
            groupBox_Tipo.Text = "Qual seu Sonho?";
        }

        private void button_Simular_Click(object sender, EventArgs e)
        {
            Cls_Cliente.Unit c = new Cls_Cliente.Unit();
            Double valor;
            if (Information.IsNumeric(comboBox_Quantidade.Text))
            {
                int parcelas = Convert.ToInt16(comboBox_Quantidade.Text);
                if (Information.IsNumeric(textBox_Valor.Text))
                {
                    valor = Convert.ToDouble(textBox_Valor.Text);
                    if (textBox_CPF.Text.Trim() == "")
                    {
                        MessageBox.Show("Precisa digitar o CPF do cliente", "BBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var resultado = c.BuscarFicharioDB(textBox_CPF.Text.Trim(), "CLIENTE");
                        if (resultado != null)
                        {

                            var salario = resultado.rendaFamiliar;
                            if (SimularFinanciamento(salario, valor, parcelas))
                            {
                                label_Resultado.ForeColor = Color.Green;
                                label_Resultado.Text = "Aprovado";
                            }
                            else
                            {
                                label_Resultado.ForeColor = Color.Red;
                                label_Resultado.Text = "Reprovado";
                                MessageBox.Show("O Cliente pode tentar Almentar as Parcelas", "Bbank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            label_Resultado.ForeColor = Color.Red;
                            label_Resultado.Text = "Reprovado";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Valor Invalido!","BBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Parcelas Invalidas!", "BBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool SimularFinanciamento(Double salario, Double valor, int parcela)
        {
            Double valorPorParcela = valor / parcela;
            if(salario >= valor)
            {
                return true;
            }
            else
            {
                if (valorPorParcela >= salario)
                {
                    return false;
                }
                else
                {
                    Double umQuartoSalario = salario / 4;
                    if(umQuartoSalario >= valorPorParcela)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void checkBox_Casa_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Carro.Checked = !checkBox_Carro.Enabled;
            comboBox_Quantidade.Items.Clear();
            comboBox_Quantidade.Enabled = true; 
            for (int i = 12; i <= 240; i += 12)
            {
                comboBox_Quantidade.Items.Add(i.ToString());
            }
        }

        private void checkBox_Carro_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Casa.Checked = !checkBox_Casa.Enabled;
            comboBox_Quantidade.Items.Clear();
            comboBox_Quantidade.Enabled = true;
            for (int i = 12; i <= 48; i += 12)
            {
                comboBox_Quantidade.Items.Add(i.ToString());
            }
        }
    }
}