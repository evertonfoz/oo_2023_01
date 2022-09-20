using Console.Heranca.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa fisica = new Fisica("Josebrezio", "1123");
        Fisica fisica1 = new Fisica("Ambroziana", "456");
        Juridica juridica = new Juridica("UTFPR", "789");

        List<Pessoa> pessoas = new List<Pessoa>();
        pessoas.Add(fisica);
        pessoas.Add(fisica1);
        pessoas.Add(juridica);

        foreach (var p in pessoas)
        {
            System.Console.WriteLine(p);
            //System.Console.Write($"{p.Nome}: ");
            //if (p.GetType() == typeof(Fisica))
            //{
            //    System.Console.WriteLine((p as Fisica).CPF);
            //} else
            //{
            //    System.Console.WriteLine((p as Juridica).CNPJ);
            //}
        }

        System.Console.ReadKey();
    }
}