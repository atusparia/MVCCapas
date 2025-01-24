using Microsoft.AspNetCore.Mvc;
using MVCCapas.Models;
using Services;
using Domain;

namespace MVCCapas.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            CursoService service = new CursoService();

            //Listado de cursos de DOMAIN
            var cursos = service.Get();

            //Dominio a Modelo 
            //Curso => CursoModel

            var model = cursos.Select(x => new CursoModel
            {
                CursoID = x.CursoID,
                Nombre = x.Nombre,
            });

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Nombre")]  CursoModel model)
        {
            if (ModelState.IsValid)
            {
                CursoService service = new CursoService();

                //Modelo a Dominio
                //CursoModel => Curso

                var dominio = new Curso
                {
                    Nombre = model.Nombre,
                    Activo = true,
                    FechaCreacion = DateTime.Now
                };
                
                service.Insert(dominio);

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
