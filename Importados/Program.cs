using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importados
{
    class Program
    {
        static double taxa, preço;
        static string produto, status, data, s1;



        static void Main(string[] args)
        {
            
            int n = 0 ;
            //identificão de quantos usuarios serão criados
            Console.Write("Quantos produtos serão criados:");
            n = int.Parse(Console.ReadLine());
            //criação da lista
            List<string> list = new List<string>();
            //for para gerar as listas agrupadaa
            for (int i = 1; i <= n; i++)
            {
                //Informa a lista
                list = new List<string>();
                //Informações de dentro da lista
                Console.WriteLine("produto #" + i);
                Console.WriteLine("Comum, Usado ou Importado (C/U/I)?");
                status = Console.ReadLine();

                //caso escolha c, imprima:
                if (status == "c")
                {
                    string nn = i.ToString();
                    list.Add(nn);
                    Console.Write("nome: ");
                    produto = Console.ReadLine();
                    list.Add(produto);
                    Console.WriteLine("preço: ");
                    preço = double.Parse(Console.ReadLine());
                    list.Add(preço.ToString());
                    Console.WriteLine("taxa: ");
                    taxa = double.Parse(Console.ReadLine());
                    list.Add(taxa.ToString());
                }
                //caso escolha u, imprima:

                else if (status == "u")
                {
                    string nnn = i.ToString();
                    string nn = i.ToString();
                    list.Add(nn);
                    Console.Write("nome: ");
                    produto = Console.ReadLine();
                    list.Add(produto);
                    Console.WriteLine("preço: ");
                    preço = double.Parse(Console.ReadLine());
                    list.Add(preço.ToString());
                    
                }
                //caso escolha i, imprima:
                else if (status == "i")
                {
                    string nn = i.ToString();
                    list.Add(nn);
                    Console.Write("nome: ");
                    produto = Console.ReadLine();
                    list.Add(produto);
                    Console.WriteLine("preço: ");
                    preço = double.Parse(Console.ReadLine());
                    list.Add(preço.ToString());
                    Console.WriteLine("fabricação(dd/mm/aaaa): ");
                    data = Console.ReadLine();
                    list.Add(data);

                }

                foreach (var nn in list)
                {

                    if (status == "c")
                    {
                        Console.WriteLine("-- " + produto + " -- " + preço + " -- taxa -- " + taxa);

                    }
                     if (status == "u")
                    {
                        Console.WriteLine("-- " + produto + " -- " + preço);

                    }
                     if (status == "i")
                    {
                        Console.WriteLine("-- " + produto + " -- " + preço + " -- fabricado -- " + data);

                    }
                }
                Console.ReadKey();
            }
            
            

        }

    }
    
}
