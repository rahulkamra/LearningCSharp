﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Chapter9
{
    class EventDispatcher
    {

        public delegate void EventDeletegate(Event data);
        public event EventDeletegate AddListeners;
    }

    class Event
    {
        Object data;
    }
}
