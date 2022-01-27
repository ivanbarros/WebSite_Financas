using Microsoft.AspNetCore.Mvc;
using MyFinance.Interfaces.Services;

namespace MyFinance.Controllers
{
    public class ExtractController : Controller
    {
        private readonly IExtractServiceApplication _serviceApplication;

        public ExtractController(IExtractServiceApplication serviceApplication)
        {
            _serviceApplication = serviceApplication;
        }
    }
}
