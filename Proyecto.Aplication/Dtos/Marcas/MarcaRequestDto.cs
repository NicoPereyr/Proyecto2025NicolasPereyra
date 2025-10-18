using System.ComponentModel.DataAnnotations;

namespace Proyecto.Aplication.Dtos.Marcas
{
    public class MarcaRequestDto
    {
        public int Id { get; set; }


        [StringLength(30)]
        public string Nombre { get; set; }
    }
}
