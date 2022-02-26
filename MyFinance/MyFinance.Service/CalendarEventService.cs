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
            _repository.Delete(id);
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
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(CalendarEventEntity item)
        {
            _repository.Add(item);
        }

        public async Task<CalendarEventEntity> Update(CalendarEventEntity item)
        {
            var result = await _repository.Update(item);
            return result;
        }
    }
}
