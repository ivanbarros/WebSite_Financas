using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service.Interfaces.Services
{
    public interface ICalendarEventService : IServiceBase<CalendarEventEntity>
    {
        Task<IEnumerable<CalendarEventEntity>> GetAll(string start, string end, int id);
    }
}
