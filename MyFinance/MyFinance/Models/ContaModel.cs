using Microsoft.AspNetCore.Http;
using MyFinance.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Models
{
    public class ContaModel
    {
        [Key]
        [Display(Name = "ID")]
        public int idConta { get; set; }

        [Display(Name="Conta")]
        public string NomeConta { get; set; }

        [Display(Name = "Saldo")]
        public double Saldo { get; set; }

        [Display(Name = "Usuario")]
        public int Usuario_idUsuario { get; set; }
        IHttpContextAccessor HttpContextAccessor;

        public ContaModel()
        {

        }
        //Recebe o context para acesso as variaveis de sessão
        public ContaModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public List<ContaModel> ListaConta()
        {
            List<ContaModel> lista = new List<ContaModel>();
            ContaModel item;
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"select idConta, NomeConta, Saldo, Usuario_idUsuario from Conta Where Usuario_idUsuario = {id_usuario_logado}";

            DAL objDAL = new DAL();

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ContaModel();
                item.idConta = int.Parse(dt.Rows[i]["idConta"].ToString());
                item.NomeConta = dt.Rows[i]["NomeConta"].ToString();
                item.Saldo =  double.Parse(dt.Rows[i]["Saldo"].ToString());
                item.idConta = int.Parse(dt.Rows[i]["Usuario_idUsuario"].ToString());
                lista.Add(item);
            }
            return lista;
        }
    }
}
