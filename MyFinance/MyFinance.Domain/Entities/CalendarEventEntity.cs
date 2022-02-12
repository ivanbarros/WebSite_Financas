using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    [Table("CalendarEvent")]
    public class CalendarEventEntity : BaseEntity
    {
       [Column("Start")]
        public DateTime Start { get; set; }
        
        [Column("End")]
        public DateTime End { get; set; }
        [Column("Text")]
        public string? Text { get; set; }
        
        [Column("Color")]
        public string? Color { get; set; }
        [Column("IdUser")]
        public int IdUser { get; set; }
    }
}
