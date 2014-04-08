using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public class InBehandelingState : VoorstelState
    {
        public InBehandelingState(Voorstel voorstel)
            : base(voorstel)
        {
        }
    }
}