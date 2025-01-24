using Microsoft.AspNetCore.Mvc;
using MVCCapas.Models;
using Services;

namespace MVCCapas.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            CursoService service = new CursoService();

            //Listado de cursos de DOMAIN
            var cursos = service.Get();

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
        public IActionResult Create([Bind("CursoId,Nombre")]  CursoModel model)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(curso);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
