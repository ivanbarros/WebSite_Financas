using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Models
{
    public class TransacaoModel
    {
        [Key]

        public int idTransacao { get; set; }

        [Required(ErrorMessage = "Informe a data")]
        [Display(Name = "Data")]
        public string Data_Transacao { get; set; }

        [Required(ErrorMessage = "Informe o Tipo de conta")]
        [Display(Name = "Tipo de conta")]
        public string Tipo_Transacao { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Informe o valor")]
        [Display(Name = "Valor")]
        public double Valor_Transacao { get; set; }

        [Required(ErrorMessage = "Informe a descrição")]
        [Display(Name = "Descrição")]
        public string Descricao_Transacao { get; set; }
        public int Conta_idConta { get; set; }
        public int UsuarioId { get; set; }

        public int Plano_Contas_idPlano_Contas { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public TransacaoModel()
        {

        }

        //Recebe o context para acesso as variaveis de sessão
        public TransacaoModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        internal void Insert()
        {
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = "";
            if (idTransacao == 0)
            {
                if (Data_Transacao == null)
                {
                    sql = $"insert into Transacao (Data_Transacao, Tipo_Transacao, Valor_Transacao, Descricao_Transacao, Conta_idConta,Plano_Contas_idPlano_Contas) values(CURDATE(), {Tipo_Transacao}, {Valor_Transacao}, '{Descricao_Transacao}',{Conta_idConta} , {Plano_Contas_idPlano_Contas}) ";
                }
            }
            if(Data_Transacao != null)

            { sql = $"insert into Transacao (Data_Transacao, Tipo_Transacao, Valor_Transacao, Descricao_Transacao, Conta_idConta,Plano_Contas_idPlano_Contas) values({Data_Transacao}, {Tipo_Transacao}, {Valor_Transacao}, '{Descricao_Transacao}',{Conta_idConta} , {Plano_Contas_idPlano_Contas}) "; }
             
            if(idTransacao != 0)
            {
                sql = $"Update  Finance_Project.Transacao  set Data_Transacao ='{Data_Transacao}', Tipo_Transacao = '{Tipo_Transacao}', Valor_Transacao = {Valor_Transacao}, Descricao_Transacao = '{Descricao_Transacao}',Conta_idConta = '{Conta_idConta}' , Plano_Contas_idPlano_Contas= '{Plano_Contas_idPlano_Contas}' WHERE Usuario_id = {id_usuario_logado} AND idTransacao = {idTransacao}";
            }
            DAL objDAL = new DAL();
            objDAL.ExecutaComandoSql(sql);
        }

        public TransacaoModel CarregarRegistro(int? id)
        {
            TransacaoModel item = new TransacaoModel();
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"select idPlano_Contas, Descricao, Tipo, Usuario_id from Plano_Contas Where Usuario_id = {id_usuario_logado} and isActive = 1 and idPlano_Contas = {id}";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            item.Conta_idConta = int.Parse(dt.Rows[0]["Conta_idConta"].ToString());
            item.Plano_Contas_idPlano_Contas = int.Parse(dt.Rows[0]["Plano_Contas_idPlano_Contas"].ToString());
            item.Descricao_Transacao = dt.Rows[0]["Descricao_Transacao"].ToString();
            item.Tipo_Transacao = dt.Rows[0]["Tipo_Transacao"].ToString();
            item.UsuarioId = int.Parse(dt.Rows[0]["UsuarioId"].ToString());

            return item;
        }

        public void ExcluirConta(int id)
        {

            int id_Conta = id;
            string sql = $"delete from Finance_Project.Plano_Contas where idPlano_Contas = {id}";
            DAL objDAL = new DAL();
            objDAL.ExecutaComandoSql(sql);
        }

        public List<TransacaoModel> ListaPlanoContas()
        {
            List<TransacaoModel> lista = new List<TransacaoModel>();
            TransacaoModel item = new TransacaoModel();
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"select idPlano_Contas, Descricao, Tipo, Usuario_id from Plano_Contas Where Usuario_id = {id_usuario_logado} and isActive = 1";
            DAL objDAL = new DAL();

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item.Conta_idConta = int.Parse(dt.Rows[0]["Conta_idConta"].ToString());
                item.Plano_Contas_idPlano_Contas = int.Parse(dt.Rows[0]["Plano_Contas_idPlano_Contas"].ToString());
                item.Descricao_Transacao = dt.Rows[0]["Descricao_Transacao"].ToString();
                item.Tipo_Transacao = dt.Rows[0]["Tipo_Transacao"].ToString();
                item.UsuarioId = int.Parse(dt.Rows[0]["UsuarioId"].ToString()); ;
                lista.Add(item);
            }
            return lista;
        }
    }
}
