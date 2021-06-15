using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using movie.data.Abstract;
using movie.entity;

namespace movie.data.Concrete
{
    public class DirectorRepository : IDirector
    {
        public void Add(Director entity)
        {
            using (var db = new database())
            {
                db.Directors.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new database())
            {
                db.Directors.Remove(db.Directors.Where(i => i.id == id).FirstOrDefault());
                db.SaveChanges();
            }
        }

        public List<Director> GetAll()
        {
            using (var db = new database())
            {
                return db.Directors.ToList();
            }
        }

        public Director GetById(int id)
        {
            Director director;
            using (var db = new database())
            {
                director = db.Directors.Include(i => i.movies).Where(j => j.id == id).FirstOrDefault();
                director.movies = db.Movies.Where(i => i.director_id == id).ToList();
            }
            return director;
        }

        public List<Director> GetByName(string q)
        {
            List<Director> directors = null;
            using (var db = new database())
            {
                directors = db.Directors.Where(i => i.name.ToLower().Contains(q.ToLower())).ToList();
                if(directors.Count==0){
                    return GetAll();
                }
                else{
                    return directors;
                }
            }
        }

        public void Update(Director entity)
        {
            using (var db = new database())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}