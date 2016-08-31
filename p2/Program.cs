using p1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Program
    { 
        static void Main(string[] args)
        {
            var lista = new List<Biblioteca>();
            string nomelivro;
            string autor;
            string edicao;
            int ano;
            string editora;

            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("Digite o Nome do Livro:");
                nomelivro = Console.ReadLine();
                Console.WriteLine("Digite o Autor do Livro :");
                autor = Console.ReadLine();
                Console.WriteLine("Digite a Edição do Livro");
                edicao = Console.ReadLine();
                Console.WriteLine("Digite o ano do Livro :");
                ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a Editora");
                editora = Console.ReadLine();

                var aluno = new Biblioteca(nomelivro,autor,edicao,ano,editora);
                lista.Add(aluno);
                Console.WriteLine("Deseja Continuar ? s ou n");
                continuar = Console.ReadLine();
            }
            foreach (var item in lista)
            {
                Console.WriteLine("Livro : {0} | Autor : {1} | Edição : {2} | Ano : {3} | Editora : {4}", item.Nomelivro,
                    item.Autor, item.Edicao, item.Ano, item.Editora);
            }
            
        }
    }
}
