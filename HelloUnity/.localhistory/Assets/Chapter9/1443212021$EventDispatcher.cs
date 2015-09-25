﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    class EventDispatcher
    {

        public delegate void EventDeletegate(Event data);
        public event EventDeletegate AddListeners;

        public void dispatchEventWith<T>(T data)
        {
            Event e = new Event();
            e.data = data;
            AddListeners(e);
        }
    }

    class Event<T>
    {
        public Object data;
    }
}
