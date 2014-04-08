using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Bachelorproef.Models.Domain;

namespace Bachelorproef.Models.DAL.Mapping
{
    public class VoorstelMapper : EntityTypeConfiguration<Voorstel>
    {
        public VoorstelMapper()
        {
            HasKey(v => v.StudentId);

            Property(v => v.Titel);
            Property(v => v.VrijeTrefwoorden);
            Property(v => v.Probleemstelling);
            Property(v => v.Onderzoeksvraag);
            Property(v => v.PlanVanAanpak);
            Property(v => v.TijdstipVanIndienen);

            ToTable("Voorstel");
        }
    }
}