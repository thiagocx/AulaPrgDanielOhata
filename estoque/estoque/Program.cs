using System;

namespace estoque
{
    public class produto
    {
        // cria variaveis publicas
        public string Nome;
        public double Preco;
        public int Quantidade;
        //cria construtor

            public produto (string nome, double preco, int quantidade) { 
            Nome = nome;
            Preco = preco; 
            Quantidade = quantidade; 
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        //cria função para adicionar produto
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        //cria função para remover produto

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        //cria processo de conversão
        public override string ToString()
        {
            return Nome
            + ", R$ "
            + Preco.ToString("F2")
            + ", "
            + Quantidade
            + " unidades, Total: R$ "
            + ValorTotalEmEstoque().ToString("F2");
        }
    }
    public class Program
    {
        static void Main(string[] arg)
        {//chama variaves de outra classe
            //efetua  o programa
            Console.WriteLine("Entre com os dados do produto;");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Preço: ");
            double Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int Quantidade = int.Parse(Console.ReadLine());

            //atribui a variavel ao construtor
            produto p = new produto(Nome, Preco, Quantidade);
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine("Dados do atualizados: " + p);
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine("Dados do atualizados: " + p);
        }
        }
}