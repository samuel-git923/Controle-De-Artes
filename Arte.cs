using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeArtes
{
    public class Arte : IArte
    {
        public Arte()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        public Arte(String nome, String descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        private string nome;
        public string Nome 
        {
            get { return this.nome; }

            set { this.nome = value.ToUpper(); }
        }

        private string descricao;
        public string Descricao 
        { 
            get { return this.descricao; }
            
            set { this.descricao = value.ToUpper(); }  
        }

        public void ExibirDados()
        {
            //Console.WriteLine("Arte: " + this.Nome + "Descricao: " + this.Descricao);
            Console.WriteLine("Arte: {0} - Descricao {1}", this.Nome, this.Descricao);
        }
    }
}
