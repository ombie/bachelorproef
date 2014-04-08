using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public class Promotor : Gebruiker
    {
        #region properties
        public ICollection<Student> Studenten { get; set; }
        #endregion

        #region constructors
        public Promotor(string voornaam, string naam, string emailadres, string wachtwoord)
            : base(voornaam, naam, emailadres, wachtwoord)
        {
            Studenten = new List<Student>();
        }

        public Promotor(string voornaam, string naam, string emailadres)
            : base(voornaam, naam, emailadres)
        {
        }
        #endregion
    }
}