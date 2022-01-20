using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using Newtonsoft.Json;

namespace MyFinance.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUserServiceApplication _serviceApplication;

        public UsuarioController(IUserServiceApplication servuceApplication)
        {
            _serviceApplication = servuceApplication;
        }

        [HttpGet]
        public IActionResult Login( int? id)
        {
            if (id != null)
            {
                if (id == 0)
                {
                    HttpContext.Session.SetString("IdUsuarioLogado",string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty);
                    HttpContext.Session.SetString("EmailUsuarioLogado", string.Empty);
                    
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult ValidarLogin(UserEntity usuario)
        {
            var login = _serviceApplication.ValidarLogin(usuario);
            if (login.UserName!=null)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.UserName);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.IdPermission.ToString());
                HttpContext.Session.SetString("EmailUsuarioLogado", usuario.Email.ToString());
                HttpContext.Session.SetString("IdPermission", usuario.IdPermission.ToString());
                var userInfo = new UserEntity()
                {
                    UserName = usuario.UserName,
                    Email = usuario.Email,
                    IdPermission = usuario.IdPermission,
                    IsActive = usuario.IsActive,
                    Login = usuario.Login,
                    PassWord = usuario.PassWord,
                    CreateDate = usuario.CreateDate,
                    TipoPermissao = usuario.PermissionType.ToString()
                    
                };
                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(userInfo));
                return RedirectToAction("_PartialMenu", "Menu");
            }
            else
            {
             
                TempData["LoginIvalido"] = "Usuario ou senha não estão corretos!";                
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        
        public IActionResult Registrar(UserEntity usuario)
        {
            
            if (ModelState.IsValid)
            {
                usuario.PermissionType.ToString();
                usuario.TipoPermissao = usuario.PermissionType.ToString();
                _serviceApplication.Insert(usuario);                
                return RedirectToAction("Sucesso");
                
            }
            return View();
        }
        [HttpGet]
        public IActionResult Registrar() { return View(); }

        [HttpGet]
        public IActionResult Sucesso() { return View(); }
    }
}