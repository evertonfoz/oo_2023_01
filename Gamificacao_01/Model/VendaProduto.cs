using System;
namespace JRJ.Modas.Model
{
	public class VendaProduto
	{
        public long VendaProdutoID { get; set; }
        public Produto? Produto { get; set; }
        public double Quantidade { get; set; }
        public double PrecoUnitario { get; set; }

        public double Subtotal
        {
            get { return Quantidade * PrecoUnitario; }
        }
    }
}

