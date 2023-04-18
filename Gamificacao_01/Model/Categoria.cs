using System;
namespace JRJ.Modas.Model
{
	public class CategoriaModel
	{
        public long? CategoriaID { get; set; }
        public Guid CategoriaIDGUID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}
