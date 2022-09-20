using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Heranca.Models
{
    internal class Fisica : Pessoa
    {
        public Fisica(string nome, string cpf) : base(nome)
        {
            CPF = cpf;
            logDeSucesso();
        }

        public string CPF { get; set; }

        public override string ToString()
        {
            return $"[{Nome}]: [{CPF}]";
        }

        protected override void logDeSucesso()
        {
            base.logDeSucesso();
            System.Console.WriteLine($"Com o CPF {CPF}");
        }

    }
}
