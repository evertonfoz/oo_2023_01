namespace Aula03_POO_Associações_Windows_Forms.Dominio.Compartilhados
{
    internal class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Endereco)
            {
                return false;
            }
            
            var objetoParaComparar = (Endereco)obj;

            if (objetoParaComparar.Rua != Rua || 
                    objetoParaComparar.Numero != Numero) {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return Rua.GetHashCode() ^ Numero.GetHashCode();
        }
    }
}
