using LosGrisesWeb.ProxyCliente;
using LosGrisesWeb.ProxyUbigeo;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LosGrisesWeb.Controllers
{
    public class LibroController : Controller
    {
        ServicioLibroClient servicioLibro = new ServicioLibroClient();

        // GET: Libro
        public ActionResult Index()
        {
            ViewBag.LibroAlias = new Dictionary<string, string>
            {
                { "lib_id", "Id" },
                { "lib_nom", "Título" },
                { "aut_id", "Autor" },
                { "gen_id", "Género" },
                { "lib_fec_pub", "Fecha de Publicación" },
                { "lib_disp_stock", "Stock" }
            };

            var libros = servicioLibro.ListarLibros();
            return View(libros);
        }

        // GET: Libro/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.LibroAlias = new Dictionary<string, string>
            {
                { "lib_id", "Id" },
                { "lib_nom", "Título" },
                { "aut_id", "Autor" },
                { "gen_id", "Género" },
                { "lib_fec_pub", "Fecha de Publicación" },
                { "lib_disp_stock", "Stock" }
            };

            var libro = servicioLibro.ConsultarLibro((short)id);
            return View(libro);
        }

        // GET: Libro/Create
        public ActionResult Create()
        {
            ViewBag.LibroAlias = new Dictionary<string, string>
            {
                { "lib_id", "Id" },
                { "lib_nom", "Título" },
                { "aut_id", "Autor" },
                { "gen_id", "Género" },
                { "lib_fec_pub", "Fecha de Publicación" },
                { "lib_disp_stock", "Stock" }
            };

            return View();
        }

        // POST: Libro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LibroDC libro)
        {
            if (ModelState.IsValid)
            {
                libro.lib_user_reg = "admin";
                libro.lib_fec_reg = DateTime.Now;
                servicioLibro.InsertarLibro(libro);
                return RedirectToAction("Index");
            }

            return View(libro);
        }

        // GET: Libro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var libro = servicioLibro.ConsultarLibro((short)id);
            if (libro == null)
            {
                return HttpNotFound();
            }

            ViewBag.LibroAlias = new Dictionary<string, string>
            {
                { "lib_id", "Id" },
                { "lib_nom", "Título" },
                { "aut_id", "Autor" },
                { "gen_id", "Género" },
                { "lib_fec_pub", "Fecha de Publicación" },
                { "lib_disp_stock", "Stock" }
            };

            return View(libro);
        }

        // POST: Libro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LibroDC libro)
        {
            if (ModelState.IsValid)
            {
                libro.lib_user_mod = "admin";
                libro.lib_fec_mod = DateTime.Now;
                var resultado = servicioLibro.ActualizarLibro(libro);

                if (resultado)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "No se pudo actualizar el libro.";
                }
            }

            return View(libro);
        }
    }
}
