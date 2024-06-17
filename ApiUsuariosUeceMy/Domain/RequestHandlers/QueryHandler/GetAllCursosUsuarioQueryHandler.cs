using ApiUsuariosUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Domain.Request.Query;
using ApiUsuariosUeceMy.Services.Interface;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.RequestHandlers.QueryHandler;

public class GetAllCursosUsuarioQueryHandler : IRequestHandler<GetAllCursosUsuarioQuery, Result<List<Guid>>>
{
    private readonly IUsuarioRepository _usuarioRepository;

    public GetAllCursosUsuarioQueryHandler(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }
    public async Task<Result<List<Guid>>> Handle(GetAllCursosUsuarioQuery request, CancellationToken cancellationToken)
    {
        var cursos = _usuarioRepository.GetCursosUsuario(request.Id);
        return cursos;
    }
}
