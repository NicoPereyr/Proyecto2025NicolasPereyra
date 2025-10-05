using Proyecto.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Entities
{
    public class Category : IEntidad
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }

        public virtual ICollection<Product> Productos { get; set; }

        public Category()
        {
            Productos = new HashSet<Product>();
        }
    }
}
