using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Login( int? idUsuario)
        {
            return View();
        }
        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.NomeUsuario);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.idUsuario.ToString());
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //if (usuario.Email != typeof(usuario.Email))
                //{

                //}
                TempData["LoginIvalido"] = "Usuario ou senha não estão corretos!";
                //TempData["CorrigirEmail"] = "Campo E-mail incorreto!";
                //TempData["CorrigirSenha"] = "Campo senha incorreto!";
                return RedirectToAction("Login");
            }
        }
    }
}