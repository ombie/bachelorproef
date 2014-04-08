using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Bachelorproef.Models.DAL.Mapping;
using Bachelorproef.Models.Domain;
using MySql.Data.Entity;

namespace Bachelorproef.Models.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BachelorproefContext : DbContext
    {
        public BachelorproefContext() : base("BachelorproefConnectie") //Zie web.config
        {

        }

        //Hier komen de DbSets
        public DbSet<Student> Studenten { get; set; }
        public DbSet<Voorstel> Voorstellen { get; set; }
        public DbSet<Onderzoeksdomein> Onderzoeksdomeinen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentMapper());
            modelBuilder.Configurations.Add(new VoorstelMapper());
            modelBuilder.Configurations.Add(new OnderzoeksdomeinMapper());
        }
    }
}