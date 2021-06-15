using System.Collections.Generic;
using System.Linq;
using movie.data.Abstract;
using movie.entity;

namespace movie.data.Concrete
{
    public class ActorRepository : IActor
    {
        public void Add(Actor entity)
        {
            using(var db=new database()){
                db.Actors.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using(var db=new database()){
                db.Actors.Remove(db.Actors.Where(i=>i.id==id).FirstOrDefault());
                db.SaveChanges();
            }
        }

        public List<Actor> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Actor GetById(int id)
        {
            using(var db=new database()){
                return db.Actors.Where(i=>i.id==id).FirstOrDefault();
            }
        }

        public void Update(Actor entity)
        {
            using(var db=new database()){
                db.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}