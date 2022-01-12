using MyFinance.Domain.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    [Table("User")]
    public class UserEntity : BaseEntity
    {
        [Column("UserName")]
        public string UserName { get; set; }

        [Column("Login")]
        public string Login { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("PassWord")]
        public string PassWord { get; set; }

        [Column("IsActive")]
        public bool IsActive { get; set; }


    }
}
