using Authentication.API.Data;
using Authentication.API.Models.Domain;
using Authentication.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Authentication.API.Repository.Implementations
{
    public class PeopleRepository(AuthenticationDbContext context) : IPeopleRepository
    {
        private readonly AuthenticationDbContext _context = context;

        public async Task CreateUserAsync(Person person)
        {
            await _context.People.AddAsync(person);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(Guid id)
        {
            var user = await _context.People.FirstOrDefaultAsync(x => x.Id == id);
            if (user is not null)
            {
                _context.People.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Person>> GetAllUsersAsync()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<Person?> GetUserByIdAsync(Guid id)
        {
            return await _context.People.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateUserAsync(Person person)
        {
            _context.People.Update(person);
            await _context.SaveChangesAsync();
        }
    }
}
