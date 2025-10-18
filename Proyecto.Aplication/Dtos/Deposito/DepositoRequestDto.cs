using System.ComponentModel.DataAnnotations;

namespace Proyecto.Aplication.Dtos.Deposito
{
    public class DepositoRequestDto
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Direccion { get; set; }

    }
}
