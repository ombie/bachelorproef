using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public class Voorstel
    {
        #region properties
        public string StudentId { get; set; }
        [NotMapped]
        public Student Student {
            get { return _Student; }
            set { _Student = value; StudentId = _Student.Emailadres; } }
        [NotMapped]
        public Student _Student { get; set; }
        public string Titel { get; set; }
        public string VrijeTrefwoorden { get; set; }
        public string Probleemstelling { get; set; }
        public string Onderzoeksvraag { get; set; }
        public string PlanVanAanpak { get; set; }
        public DateTime TijdstipVanIndienen { get; set; }

        public string StateString { get; set; }

        [NotMapped]
        public VoorstelState CurrentState{
            get
            {
                return StateFactory.GetState(this.StateString);
            }
            set
            {
                this.StateString = value.GetType().Name;
            }
        }



        public Onderzoeksdomein[] onderzoeksdomeinen;
        #endregion

        #region constructors
        public Voorstel(Student student)
        {
            Student = student;
            toNieuwState();
            onderzoeksdomeinen = new Onderzoeksdomein[2];
        }
        #endregion

        public void toNieuwState()
        {
            CurrentState = new NieuwState(this);
        }

        public void toInBehandelingState()
        {
            CurrentState = new InBehandelingState(this);
        }

    }
}