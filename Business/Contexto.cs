using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {
            Database.EnsureCreated();
            // caso não exista o banco de dados o entity vai usar a inteligencia dele para criar essas tabelas para mim. 
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
