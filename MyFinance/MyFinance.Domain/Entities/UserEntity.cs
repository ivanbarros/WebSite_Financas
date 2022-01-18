using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    [Table("User")]
    public class UserEntity : BaseEntity
    {
        [Column("UserName")]
        [Display(Name ="Nome Completo")]
        public string UserName { get; set; }

        [Column("Login")]
        public string Login { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("PassWord")]
        public string PassWord { get; set; }

        [Column("IdPermission")]
        public int IdPermission { get; set; }

        [NotMapped]
        public string TipoPermissao { get; set; }

        [NotMapped]
        public PermissionEnum PermissionType { get; set; }

        [Column("IsActive")]
        public bool IsActive { get; set; }

        [Column("IdPermission")]
        public int IdPermission { get; set; }
        public virtual PermissionsEntity Permission { get; set; }

        public ICollection<EmployeeEntity> Employee { get; set; }

    }
}
