using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MyFinance.Models
{
    public class PlanoContaModel
    {
        [Key]
        public int idPlano_Contas { get; set; }

        [Required(ErrorMessage ="Informe a descrição")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Informe o Tipo de conta")]
        [Display(Name = "Tipo de conta")]
        public string Tipo { get; set; }
        public string[] Tipos = new[] { "Despesa", "Receita", "Outros" };
        public int Usuario_id { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public PlanoContaModel()
        {

        }

        //Recebe o context para acesso as variaveis de sessão
        public PlanoContaModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        internal void Insert()
        {
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"insert into Plano_Contas (Descricao, Tipo, Usuario_id, isActive) values ('{Descricao}','{Tipo}','{id_usuario_logado}', 1)";
            DAL objDAL = new DAL();
            objDAL.ExecutaComandoSql(sql);
        }

        public void ExcluirConta(int id)
        {

            int id_Conta = id;
            string sql = $"update Plano_Contas set isActive = 0 where idPlano_Contas = {id}";
            DAL objDAL = new DAL();
            objDAL.ExecutaComandoSql(sql);
        }

        public List<PlanoContaModel> ListaPlanoContas()
        {
            List<PlanoContaModel> lista = new List<PlanoContaModel>();
            PlanoContaModel item;
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"select idPlano_Contas, Descricao, Tipo, Usuario_id from Plano_Contas Where Usuario_id = {id_usuario_logado} and isActive = 1";
            DAL objDAL = new DAL();

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new PlanoContaModel();
                item.idPlano_Contas = int.Parse(dt.Rows[i]["idPlano_Contas"].ToString());
                item.Descricao = dt.Rows[i]["Descricao"].ToString();
                item.Tipo = dt.Rows[i]["Tipo"].ToString();
                item.Usuario_id = int.Parse(dt.Rows[i]["Usuario_id"].ToString());
                lista.Add(item);
            }
            return lista;
        }
    }
}
