using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamificacao.Models.Enums;

namespace Gamificacao.Models
{
    public abstract class ProdutoModel
    {
        public long ProdutoID { get; private set; }
        public string Codigo { get; private set; }
        //public int Tipo { get; set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public decimal Desconto { get; private set; }

        public CategoriaEnum Categoria { get; private set; }

        public ProdutoModel(long produtoID, string codigo, string nome, decimal preco, decimal desconto)
        {
            ProdutoID = produtoID;
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }


        public abstract decimal CalcularValorDoDesconto(Promocao? promocao);

    }

}
