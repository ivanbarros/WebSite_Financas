using MyFinance.Domain.Entities.BaseEntities;
using System;

namespace MyFinance.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool IsActive { get; set; }
        public string NomeUsuario { get; set; }


    }
}
