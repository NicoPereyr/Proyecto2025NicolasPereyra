using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Aplication;
using Proyecto.Aplication.Dtos.Deposito;
using Proyecto.Entities;

namespace Proyecto.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositosController : ControllerBase
    {
        private readonly ILogger<DepositosController> _logger;
        private readonly IApplication<Deposito> _deposito;
        private readonly IMapper _mapper;
        public DepositosController(
            ILogger<DepositosController> logger
            , IApplication<Deposito> deposito
            , IMapper mapper)
        {
            _logger = logger;
            _deposito = deposito;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            return Ok(_mapper.Map<IList<DepositoResponseDto>>(_deposito.GetAll()));
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(int? Id)
        {
            if (!Id.HasValue)
            {
                return BadRequest();
            }
            Deposito deposito = _deposito.GetById(Id.Value);
            if (deposito is null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DepositoResponseDto>(deposito));
        }

        [HttpPost]
        public async Task<IActionResult> Crear(DepositoRequestDto depositoRequestDto)
        {
            if (!ModelState.IsValid)
            { return BadRequest(); }
            var deposito = _mapper.Map<Deposito>(depositoRequestDto);
            _deposito.Save(deposito);
            return Ok(deposito.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Editar(int? Id, DepositoRequestDto depositoRequestDto)
        {
            if (!Id.HasValue)
            { return BadRequest(); }
            if (!ModelState.IsValid)
            { return BadRequest(); }
            Deposito depositoBack = _deposito.GetById(Id.Value);
            if (depositoBack is null)
            { return NotFound(); }
            depositoBack = _mapper.Map<Deposito>(depositoRequestDto);
            _deposito.Save(depositoBack);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Borrar(int? Id)
        {
            if (!Id.HasValue)
            { return BadRequest(); }
            if (!ModelState.IsValid)
            { return BadRequest(); }
            Deposito depositoBack = _deposito.GetById(Id.Value);
            if (depositoBack is null)
            { return NotFound(); }
            _deposito.Delete(depositoBack.Id);
            return Ok();
        }
    }

}
