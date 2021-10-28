using Microsoft.EntityFrameworkCore;
using Milk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) :base(options)
        {
            
        }      
        public DbSet<Paciente> Pacientes { get; set; }
        //public DbSet<Consulta> Consultas { get; set; }
    }
}
