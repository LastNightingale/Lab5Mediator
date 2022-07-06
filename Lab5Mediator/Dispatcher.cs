using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Sharp
{
    internal class Dispatcher : IMediator
    {
        private Terminal _terminal;

        private LandingStrip _landingstrip;

        public Dispatcher(Terminal terminal, LandingStrip landingstrip)
        {
            this._terminal = terminal;
            this._terminal.SetDispatcher(this);
            this._landingstrip = landingstrip;
            this._landingstrip.SetDispatcher(this);
        }

        public void Notify(Plane plane)
        {            
            if(!this._terminal.isBusy) plane.Terminal = this._terminal;
            this._terminal.GetState();            
            if (!this._landingstrip.isBusy) plane.Strip = this._landingstrip;
            this._landingstrip.GetState();
        }
    }
}
