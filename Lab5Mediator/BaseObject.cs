using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Sharp
{
    abstract class BaseObject
    {
        public int Number { get; set; } = 0;
        public bool isBusy { get; set; } = false;

        protected IMediator _dispatcher;

        public BaseObject(IMediator mediator = null)
        {
            this._dispatcher = mediator;
        }

        public void SetDispatcher(IMediator mediator)
        {
            this._dispatcher = mediator;
        }

        public virtual void GetState()
        {
            Console.WriteLine("Поточний об'єкт зайнятий");
        }
    }
}
