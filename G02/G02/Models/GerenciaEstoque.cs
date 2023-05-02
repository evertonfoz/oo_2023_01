//using gamificação.Models.Enums;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace gamificação.Models
//{
//    public class GerenciaEstoque
//    {
//        private Estoque _estoque = new Estoque();

//        public GerenciaEstoque()
//        {
//            AdicionarProdutosAoEstoque();
//        }



//        public void AdicionarProdutosAoEstoque()
//        {

//            _estoque.AdicionarProduto(new Bolsa()
//            {
//                Codigo = 1,
//                Tipo = 1,
//                Nome = "Bolsa Feminina",
//                Preco = 99.90m,
//                Categoria = CategoriaProduto.Bolsa,
//                Cor = CorAcessorio.Preto,
//                Tamanho = TamanhoAcessorio.G,
//                Material = "Couro",
//                NumeroCompartimentos = 4
//            });

//            _estoque.AdicionarProduto(new Sapato()
//            {
//                Codigo = 1,
//                Tipo = 2,
//                Nome = "Sapato Social Masculino",
//                Preco = 149.90m,
//                Categoria = CategoriaProduto.Sapato,
//                Cor = CorAcessorio.Preto,
//                Tamanho = TamanhoAcessorio.G,
//                TamanhoSapato = TamanhoSapato.Numero42,
//                Marca = "Calvin Klein"
//            });

//            _estoque.AdicionarProduto(new Calca()
//            {
//                Codigo = 1,
//                Tipo = 3,
//                Nome = "Calça Jeans Masculina",
//                Preco = 89.90m,
//                Categoria = CategoriaProduto.Calca,
//                Tamanho = TamanhoCalca.M,
//                Cor = CorRoupa.Azul
//            });
//            _estoque.AdicionarProduto(new Calca()
//            {
//                Codigo = 2,
//                Tipo = 3,
//                Nome = "Calça Jeans Masculina",
//                Preco = 89.90m,
//                Categoria = CategoriaProduto.Calca,
//                Tamanho = TamanhoCalca.M,
//                Cor = CorRoupa.Azul
//            });
//            _estoque.AdicionarProduto(new Calca()
//            {
//                Codigo = 3,
//                Tipo = 3,
//                Nome = "Calça Jeans Masculina",
//                Preco = 89.90m,
//                Categoria = CategoriaProduto.Calca,
//                Tamanho = TamanhoCalca.M,
//                Cor = CorRoupa.Azul
//            });
//            _estoque.AdicionarProduto(new Calca()
//            {
//                Codigo = 4,
//                Tipo = 3,
//                Nome = "Calça Jeans Masculina",
//                Preco = 89.90m,
//                Categoria = CategoriaProduto.Calca,
//                Tamanho = TamanhoCalca.M,
//                Cor = CorRoupa.Azul
//            });


//        }

//    }
//}
