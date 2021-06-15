using System.Collections.Generic;
using System.Linq;
using movie.data.Abstract;
using movie.entity;

namespace movie.data.Concrete
{
    public class AboutRepository:IAbout
    {
        public void Add(About entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<About> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public About GetById(int id)
        {
            About about;
            using (var db=new database()){
                    about=db.About.Where(i=>i.id==id).FirstOrDefault();
            }
            return about;
        }
        public void Update(About entity)
        {
            using(var db=new database()){
                db.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}