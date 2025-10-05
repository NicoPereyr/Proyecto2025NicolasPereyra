using Proyecto.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Entities
{
    public class Deposit : IEntidad
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Direccion { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }

        public Deposit()
        {
            Stocks = new HashSet<Stock>();
        }
    }
}
