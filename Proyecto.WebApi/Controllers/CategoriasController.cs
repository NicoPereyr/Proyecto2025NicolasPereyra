﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Aplication;
using Proyecto.Aplication.Dtos.Categoria;
using Proyecto.Entities;

namespace Proyecto.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ILogger<CategoriasController> _logger;
        private readonly IApplication<Categoria> _categoria;
        private readonly IMapper _mapper;
        public CategoriasController(
            ILogger<CategoriasController> logger
            , IApplication<Categoria> categoria
            , IMapper mapper)
        {
            _logger = logger;
            _categoria = categoria;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            return Ok(_mapper.Map<IList<CategoriaResponseDto>>(_categoria.GetAll()));
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(int? Id)
        {
            if (!Id.HasValue)
            {
                return BadRequest();
            }
            Categoria categoria = _categoria.GetById(Id.Value);
            if (categoria is null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CategoriaResponseDto>(categoria));
        }

        [HttpPost]
        public async Task<IActionResult> Crear(CategoriaRequestDto categoriaRequestDto)
        {
            if (!ModelState.IsValid)
            { return BadRequest(); }
            var categoria = _mapper.Map<Categoria>(categoriaRequestDto);
            _categoria.Save(categoria);
            return Ok(categoria.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Editar(int? Id, CategoriaRequestDto categoriaRequestDto)
        {
            if (!Id.HasValue)
            { return BadRequest(); }
            if (!ModelState.IsValid)
            { return BadRequest(); }
            Categoria categoriaBack = _categoria.GetById(Id.Value);
            if (categoriaBack is null)
            { return NotFound(); }
            categoriaBack = _mapper.Map<Categoria>(categoriaRequestDto);
            _categoria.Save(categoriaBack);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Borrar(int? Id)
        {
            if (!Id.HasValue)
            { return BadRequest(); }
            if (!ModelState.IsValid)
            { return BadRequest(); }
            Categoria categoriaBack = _categoria.GetById(Id.Value);
            if (categoriaBack is null)
            { return NotFound(); }
            _categoria.Delete(categoriaBack.Id);
            return Ok();
        }
    }

}
