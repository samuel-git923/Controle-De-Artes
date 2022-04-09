using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeArtes
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Arte> Artes = new List<Arte>();
            int n = 0;
            Arte arte;

            Console.WriteLine("Controle de obras de arte");
            Console.Write("Quantas obras você quer inserir? ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iniciando o cadastro das obras de arte");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Leitura da Obra {0}", i);
                arte = new Arte();
                Console.Write("Nome: ");
                arte.Nome = Console.ReadLine();
                Console.Write("Descricao: ");
                arte.Descricao = Console.ReadLine();
                Artes.Add(arte);
            }

            Console.WriteLine("Lista das obras de arte cadastradas");
            //for (int i = 0; i < n; i++)
            //{
            //    Artes[i].ExibirDados();
            //}

            foreach (var item in Artes)
            {
                item.ExibirDados();
            }

            Console.ReadKey();
        }
    }
}
