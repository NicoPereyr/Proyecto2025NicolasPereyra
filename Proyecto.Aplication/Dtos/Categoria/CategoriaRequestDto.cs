using System.ComponentModel.DataAnnotations;

namespace Proyecto.Aplication.Dtos.Categoria
{
    public class CategoriaRequestDto
    {
        public int Id { get; set; }


        [StringLength(30)]
        public string Nombre { get; set; }
    }
}
