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

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo nome obrigatório")]
        [Display(Name ="Nome")]
        public string NomeUsuario { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo E-mail obrigatório")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Campo E-mail está num formato inválido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Senha obrigatório")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo data obrigatório")]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public string Dt_nasc { get; set; }

        public bool ValidarLogin()
        {
            //DAL objDal = new DAL();
            //string sql = $"select idUsuario, NomeUsuario, Email, Senha, DT_Nasc from Usuario where Email = '{Email}' and Senha = '{Senha}'";
            //DataTable dt = objDal.RetDataTable(sql);
            //if (dt != null)
            //{
            //    if (dt.Rows.Count == 1)
            //    {
            //        idUsuario = int.Parse(dt.Rows[0]["idUsuario"].ToString());
            //        NomeUsuario = dt.Rows[0]["NomeUsuario"].ToString();
            //        Email = dt.Rows[0]["Email"].ToString();
            //        Dt_nasc = dt.Rows[0]["Dt_nasc"].ToString();
            //        return true;
            //    }
            //}
            return false;
        }
        public void RegistrarUsuario()
        {
            //string datanasc = DateTime.Parse(Dt_nasc).ToString("yyyy/MM/dd");
            string sql = $"Insert into Usuario(NomeUsuario,Email,Senha, Dt_Nasc) VALUES ('{NomeUsuario}', '{Email}','{Senha}', '{Dt_nasc}')";
            //DAL obj = new DAL();
            //obj.ExecutaComandoSql(sql);
        }
    }
   
}
