using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Bachelorproef.Models.Domain;

namespace Bachelorproef.Models.DAL
{
    public class OnderzoeksdomeinenRepository : IOnderzoeksdomeinenRepository
    {
        private BachelorproefContext context;
        private DbSet<Onderzoeksdomein> Onderzoeksdomeinen;

        public OnderzoeksdomeinenRepository(BachelorproefContext context)
        {
            this.context = context;
            Onderzoeksdomeinen = context.Onderzoeksdomeinen;
        }

        public IQueryable<Onderzoeksdomein> FindAll()
        {
            return Onderzoeksdomeinen;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}