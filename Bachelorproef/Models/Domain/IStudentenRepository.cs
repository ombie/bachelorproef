using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public interface IStudentenRepository
    {
        IQueryable<Student> FindAll();
        Student Find(string email);
        IQueryable<Student> FindByName(string naam);
        void SaveChanges();
    }
}