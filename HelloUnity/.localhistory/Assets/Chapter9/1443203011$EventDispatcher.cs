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
        public void dispatchEventWith(Object data)
        {
            AddListeners.Invoke(e);
        }
    }

    class Event
    {
        Object data;
    }
}
