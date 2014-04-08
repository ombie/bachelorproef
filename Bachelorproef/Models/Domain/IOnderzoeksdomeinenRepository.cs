using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public interface IOnderzoeksdomeinenRepository
    {
        IQueryable<Onderzoeksdomein> FindAll();
        void SaveChanges();
    }
}