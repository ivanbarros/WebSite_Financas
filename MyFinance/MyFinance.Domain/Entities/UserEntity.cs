using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Domain.Entities
{
    public class UserEntity
    {
        public DateTime CreateDate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


    }
}
