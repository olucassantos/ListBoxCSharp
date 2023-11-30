using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CestasDaPrima
{
    public partial class Form2 : Form
    {
        List<string> categorias = new List<string> {
            "Natal",
            "Dia dos Namorados",
            "Dia dos Pais",
            "Dia das Mães",
            "Páscoa",
            "Dia da Rata"
        };

        public Form2()
        {
            InitializeComponent();

            AtualizaListBox();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Se o item estiver em branco, não adiciona
            if (txtNovoItem.Text == "")
                return;

            // Adiciona o novo item a Lista de categorias
            categorias.Add(txtNovoItem.Text);

            AtualizaListBox();
            txtNovoItem.Clear();
        }

        void AtualizaListBox()
        {
            // Limpa a lista
            listBox1.Items.Clear();

            // Para cada elemento das categorias
            foreach (string categoria in categorias)
            {
                // Adiciona a categoria na lista
                listBox1.Items.Add(categoria);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ativa o botão de remover
            btnRemover.Enabled = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja remover o item?",
                "Remoção de item",
                MessageBoxButtons.YesNo
            );

            // Se a resposta é não, encerra a função.
            if (resultado == DialogResult.No)
                return;

            // Pega o indice o item selecionado na lista
            int indiceItem = listBox1.SelectedIndex;

            // Remove o item da lista
            categorias.RemoveAt(indiceItem);

            btnRemover.Enabled = false;

            AtualizaListBox();
        }
    }
}
