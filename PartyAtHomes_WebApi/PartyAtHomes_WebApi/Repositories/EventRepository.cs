using Microsoft.EntityFrameworkCore;
using PartyAtHomes_Lib;
using PartyAtHomes_WebApi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyAtHomes_WebApi.Repositories
{
    public class EventRepository
    {
        private readonly PartyAtHomesContext _context;
        public EventRepository(PartyAtHomesContext context)
        {
            _context = context;
        }
        public async Task<List<Event>> GetAll()
        {
            return await _context.Event.ToListAsync();
        }

        public async Task<Event> GetById(Guid id)
        {
            return await _context.Event.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> Create(Event even, User user)
        {
            try
            {
                even.CreatorId = user.Id;
                await _context.AddAsync(even);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Event> Update(Event even, User user)
        {
            if(even != await _context.Event.FirstOrDefaultAsync(x => x.Id == even.Id))
            {
                _context.Event.Update(even);
                await _context.SaveChangesAsync();
            }

            return await GetById(even.Id);
        }
    }
}
