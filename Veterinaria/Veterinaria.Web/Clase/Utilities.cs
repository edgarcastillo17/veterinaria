using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veterinaria.Web.Models;

namespace Veterinaria.Web.Clase
{
    public class Utilities
    {
        readonly static ApplicationDbContext db = new ApplicationDbContext();

        public static void CheckRoles(string roleName)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            if (!roleManager.RoleExists(roleName))
            {
                roleManager.Create(new IdentityRole(roleName));
            }
        }

        internal static void CheckSuperUser()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var userAsp = userManager.FindByName("adm@admin.com");

            if (userAsp == null)
            {
                CreateUserASP("adm@admin.com", "123456", "Admin");
            }
        }

        internal static void CheckClientDefault()
        {
            var clientdb = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var userclient = clientdb.FindByName("own@owner.com");
            if (userclient == null)
            {
                CreateUserASP("own@owner.com", "123456", "Owner");
                userclient = clientdb.FindByName("own@owner.com");
                var owner = new Owner
                {
                    UserId = userclient.Id,
                };

                db.Owners.Add(owner);
                db.SaveChanges();
            }
        }

        internal static void CheckEmployee()
        {
            var vetdb = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var useremployee = vetdb.FindByName("vet@veterinary.com");
            if (useremployee == null)
            {
                CreateUserASP("vet@veterinary.com", "123456", "Veterinary");
            }
        }

        public static void CreateUserASP(string email, string password, string rol)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var userASP = new ApplicationUser()
            {
                UserName = email,
                Email = email,
            };

            userManager.Create(userASP, password);
            userManager.AddToRole(userASP.Id, rol);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}