using System.Collections.Generic;
using movie.entity;

namespace movie.data.Abstract
{
    public interface IDirector : IGeneric<Director>
    {
        List<Director> GetByName(string q);
    }
}