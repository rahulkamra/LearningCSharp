using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    public delegate void EventDeletegate(Event data);
    public class EventDispatcher
    {
        
        public event EventDeletegate AddListeners;
        public event Action<string> TestEvent;

        public void dispatchEventWith(Object data)
        {
            Event e = new Event();
            e.data = data;
            AddListeners(e);
        }
    }

    public class Event
    {
        public Object data;
    }
}
