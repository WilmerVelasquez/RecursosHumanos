using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecursosHumanos.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecursosHumanos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
            public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<RegistroIngreso> RegistroIngreso { get; set; }
    }
    }
