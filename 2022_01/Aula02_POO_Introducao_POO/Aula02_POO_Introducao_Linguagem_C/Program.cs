// See https://aka.ms/new-console-template for more information
using Aula02_POO_Introducao_Linguagem_C.Dominio;

Console.WriteLine("Hello, World!");

//Estudante estudante = new Estudante();
//Estudante estudante = new Estudante() { RegistroAcademico = "1234567" };
//Estudante estudante = new Estudante() { RegistroAcademico = "1" };
Estudante estudante = new Estudante("123456");

Console.WriteLine($"Estado do objeto: {estudante.EhValido()}");

//Estudante estudante = new Estudante() { RegistroAcademico ="1234567"};
//estudante.RegistroAcademico = "1234567";

//estudante.AtribuirValorARA("1234567");

Console.WriteLine($"RA: {estudante.RegistroAcademico}");
//estudante.RegistroAcademico = "ABCDEFGH";

Console.WriteLine($"RA: {estudante.RegistroAcademico}");
