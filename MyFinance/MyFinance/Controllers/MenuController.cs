using Microsoft.AspNetCore.Mvc;

namespace MyFinance.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult _PartialMenu()
        {

            return PartialView("_PartialMenu");
        }
    }
}