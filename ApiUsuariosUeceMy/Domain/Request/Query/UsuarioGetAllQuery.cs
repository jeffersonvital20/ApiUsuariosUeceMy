using ApiUsuariosUeceMy.Domain.Model;
using AppChurch.Domain.Validation;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.Request.Query;

public class UsuarioGetAllQuery : IRequest<Result<List<Usuario>>>, IValidatable
{
}
