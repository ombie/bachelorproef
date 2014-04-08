using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public class Student : Gebruiker
    {
        //public Promotor Promotor { get; set; }

        #region constructors
        public Student() : base()
        {}

        public Student(string voornaam, string naam, string emailadres, string wachtwoord)
            : base(voornaam, naam, emailadres, wachtwoord)
        {
        }

        public Student(string voornaam, string naam, string emailadres)
            : base(voornaam, naam, emailadres)
        {
        }
        #endregion
    }
}