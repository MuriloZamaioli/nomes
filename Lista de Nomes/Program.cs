using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Nomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria uma lista para armazenar os nomes dos amigos
            List<string> amigos = new List<string>();

            //Variável para armazenar o nome inserido
            string nomeAmigo;
            int contador = 0;
            

            //Solicita ao usuário a inserção dos nomes
            Console.WriteLine("Digite o nome dos amigos (digite 'sair' para terminar):");

            //loop para inserir os nomes
            do
            {
                Console.Write("Digite o nome do amigo: ");
                nomeAmigo = Console.ReadLine();
                contador++;
                //Adiciona o nome a lista, a menos que seja "sair"
                if (nomeAmigo.ToLower() != "sair")
                {
                    amigos.Add(nomeAmigo);
                }
            } while (nomeAmigo.ToLower() != "sair");

            //Exibe os nomes dos amigos usando foreach
            Console.WriteLine("\nOs nomes dos amigos são: ");
            foreach (string amigo in amigos)
            {
                Console.WriteLine(amigo);
                
            }
            //int totalAmigos = amigos.Count;
            Console.WriteLine($"Você tem um total de {contador-1} amigos");
            Console.ReadKey();
        }
    }
}
