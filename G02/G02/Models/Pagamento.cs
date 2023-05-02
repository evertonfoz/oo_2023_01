//using Gamificacao.Models.Enums;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Gamificacao.Models
//{
//    public class Pagamento
//    {
//        public CarrinhoDeCompras CarrinhoDeCompras { get; set; }
//        public string NomeCliente { get; set; }
//        public string EnderecoEntrega { get; set; }

//        public void RealizarPagamento(CarrinhoDeCompras carrinho)
//        {
//            CarrinhoDeCompras = carrinho;
//            GerarNotaFiscal(CarrinhoDeCompras);
//        }

//        public void GerarNotaFiscal(CarrinhoDeCompras carrinho)
//        {
//            Console.WriteLine("Nota Fiscal");
//            Console.WriteLine($"Nome do Cliente: {NomeCliente}");
//            Console.WriteLine($"Endereço de Entrega: {EnderecoEntrega}");

//            decimal totalDescontosProduto = 0;
//            decimal precoTotalAtualizado = 0;
//            foreach (var produto in carrinho.Produtos)
//            {
//                decimal descontoProduto = produto.Desconto;
//                totalDescontosProduto += descontoProduto;

//                decimal precoAtualizado = produto.Preco - descontoProduto;
//                precoTotalAtualizado += precoAtualizado;
//                Console.WriteLine($"{produto.Codigo} - {produto.Nome} ({produto.Preco:C2} => {precoAtualizado:C2})");
//            }

//            decimal totalCompra = carrinho.ObterValorTotal();
//            Console.WriteLine($"Total dos produtos: {totalCompra:C2}");
//            Console.WriteLine($"Total de descontos de produto: {totalDescontosProduto:C2}");
//            Console.WriteLine($"Total a pagar: {precoTotalAtualizado:C2}");

//            if (!carrinho.Produtos.Any())
//            {
//                Console.WriteLine("O carrinho está vazio.");
//            }
//        }


//    }



//}


