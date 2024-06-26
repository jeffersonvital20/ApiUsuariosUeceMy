﻿using ApiUsuariosUeceMy.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiUsuariosUeceMy.Infra.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Usuario>? Usuario { get; set; }
   
}
