using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public abstract class Gebruiker
    {
        #region properties
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        [Key]
        public string Emailadres { get; set; }
        public string Wachtwoord { get; set; }
        public bool EersteAanmelding { get; set; }
        #endregion

        #region constructors
        public Gebruiker(){}

        public Gebruiker(string voornaam, string naam, string emailadres, string wachtwoord)
            : this(voornaam, naam, emailadres)
        {
            Wachtwoord = wachtwoord;
        }

        public Gebruiker(string voornaam, string naam, string emailadres)
        {
            Voornaam = voornaam;
            Naam = naam;
            Emailadres = emailadres;
        }
        #endregion
    }
}