using MyFinance.Domain.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    [Table("Permission")]
    public class PermissionEntity : BaseEntity
    {
        private string name;

        [Column("Name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool isActive;

        [Column("IsActive")]
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }


    }
}
