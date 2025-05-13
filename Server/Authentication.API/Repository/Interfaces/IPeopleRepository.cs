using Authentication.API.Models.Domain;

namespace Authentication.API.Repository.Interfaces
{
    public interface IPeopleRepository
    {
        Task<List<Person>> GetAllUsersAsync();
        Task<Person?> GetUserByIdAsync(Guid id);
        Task<Person?> GetUserByUsernameAsync(string username);
        Task<Person?> GetUserByEmailAsync(string email);
        Task CreateUserAsync(Person person);
        Task UpdateUserAsync(Person person);
        Task DeleteUserAsync(Guid id);
    }
}
