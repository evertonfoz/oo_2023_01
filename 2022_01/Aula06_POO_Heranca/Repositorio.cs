using System.Collections;

namespace Aula06_POO_Heranca
{
    internal class Repositorio
    {
        private IList _dados = new List<object>();
        public void Registrar(object obj)
        {
            _dados.Add(obj);
        }
        public void Remover(object obj)
        {
            _dados.Remove(obj);
        }
    }
}
