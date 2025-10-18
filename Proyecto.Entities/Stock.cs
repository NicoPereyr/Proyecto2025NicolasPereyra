using Proyecto.Abstractions;

namespace Proyecto.Entities
{
    public class Stock : IEntidad
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }

        public int DepositoId { get; set; }
        public virtual Deposito Deposito { get; set; }

        public decimal CantidadActual { get; set; }
        public decimal StockMinimo { get; set; }
    }
}
