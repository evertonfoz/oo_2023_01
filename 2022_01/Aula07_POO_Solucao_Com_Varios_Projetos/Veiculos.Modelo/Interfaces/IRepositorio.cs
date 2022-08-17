namespace Veiculos.Modelo.Interfaces
{
    public interface IRepositorio
    {
        public MarcaModelo Registrar(MarcaModelo marcaModelo);
        public IList<MarcaModelo> ObterTodos();
    }
}
