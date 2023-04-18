using System;

namespace JRJ.Modas.Model
{
	public class Venda
	{
        public long VendaID { get; set; }
        public DateTime Data { get; set; }
        public Cliente? Cliente { get; set; }
        public List<VendaProduto>? Produtos { get; set; }
        public double Total { get
            {//LINQ
                try
                {
                    return Produtos!.Sum(p => p.Subtotal);
                } catch(NullReferenceException nrfe)
                {
                    throw new Exception($"Nota sem venda: {nrfe.Message}");
                }
            }
        }
    }
}

