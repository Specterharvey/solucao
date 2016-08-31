using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            var lista = new List<Aluno>();
            while (continuar == "s")
            {
                Console.WriteLine("Digite seu nome :");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite sua Idade");
                int idade = int.Parse(Console.ReadLine());
                var aluno = new Aluno(nome, idade);
                lista.Add(aluno);
                Console.WriteLine("Deseja Continuar ? s ou n");
                continuar = Console.ReadLine();

            }

            foreach (Aluno item in lista)
            {
                Console.WriteLine("{0} tem {1} anos de idade", item.Nome, item.Idade);
            }
        }
    }
}
