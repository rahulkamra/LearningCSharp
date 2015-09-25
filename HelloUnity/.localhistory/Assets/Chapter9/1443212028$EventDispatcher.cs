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
            Event<T> e = new Event();
            e.data = data;
            AddListeners(e);
        }
    }

    class Event<T>
    {
        public T data;
    }
}
