using Authentication.API.Data;
using Authentication.API.Models.Domain;
using Authentication.API.Repository.Interfaces;

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

        public Task DeleteUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetUserByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
