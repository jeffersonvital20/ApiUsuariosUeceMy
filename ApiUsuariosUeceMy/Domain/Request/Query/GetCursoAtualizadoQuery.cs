using AppChurch.Domain.Validation;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.Request.Query;

public class GetCursoAtualizadoQuery : IRequest<Result<bool>>, IValidatable
{
}
