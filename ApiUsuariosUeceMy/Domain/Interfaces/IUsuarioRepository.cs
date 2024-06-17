using ApiUsuariosUeceMy.Domain.Model;

namespace ApiUsuariosUeceMy.Domain.Interfaces;

public interface IUsuarioRepository : IBaseRepository<Usuario>
{
    public Usuario GetByEmail(string email);
    public List<Guid> GetCursosUsuario(Guid Id);
    public void AtualizaCurso(Guid IdUsuario, Guid IdCurso);
}
