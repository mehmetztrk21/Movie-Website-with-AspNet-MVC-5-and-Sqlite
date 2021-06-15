using System.Collections.Generic;
using System.Linq;
using movie.data.Abstract;
using movie.entity;

namespace movie.data.Concrete
{
    public class AwardsRepository : IAwards
    {
        public void Add(Awards entity)
        {

            using (var db = new database())
            {
                db.Awards.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new database())
            {
                db.Awards.Remove(db.Awards.Where(i => i.id == id).FirstOrDefault());
                db.SaveChanges();
            }
        }

        public List<Awards> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Awards GetById(int id)
        {
            using (var db = new database())
            {
                return db.Awards.Where(i => i.id == id).FirstOrDefault();
            }
        }

        public void Update(Awards entity)
        {

            using (var db = new database())
            {
                db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }

        }
    }
}