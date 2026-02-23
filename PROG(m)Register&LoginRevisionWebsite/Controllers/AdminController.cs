using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PROG_m_Register_LoginRevisionWebsite.Controllers
{
    public class AdminController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Search(string searchString)
        {
            var users = _userManager.Users.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                users = users.Where(u => u.Email.Contains(searchString));
            }

            return View(users.ToList());
        }


    }
    }
