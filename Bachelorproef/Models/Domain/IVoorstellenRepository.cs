using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public interface IVoorstellenRepository
    {
        IQueryable<Voorstel> FindAll();
        Voorstel Find(string studentId);
        void SaveChanges();
        void create(Voorstel voorstel);
    }
}