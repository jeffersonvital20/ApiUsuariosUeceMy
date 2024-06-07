using ApiUsuariosUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Domain.Model;
using ApiUsuariosUeceMy.Domain.Request.Query;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.RequestHandlers.QueryHandler;

public class UsuarioGetAllQueryHandler : IRequestHandler<UsuarioGetAllQuery, Result<List<Usuario>>>
{
    private readonly IUsuarioRepository _repository;

    public UsuarioGetAllQueryHandler(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public Task<Result<List<Usuario>>> Handle(UsuarioGetAllQuery request, CancellationToken cancellationToken)
    {
        List<Usuario> result = _repository.GetAll().ToList();

        return Result.Success(result);
    }
}
