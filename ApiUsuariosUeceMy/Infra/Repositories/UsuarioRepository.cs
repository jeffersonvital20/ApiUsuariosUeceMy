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

    public Usuario GetByEmail(string email)
    {
        var usuarios = GetAll();
        return usuarios.FirstOrDefault(u => u.Email == email);
    }
}
