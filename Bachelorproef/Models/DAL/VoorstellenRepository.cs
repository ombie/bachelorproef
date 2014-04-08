using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Bachelorproef.Models.Domain;

namespace Bachelorproef.Models.DAL
{
    public class VoorstellenRepository : IVoorstellenRepository
    {
        private BachelorproefContext context;
        private DbSet<Voorstel> Voorstellen;

        public VoorstellenRepository(BachelorproefContext context)
        {
            this.context = context;
            Voorstellen = context.Voorstellen;
        }

        public IQueryable<Voorstel> FindAll()
        {
            return Voorstellen.OrderBy(l => l.Student.Emailadres);
        }

        public Voorstel Find(string studentId)
        {
            return Voorstellen.Find(studentId);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void create(Voorstel voorstel)
        {
            Voorstellen.Add(voorstel);
            SaveChanges();
        }
    }
}