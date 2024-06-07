using ApiUsuariosUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Domain.Model;
using ApiUsuariosUeceMy.Domain.Request.Command;
using ApiUsuariosUeceMy.Infra.Utils;
using MediatR;
using OperationResult;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ApiUsuariosUeceMy.Domain.RequestHandlers.CommandHandler;

public sealed class CreateUsuarioRequestHandler : IRequestHandler<CreateUsuarioRequest, Result<Usuario>>
{
    private readonly IUsuarioRepository _repository;

    public CreateUsuarioRequestHandler(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Usuario>> Handle(CreateUsuarioRequest request, CancellationToken cancellationToken)
    {
        Usuario entity = new Usuario()
        {
            Nome = request._usuario.Nome,
            Email = request._usuario.Email,
            CartaoCredito = request._usuario.CartaoCredito,
            Senha = request._usuario.Senha.GerarCodigo()
        };

        await _repository.Create(entity).ConfigureAwait(false);

        Usuario result = _repository.GetById(entity.Id);
        Usuario retorno = new Usuario()
        {
            Nome = result.Nome,
            Email = result.Email,
            CartaoCredito = request._usuario.CartaoCredito
        };
        return Result.Success(retorno);
    }
}
