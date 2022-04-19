namespace Veiculos.Modelo
{
    public class MarcaModelo
    {
        public int? MarcaID { get; set; }
        public string Nome { get; set; }
        public MarcaModelo(string nome, int? marcaID = null)
        {
            Nome = nome;
            MarcaID = marcaID;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(MarcaModelo) ||
                obj != this || ((MarcaModelo)obj).MarcaID != MarcaID)
            {
                return false;
            }
                
            return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MarcaID, Nome);
        }
    }
}
