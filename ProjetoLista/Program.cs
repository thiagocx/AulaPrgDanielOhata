using System;
using System.Collections.Generic;

namespace ProjetoLista
{
    class Program
    {
        static string s1, s2;
        static void Main(string[] args)
        {
            
            //Criando a lista de strings
            List<string> list = new List<string>();
            //Adiciono elementos na lista
            list.Add("Fábio"); list.Add("Wilson"); list.Add("Angelina"); list.Add("Eliney"); list.Add("Andre");
            //Adiciona um elemento na posição sugerida
            Console.WriteLine("adicionando o usuario lucas na posição 2: ");
            list.Insert(2, "Lucas");

            //Realizo um loop de leitura dos elementos inseridos
            foreach (string obj in list)
            {
                //Conto quantos elementos tem na minha lista
                //Encontrar o primeiro elemento que inicia com a letra A, com uma função lambda
                 s1 = list.Find(x => x[0] == 'A');
               
                //Encontrar o último elemento que inicia com a letra A, com uma função lambda
                 s2 = list.FindLast(x =>

                {
                    return x[0] == 'A';
                });
                
            }
            Console.WriteLine("Qnt de elementos na Lista: " + list.Count);
            Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
            Console.WriteLine("Ultimo elemento que começa com a letra A: " + s2);

            //Buscar elementos pela sua posição
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posição de A: " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última Posição de A: " + pos2);
            //Buscar todos os elementos com tamanho igual a 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Elementos com caracteres igual a 5: ");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
                //Remover elementos da lista
                list.Remove("Andre");
               
               
            }
            Console.WriteLine("===================");
            Console.WriteLine("Removendo o usuario andré...");

            //Remover determinado elemento da lista
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("===================");
            Console.WriteLine("removendo usuario que tenha 'W'. ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Remover elemento de determinada posição lista
            list.RemoveAt(2);
            Console.WriteLine("===================");
            Console.WriteLine("removendo usuario na posição 3");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Continuação do programa
            //Remover elementos da lista a partir da posição e quantos elementos
            list.RemoveRange(1, 2);
            Console.WriteLine("===================");
            Console.WriteLine("removendo usuarios depois da posição 1  e com  mais de dois elementos");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

