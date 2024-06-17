using ApiUsuariosUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Domain.Model;
using ApiUsuariosUeceMy.Domain.Request.Command;
using ApiUsuariosUeceMy.Services.Results;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.RequestHandlers.CommandHandler
{
    public class AtualizarCursoRequestHandler : IRequestHandler<AtualizarCursoRequest, Result<bool>>
    {
        private readonly IUsuarioRepository _repository;

        public AtualizarCursoRequestHandler(IUsuarioRepository usuarioRepository)
        {
            _repository = usuarioRepository;
        }
        public Task<Result<bool>> Handle(AtualizarCursoRequest request, CancellationToken cancellationToken)
        {
             _repository.AtualizaCurso(request._pagamento.IdUsuario, request._pagamento.IdCurso);
            return Result.Success(true);
        }
    }
}
