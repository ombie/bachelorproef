using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public class NieuwState : VoorstelState
    {
        public NieuwState(Voorstel voorstel)
            : base(voorstel)
        {
        }

        protected void IndienenVoorstel()
        {
            Voorstel.toInBehandelingState();
        }
    }
}