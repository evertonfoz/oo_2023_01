// See https://aka.ms/new-console-template for more information
using Aula06_POO_Heranca;
using Aula06_POO_Heranca.Modelos;
using Aula06_POO_Heranca.Modelos.Implementacao;

List<Forma>? _formas = new List<Forma>();
_formas.Add(new Retangulo("Retânuglo") {  Altura = 5, Largura = 3 });
_formas.Add(new Circulo("Círculo") { Raio = 3 });

//Console.WriteLine(_formas[0].Nome);
_formas.ForEach((Forma forma) => {
    Console.WriteLine(forma.ObterArea());
    Console.WriteLine(forma.GetType());
    Console.WriteLine(forma);
});

//Fisica _fisica = new Fisica();
//Juridica _juridica = new Juridica();

//_fisica.Endereco = "Brasil";
//_juridica.Endereco = "Paraguai";

//_juridica.Registrar(_fisica);
//_fisica.Registrar(_fisica);
//_juridica.Remover(_fisica);
//_fisica.Remo(_fisica);

//var _pessoas = new List<Pessoa>();
//_pessoas.Add(_fisica);
//_pessoas.Add(_juridica);

//_pessoas.
//    ForEach(pessoa => Console.WriteLine(pessoa.Endereco));

Console.ReadKey();
