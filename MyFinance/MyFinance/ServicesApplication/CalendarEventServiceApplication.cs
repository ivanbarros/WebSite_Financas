using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services.InterfaceBase;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class CalendarEventServiceApplication : ICalendarEventServiceApplication
    {
        private readonly ICalendarEventService _service;

        public CalendarEventServiceApplication(ICalendarEventService service)
        {
            _service = service;
        }

        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public async Task<CalendarEventEntity> Get(int id)
        {
            var result = await _service.Get(id);
            return result;
        }

        public Task<IEnumerable<CalendarEventEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CalendarEventEntity>> GetAll(string start, string end, int id)
        {
            var result = await _service.GetAll(start, end, id);
            return result;
        }

        public void Insert(CalendarEventEntity item)
        {
            _service.Insert(item);
        }

        public async Task<CalendarEventEntity> Update(CalendarEventEntity entity)
        {
            var result = await _service.Update(entity);
            return result;
        }
    }
}
