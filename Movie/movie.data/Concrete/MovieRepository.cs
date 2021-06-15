using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using movie.data.Abstract;
using movie.entity;

namespace movie.data.Concrete
{
    public class MovieRepository : IMovie
    {
        public void Add(Movie entity)
        {
            using(var db=new database()){
                db.Movies.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new database())
            {
                db.Movies.Remove(db.Movies.Where(i => i.id == id).FirstOrDefault());
                db.SaveChanges();
            }

        }

        public List<Movie> GetAll()
        {
            List<Movie> movies = null;
            using (var db = new database())
            {
                movies = db.Movies.ToList();

            }
            return null;
        }
        public Movie GetById(int id)
        {   Movie movies;
            using (var db = new database())
            {
               movies=  db.Movies.Where(i => i.id == id).FirstOrDefault();
               movies.actors=db.Actors.Where(i=>i.movie_id==id).ToList();
               movies.awards=db.Awards.Where(i=>i.movieId==id).ToList();
            }
            return movies;
        }

        public void Update(Movie entity)
        {
            using(var db=new database()){
                db.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}