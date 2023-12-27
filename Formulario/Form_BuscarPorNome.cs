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
    public partial class Form_BuscarPorNome : Form
    {
        public List<List<string>> conteudo;
        public string idSelect { get; set; }


        public Form_BuscarPorNome(List<List<string>> conteudo)
        {
            InitializeComponent();
            button_Select.Text = "Abrir";
            this.conteudo = conteudo;
            PreecherLista(conteudo);
            listBox_Lista.Sorted = true;
        }
        private void PreecherLista(List<List<string>> dados)
        {

            for (int i = 0; i <= dados.Count - 1; i++)
            {
                CaixadeItens x = new CaixadeItens();
                x.cpf = dados[i][0];
                x.nome = dados[i][1];
                listBox_Lista.Items.Add(x);
            }
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            CaixadeItens caixadeItens = (CaixadeItens)listBox_Lista.Items[listBox_Lista.SelectedIndex];
            idSelect = caixadeItens.cpf;
            this.Close();
        }
        class CaixadeItens
        {
            public string cpf { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }
    }
}