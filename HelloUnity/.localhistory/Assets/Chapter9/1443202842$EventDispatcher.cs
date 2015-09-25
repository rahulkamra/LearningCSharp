using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Chapter9
{
    class EventDispatcher
    {

        public delegate void EventDeletegate();
        public event EventDeletegate AddListeners;
    }

    class Event
    {

    }
}
