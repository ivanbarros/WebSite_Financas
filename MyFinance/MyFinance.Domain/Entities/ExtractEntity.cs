using MyFinance.Domain.Entities.BaseEntities;

namespace MyFinance.Domain.Entities
{
    public class ExtractEntity : BaseEntity
    {
        public AccountEntity Account { get; set; }
        //public AccountPlanEntity AccountPlan { get; set; }
        //public UserEntity User { get; set; }

        //public CalendarEventEntity Calendar { get; set; }


    }
}
