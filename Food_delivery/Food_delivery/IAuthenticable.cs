﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public interface IAuthenticable
    {
        bool Authenticate(string email, string password);
    }
}