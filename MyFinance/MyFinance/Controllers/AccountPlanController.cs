using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MyFinance.Interfaces.Services;

namespace MyFinance.Controllers
{
    public class AccountPlanController : Controller
    {
        private readonly IAccountPlanServiceApplication _service;
        IHttpContextAccessor _httpContextAccessor;
    }
}
