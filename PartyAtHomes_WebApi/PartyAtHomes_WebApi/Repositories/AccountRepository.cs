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

        public async Task<User> GetById(Guid id)
        {
            return await _context.User.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid?> Login(LoginDto login)
        {
            var c = await _context.User.FirstOrDefaultAsync(x => x.Password == login.Password && x.UserName == login.UserName);
            return c?.Id;
        }

        public async Task<User> Register(RegisterDto register)
        {
            if (await _context.User.AnyAsync(x => x.UserName == register.UserName) && register.UserName != null && register.Password != null)
                return null;

            var newUser = new User
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                UserName = register.UserName,
                Password = register.Password
            };

            await _context.User.AddAsync(newUser);
            await _context.SaveChangesAsync();

            return await _context.User.FirstOrDefaultAsync(x => x.Id == newUser.Id);
        }
    }
}
