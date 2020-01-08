using System;
using Xunit;
using MyFinance.Models;

namespace ProjetoFinanceTeste
{
    public class UniteTestModels
    {
        [Fact]
        public void TestUsuarioLogin()
        {
            UsuarioModel usuario = new UsuarioModel();
            usuario.Email = "ivansilvabarros@gmail.com";
            usuario.Senha = "12345";
            Assert.True(usuario.ValidarLogin());

        }
        [Fact]
        public void TesteUsuarioRegistro() 
        {
            UsuarioModel usuario = new UsuarioModel();
            usuario.NomeUsuario = "Usuario";
            usuario.Email = "usuario@gmail.com";
            usuario.Senha = "12345";
            usuario.Dt_nasc = "1985/03/30";
            usuario.RegistrarUsuario();
            Assert.True(usuario.ValidarLogin());
        }
    }
}
