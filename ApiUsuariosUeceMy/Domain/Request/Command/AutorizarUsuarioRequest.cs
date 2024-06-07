using ApiUsuariosUeceMy.Domain.Model;
using ApiUsuariosUeceMy.ViewModels;
using AppChurch.Domain.Validation;
using MediatR;
using OperationResult;

namespace ApiUsuariosUeceMy.Domain.Request.Command
{
    public class AutorizarUsuarioRequest : IRequest<Result<bool>>, IValidatable
    {
        public AutorizarUsuarioViewModel _usuario { get; set; }
        public AutorizarUsuarioRequest(AutorizarUsuarioViewModel usuario)
        {
            _usuario = usuario;
        }
    }
}
