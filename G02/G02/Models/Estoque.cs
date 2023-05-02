using Gamificacao.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gamificacao.Models
{
    public class Estoque
    {
        private List<ProdutoModel> _produtos;
        private List<Promocao> promocoes;
        public Estoque()
        {
            _produtos = new List<ProdutoModel>();
            promocoes = new List<Promocao>();
        }

        public void AdicionarPromocao(Promocao promocao)
        {
            foreach (var produto in _produtos)
            {
                if (promocao.Produtos().Contains(produto))
                {
                    //produto.Desconto = promocao.ValorDesconto;
                }
            }
        }



        public void AdicionarProduto(ProdutoModel produto)
        {
            _produtos.Add(produto);
        }

        public List<ProdutoModel> ListarProdutos(int code)
        {
            List<ProdutoModel> produtosFiltrados = new List<ProdutoModel>();
            //foreach (var produto in _produtos)
            //{
            //    if (code == produto.Tipo)
            //    {
            //        produtosFiltrados.Add(produto);
            //    }
            //}
            return produtosFiltrados;
        }

        public void RemoverProduto(long produtoID)
        {
            var produto = _produtos.FirstOrDefault(p => p.ProdutoID == produtoID);
            if (produto != null)
            {
                _produtos.Remove(produto);
            }
        }
        public ProdutoModel ObterProdutoPorCodigo(int codigo)
        {
            return _produtos.FirstOrDefault(p => p.ProdutoID == codigo);
        }




        public ProdutoModel AdicionarProdutoNoCarrinho(long produtoID, int tipo)
        {
            List<ProdutoModel> produtosFiltrados = ListarProdutos(tipo);
            var produto = produtosFiltrados.FirstOrDefault(p => p.ProdutoID == produtoID);
            if (produto != null)
            {
                Promocao promocao = promocoes.FirstOrDefault(pr => pr.Produtos().Contains(produto));
                if (promocao != null)
                {
                    decimal desconto = 0;
                    if (promocao.TipoDesconto == TipoDesconto.Porcentagem)
                    {
                        desconto = produto.Preco * (promocao.ValorDesconto / 100);
                    }
                    else if (promocao.TipoDesconto == TipoDesconto.ValorFixo)
                    {
                        desconto = promocao.ValorDesconto;
                    }
                    //produto.Desconto = desconto;
                }
                else
                {
                    //produto.Desconto = 0;
                }
                _produtos.Remove(produto);
                return produto;
            }
            return null;
        }

        public List<ProdutoModel> ListarProdutosPorCategoria(string categoria)
        {
            List<ProdutoModel> produtosPorCategoria = new List<ProdutoModel>();
            foreach (ProdutoModel produto in _produtos)
            {
                if (Enum.TryParse(categoria, out CategoriaEnum categoriaProduto) && produto.Categoria == categoriaProduto)
                {
                    produtosPorCategoria.Add(produto);
                }




            }
            return produtosPorCategoria;
        }



    }
}


