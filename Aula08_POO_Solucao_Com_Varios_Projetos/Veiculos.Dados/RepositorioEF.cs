using Microsoft.EntityFrameworkCore;
using Veiculos.Dados.EFContexts;
using Veiculos.Modelo;
using Veiculos.Modelo.Interfaces;

namespace Veiculos.Dados
{
    public class RepositorioEF : IRepositorio
    {
        private EFGlobalContext _eFGlobalContext = new EFGlobalContext();
        public async Task<IList<MarcaModelo>> ObterTodos()
        {
            return await _eFGlobalContext.Marcas.ToListAsync();
        }

        public async Task<MarcaModelo>  Registrar(MarcaModelo marcaModelo)
        {
            
            _eFGlobalContext.Add(marcaModelo);
            await _eFGlobalContext.SaveChangesAsync();
            return marcaModelo;
        }
    }
}
