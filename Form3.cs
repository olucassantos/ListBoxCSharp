using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace CestasDaPrima 
{
    public partial class Form3 : Form
    {
        List<Produto> lista_produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Chocolate", Preco = 19.9m },
            new Produto { Id = 2, Nome = "Vinho", Preco = 29.5m },
            new Produto { Id = 3, Nome = "Flores", Preco = 15.0m },
            new Produto { Id = 4, Nome = "Cartão de Aniversário", Preco = 5.99m },
            new Produto { Id = 5, Nome = "Cesta de Frutas", Preco = 25.0m },
            new Produto { Id = 6, Nome = "Perfume", Preco = 49.99m },
            new Produto { Id = 7, Nome = "Caneca Personalizada", Preco = 12.5m },
            new Produto { Id = 8, Nome = "Bolo Decorado", Preco = 34.99m },
            new Produto { Id = 9, Nome = "Chá Especial", Preco = 9.0m },
            new Produto { Id = 10, Nome = "Kit de Velas Perfumadas", Preco = 18.75m },
            new Produto { Id = 11, Nome = "Livro de Poesias", Preco = 22.8m },
            new Produto { Id = 12, Nome = "Bouquet de Balões", Preco = 8.5m },
            new Produto { Id = 13, Nome = "Kit de Massagem", Preco = 42.0m },
            new Produto { Id = 14, Nome = "Caneta de Luxo", Preco = 30.25m },
            new Produto { Id = 15, Nome = "Café Gourmet", Preco = 14.99m },
            new Produto { Id = 16, Nome = "Kit de Maquiagem", Preco = 55.0m },
            new Produto { Id = 17, Nome = "Almofada Personalizada", Preco = 16.5m },
            new Produto { Id = 18, Nome = "Queijo Especial", Preco = 27.75m },
            new Produto { Id = 19, Nome = "Relógio Decorativo", Preco = 38.0m },
            new Produto { Id = 20, Nome = "Jogo de Toalhas Bordadas", Preco = 19.0m },
            new Produto { Id = 21, Nome = "Conjunto de Taças", Preco = 32.5m },
            new Produto { Id = 22, Nome = "Caixa de Bombons Finos", Preco = 23.49m },
            new Produto { Id = 23, Nome = "Cesta de Café da Manhã", Preco = 44.99m },
            new Produto { Id = 24, Nome = "Kit de Plantas Ornamentais", Preco = 28.0m },
            new Produto { Id = 25, Nome = "Porta-Retrato Personalizado", Preco = 10.0m },
            new Produto { Id = 26, Nome = "Sabonetes Artesanais", Preco = 13.25m },
            new Produto { Id = 27, Nome = "Kit de Jogos de Tabuleiro", Preco = 36.75m },
            new Produto { Id = 28, Nome = "Garrafa de Champagne", Preco = 49.5m },
            new Produto { Id = 29, Nome = "Kit de Pintura", Preco = 20.99m },
            new Produto { Id = 30, Nome = "Copo Térmico", Preco = 15.0m }
        };

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Executa quando o formulário carrega
            ConfiguraListView();
        }

        /*
            Configura as colunas do listView
        */
        void ConfiguraListView()
        {
            lsvItens.View = View.Details;
            lsvItens.Columns.Add("ID");
            lsvItens.Columns.Add("Nome");
            lsvItens.Columns.Add("Preço");

            lstResultadosBusca.View = View.Details;
            lstResultadosBusca.Columns.Add("ID");
            lstResultadosBusca.Columns.Add("Nome");
            lstResultadosBusca.Columns.Add("Preço");

            AtualizaItensListView();
        }

        void AtualizaItensListView()
        {
            // Limpa os itens da lista
            lsvItens.Items.Clear();

            // Percorre os itens da lista, adicionando no list View
            foreach (Produto produto in lista_produtos)
            {
                AdicionarItemListView(produto);
            }
        }

        /*
            Adiciona um item no listView
        */
        void AdicionarItemListView(Produto produto)
        {
            // Cria um item vazio
            ListViewItem item = new ListViewItem(produto.Id.ToString());

            item.SubItems.Add(produto.Nome);
            item.SubItems.Add(produto.Preco.ToString("c"));

            // Adiciona o item na listView
            lsvItens.Items.Add(item);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Produto produto;

            //produto.Id = 1;
            //produto.Nome = "Chocolate";
            //produto.Preco = 19.9m;

            Produto produto = new Produto { Id = 1, Nome = "Chocolate", Preco = 19.9m };

            AdicionarItemListView(produto);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Pega os itens selecionados de um ListView
            //SelectedListViewItemCollection itens = lsvItens.SelectedItems;

            // Percorre cada item selecionado no ListView
            foreach (ListViewItem item in lsvItens.SelectedItems)
            {
                int id = int.Parse(item.Text);

                Produto produto = lista_produtos.Find(prod => prod.Id == id);

                lista_produtos.Remove(produto);
            }

            AtualizaItensListView();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            // Mostrar o formulário
            grbFormulario.Visible = true;

            // Foca no campo Nome
            txtNome.Focus();

            // Desabilitar o botão Novo Item
            btnAdicionar.Enabled = false;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;

            // Pegar o ultimo ID da lista de produtos
            numID.Value = PegarUltimoIdLista() + 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Busca o ID do produto selecionado
            foreach (ListViewItem item in lsvItens.SelectedItems)
            {
                int id = int.Parse(item.Text);

                Produto produto = lista_produtos.Find(prod => prod.Id == id);

                numID.Value = produto.Id;
                txtNome.Text = produto.Nome;
                numPreco.Value = produto.Preco;

                // Para o laço de repetição.
                break;
            }

            if (numID.Value == 0)
                return;

            // Mostrar o formulário
            grbFormulario.Visible = true;

            // Foca no campo Nome
            txtNome.Focus();

            // Desabilitar o botão Novo Item
            btnAdicionar.Enabled = false;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
        }

        /*
            Pega o ultimo ID de uma List<> 
        */
        private int PegarUltimoIdLista()
        {
            return lista_produtos.Max(produto => produto.Id);
        }

        /*
            Fecha o formulário e limpa os campos 
        */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FechaFormulario();
        }

        /*
            Salva os valores na lista 
        */
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validar as informações
            if (txtNome.Text == "")
            {
                MessageBox.Show("O nome do produto não pode ficar em branco!");
                txtNome.Focus();
                return;
            }

            if (numPreco.Value == 0)
            {
                MessageBox.Show("O preço do produto não pode ser Zero!");
                numPreco.Focus();
                return;
            }

            if (numID.Value == 0)
            {
                return;
            }

            // Verifica se um ID já existe na lista, caso não existe é adição
            int id = ((int)numID.Value);
            Produto? produto = BuscaProdutoId(id);

            // Caso não seja nulo, encontrou um item
            if (produto != null)
            {
                // Busca o index do item a ser pesquisado
                int index = lista_produtos.FindIndex(item => object.Equals(item, produto));

                Produto produto_editado = new Produto { Id = (int)numID.Value, Nome = txtNome.Text, Preco = numPreco.Value };
                lista_produtos[index] = produto_editado;
            }
            else
            {
                // Adiciona um item

                Produto novo_produto = new Produto { 
                    Id = (int)numID.Value, 
                    Nome = txtNome.Text, 
                    Preco = numPreco.Value 
                };

                lista_produtos.Add(novo_produto);
            }

            FechaFormulario();
            AtualizaItensListView();
        }

        private Produto? BuscaProdutoId(int Id)
        {
            Produto produto = lista_produtos.Find(prod => prod.Id == Id);

            if (produto.Id == 0)
                return null;

            return produto;
        }

        void FechaFormulario()
        {
            // Esconde o formulário
            grbFormulario.Visible = false;

            // Habilita os botões
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnApagar.Enabled = true;

            // Limpa os campos
            txtNome.Clear();
            numID.Value = 0;
            numPreco.Value = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;

            List<Produto> resultados_busca = lista_produtos.FindAll(
                prod => prod.Nome.Contains(pesquisa)
            );

            lstResultadosBusca.Items.Clear();

            foreach (Produto prod in resultados_busca)
            {
                // Cria um item vazio
                ListViewItem item = new ListViewItem(prod.Id.ToString());

                item.SubItems.Add(prod.Nome);
                item.SubItems.Add(prod.Preco.ToString("c"));

                // Adiciona o item na listView
                lstResultadosBusca.Items.Add(item);
            }
        }
    }
}