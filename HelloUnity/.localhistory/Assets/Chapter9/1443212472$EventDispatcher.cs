using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    class EventDispatcher<T>
    {

        public delegate void EventDeletegate<T>(Event<T> data);
        public event EventDeletegate<T> AddListeners;
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
