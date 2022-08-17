// See https://aka.ms/new-console-template for more information
using Aula02_POO_Introducao_Linguagem_C.Dominio;
using Aula02_POO_Introducao_Linguagem_C.Dominio.Compartilhados;

Console.WriteLine("Hello, World!");

//Estudante estudante = new Estudante();
//Estudante estudante = new Estudante() { RegistroAcademico = "1234567" };
//Estudante estudante = new Estudante() { RegistroAcademico = "1" };

//Endereco endereco = new Endereco(numero: "1A", rua: "Brasil");

//Estudante estudante = new Estudante("123456", endereco);

//Endereco endereco = new Endereco(numero: "1A", rua: "Brasil");

var enderecos = new Endereco[5];
enderecos[0] = new Endereco(numero: "1A", rua: "Brasil");
enderecos[1] = new Endereco(numero: "2A", rua: "Medianeira");
enderecos[2] = new Endereco(numero: "3A", rua: "Missal");
enderecos[3] = new Endereco(numero: "4A", rua: "SMI");
enderecos[4] = new Endereco(numero: "5A", rua: "Foz");
//enderecos[5] = new Endereco(numero: "6A", rua: "Cascavel");

Estudante estudante = new Estudante(
    "123456",
    enderecos);
//Estudante estudante = new Estudante(
//    "123456",
//    new Endereco(numero: "1A", rua: "Brasil"));

foreach (var endereco in estudante.Enderecos)
{
    Console.WriteLine($"Endereco: {endereco}");
    //Console.WriteLine($"Endereco: {endereco.Rua}");
}
//estudante.Enderecos[0].Rua = "Missal";

//estudante = null;

//Console.WriteLine($"Endereco: {estudante?.Endereco.Rua}");

//endereco.Rua = "Medianeira";

//Console.WriteLine($"Endereco: {estudante?.Endereco.Rua}");

Console.ReadKey();
//Console.WriteLine($"Estado do objeto: {estudante.EhValido()}");

//Estudante estudante = new Estudante() { RegistroAcademico ="1234567"};
//estudante.RegistroAcademico = "1234567";

//estudante.AtribuirValorARA("1234567");

Console.WriteLine($"RA: {estudante.RegistroAcademico}");
//estudante.RegistroAcademico = "ABCDEFGH";

Console.WriteLine($"RA: {estudante.RegistroAcademico}");
