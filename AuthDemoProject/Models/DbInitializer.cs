using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AuthDemoProject.Models
{
	public class DbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
	{
		protected override void Seed(ApplicationDbContext context)
		{
			var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
			var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

			var adminRole = new IdentityRole { Name = "admin" };

			roleManager.Create(adminRole);

			var admin = new ApplicationUser { Email = "somemail@mail.ru", UserName = "somemail@mail.ru" };
			var password = "ad46D_ewr3";
			var result = userManager.Create(admin, password);

			if (result.Succeeded)
			{
				userManager.AddToRole(admin.Id, adminRole.Name);
			}

			base.Seed(context);
		}
	}
}