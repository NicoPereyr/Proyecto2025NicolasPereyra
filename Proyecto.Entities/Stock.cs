using Proyecto.Abstractions;

namespace Proyecto.Entities
{
    public class Stock : IEntidad
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }
        public virtual Product Producto { get; set; }

        public int DepositoId { get; set; }
        public virtual Deposit Deposito { get; set; }

        public decimal CantidadActual { get; set; }
        public decimal StockMinimo { get; set; }
    }
}
