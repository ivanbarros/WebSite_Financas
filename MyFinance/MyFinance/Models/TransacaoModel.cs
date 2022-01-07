using Microsoft.AspNetCore.Http;
using MyFinance.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MyFinance.Models
{
    public class TransacaoModel
    {
        [Key]
        public int idTransacao { get; set; }

        [Display(Name = "Data da transação")]
        public string Data_Transacao { get; set; }

        [Display(Name = "Data Final")]
        public string DataFinal { get; set; } //utilizada somente no filtro de extrato

        [Required(ErrorMessage = "Informe o Tipo de conta")]
        [Display(Name = "Tipo de conta")]
        public string Tipo_Transacao { get; set; }

        [Required(ErrorMessage = "Informe o Valor")]
        [Display(Name = "Valor")]
        public double Valor_Transacao { get; set; }

        [Required(ErrorMessage = "Informe o historico")]
        [Display(Name = "historico")]
        public string Descricao_Transacao { get; set; }
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe a Conta")]
        [Display(Name = "Conta")]
        public int Conta_idConta { get; set; }

        [Display(Name = "Conta")]
        public string NomeConta { get; set; }

        [Required(ErrorMessage = "Informe o Plano de conta")]
        [Display(Name = "Plano de conta")]
        public int Plano_Contas_idPlano_Contas { get; set; }

        [Display(Name = "Plano de conta")]
        public string DescricaoPlanoConta { get; set; }

        //public IHttp Http { get; set; }

        //public TransacaoModel()
        //{

        //}

        ////Recebe o context para acesso as variaveis de sessão
        //public TransacaoModel(IHttp http)
        //{
        //    Http = http;
        //}

        internal void ExcluirConta(int id)
        {
            int idTransacao = id;
            string sql = $"delete from Finance_Project.Transacao where idTransacao = {idTransacao}";
            //DAL objDAL = new DAL();
            //objDAL.ExecutaComandoSql(sql);
        }

        public List<TransacaoModel> ListaTransacao()
        {
            List<TransacaoModel> lista = new List<TransacaoModel>();
            TransacaoModel item;
            #region Filtro
            string filtro = "";
            if ((Data_Transacao != null) && (DataFinal != null))
            {
                filtro += $" and t.Data_Transacao  >='{DateTime.Parse(Data_Transacao).ToString("yyyy/MM/dd")}' and t.Data_Transacao <= '{DateTime.Parse(DataFinal).ToString("yyyy/MM/dd")}'";
            }

            if (Tipo_Transacao != null)
            {
                if (Tipo_Transacao != "A")
                {
                    filtro += $" and t.Tipo_Transacao = '{Tipo_Transacao}'";
                }
            }



            if (Conta_idConta != 0)
            {
                filtro += $" and t.Conta_idConta = {Conta_idConta}";
            }
            #endregion Filtro
            //string id_usuario_logado = Http.HttpContext.Session.GetString("IdUsuarioLogado");
            //string sql = "SELECT t.idTransacao, t.Data_Transacao, t.Tipo_Transacao, t.Valor_Transacao, " +
            //    " t.Descricao_Transacao AS historico,t.Conta_idConta, c.NomeConta AS conta ,t.Plano_Contas_idPlano_Contas," +
            //    " p.Descricao AS plano_conta FROM Transacao AS t INNER JOIN Conta AS c ON t.Conta_idConta = c.idConta" +
            //    " INNER JOIN Plano_Contas AS p ON t.Plano_Contas_idPlano_Contas = p.idPlano_Contas" +
            //    $" where c.Usuario_idUsuario = {id_usuario_logado} {filtro} order by t.Data_Transacao desc; ";
            //DAL objDAL = new DAL();

            //DataTable dt = objDAL.RetDataTable(sql);

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    item = new TransacaoModel();
            //    item.idTransacao = int.Parse(dt.Rows[i]["idTransacao"].ToString());
            //    item.Data_Transacao = DateTime.Parse(dt.Rows[i]["Data_Transacao"].ToString()).ToString("dd/MM/yyyy");
            //    item.Tipo_Transacao = dt.Rows[i]["Tipo_Transacao"].ToString();
            //    item.Valor_Transacao = double.Parse(dt.Rows[i]["Valor_Transacao"].ToString());
            //    item.Descricao_Transacao = dt.Rows[i]["historico"].ToString();
            //    item.Conta_idConta = int.Parse(dt.Rows[i]["Conta_idConta"].ToString());
            //    item.NomeConta = dt.Rows[i]["conta"].ToString();
            //    item.Plano_Contas_idPlano_Contas = int.Parse(dt.Rows[i]["Plano_Contas_idPlano_Contas"].ToString());
            //    item.DescricaoPlanoConta = dt.Rows[i]["plano_conta"].ToString();
            //    lista.Add(item);
            //}
            return lista;
        }

        public void Insert()
        {
            ////string id_usuario_logado = Http.HttpContext.Session.GetString("IdUsuarioLogado");
            //string sql = "";
            //if (idTransacao == 0)
            //{
            //    sql = "insert into Transacao (Data_Transacao, " +
            //        "Tipo_Transacao, Valor_Transacao, Descricao_Transacao," +
            //        "UsuarioId, Conta_idConta,Plano_Contas_idPlano_Contas) values" +
            //           $"('{DateTime.Parse(Data_Transacao).ToString("yyyy/MM/dd")}'," +
            //           $"'{Tipo_Transacao}',{Valor_Transacao}, '{Descricao_Transacao}'" +
            //           $",{id_usuario_logado},{Conta_idConta},{Plano_Contas_idPlano_Contas})";
            //}
            //else
            //{
            //    sql = $"update  Finance_Project.Transacao set Data_Transacao = '{DateTime.Parse(Data_Transacao).ToString("yyyy/MM/dd")}'," +
            //         $"Tipo_Transacao = '{Tipo_Transacao}', Valor_Transacao = {Valor_Transacao}," +
            //         $" Descricao_Transacao = '{Descricao_Transacao}'," +
            //         $"Conta_idConta = {Conta_idConta}, " +
            //         $" Plano_Contas_idPlano_Contas = {Plano_Contas_idPlano_Contas} Where UsuarioId = {id_usuario_logado}  and idTransacao = {idTransacao};";



            //}
            //DAL objDAL = new DAL();
            //objDAL.ExecutaComandoSql(sql);
        }

        public TransacaoModel CarregarRegistro(int? id)
        {
            TransacaoModel item;
            //string id_usuario_logado = Http.HttpContext.Session.GetString("IdUsuarioLogado");
            //string sql = "SELECT t.idTransacao, t.Data_Transacao, t.Tipo_Transacao, t.Valor_Transacao, " +
            //    " t.Descricao_Transacao AS historico,t.Conta_idConta, c.NomeConta AS conta ,t.Plano_Contas_idPlano_Contas," +
            //    " p.Descricao AS plano_conta FROM Transacao AS t INNER JOIN Conta AS c ON t.Conta_idConta = c.idConta" +
            //    " INNER JOIN Plano_Contas AS p ON t.Plano_Contas_idPlano_Contas = p.idPlano_Contas" +
            //    $" where c.Usuario_idUsuario = {id_usuario_logado} and t.idTransacao = '{id}';";
            //DAL objDAL = new DAL();

            //DataTable dt = objDAL.RetDataTable(sql);

            item = new TransacaoModel();
            //item.idTransacao = int.Parse(dt.Rows[0]["idTransacao"].ToString());
            //item.Data_Transacao = DateTime.Parse(dt.Rows[0]["Data_Transacao"].ToString()).ToString("dd/MM/yyyy");
            //item.Tipo_Transacao = dt.Rows[0]["Tipo_Transacao"].ToString();
            //item.Valor_Transacao = double.Parse(dt.Rows[0]["Valor_Transacao"].ToString());
            //item.Descricao_Transacao = dt.Rows[0]["historico"].ToString();
            //item.Conta_idConta = int.Parse(dt.Rows[0]["Conta_idConta"].ToString());
            //item.NomeConta = dt.Rows[0]["conta"].ToString();
            //item.Plano_Contas_idPlano_Contas = int.Parse(dt.Rows[0]["Plano_Contas_idPlano_Contas"].ToString());
            //item.DescricaoPlanoConta = dt.Rows[0]["plano_conta"].ToString();

            return item;
        }

    }

    public class Dashboard
    {
        public double Total { get; set; }
        public string PlanoConta { get; set; }
        //public IHttp Http { get; set; }
        
        //public Dashboard()
        //{

        //}
        //public Dashboard(IHttp http)
        //{
        //    Http = http;
        //}

        public List<Dashboard> RetornaGrafico()
        {
            
            List<Dashboard> lista = new List<Dashboard>();
            Dashboard item;
            //string id_usuario_logado = Http.HttpContext.Session.GetString("IdUsuarioLogado");
            //string sql = " select SUM(t.Valor_Transacao) AS total, p.Descricao  from Transacao AS t" +
            //" INNER JOIN Plano_Contas AS p ON" +
            //$" t.Plano_Contas_idPlano_Contas = p.idPlano_Contas where t.UsuarioId = {id_usuario_logado} " +
            //" GROUP BY p.Descricao; ";
            //DAL objDAL = new DAL();
            //DataTable dt = new DataTable();
            //dt = objDAL.RetDataTable(sql);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    item = new Dashboard();
            //    item.Total = double.Parse(dt.Rows[i]["Total"].ToString());
            //    item.PlanoConta = dt.Rows[i]["Descricao"].ToString();
            //    lista.Add(item);
            //}
            return lista;
        }

        public List<Dashboard> RetornaGraficoReceita()
        {
            List<Dashboard> lista = new List<Dashboard>();
            Dashboard item;
            string sql = " select SUM(t.Valor_Transacao) AS total, p.Descricao  from Transacao AS t" +
            " INNER JOIN Plano_Contas AS p ON" +
            " t.Plano_Contas_idPlano_Contas = p.idPlano_Contas " +
            " GROUP BY p.Descricao; ";
            //DAL objDAL = new DAL();
            //DataTable dt = new DataTable();
            //dt = objDAL.RetDataTable(sql);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    item = new Dashboard();
            //    item.Total = double.Parse(dt.Rows[i]["Total"].ToString());
            //    item.PlanoConta = dt.Rows[i]["Descricao"].ToString();
            //    lista.Add(item);
            //}
            return lista;
        }

    }
   

    
}
