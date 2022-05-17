using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StarterPlataform.Models;

namespace StarterPlatform.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Forum> Foruns { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

    }
}
