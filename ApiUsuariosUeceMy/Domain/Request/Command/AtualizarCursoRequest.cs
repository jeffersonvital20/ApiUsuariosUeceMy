using ApiUsuariosUeceMy.Services.Results;
using ApiUsuariosUeceMy.ViewModels;
using AppChurch.Domain.Validation;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.Request.Command
{
    public class AtualizarCursoRequest : IRequest<Result<bool>>, IValidatable
    {
        public Payment _pagamento { get; set; }
        public AtualizarCursoRequest(Payment pagamento)
        {
            _pagamento = pagamento;
        }
    }
}
