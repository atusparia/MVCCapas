using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CursoService
    {
        public List<Curso> Get() 
        {
            using (var context = new EscuelaContext()) 
            { 
                return context.Cursos.ToList();
            }
        }

        public void Create(Curso curso) 
        {
            using (var context = new EscuelaContext())
            {
                context.Cursos.Add(curso);
                context.SaveChanges();
            }
        }
    }
}
