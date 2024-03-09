using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        UsersContext uc = new();
        public IActionResult YKView()
        {
            return View(uc.YkumarTables.ToList());
        }
    }
}
