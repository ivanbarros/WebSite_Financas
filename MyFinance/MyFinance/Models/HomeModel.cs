using MyFinance.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Models
{
    public class HomeModel
    {
        public string LerNomeUsuario()
        {
            //DAL objDal = new DAL();
            //DataTable dt = objDal.RetDataTable("select * from Usuario");
            //if (dt!=null)
            //{
            //    if (dt.Rows.Count > 0)
            //    {
            //        return dt.Rows[0]["NomeUsuario"].ToString();
            //    }
            //}
            return "Não encontrado!";
        }

        //public string GetEmail(string email, string senha)
        //{
        //    DAL objDal = new DAL();
        //    DataTable dt = objDal.RetDataTable($"select * from Usuario where Email = '{email}' and Senha = '{senha}'");
        //    if (dt != null)
        //    {
        //        if (dt.Rows.Count > 0)
        //        {
        //            return dt.Rows[0]["NomeUsuario"].ToString();
        //        }
        //    }
        //    return "Não encontrado!";
        //}
    }
}
