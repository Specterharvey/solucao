using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    public class Biblioteca
    {
        private string nomelivro;
        private string autor;
        private string edicao;
        private int ano;
        private string editora;

        public Biblioteca(string nomelivro, string autor, string edicao, int ano, string editora)
        {
            this.nomelivro = nomelivro;
            this.autor = autor;
            this.edicao = edicao;
            this.ano = ano;
            this.editora = editora;
        }

        public string Nomelivro
        {
            get
            {
                return nomelivro;
            }

            set
            {
                nomelivro = value;
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public string Edicao
        {
            get
            {
                return edicao;
            }

            set
            {
                edicao = value;
            }
        }

        public int Ano
        {
            get
            {
                return ano;
            }

            set
            {
                ano = value;
            }
        }

        public string Editora
        {
            get
            {
                return editora;
            }

            set
            {
                editora = value;
            }
        }
    }
}
