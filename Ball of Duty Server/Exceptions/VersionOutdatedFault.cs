﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Ball_of_Duty_Server.Exceptions
{
    [Serializable]
    public class VersionOutdatedFault
    {
        public string Message;
    }
}