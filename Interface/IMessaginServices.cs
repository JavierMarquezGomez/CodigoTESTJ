﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IMessaginServices
    {
        void sendMessage(string recipient, string message);
    }
}
