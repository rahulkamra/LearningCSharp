﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    class EventDispatcher
    {

        public delegate void EventDeletegate<T>(Event<T> data);
        public event EventDeletegate<Object> AddListeners;

        public void dispatchEventWith<T>(T data)
        {
            Event<T> e = new Event<T>();
            e.data = data;
            AddListeners<T>(e);
        }
    }

    class Event<T>
    {
        public T data;
    }
}
