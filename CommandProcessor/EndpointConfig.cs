﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace CommandProcessor
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher
    {
    }
}
