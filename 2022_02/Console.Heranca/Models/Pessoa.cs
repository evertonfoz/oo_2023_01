using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Heranca.Models
{
    internal abstract class Pessoa
    {
        public string Nome { get; private set; }
        public Pessoa(string nome)
        {
            RegistrarNome(nome);
        }

        public void RegistrarNome(string nome)
        {
            Nome = nome.ToUpper();
            //logDeSucesso();
        }

        protected virtual void logDeSucesso()
        {
            System.Console.WriteLine($"{Nome} criado com sucesso");
        }

        //private void _logDeSucesso()
        //{
        //    System.Console.WriteLine($"{Nome} criado com sucesso");
        //}
    }
}
