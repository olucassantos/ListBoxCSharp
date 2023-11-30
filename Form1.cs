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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<int> idades = new List<int>();

            // Adiciona itens dentro da lista
            idades.Add(18);
            idades.Add(30);
            idades.Add(35);
            idades.Add(40);

            // Os itens de uma lista podem ser acessados por colchetes
            // indicando a posição;
            // MessageBox.Show(idades[2].ToString());

            // Passa por cada item da lista
            foreach (int i in idades)
            {
                MessageBox.Show("Listagem" + i.ToString());
            }

            // Remove o primeiro item da lista
            // idades.RemoveAt(0);

            // Remove o ultimo item da lista
            // idades.RemoveAt(idades.Count - 1);

            foreach (int i in idades)
            {
                MessageBox.Show("Listagem 2" + i.ToString());
            }

            // Verifica se existe um item na lista
            if (idades.Contains(35))
                MessageBox.Show("Contem o 35");

            // Pegar o index de um item
            int index = idades.IndexOf(35);
            // idades.RemoveAt(index);

            // Limpa uma lista
            // idades.Clear();

            foreach(int idade in idades)
            {
                listBox1.Items.Add(idade);
            }
        }

        
        
    }
}
