using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFinance.Domain.Entities
{
    public class TransactionEntity : BaseEntity
    {
        [Display(Name ="Conta")]
        public AccountEntity Account { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Data da transação")]
        public DateTime DateTransaction { get; set; }
        [NotMapped]
        public PaymentMethodEnum TypeTransfer { get; set; }

        [Display(Name = "Tipo de transferência")]
        public string TipoTransferencia { get; set; }

    }
}
