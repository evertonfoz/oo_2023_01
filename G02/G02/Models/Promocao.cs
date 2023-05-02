using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamificacao.Models.Enums;

namespace Gamificacao.Models
{
    public class Promocao
    {
        /// <summary>
        /// Propriedades Públicas
        /// </summary>
        public decimal ValorDesconto { get; private set; }
        public TipoDesconto TipoDesconto { get; private set; }

        /// Campos privados
        private List<ProdutoModel> _produtos = new List<ProdutoModel>();


        /// Construtores
        public Promocao(TipoDesconto tipoDesconto, decimal valorDesconto)
        {
            TipoDesconto = tipoDesconto;
            ValorDesconto = valorDesconto;
        }


        ///  Serviços
        public void RegistrarProduto(ProdutoModel produto)
        {
            _produtos.Add(produto);
        }

        
        public IReadOnlyCollection<ProdutoModel> Produtos()
        {
            return _produtos.AsReadOnly();
            //return new List<ProdutoModel>(_produtos);
        }


        public decimal CalcularDesconto(ProdutoModel produto)
        {
            if (!_produtos.Contains(produto))
            {
                return 0;
            }

            if (TipoDesconto == TipoDesconto.Porcentagem)
            {
                return produto.Preco * ValorDesconto / 100;
            }
            else if (TipoDesconto == TipoDesconto.ValorFixo)
            {
                return ValorDesconto;
            }

            return 0;
        }
    }
}
