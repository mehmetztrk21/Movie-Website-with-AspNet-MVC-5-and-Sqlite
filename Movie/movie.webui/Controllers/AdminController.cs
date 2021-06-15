using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movie.data.Abstract;
using movie.entity;
using movie.webui.Models;

namespace movie.webui.Controllers
{
    [Authorize(Roles = "admin")]  //admin sayfasına ulaşmak için illa giriş yapılması lazım.

    public class AdminController : Controller
    {
        IAbout _about;
        IActor _actors;
        IAwards _awards;
        IDirector _directors;
        IMovie _movies;

        public AdminController(IAbout about, IActor actors, IAwards awards, IDirector directors, IMovie movies)
        {
            _about = about;
            _actors = actors;
            _awards = awards;
            _directors = directors;
            _movies = movies;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult editAbout()
        {
            var about = _about.GetById(1);
            var model = new aboutModel()
            {
                id = about.id,
                about = about.about
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult editAbout(aboutModel model)
        {

            About about = new About()
            {
                id = model.id,
                about = model.about
            };
            _about.Update(about);
            return RedirectToAction("Index", "Admin");
        }
        public IActionResult directors()
        {
            var director = _directors.GetAll();
            var model = new GenericModel()
            {
                directors = director
            };
            return View(model);
        }

        public IActionResult DeleteDirector(int id)
        {
            _directors.Delete(id);
            return RedirectToAction("Directors", "Admin");
        }

        [HttpGet]
        public IActionResult EditDirector(int id)
        {
            var director = _directors.GetById(id);
            var model = new directorModel()
            {
                id = director.id,
                name = director.name,
                ozet = director.ozet,
                description = director.description,
                ımdb = director.ımdb,
                avatar = director.avatar,
                avatar_2 = director.avatar_2,
                movies = director.movies
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditDirector(directorModel model, IFormFile file1, IFormFile file2)
        {
            Director director = new Director()
            {
                id = model.id,
                name = model.name,
                ozet = model.ozet,
                description = model.description,
                ımdb = model.ımdb,
                avatar = model.avatar,
                avatar_2 = model.avatar_2
            };
            if (file1 != null)
            {
                var extention = Path.GetExtension(file1.FileName);  //resmin uzantısını bulduk.
                var randomName = string.Format($"{Guid.NewGuid()}{extention}"); //rastgele bir isim tanımlama. İstediğin bir mantık ile kullanabilirsin. Guid.neGuid uzun bir sayı verir bize başka resimlerle aynı isim olmasın diye. Ayrıca uzantısını da belirttik.
                director.avatar = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resmin kaydedileceği yer.

                using (var stream = new FileStream(path, FileMode.Create))  //girdiğimiz yola resmi fiiksel olarak kaydetmemiz için yazdık.
                {
                    await file1.CopyToAsync(stream);  //kaydettik.
                }
            }
            if (file2 != null)
            {
                var extention = Path.GetExtension(file2.FileName);  //resmin uzantısını bulduk.
                var randomName = string.Format($"{Guid.NewGuid()}{extention}"); //rastgele bir isim tanımlama. İstediğin bir mantık ile kullanabilirsin. Guid.neGuid uzun bir sayı verir bize başka resimlerle aynı isim olmasın diye. Ayrıca uzantısını da belirttik.
                director.avatar_2 = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resmin kaydedileceği yer.

                using (var stream = new FileStream(path, FileMode.Create))  //girdiğimiz yola resmi fiiksel olarak kaydetmemiz için yazdık.
                {
                    await file2.CopyToAsync(stream);  //kaydettik.
                }
            }
            _directors.Update(director);
            return RedirectToAction("EditDirector", "Admin", new { @id = director.id });
        }

        [HttpGet]
        public IActionResult AddDirector()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddDirector(directorModel model, IFormFile file1, IFormFile file2)
        {

            Director director = new Director()
            {
                name = model.name,
                ozet = model.ozet,
                description = model.description,
                ımdb = model.ımdb,
                avatar = model.avatar,
                avatar_2 = model.avatar_2
            };
            if (file1 != null)
            {
                var extention = Path.GetExtension(file1.FileName);  //resmin uzantısını bulduk.
                var randomName = string.Format($"{Guid.NewGuid()}{extention}"); //rastgele bir isim tanımlama. İstediğin bir mantık ile kullanabilirsin. Guid.neGuid uzun bir sayı verir bize başka resimlerle aynı isim olmasın diye. Ayrıca uzantısını da belirttik.
                director.avatar = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resmin kaydedileceği yer.

                using (var stream = new FileStream(path, FileMode.Create))  //girdiğimiz yola resmi fiiksel olarak kaydetmemiz için yazdık.
                {
                    await file1.CopyToAsync(stream);  //kaydettik.
                }
            }
            if (file2 != null)
            {
                var extention = Path.GetExtension(file2.FileName);  //resmin uzantısını bulduk.
                var randomName = string.Format($"{Guid.NewGuid()}{extention}"); //rastgele bir isim tanımlama. İstediğin bir mantık ile kullanabilirsin. Guid.neGuid uzun bir sayı verir bize başka resimlerle aynı isim olmasın diye. Ayrıca uzantısını da belirttik.
                director.avatar_2 = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resmin kaydedileceği yer.

                using (var stream = new FileStream(path, FileMode.Create))  //girdiğimiz yola resmi fiiksel olarak kaydetmemiz için yazdık.
                {
                    await file2.CopyToAsync(stream);  //kaydettik.
                }
            }
            _directors.Add(director);
            return RedirectToAction("Directors", "Admin");
        }



        public IActionResult EditMovie(int id)
        {
            var movie = _movies.GetById(id);
            var model = new movieModel()
            {
                id = movie.id,
                name = movie.name,
                ozet = movie.ozet,
                description = movie.description,
                img = movie.img,
                vizyon = movie.vizyon,
                imdb_puan = movie.imdb_puan,
                app_store = movie.app_store,
                play_store = movie.play_store,
                netflix = movie.netflix,
                imdb = movie.imdb,
                metacritic = movie.metacritic,
                director_id = movie.director_id,
                actors = movie.actors,
                fragman = movie.fragman,
                awards = movie.awards,
                süre = movie.süre
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditMovie(movieModel movie, IFormFile file1)
        {
            var temp = _movies.GetById(movie.id);
            Movie model = new Movie()
            {
                id = movie.id,
                name = movie.name,
                ozet = movie.ozet,
                description = movie.description,
                img = movie.img,
                vizyon = movie.vizyon,
                imdb_puan = movie.imdb_puan,
                app_store = movie.app_store,
                play_store = movie.play_store,
                netflix = movie.netflix,
                imdb = movie.imdb,
                metacritic = movie.metacritic,
                director_id = temp.director_id,
                actors = movie.actors,
                fragman = movie.fragman,
                awards = movie.awards,
                süre = movie.süre,
                director_name = _directors.GetById(temp.director_id).name
            };
            if (file1 != null)
            {
                var extention = Path.GetExtension(file1.FileName);  //resmin uzantısını bulduk.
                var randomName = string.Format($"{Guid.NewGuid()}{extention}"); //rastgele bir isim tanımlama. İstediğin bir mantık ile kullanabilirsin. Guid.neGuid uzun bir sayı verir bize başka resimlerle aynı isim olmasın diye. Ayrıca uzantısını da belirttik.
                model.img = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resmin kaydedileceği yer.

                using (var stream = new FileStream(path, FileMode.Create))  //girdiğimiz yola resmi fiiksel olarak kaydetmemiz için yazdık.
                {
                    await file1.CopyToAsync(stream);  //kaydettik.
                }
            }
            _movies.Update(model);
            return RedirectToAction("EditMovie", "Admin", new { @id = movie.id });
        }

        [HttpGet]
        public IActionResult AddMovie(int id)
        {
            var model = new movieModel()
            {
                director_id = id
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddMovie(movieModel movie, IFormFile file1)
        {
            Movie model = new Movie()
            {
                name = movie.name,
                ozet = movie.ozet,
                description = movie.description,
                vizyon = movie.vizyon,
                imdb_puan = movie.imdb_puan,
                app_store = movie.app_store,
                play_store = movie.play_store,
                netflix = movie.netflix,
                imdb = movie.imdb,
                director_id = movie.director_id,
                metacritic = movie.metacritic,
                actors = movie.actors,
                fragman = movie.fragman,
                awards = movie.awards,
                süre = movie.süre,
                director_name = _directors.GetById(movie.director_id).name
            };
            if (file1 != null)
            {
                var extention = Path.GetExtension(file1.FileName);  //resmin uzantısını bulduk.
                var randomName = string.Format($"{Guid.NewGuid()}{extention}"); //rastgele bir isim tanımlama. İstediğin bir mantık ile kullanabilirsin. Guid.neGuid uzun bir sayı verir bize başka resimlerle aynı isim olmasın diye. Ayrıca uzantısını da belirttik.
                model.img = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resmin kaydedileceği yer.

                using (var stream = new FileStream(path, FileMode.Create))  //girdiğimiz yola resmi fiiksel olarak kaydetmemiz için yazdık.
                {
                    await file1.CopyToAsync(stream);  //kaydettik.
                }
            }
            _movies.Add(model);
            return RedirectToAction("EditDirector", "Admin", new { @id = movie.director_id });
        }

        [HttpGet]
        public IActionResult EditAward(int id)
        {
            var award = _awards.GetById(id);
            awardModel model = new awardModel()
            {
                id = award.id,
                name = award.name,
                movieId = award.movieId
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditAward(awardModel award)
        {
            Awards model = new Awards()
            {
                id = award.id,
                name = award.name,
                movieId = award.movieId
            };
            _awards.Update(model);
            return RedirectToAction("EditMovie", "Admin", new { @id = model.movieId });
        }

        [HttpGet]
        public IActionResult AddAward(int id)
        {
            var model = new awardModel()
            {
                movieId = id
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddAward(awardModel award)
        {
            Awards model = new Awards()
            {
                name = award.name,
                movieId = award.movieId
            };
            _awards.Add(model);
            return RedirectToAction("EditMovie", "Admin", new { @id = model.movieId });


        }


        [HttpGet]
        public IActionResult AddActor(int id)
        {
            var model = new actorModel()
            {
                movie_id = id
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddActor(actorModel actor, IFormFile file1)
        {
            var model = new Actor()
            {
                name = actor.name,
                description = actor.description,
                movie_id = actor.movie_id
            };
            if (file1 != null)
            {
                var extention = Path.GetExtension(file1.FileName);  //resmin uzantısını bulduk.
                var randomName = string.Format($"{Guid.NewGuid()}{extention}"); //rastgele bir isim tanımlama. İstediğin bir mantık ile kullanabilirsin. Guid.neGuid uzun bir sayı verir bize başka resimlerle aynı isim olmasın diye. Ayrıca uzantısını da belirttik.
                model.img = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resmin kaydedileceği yer.

                using (var stream = new FileStream(path, FileMode.Create))  //girdiğimiz yola resmi fiiksel olarak kaydetmemiz için yazdık.
                {
                    await file1.CopyToAsync(stream);  //kaydettik.
                }
            }
            _actors.Add(model);
            return RedirectToAction("EditMovie", "Admin", new { @id = model.movie_id });
        }

        [HttpGet]
        public IActionResult EditActor(int id)
        {
            var actor = _actors.GetById(id);
            var model = new actorModel()
            {
                id = actor.id,
                name = actor.name,
                description = actor.description,
                img = actor.img,
                movie = actor.movie,
                movie_id = actor.movie_id
            };
            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> EditActor(actorModel actor, IFormFile file1)
        {
            var model = new Actor()
            {
                id = actor.id,
                name = actor.name,
                description = actor.description,
                img = actor.img,
                movie = actor.movie,
                movie_id = actor.movie_id
            };
            if (file1 != null)
            {
                var extention = Path.GetExtension(file1.FileName);  //resmin uzantısını bulduk.
                var randomName = string.Format($"{Guid.NewGuid()}{extention}"); //rastgele bir isim tanımlama. İstediğin bir mantık ile kullanabilirsin. Guid.neGuid uzun bir sayı verir bize başka resimlerle aynı isim olmasın diye. Ayrıca uzantısını da belirttik.
                model.img = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName); //resmin kaydedileceği yer.

                using (var stream = new FileStream(path, FileMode.Create))  //girdiğimiz yola resmi fiiksel olarak kaydetmemiz için yazdık.
                {
                    await file1.CopyToAsync(stream);  //kaydettik.
                }
            }
            _actors.Update(model);
            return RedirectToAction("EditMovie", "Admin", new { @id = model.movie_id });



        }
        public IActionResult DeleteActor(int id)
        {
            var actor = _actors.GetById(id);
            _actors.Delete(id);
            return RedirectToAction("EditMovie", "Admin", new { @id = actor.movie_id });
        }

        public IActionResult DeleteMovie(int id)
        {
            var movie = _movies.GetById(id);
            _movies.Delete(id);
            return RedirectToAction("EditDirector", "Admin", new { @id = movie.director_id });
        }

        public IActionResult DeleteAward(int id)
        {
            var award = _awards.GetById(id);
            _awards.Delete(id);
            return RedirectToAction("EditMovie", "Admin", new { @id = award.movieId });
        }
    }
}