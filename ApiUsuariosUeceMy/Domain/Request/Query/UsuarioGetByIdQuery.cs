using ApiUsuariosUeceMy.ViewModels;
using AppChurch.Domain.Validation;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.Request.Query;

public class UsuarioGetByIdQuery : IRequest<Result<GetUsuarioViewModel>>, IValidatable
{
    public Guid Id { get; set; }
    public UsuarioGetByIdQuery(Guid id)
    => Id = id;
}
