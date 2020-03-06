using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AcervoFilmes.Models;

namespace AcervoFilmes.Controllers
{
    public class MovieController : Controller
    {
        MovieDbContext db;

        public MovieController()
        {
            db = new MovieDbContext();
        }
        // GET: Produtos
        public ActionResult Index()
        {
            var movies = db.Movies.ToList();
            return View(movies);
        }

        public ActionResult Create()
        {
            //ViewBag.Categorias = db.Categorias;
            var model = new MovieViewModel();
            ViewBag.Title = "Novo Filme";
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieViewModel model)
        {
          
            if (model.MovieId != 0) {
                var movie = db.Movies.Find(model.MovieId);
                movie.title = model.Title;
                movie.duration = model.Duration;
                movie.sinopse = model.Sinopse;
                movie.yearMovie = model.Year;
                movie.elenco = model.Elenco;
                movie.typeMidia = model.TypeMidia;
                movie.direction = model.Direction;

                db.SaveChanges();
                return RedirectToAction("Index");
            }


            if (ModelState.IsValid)
            {
                var movie = new Movie();
                movie.title = model.Title;
                movie.sinopse = model.Sinopse;
                movie.duration = model.Duration;
                movie.direction = model.Direction;
                movie.yearMovie = model.Year;
                movie.elenco = model.Elenco;
                movie.typeMidia = model.TypeMidia;
                db.Movies.Add(movie);

               
                db.SaveChanges();
                return RedirectToAction("Index");
            }
 
            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Movie movie = db.Movies.Find(id);
            var model = new MovieViewModel();
            model.MovieId = movie.movieId;
            model.Title = movie.title;
            model.Sinopse = movie.sinopse;
            model.Direction = movie.direction;
            model.Duration = movie.duration;
            model.Elenco = movie.elenco;
            model.Year = movie.yearMovie;
            model.TypeMidia = movie.typeMidia;
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.Title = "Editar Filme";
            return View("Create",model);
        }

        public ActionResult Details(int id) {
            Movie movie = db.Movies.Find(id);
            return View(movie);
        }

       
     
      
        public ActionResult Delete(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

