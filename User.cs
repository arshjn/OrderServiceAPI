﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesAssignment4
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Role role { get; set; }

        public enum Role
        {
            user,
            admin
        };

    }
}
