using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    public class Aluno
    {
        private string nome;
        private int idade;

        public Aluno(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
        }
    }
}
