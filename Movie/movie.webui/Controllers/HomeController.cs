using Microsoft.AspNetCore.Mvc;
using movie.data.Abstract;
using movie.entity;
using movie.webui.Models;

namespace movie.webui.Controllers
{
    public class HomeController : Controller
    {
        IAbout _about;
        IActor _actors;
        IAwards _awards;
        IDirector _directors;
        IMovie _movies;

        public HomeController(IAbout about, IActor actor, IAwards awards, IDirector director, IMovie movie)
        {
            _about = about;
            _actors = actor;
            _awards = awards;
            _directors = director;
            _movies = movie;

        }
        public IActionResult Index(string q = null)
        {
            if (q == null)
            {
                var directors = _directors.GetAll();
                var model = new GenericModel()
                {
                    directors = directors
                };
                return View(model);
            }
            else
            {
                var directors = _directors.GetByName(q);

                var model = new GenericModel()
                {
                    directors = directors
                };
                return View(model);
            }

        }
        public IActionResult Details(int id)
        {
            var director = _directors.GetById(id);
            var model = new GenericModel()
            {
                director = director
            };
            return View(model);
        }
        public IActionResult movieDetails(int id)
        {
            var movie = _movies.GetById(id);
            var model = new GenericModel()
            {
                movie = movie
            };
            return View(model);
        }
        public IActionResult about()
        {
            var about = _about.GetById(1);
            var model = new aboutModel()
            {
                id = about.id,
                about = about.about
            };

            return View(model);
        }

        public IActionResult search(string q)
        {

            return RedirectToAction("Index", "Home", new { @q = q });
        }
    }
}