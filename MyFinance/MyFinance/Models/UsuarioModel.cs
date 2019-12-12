using MyFinance.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Models
{
    public class UsuarioModel
    {
        [Key]
        public int idUsuario { get; set; }
        [Display(Name ="Nome")]
        public string NomeUsuario { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime Dt_nasc { get; set; }

        public bool ValidarLogin()
        {
            DAL objDal = new DAL();
            string sql = $"select idUsuario, NomeUsuario, Email, Senha, DT_Nasc from Usuario where Email = '{Email}' and Senha = '{Senha}'";
            DataTable dt = objDal.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    idUsuario = int.Parse(dt.Rows[0]["idUsuario"].ToString());
                    NomeUsuario = dt.Rows[0]["NomeUsuario"].ToString();
                    Dt_nasc = DateTime.Parse(dt.Rows[0]["Dt_nasc"].ToString());
                    return true;
                }
            }
            return false;
        }
    }
   
}
