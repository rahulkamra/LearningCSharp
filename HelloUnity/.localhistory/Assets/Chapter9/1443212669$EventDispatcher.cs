﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    public delegate void EventDeletegate(Event data);
    class EventDispatcher
    {
        
        public event EventDeletegate AddListeners;
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
