using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public abstract class VoorstelState
    {

        protected VoorstelState(Voorstel voorstel)
        {
            Voorstel = voorstel;
        }

        public Voorstel Voorstel { get; set; }

        protected void NieuwVoorstelAanmaken()
        {
            throw new System.NotImplementedException();
        }

        protected void IndienenVoorstel()
        {
            throw new System.NotImplementedException();
        }
    }
}