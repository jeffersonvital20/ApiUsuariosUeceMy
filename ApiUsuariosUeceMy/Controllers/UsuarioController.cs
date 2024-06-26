﻿using ApiUsuariosUeceMy.Controllers.Base;
using ApiUsuariosUeceMy.Domain.Model;
using ApiUsuariosUeceMy.Domain.Request.Command;
using ApiUsuariosUeceMy.Domain.Request.Query;
using ApiUsuariosUeceMy.Domain.RequestHandlers.QueryHandler;
using ApiUsuariosUeceMy.Services.Results;
using ApiUsuariosUeceMy.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiUsuariosUeceMy.Controllers
{
    public class UsuarioController : AppControllerBase
    {
        public UsuarioController(IMediator mediator) : base(mediator)
        {}

        [HttpPost("create")]
        public Task<IActionResult> Create([FromBody] Usuario usuario)
            => SendRequest(new CreateUsuarioRequest(usuario));

        [HttpGet("getById")]
        public Task<IActionResult> GetById([FromQuery] Guid id) => SendRequest(new UsuarioGetByIdQuery(id));

        [HttpGet("getAll")]
        public Task<IActionResult> GetAll()
            => SendRequest(new UsuarioGetAllQuery());

        [HttpPost("Autorizar")]
        public Task<IActionResult> Autorizar([FromBody] AutorizarUsuarioViewModel autorizarUsuario)
            => SendRequest(new AutorizarUsuarioRequest(autorizarUsuario));

        [HttpGet("Cursos")]
        public Task<IActionResult> GetAllCursos([FromQuery] Guid id) => SendRequest(new GetAllCursosUsuarioQuery(id));

        [HttpGet("AtualizaCurso")]
        public Task<IActionResult> GetAtualizaCurso()
            => SendRequest(new GetCursoAtualizadoQuery());

        [HttpPost("AtualizaCurso")]
        public Task<IActionResult> GetAtualizaCurso([FromQuery] Payment pagamento) => SendRequest(new AtualizarCursoRequest(pagamento));

    }
}
