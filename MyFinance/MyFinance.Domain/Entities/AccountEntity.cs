using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Domain.Entities
{
    public class AccountEntity : BaseEntity
    {
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public UserEntity User { get; set; }

        
    }
}
