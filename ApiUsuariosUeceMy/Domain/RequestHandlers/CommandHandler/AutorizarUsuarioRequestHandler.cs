using ApiUsuariosUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Domain.Model;
using ApiUsuariosUeceMy.Domain.Request.Command;
using ApiUsuariosUeceMy.Infra.Utils;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.RequestHandlers.CommandHandler
{
    public sealed class AutorizarUsuarioRequestHandler : IRequestHandler<AutorizarUsuarioRequest, Result<bool>>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public AutorizarUsuarioRequestHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<Result<bool>> Handle(AutorizarUsuarioRequest request, CancellationToken cancellationToken)
        {
            var usu = _usuarioRepository.GetByEmail(request._usuario.Email);
            if (usu == null)
                return Result.Success(false);
            if (request._usuario.Senha.GerarCodigo() != usu.Senha )
                return Result.Success(false);
            return Result.Success(true);
        }
    }
}
