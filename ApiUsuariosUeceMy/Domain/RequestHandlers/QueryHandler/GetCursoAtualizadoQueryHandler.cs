using ApiUsuariosUeceMy.Domain.Request.Query;
using ApiUsuariosUeceMy.Services.Interface;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.RequestHandlers.QueryHandler
{
    public class GetCursoAtualizadoQueryHandler : IRequestHandler<GetCursoAtualizadoQuery, Result<bool>>
    {
        private readonly IRabbitServices _rabbitServices;

        public GetCursoAtualizadoQueryHandler(IRabbitServices rabbitServices)
        {
            _rabbitServices = rabbitServices;
        }
        public async Task<Result<bool>> Handle(GetCursoAtualizadoQuery request, CancellationToken cancellationToken)
        {
            return _rabbitServices.ReceveMensagem();
            
        }
    }
}
