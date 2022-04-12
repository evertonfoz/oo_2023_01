using Aula03_POO_Associações_Windows_Forms.Dominio.Compartilhados;

namespace Aula03_POO_Associações_Windows_Forms.Dominio
{
    internal class EstudanteModel
    {
        public string RegistroAcademico { get; set; }
        public string Nome { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}
