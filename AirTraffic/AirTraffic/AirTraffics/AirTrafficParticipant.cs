using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTraffic
{
    public abstract class AirTrafficParticipant
    {
        protected IAirTrafficMediator _mediator;
        protected AirTrafficParticipant(IAirTrafficMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
