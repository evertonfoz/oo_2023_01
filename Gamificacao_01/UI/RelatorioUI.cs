//   using System;
//using System.Collections.Generic;


//    namespace JRJ.Relatorio{
//    static void MostrarRelatorioVendas()
//    {
//        Console.Clear();
//        Console.WriteLine("Relatório de Vendas:");

//        if (vendas.Count == 0)
//        {
//            Console.WriteLine("Não há vendas registradas.");
//            return;
//        }

//        double totalVendas = 0;

//        foreach (var venda in vendas)
//        {
//            Console.WriteLine($"ID da venda: {venda.Id} | Data: {venda.Data} | Cliente: {venda.Cliente.Nome}");

//            foreach (var itemVenda in venda.Itens)
//            {
//                Console.WriteLine($"   - Produto: {itemVenda.Produto.Nome} | Quantidade: {itemVenda.Quantidade} | Preço unitário: {itemVenda.PrecoUnitario:C2} | Subtotal: {itemVenda.Subtotal:C2}");
//            }

//            Console.WriteLine($"   Total da venda: {venda.Total:C2}");
//            Console.WriteLine();

//            totalVendas += venda.Total;
//        }

//        Console.WriteLine($"Total de vendas: {vendas.Count} | Valor total das vendas: {totalVendas:C2}");

//    }
//}