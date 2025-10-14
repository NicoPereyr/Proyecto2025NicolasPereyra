using Microsoft.AspNetCore.Mvc;
using Proyecto.Aplication;
using Proyecto.Entities;

namespace Proyecto.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ILogger<ProductosController> _logger;
        private readonly IApplication<Product> _producto;
        public ProductosController(ILogger<ProductosController> logger, IApplication<Product> producto)
        {
            _logger = logger;
            _producto = producto;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            return Ok(_producto.GetAll());
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(int? Id)
        {
            if (!Id.HasValue)
            {
                return BadRequest();
            }
            Product producto = _producto.GetById(Id.Value);
            if (producto is null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Product producto)
        {
            if (!ModelState.IsValid)
            { return BadRequest(); }
            _producto.Save(producto);
            return Ok(producto.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Editar(int? Id, Product producto)
        {
            if (!Id.HasValue)
            { return BadRequest(); }
            if (!ModelState.IsValid)
            { return BadRequest(); }
            Product productoBack = _producto.GetById(Id.Value);
            if (productoBack is null)
            { return NotFound(); }
            productoBack.Nombre = producto.Nombre;
            productoBack.Codigo = producto.Codigo;
            //terminar de copiar todas las propiedades
            //productoBack.Email = autor.Email;
            //productoBack.FechaNacimiento = autor.FechaNacimiento;
            _producto.Save(productoBack);
            return Ok(productoBack);
        }

        [HttpDelete]
        public async Task<IActionResult> Borrar(int? Id)
        {
            if (!Id.HasValue)
            { return BadRequest(); }
            if (!ModelState.IsValid)
            { return BadRequest(); }
            Product productoBack = _producto.GetById(Id.Value);
            if (productoBack is null)
            { return NotFound(); }
            _producto.Delete(productoBack.Id);
            return Ok();
        }
    }
}
