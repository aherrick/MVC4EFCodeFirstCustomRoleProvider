﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4CustomRoleProvider.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IList<User> Users { get; set; }
    }
}