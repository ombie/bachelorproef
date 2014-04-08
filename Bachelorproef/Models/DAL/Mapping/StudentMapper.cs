using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Bachelorproef.Models.Domain;

namespace Bachelorproef.Models.DAL.Mapping
{
    public class StudentMapper : EntityTypeConfiguration<Student>
    {
        public StudentMapper()
        {
            HasKey(s => s.Emailadres);
            Property(s => s.Naam);
            Property(s => s.Voornaam);
            Property(s => s.Wachtwoord);
            Property(s => s.EersteAanmelding);

            ToTable("gebruiker");
        }
    }
}