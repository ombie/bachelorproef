using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Bachelorproef.Models.Domain;

namespace Bachelorproef.Models.DAL
{
    //via repository klasse kan een controller toegang krijgen tot de database.
    //De repository wordt aan de controller gegeven via ninject in zijn controller. 
    //(om dat te doen, zie klasse NinjectWebCommon.cs in map App_Start)
    //Deze repository vraagt aan de context, ProjectContext dus, om de objecten
    //die hij nodig heeft. In dit geval studenten. Daarvoor gebruik je Linq queries enzo.
    //Vergeet ook niet een interface van een repository aan te maken, hier IStudentenRepository.
    //Anders kan ninject deze klasse niet in de controller injecteren!
    public class StudentenRepository : IStudentenRepository
    {
        private BachelorproefContext context;
        private DbSet<Student> studenten;

        public StudentenRepository(BachelorproefContext context)
        {
            this.context = context;
            studenten = context.Studenten;
        }

        public IQueryable<Student> FindAll()
        {
            return studenten.OrderBy(l => l.Emailadres);
        }

        public Student Find(string email)
        {
            return studenten.Find(email);
        }

        public IQueryable<Student> FindByName(string naam)
        {
            return studenten.Where(s => s.Naam.Equals(naam));
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}