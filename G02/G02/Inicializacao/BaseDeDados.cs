using System;
using Gamificacao.Models;
using Gamificacao.Models.Enums;

namespace G02.Inicializacao
{

    public class BaseDeDados
	{
        private Estoque _estoque;

        public BaseDeDados(Estoque estoque)
		{
            _estoque = estoque;
		}

		public void PopularBaseDeDados()
		{
            //_estoque.AdicionarProduto(new Bolsa()
            //{
            //    Codigo = 1,
            //    Tipo = 1,
            //    Nome = "Bolsa Feminina",
            //    Preco = 9112.90m,
            //    Categoria = CategoriaProduto.Acessorio,
            //    Cor = CorAcessorio.Preto,
            //    Tamanho = TamanhoAcessorio.G,
            //    Material = "Couro",
            //    NumeroCompartimentos = 4
            //});

            //_estoque.AdicionarProduto(new Calcado()
            //{
            //    Codigo = 1,
            //    Tipo = 2,
            //    Nome = "Sapato Social Masculino",
            //    Preco = 149.90m,
            //    Categoria = CategoriaProduto.Acessorio,
            //    Cor = CorAcessorio.Preto,
            //    Tamanho = TamanhoAcessorio.G,
            //    TamanhoSapato = TamanhoSapato.Numero42,
            //    Marca = "Calvin Klein"
            //});

            //_estoque.AdicionarProduto(new Calca()
            //{
            //    Codigo = 1,
            //    Tipo = 3,
            //    Nome = "Calça Jeans unisex",
            //    Preco = 89.90m,
            //    Categoria = CategoriaProduto.Calca,
            //    Tamanho = TamanhoCalca.M,
            //    Cor = CorRoupa.Azul
            //});

            //_estoque.AdicionarProduto(new Calca()
            //{
            //    Codigo = 2,
            //    Tipo = 3,
            //    Nome = "Calça Tactel unisex",
            //    Preco = 89.90m,
            //    Categoria = CategoriaProduto.Calca,
            //    Tamanho = TamanhoCalca.M,
            //    Cor = CorRoupa.Azul
            //});

            //_estoque.AdicionarProduto(new Calca()
            //{
            //    Codigo = 3,
            //    Tipo = 3,
            //    Nome = "Calça Leg Feminina",
            //    Preco = 89.90m,
            //    Categoria = CategoriaProduto.Calca,
            //    Tamanho = TamanhoCalca.M,
            //    Cor = CorRoupa.Azul
            //});

            //_estoque.AdicionarProduto(new Calca()
            //{
            //    Codigo = 4,
            //    Tipo = 3,
            //    Nome = "Calça Jeans Masculina",
            //    Preco = 89.90m,
            //    Categoria = CategoriaProduto.Calca,
            //    Tamanho = TamanhoCalca.M,
            //    Cor = CorRoupa.Azul
            //});

            //_estoque.AdicionarProduto(new Calca()
            //{
            //    Codigo = 1,
            //    Tipo = 4,
            //    Nome = "Camisa peruana",
            //    Preco = 89.90m,
            //    Categoria = CategoriaProduto.Calca,
            //    Tamanho = TamanhoCalca.M,
            //    Cor = CorRoupa.Azul
            //});

            //_estoque.AdicionarProduto(new Calca()
            //{
            //    Codigo = 2,
            //    Tipo = 4,
            //    Nome = "Camisa lala",
            //    Preco = 89.90m,
            //    Categoria = CategoriaProduto.Calca,
            //    Tamanho = TamanhoCalca.M,
            //    Cor = CorRoupa.Azul
            //});

            //_estoque.AdicionarProduto(new Calca()
            //{
            //    Codigo = 3,
            //    Tipo = 4,
            //    Nome = "Camisa polo",
            //    Preco = 89.90m,
            //    Categoria = CategoriaProduto.Calca,
            //    Tamanho = TamanhoCalca.M,
            //    Cor = CorRoupa.Azul
            //});
        }
	}
}

