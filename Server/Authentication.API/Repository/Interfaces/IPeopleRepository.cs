using Authentication.API.Models.Domain;

namespace Authentication.API.Repository.Interfaces
{
    public interface IPeopleRepository
    {
        Task<List<Person>> GetAllUsersAsync();
        Task<Person?> GetUserByIdAsync(Guid id);
        Task CreateUserAsync(Person person);
        Task UpdateUserAsync(Person person);
        Task DeleteUserAsync(Guid id);
    }
}
