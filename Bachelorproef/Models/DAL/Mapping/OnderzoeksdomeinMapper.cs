using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Bachelorproef.Models.Domain;

namespace Bachelorproef.Models.DAL.Mapping
{
    public class OnderzoeksdomeinMapper : EntityTypeConfiguration<Onderzoeksdomein>
    {
        public OnderzoeksdomeinMapper()
        {
            HasKey(o => o.OnderzoeksId);

        }
    }
}