using ApiUsuariosUeceMy.Domain.Model;

namespace ApiUsuariosUeceMy.Domain.Interfaces;

public interface IUsuarioRepository : IBaseRepository<Usuario>
{
    public Usuario GetByEmail(string email);
}
