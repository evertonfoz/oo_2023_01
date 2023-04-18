using System;

namespace JRJ.Modas.Model
{
	public class Produto
	{
        public long? ProdutoID { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }
        public CategoriaModel? Categoria { get; set; }
    }
}

