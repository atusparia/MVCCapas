using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Curso> Cursos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = SRVMIO;" +
                    "initial catalog=EscuelaCapasDB; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true");
        }
        //public DbSet<MVCCore.Models.EstudianteModel> EstudianteModel { get; set; } = default!;
    }
}
