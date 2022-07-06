using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Sharp
{
    internal class LandingStrip : BaseObject
    {
        public LandingStrip(int number = 0)
        {
            this.Number = number;
        }
        public void SetLandingStrip(Plane plane)
        {
            this._dispatcher.Notify(plane);
        }
        public override void GetState()
        {
            if (!this.isBusy)
            {
                this.isBusy = true;
                Console.WriteLine("Поточна полоса " + this.Number);
            }
            else
            {                
                Console.WriteLine("Ця полоса вже застосовується, оберіть іншу");
            }            
        }
        public override string ToString()
        {
            return "Поточна полоса " + this.Number + " \n";
        }
    }
}
