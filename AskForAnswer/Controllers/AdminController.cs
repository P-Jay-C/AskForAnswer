using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AskForAnswer.Controllers
{
	public class AdminController : Controller
	{
		private readonly UserManager<IdentityUser> userManager;

		public AdminController(UserManager<IdentityUser> userManager)
		{
			userManager = userManager;
		}
		public async Task<IActionResult> Index()
		{
			var users = await userManager.Users.ToListAsync();
			
			return View(users);
		}
	}
}
