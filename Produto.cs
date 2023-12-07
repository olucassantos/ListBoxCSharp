using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestasDaPrima
{
    struct Produto
    {
        public int Id;
        public string Nome;
        public decimal Preco;
    }
    
    class Listas
    {
        public Listas() { }

        public List<Produto> lista_produtos = new List<Produto>
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

        public static List<Produto> produtos()
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

            return lista_produtos;
        }
    }
}
