using Microsoft.AspNetCore.Http;
using MyFinance.Utils;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MyFinance.Models
{
    public class ContaModel
    {
        [Key]
        [Display(Name = "ID")]
        public int idConta { get; set; }

        [Required(ErrorMessage = "Informe o nome da conta")]
        [Display(Name="Conta")]
        public string NomeConta { get; set; }

        [Required(ErrorMessage = "Informe o saldo")]
        [Display(Name = "Saldo")]
        public double Saldo { get; set; }

       
        [Display(Name = "Usuario")]
        public int Usuario_idUsuario { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

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
            string sql = $"select idConta, NomeConta, Saldo, Usuario_idUsuario from Conta Where Usuario_idUsuario = {id_usuario_logado} and isActive = 1";

            DAL objDAL = new DAL();

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ContaModel();
                item.idConta = int.Parse(dt.Rows[i]["idConta"].ToString());
                item.NomeConta = dt.Rows[i]["NomeConta"].ToString();
                item.Saldo =  double.Parse(dt.Rows[i]["Saldo"].ToString());
                item.Usuario_idUsuario = int.Parse(dt.Rows[i]["Usuario_idUsuario"].ToString());
                lista.Add(item);
            }
            return lista;
        }

        public void Insert()
        {
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"insert into Conta (NomeConta,Saldo,Usuario_idUsuario, isActive) values ('{NomeConta}','{Saldo}','{id_usuario_logado}', 1)";
            DAL objDAL = new DAL();
            objDAL.ExecutaComandoSql(sql);
        }

        public void ExcluirConta(int id)
        {
            
            int id_Conta = id;
            string sql = $"update Finance_Project.Conta set isActive = 0 where idConta = {id}";
            DAL objDAL = new DAL();
            objDAL.ExecutaComandoSql(sql);
        }
    }
}
