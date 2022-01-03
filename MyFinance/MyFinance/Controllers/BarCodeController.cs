using Microsoft.AspNetCore.Mvc;

namespace MyFinance.Controllers
{
    public class BarCodeController : Controller
    {
            public IActionResult Index() { return View(); }

            [HttpPost]
            public IActionResult GenerateBarCode(string valor)
            {
                ViewBag.valor = valor;
                return View();
            }

    }
}
