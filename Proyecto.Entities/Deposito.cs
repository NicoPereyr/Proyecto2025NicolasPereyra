using Proyecto.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Entities
{
    public class Deposito : IEntidad
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Direccion { get; set; }

    }
}
