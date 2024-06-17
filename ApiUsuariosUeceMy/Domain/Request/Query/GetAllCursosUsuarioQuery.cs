using ApiUsuariosUeceMy.ViewModels;
using AppChurch.Domain.Validation;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.Request.Query;

public class GetAllCursosUsuarioQuery : IRequest<Result<List<Guid>>>, IValidatable
{
    public Guid Id { get; set; }
    public GetAllCursosUsuarioQuery(Guid id)
    => Id = id;
}