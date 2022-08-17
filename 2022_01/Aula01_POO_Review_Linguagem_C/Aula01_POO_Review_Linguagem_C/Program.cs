namespace CC53
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Digite seu nome: ");
            string nomeDoUsuario = Console.ReadLine();

            Console.WriteLine($"Olá {nomeDoUsuario}");

            Console.ReadKey();

            //string? argumentosRecebidosDoTerminal =null;
            //for (int i = 0; i < args.Length; i++)
            //{
            //    argumentosRecebidosDoTerminal += $" {args[i]}";
            //}

            //Console.WriteLine(argumentosRecebidosDoTerminal ?? "Não chegou nada");

            //if (!string.IsNullOrEmpty(argumentosRecebidosDoTerminal))
            //{
            //    Console.WriteLine("Chegou algo");
            //    //Console.WriteLine(argumentosRecebidosDoTerminal ?? "");
            //} else
            //{
            //    Console.WriteLine("Não Chegou algo");

            //}

            //if (argumentosRecebidosDoTerminal != null)
            //{
            //Console.WriteLine(argumentosRecebidosDoTerminal??"");
            //}

            //foreach (string? item in args)
            //{
            //    argumentosRecebidosDoTerminal += $" {item}";
            //}
            //Console.WriteLine(argumentosRecebidosDoTerminal);
            //if (args.Length == 0)
            //{
            //    Console.WriteLine("Não veio nada");
            //}
            //else
            //{
            //    string? argumentosRecebidosDoTerminal = "";
            //    foreach (string? item in args)
            //    {
            //        argumentosRecebidosDoTerminal += $" {item}";
            //    }
            //    Console.WriteLine(argumentosRecebidosDoTerminal);

            //    //Console.WriteLine(args.ToString());
            //    //Console.WriteLine($"Olá  {args[0]} {args[1]}");
            //    //Console.WriteLine("Olá");
            //    //foreach (string? item in args)
            //    //{
            //    //    Console.WriteLine(item);
            //    //}
            //    //for (int i = 0; i < args.Length; i++)
            //    //{
            //    //    Console.WriteLine(args[i]);
            //    //}
            //    //if (args.Length == 1)
            //    //{
            //    //    Console.WriteLine("Olá " + args[0]);
            //    //} else if (args.Length == 2)
            //    //{
            //    //    Console.WriteLine("Olá " + args[0] + " " + args[1]);
            //    //}
            //}
            //return;
        }
    }
}