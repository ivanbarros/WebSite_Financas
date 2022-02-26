using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class CalendarEventRepository : ICalendarEventRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<CalendarEventEntity> _dataset;
        public CalendarEventRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<CalendarEventEntity>();
        }
        public Task<CalendarEventEntity> Add(CalendarEventEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<CalendarEventEntity> Delete(int id)
        {
            var calendarEvent = await _context.Events.FindAsync(id);
            _context.Events.Remove(calendarEvent);
            await _context.SaveChangesAsync();
            return calendarEvent;
        }

        public CalendarEventEntity Get(int id)
        {
            var result = _context.Events.Where(c => c.Id.Equals(id));
            var calendario = new CalendarEventEntity();
            foreach (var item in result)
            {
                calendario.Start = item.Start;
                calendario.End = item.End;
                calendario.Color = item.Color;
                calendario.Text = item.Text;
            }
            //var result =  await _context.Calendar.FindAsync(id);

            return calendario;
        }

        public Task<IEnumerable<CalendarEventEntity>> GetAll()
        {
            
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<CalendarEventEntity>> GetAll(string start, string end, int id)
        {
            return await _context.Events.Where(e => !((e.End.Equals(end) && e.IdUser.Equals(id)) || (e.Start.Equals(start) && e.IdUser.Equals(id))))
                .ToListAsync();
        }

        public IEnumerable<CalendarEventEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<CalendarEventEntity> Update(CalendarEventEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
