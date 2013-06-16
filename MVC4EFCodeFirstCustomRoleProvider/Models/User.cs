using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4CustomRoleProvider.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public virtual IList<Role> Roles { get; set; }
    }
}