using Proyecto.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Entities
{
    public class Categoria : IEntidad
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }

    }
}
