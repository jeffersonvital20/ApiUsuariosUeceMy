using ApiUsuariosUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Domain.Model;
using ApiUsuariosUeceMy.Domain.Request.Query;
using ApiUsuariosUeceMy.ViewModels;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.RequestHandlers.QueryHandler;

public class UsuarioGetByIdQueryHandler : IRequestHandler<UsuarioGetByIdQuery, Result<GetUsuarioViewModel>>
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioGetByIdQueryHandler(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public Task<Result<GetUsuarioViewModel>> Handle(UsuarioGetByIdQuery request, CancellationToken cancellationToken)
    {
        Usuario result = _usuarioRepository.GetById(request.Id);
        GetUsuarioViewModel retorno = new GetUsuarioViewModel()
        {
            Nome = result.Nome,
            Email = result.Email,
            CartaoCredito = result.CartaoCredito
        };
        return Result.Success(retorno);
    }
}
