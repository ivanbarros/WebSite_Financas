using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class CalendarEventService : ICalendarEventService
    {
        private readonly ICalendarEventRepository _repository;

        public CalendarEventService(ICalendarEventRepository repository)
        {
            _repository = repository;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public CalendarEventEntity Get(int id)
        {
            var result = _repository.Get(id);
            return result;
        }

        public async Task<IEnumerable<CalendarEventEntity>> GetAll(string start, string end, int id)
        {
           var result =  await _repository.GetAll(start,end, id);
            return result;
        }

        public Task<IEnumerable<CalendarEventEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(CalendarEventEntity item)
        {
            throw new NotImplementedException();
        }

        public async Task<CalendarEventEntity> Update(CalendarEventEntity item)
        {
            var result = await _repository.Update(item);
            return result;
        }
    }
}
