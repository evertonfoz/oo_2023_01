int[] valores = new int[] {11,23,34};
foreach (int valor in valores)
{
    if (valor % 2 == 0)
    {
        Console.WriteLine(valor);
    }
}

//LINQ
var pares = valores.Where(x => x % 2 == 0).ToArray();

Console.ReadKey();

//for (int i = 0; i < valores.Length; i++)
//{
//    Console.WriteLine(valores[i]);
//}

//int i = 0;

//do
//{
//    Console.WriteLine(i++);
//} while (i<10);

//int i = 0;
//while (i<10)
//{
//    Console.WriteLine(i++);
//}

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}


//Console.Write("Digite sua estado Civil (S/C/D/V): ");
//string? estadoCivil= Console.ReadLine();

//switch (estadoCivil)
//{
//    case "S":
//        Console.WriteLine("Solteiro(a)");
//        break;
//    case "C":
//        Console.WriteLine("Casado(a)");
//        break;
//    case "D":
//        Console.WriteLine("Divorciado(a)");
//        break;
//    case "V":
//        Console.WriteLine("Viúvo(a)");
//        break;
//    case "":
//        Console.WriteLine("Você não informou nada");
//        break;
//    default:
//        Console.WriteLine($"Valor inválido {estadoCivil}");
//        break;
//}


//Console.Write("Digite sua idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());


//if (idade <= 7) // && || ! != ()
//{
//    Console.WriteLine("Você ainda é uma criança");
//}
//else if (idade <= 13)
//{
//    Console.WriteLine("Você é um(a) pré-adolescente");
//}
//else
//{
//    Console.WriteLine("Você não é mais um(a) pré-adolescente");
//}

//Console.WriteLine();
//Console.WriteLine(idade);
Console.ReadKey();