using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC4CustomRoleProvider.Models
{
    public class DataContextInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Users.Add(new User()
            {
                Username = "AJ",
                Roles = new List<Role>() {

                      new Role {
                           Name = "Administrator"
                      }
                  }
            });
        }
    }
}