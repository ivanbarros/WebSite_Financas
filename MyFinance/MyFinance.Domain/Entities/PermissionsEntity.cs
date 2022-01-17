using MyFinance.Domain.Entities.BaseEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    [Table("Permission")]
    public class PermissionsEntity : BaseEntity
    {
        [Column("Name")]
        public string Name { get; set; }
        public ICollection<UserEntity> user { get; set; }
    }
}
