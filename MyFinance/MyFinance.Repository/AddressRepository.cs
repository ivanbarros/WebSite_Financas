﻿using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class AddressRepository : IAddressRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<AddressEntity> _dataset;

        public AddressRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<AddressEntity>();
        }
        public Task<AddressEntity> Add(AddressEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<AddressEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public AddressEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AddressEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AddressEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<AddressEntity> Update(AddressEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
