﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
   

    class EventDispatcher
    {
        
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

    public delegate void EventDeletegate(Event data);
}
