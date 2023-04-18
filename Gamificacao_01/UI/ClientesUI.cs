//using System;
//using System.Collections.Generic;


//namespace JRJ.Clientes{
//static void GerenciarClientes()
//    {
//        bool continuar = true;
//        do
//        {
//            Console.Clear();
//            Console.WriteLine("1 - Listar clientes");
//            Console.WriteLine("2 - Cadastrar cliente");
//            Console.WriteLine("3 - Alterar cliente");
//            Console.WriteLine("4 - Excluir cliente");
//            Console.WriteLine("0 - Voltar");
//            Console.Write("Escolha uma opção: ");
//            string opcao = Console.ReadLine();

//            switch (opcao)
//            {
//                case "1":
//                    ListarClientes();
//                    break;
//                case "2":
//                    CadastrarCliente();
//                    break;
//                case "3":
//                    AlterarCliente();
//                    break;
//                case "4":
//                    ExcluirCliente();
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
//    static void ListarClientes()
//    {
//        Console.Clear();
//        Console.WriteLine("Lista de clientes:");
//        foreach (var cliente in clientes)
//        {
//            Console.WriteLine($"ID: {cliente.Id} | Nome: {cliente.Nome} | Endereço: {cliente.Endereco}");
//        }
//    }

//    static void CadastrarCliente()
//    {
//        Console.Clear();
//        Console.WriteLine("Cadastro de cliente:");
//        Console.Write("Nome: ");
//        string nome = Console.ReadLine();
//        Console.Write("Endereço: ");
//        string endereco = Console.ReadLine();

//        Cliente cliente = new Cliente
//        {
//            Id = proximoIdCliente,
//            Nome = nome,
//            Endereco = endereco
//        };
//        clientes.Add(cliente);
//        proximoIdCliente++;

//        Console.WriteLine();
//        Console.WriteLine("Cliente cadastrado com sucesso!");
//    }

//    static void AlterarCliente()
//    {
//        Console.Clear();
//        Console.WriteLine("Alterar cliente");
//        Console.Write("Digite o ID do cliente que deseja alterar: ");
//        int id = int.Parse(Console.ReadLine());
//        Cliente cliente = clientes.Find(c => c.Id == id);
//        if (cliente == null)
//        {
//            Console.WriteLine("Cliente não encontrado!");
//            return;
//        }
//        Console.Write("Digite o novo nome: ");
//        string nome = Console.ReadLine();
//        Console.Write("Digite o novo endereço: ");
//        string endereco = Console.ReadLine();
//        cliente.Nome = nome;
//        cliente.Endereco = endereco;
//        Console.WriteLine("Cliente alterado com sucesso!");
//    }
//    static void ExcluirCliente()
//    {
//        Console.Clear();
//        Console.WriteLine("Excluir cliente");

//        Console.Write("Informe o ID do cliente que deseja excluir: ");
//        int id = int.Parse(Console.ReadLine());

//        Cliente cliente = clientes.Find(c => c.Id == id);
//        if (cliente != null)
//        {
//            clientes.Remove(cliente);
//            Console.WriteLine("Cliente removido com sucesso!");
//        }
//        else
//        {
//            Console.WriteLine("Cliente não encontrado!");
//        }
//    }

//    static void RealizarVenda()
//    {
//        Console.Clear();
//        Console.WriteLine("Realizar venda:");

//        // Seleciona um cliente existente ou cadastra um novo
//        Cliente cliente = SelecionarCliente();

//        // Cria uma nova venda
//        Venda venda = new Venda();
//        venda.Cliente = cliente;
//        venda.Id = proximoIdVenda;
//        proximoIdVenda++;

//        bool continuar = true;
//        do
//        {
//            Console.Clear();
//            Console.WriteLine($"Venda nº {venda.Id} - Cliente: {venda.Cliente.Nome}");
//            Console.WriteLine();
//            ListarProdutos();

//            Console.WriteLine();
//            Console.WriteLine("Digite o ID do produto que deseja comprar (0 para finalizar):");
//            int idProduto = int.Parse(Console.ReadLine());

//            if (idProduto == 0)
//            {
//                // Finaliza a venda
//                venda.Total = venda.Itens.Sum(i => i.Subtotal);
//                vendas.Add(venda);
//                Console.WriteLine($"Venda finalizada. Total: R${venda.Total}");
//                continuar = false;
//            }
//            else
//            {
//                // Seleciona o produto a ser comprado
//                Produto produto = produtos.Find(p => p.Id == idProduto);
//                if (produto == null)
//                {
//                    Console.WriteLine("Produto não encontrado!");
//                }
//                else
//                {
//                    // Pede a quantidade desejada
//                    Console.WriteLine($"Digite a quantidade de {produto.Nome} que deseja comprar:");
//                    int quantidade = int.Parse(Console.ReadLine());



//                    // Adiciona o item à venda
//                    ItemVenda item = new ItemVenda();
//                    item.Id = venda.Itens.Count + 1;
//                    item.Produto = produto;
//                    item.Quantidade = quantidade;
//                    item.PrecoUnitario = produto.Preco;
//                    venda.Itens.Add(item);

//                    Console.WriteLine($"{quantidade} {produto.Nome} adicionado(s) à venda!");

//                }
//            }

//            Console.WriteLine();
//            Console.WriteLine("Pressione qualquer tecla para continuar...");
//            Console.ReadKey();
//        } while (continuar);
//    }

//    static Cliente SelecionarCliente()
//    {
//        Console.Clear();
//        Console.WriteLine("Selecione o cliente:");
//        foreach (var cliente in clientes)
//        {
//            Console.WriteLine($"ID: {cliente.Id} | Nome: {cliente.Nome} | Endereço: {cliente.Endereco}");
//        }
//        Console.Write("Digite o ID do cliente ou 0 para voltar: ");
//        int idCliente;
//        while (!int.TryParse(Console.ReadLine(), out idCliente) || (idCliente != 0 && !clientes.Exists(c => c.Id == idCliente)))
//        {
//            Console.WriteLine("ID inválido! Digite novamente...");
//            Console.Write("Digite o ID do cliente ou 0 para voltar: ");
//        }
//        if (idCliente == 0)
//        {
//            return null;
//        }
//        else
//        {
//            return clientes.Find(c => c.Id == idCliente);
//        }
//    }
//}