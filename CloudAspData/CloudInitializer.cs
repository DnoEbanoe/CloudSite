using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudAspData.Entity;
using CloudAspData.EntityFramework;

namespace CloudAspData
{
    public class CloudInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<CloudContext>
    {
        protected override void Seed(CloudContext context)
        {
            if (!context.Roles.Any())
            {
                Role admin = new Role{Id = Guid.NewGuid(), Name = "Admin"};
                Role user = new Role{Id = Guid.NewGuid(), Name = "User"};
                context.Roles.Add(admin);
                context.Roles.Add(user);
                context.Clients.Add(new Client
                {
                    Id = Guid.NewGuid(),
                    Role = admin,
                    Email = "azaza",
                    Password = "123",
                    FirstName = "Sasha"
                });
                News news = new News{Id = Guid.NewGuid(), Caption = "TestNews 1", Text = "gjchhbdjkvhndlkvjdl"};
                context.News.Add(news);
                context.SaveChanges();
            }

            base.Seed(context);
        }
    }
}
