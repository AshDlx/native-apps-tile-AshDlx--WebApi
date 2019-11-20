using Microsoft.EntityFrameworkCore;
using PartyAtHomes_Lib;
using PartyAtHomes_WebApi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyAtHomes_WebApi.Repositories
{
    public class AccountRepository
    {
        private PartyAtHomesContext _context;
        public AccountRepository(PartyAtHomesContext context)
        {
            _context = context;
        }

        //public async Task<User> GetById(Guid id)
        //{
        //    return await _context.User.FirstOrDefaultAsync(x => x.Id == id);
        //}

        //public async Task<Guid> Login(User user)
        //{
            
        //}

        //public async Task<User> Register(User user)
        //{

        //}
    }
}
