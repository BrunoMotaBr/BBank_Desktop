using Bbank_Bibioteca.Classes;
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

    public partial class Form_Inicio : Form
    {
        public Form_Login User = new Form_Login();
        public Form_Inicio()
        {
            Form_Login login = new Form_Login();
            login.ShowDialog();
            InitializeComponent();
            DateTime dataEntrada = DateTime.Now;
            label_Data.Text = dataEntrada.Day.ToString() + "/" + dataEntrada.Month.ToString() + "/" + dataEntrada.Year.ToString();
            label_User.Text = "Olá Sr(a) " + login.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Cadastrar_Clientes open = new Form_Cadastrar_Clientes(label_User.Text);
            open.Show();
        }

        private void button_two_Click(object sender, EventArgs e)
        {
            Form_Pesquisa open = new Form_Pesquisa(label_User.Text);
            open.Show();
        }

        private void button_three_Click(object sender, EventArgs e)
        {
            Form_Simular open = new Form_Simular(label_User.Text);
            open.Show();
        }
        private void desativa()
        {
            button_one.Enabled = false;
            button_two.Enabled = false;
            button_three.Enabled = false;

        }
    }
}