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
        public IActionResult Login( int? id)
        {
            if (id != null)
            {
                if (id == 0)
                {
                    HttpContext.Session.SetString("IdUsuarioLogado",string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty);
                }
            }
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
                return RedirectToAction("Menu", "Menu");
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

        [HttpPost]
        
        public IActionResult Registrar(UsuarioModel usuario)
        {
            
            if (ModelState.IsValid)
            {
                usuario.RegistrarUsuario();
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