using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Interfaces.Services.InterfaceBase
{
    public interface ICategoryEnumServiceApplication : IServiceApplicationBase<CategoryEnumEntity>
    {
        Task<IEnumerable<CalendarEventEntity>> GetAll(DateTime start, DateTime end);
    }
}
