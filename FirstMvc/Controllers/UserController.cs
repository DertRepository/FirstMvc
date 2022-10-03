using FirstMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvc.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>();
        public IActionResult Index()
        {
            return View(users);
        }
        public IActionResult Create()
        {
            User user = new User();
            return View(user);
        }
        public IActionResult CreateUser(User user)
        {
            users.Add(user);
            return RedirectToAction(nameof(Index));
        }
    }
}
