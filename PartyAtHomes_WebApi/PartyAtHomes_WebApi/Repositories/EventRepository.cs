using Microsoft.EntityFrameworkCore;
using PartyAtHomes_Lib;
using PartyAtHomes_WebApi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace PartyAtHomes_WebApi.Repositories
{
    public class EventRepository
    {
        private readonly PartyAtHomesContext _context;
        private readonly IMapper _mapper;
        public EventRepository(PartyAtHomesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<EventDto>> GetAllDto()
        {
            return await _context.Event.ProjectTo<EventDto>(_mapper.ConfigurationProvider).AsNoTracking().ToListAsync();
        }

        public async Task<Event> GetById(long id)
        {
            return await _context.Event.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> Create(EventCRUDDto eventToCreate)
        {
            try
            {
                eventToCreate.MainImage = "paris.jpg";
                //validate event
                await _context.AddAsync(eventToCreate);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Event> Update(Event eventToUpdate)
        {
            if(eventToUpdate != await _context.Event.FirstOrDefaultAsync(x => x.Id == eventToUpdate.Id))
            {
                //validate event
                _context.Event.Update(eventToUpdate);
                await _context.SaveChangesAsync();
            }

            return await GetById(eventToUpdate.Id);
        }

        public async Task<List<EventDto>> GetEventsByUser(Guid id)
        {
            return await _context.Event.Where(x => x.CreatorId == id).ProjectTo<EventDto>(_mapper.ConfigurationProvider).AsNoTracking().ToListAsync();
        }
    }
}
