namespace Poo.Classes.Modelos
{
    public class Pessoa
    {
        private string? nome;
        private int? idade;

        public string? Nome {
            get { return nome;}
            set { nome = value;}
        }

        public int? Idade {
            get {return idade;}
            set {
                if (value >= 18) {
                    idade = value;
                }
            }
        }


        // public string? Nome { get; set; }
        // public int? Idade { get; set; }

        // public Pessoa() {}

        // public Pessoa(string nome, int idade) {
        //     Nome = nome;
        //     Idade = idade;
        // }
    //     public void ExibirDados() {
    //         if (ObjetoEhValido()) {
    //             Console.WriteLine($"{Nome} / {Idade}");
    //         } else {
    //             Console.WriteLine("Dados inválidos");
    //         }
    //     }

    //     public bool ObjetoEhValido() {
    //         return (Nome != null && Idade!=null);
    //     }
    }
}