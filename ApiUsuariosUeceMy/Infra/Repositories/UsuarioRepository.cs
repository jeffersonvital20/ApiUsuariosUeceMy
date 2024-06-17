using ApiUsuariosUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Domain.Model;
using ApiUsuariosUeceMy.Infra.Context;
using AppChurch.Data.Repositories;

namespace ApiUsuariosUeceMy.Infra.Repositories;

public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(AppDbContext context) : base(context)
    {
    }
    public void AtualizaCurso(Guid IdUsuario, Guid IdCurso)
    {
        var usuario = GetById(IdUsuario);
        if (usuario != null)
        {
            if (usuario.Cursos == null)
                usuario.Cursos = new List<Guid> { IdCurso };
            else
                usuario.Cursos.Add(IdCurso);
            Update(usuario);
        }
    }

    public Usuario GetByEmail(string email)
    {
        var usuarios = GetAll();
        return usuarios.FirstOrDefault(u => u.Email == email);
    }

    public List<Guid> GetCursosUsuario(Guid Id)
    {
        var usuario = GetById(Id);
        return usuario.Cursos;
    }
}
