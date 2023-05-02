using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamificacao.Models.Enums;

namespace Gamificacao.Models
{
    public abstract class Acessorio : ProdutoModel
    {
        public TamanhoAcessorio Tamanho { get; set; }
        public CorAcessorio Cor { get; set; }

        public Acessorio(TamanhoAcessorio tamanhoAcessorio, CorAcessorio corAcessorio,
            long produtoID, string codigo, string nome, decimal preco,
            decimal desconto) : base(produtoID, codigo, nome, preco, desconto)
        {
            Tamanho = tamanhoAcessorio;
            Cor = corAcessorio;
        }

        public override decimal CalcularValorDoDesconto(Promocao? promocao)
        {
            decimal desconto = 0;

            if (promocao == null)
            {
                return desconto;
            }

            
            
            if (promocao.TipoDesconto == TipoDesconto.Porcentagem)
            {
                // desconto de porcentagem específico para camisetas
                desconto = (promocao.ValorDesconto / 100) * Preco;
            }
            else if (promocao.TipoDesconto == TipoDesconto.ValorFixo)
            {
                // desconto de valor fixo específico para camisetas
                desconto = promocao.ValorDesconto;
            }
            
            return desconto;
        
    }


    }


}

