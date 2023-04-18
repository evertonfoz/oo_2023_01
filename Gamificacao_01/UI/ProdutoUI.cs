//using System;
//using System.Collections.Generic;


//    namespace JRJ.Produto{
//    static void GerenciarProdutos()
//    {
//        bool continuar = true;
//        do
//        {
//            Console.Clear();
//            Console.WriteLine("1 - Listar produtos");
//            Console.WriteLine("2 - Cadastrar produto");
//            Console.WriteLine("3 - Alterar produto");
//            Console.WriteLine("4 - Excluir produto");
//            Console.WriteLine("0 - Voltar");
//            Console.Write("Escolha uma opção: ");
//            string opcao = Console.ReadLine();

//            switch (opcao)
//            {
//                case "1":
//                    ListarProdutos();
//                    break;
//                case "2":
//                    CadastrarProduto();
//                    break;
//                case "3":
//                    AlterarProduto();
//                    break;
//                case "4":
//                    ExcluirProduto();
//                    break;
//                case "0":
//                    continuar = false;
//                    break;
//                default:
//                    Console.WriteLine("Opção inválida!");
//                    break;
//            }
//            Console.WriteLine();
//            Console.WriteLine("Pressione qualquer tecla para continuar...");
//            Console.ReadKey();
//        } while (continuar);
//    }

//    static void ListarProdutos()
//    {
//        Console.Clear();
//        Console.WriteLine("Lista de produtos:");
//        foreach (var produto in produtos)
//        {
//            Console.WriteLine($"ID: {produto.Id} | Nome: {produto.Nome} | Preço: {produto.Preco} | Categoria: {produto.Categoria.Nome}");
//        }
//    }


//    static void CadastrarProduto()
//    {
//        Console.Clear();
//        Console.WriteLine("Cadastro de produto:");

//        Produto produto = new Produto();

//        produto.Id = proximoIdProduto++;

//        Console.Write("Nome: ");
//        produto.Nome = Console.ReadLine();

//        Console.Write("Preço: ");
//        produto.Preco = double.Parse(Console.ReadLine());

//        Console.Write("ID da categoria: ");
//        int idCategoria = int.Parse(Console.ReadLine());
//        produto.Categoria = categorias.Find(c => c.Id == idCategoria);

//        produtos.Add(produto);

//        Console.WriteLine("Produto cadastrado com sucesso!");
//    }

//    static void AlterarProduto()
//    {
//        Console.Clear();
//        Console.WriteLine("Alteração de produto:");

//        Console.Write("ID do produto: ");
//        int idProduto = int.Parse(Console.ReadLine());

//        Produto produto = produtos.Find(p => p.Id == idProduto);

//        if (produto != null)
//        {
//            Console.Write($"Nome ({produto.Nome}): ");
//            string nome = Console.ReadLine();
//            if (!string.IsNullOrEmpty(nome))
//            {
//                produto.Nome = nome;
//            }

//            Console.Write($"Preço ({produto.Preco}): ");
//            string precoStr = Console.ReadLine();
//            if (!string.IsNullOrEmpty(precoStr))
//            {
//                produto.Preco = double.Parse(precoStr);
//            }

//            Console.Write($"ID da categoria ({produto.Categoria.Id}): ");
//            string idCategoriaStr = Console.ReadLine();
//            if (!string.IsNullOrEmpty(idCategoriaStr))
//            {
//                int idCategoria = int.Parse(idCategoriaStr);
//                produto.Categoria = categorias.Find(c => c.Id == idCategoria);
//            }

//            Console.WriteLine("Produto alterado com sucesso!");
//        }
//        else
//        {
//            Console.WriteLine("Produto não encontrado!");
//        }
//    }

//    static void ExcluirProduto()
//    {
//        Console.Clear();
//        Console.WriteLine("Exclusão de produto:");

//        Console.Write("ID do produto: ");
//        int idProduto = int.Parse(Console.ReadLine());

//        Produto produto = produtos.Find(p => p.Id == idProduto);

//        if (produto != null)
//        {
//            produtos.Remove(produto);
//            Console.WriteLine("Produto excluído com sucesso!");
//        }
//        else
//        {
//            Console.WriteLine("Produto não encontrado!");
//        }
//    }
//}
