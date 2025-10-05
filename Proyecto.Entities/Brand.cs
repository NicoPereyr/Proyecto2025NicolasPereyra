using Proyecto.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Entities
{
    public class Brand : IEntidad
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }

        public virtual ICollection<Product> Productos { get; set; }

        public Brand()
        {
            Productos = new HashSet<Product>();
        }
    }
}
