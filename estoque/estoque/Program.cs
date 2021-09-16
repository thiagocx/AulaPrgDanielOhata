using System;

namespace estoque
{
    public class Produto
    {
        // cria variaveis publicas
        public string Nome;
        public double Preco;
        public int Quantidade;
        //cria função para calcular valor total produto

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
            Produto p = new Produto();
            //efetua  o programa
            Console.WriteLine("Entre com os dados do produto;");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
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