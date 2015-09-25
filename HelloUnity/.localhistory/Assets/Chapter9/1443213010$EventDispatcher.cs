using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    public class EventDispatcher
    {

        public delegate void EventDeletegate(Event data);
        public event EventDeletegate AddListeners;

        public event Action<string> TestEvent;

        public void dispatchEventWith(Object data)
        {
            Event e = new Event();
            e.data = data;
            AddListeners(e);
        }
    }

    class Event
    {
        public Object data;
    }
}
