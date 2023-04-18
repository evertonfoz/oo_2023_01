// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using JRJ.Modas.Model;
using JRJ.Modas.UI.Categoria;

namespace JRJ.Modas
{
    public class Program
    {
        //static List<Produto> produtos = new List<Produto>();
        static List<CategoriaModel> categorias = new List<CategoriaModel>();
        //static List<Cliente> clientes = new List<Cliente>();
        //static List<Venda> vendas = new List<Venda>();
        //static int proximoIdProduto = 1;
        //static int proximoIdCategoria = 1;
        //static int proximoIdCliente = 1;
        //static int proximoIdVenda = 1;

        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Gerenciar produtos");
                Console.WriteLine("2 - Gerenciar categorias");
                Console.WriteLine("3 - Gerenciar clientes");
                Console.WriteLine("4 - Realizar venda");
                Console.WriteLine("5 - Mostrar relatório de vendas");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //GerenciarProdutos();
                        break;
                    case "2":
                        new CategoriaUI(categorias).MenuDeFuncionalidades();

                        //var ui = new CategoriaUI(categorias);
                        //ui.MenuDeFuncionalidades();
                        break;
                    case "3":
                        //GerenciarClientes();
                        break;
                    case "4":
                        //RealizarVenda();
                        break;
                    case "5":
                        //MostrarRelatorioVendas();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (continuar);
        }

       

       
    }
}