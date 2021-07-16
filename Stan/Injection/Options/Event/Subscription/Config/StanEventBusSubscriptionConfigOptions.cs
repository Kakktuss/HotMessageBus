﻿using System;
using System.Collections.Generic;
using STAN.Client;

namespace HotBrokerBus.Stan.Extensions.Options.Event.Event.Config
{
    public class StanEventBusSubscriptionConfigOptions
    {
        public StanEventBusSubscriptionConfigOptions(Dictionary<string, Tuple<Type, Type, string, StanSubscriptionOptions>> events)
        {
            Events = events;
        }
        
        internal Dictionary<string, Tuple<Type, Type, string, StanSubscriptionOptions>> Events { get; }
    }
}