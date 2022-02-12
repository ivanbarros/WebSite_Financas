using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface ICalendarEventRepository : IRepositoryBase<CalendarEventEntity,SqlContext>
    {
        Task<IEnumerable<CalendarEventEntity>> GetAll(string start, string end, int id);
    }
}
