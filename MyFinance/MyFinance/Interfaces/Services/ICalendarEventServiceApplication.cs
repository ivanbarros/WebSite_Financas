using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Interfaces.Services.InterfaceBase
{
    public interface ICalendarEventServiceApplication : IServiceApplicationBase<CalendarEventEntity>
    {
        Task<IEnumerable<CalendarEventEntity>> GetAll(string start, string end, int id);
    }
}
