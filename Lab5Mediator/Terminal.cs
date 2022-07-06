using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Sharp
{
    internal class Terminal : BaseObject
    {
        public Terminal(int number = 0)
        {
            this.Number = number;
        }
        public void SetTerminal(Plane plane)
        {            
            this._dispatcher.Notify(plane);
        }
        public override void GetState()
        {
            if (!this.isBusy)
            {
                this.isBusy = true;
                Console.WriteLine("Підключено термінал " + this.Number);
            }
            else
            {
                Console.WriteLine("Цей термінал вже застосовується, оберіть інший");
            }
            
        }
        public override string ToString()
        {
            return "Поточний термінал " + this.Number + " \n";
        }
    }
}
