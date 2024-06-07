using ApiUsuariosUeceMy.Domain.Model;
using AppChurch.Domain.Validation;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.Request.Command;

public class CreateUsuarioRequest : IRequest<Result<Usuario>>, IValidatable
{
    public Usuario _usuario { get; set; }
    public CreateUsuarioRequest(Usuario usuario)
    {
        _usuario = usuario;
    }
}
