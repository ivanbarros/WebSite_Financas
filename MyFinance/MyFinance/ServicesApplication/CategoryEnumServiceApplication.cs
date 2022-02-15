using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class CategoryEnumServiceApplication : ICategoryEnumServiceApplication
    {
        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public CategoryEnumEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<CategoryEnumEntity>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<CalendarEventEntity>> GetAll(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public void Insert(CategoryEnumEntity item)
        {
            throw new System.NotImplementedException();
        }

        public Task<CategoryEnumEntity> Update(CategoryEnumEntity entity)
        {
            throw new System.NotImplementedException();
        }

       
    }
}
