using Authentication.API.Models.Domain;
using Authentication.API.Models.Dto;
using Authentication.API.Repository.Implementations;
using Authentication.API.Repository.Interfaces;
using Authentication.API.Services.Interfaces;

namespace Authentication.API.Services.Implementation
{
    public class AuthService(IPeopleRepository peopleRepository) : IAuthService
    {
        private readonly IPeopleRepository _peopleRepository = peopleRepository;

        public async Task<Person?> LoginAsync(PersonDto person)
        {
            var duplicateEmail = await _peopleRepository.GetUserByEmailAsync(person.Email);
            
            if(duplicateEmail is null)
            {
                return null;
            }

            var duplicateUsername = await _peopleRepository.GetUserByUsernameAsync(person.Username);

            if (duplicateUsername is null)
            {
                return null;
            }

            await _peopleRepository.CreateUserAsync(person);
        }

        public Task<Person?> RegisterAsync(PersonDto person)
        {
            throw new NotImplementedException();
        }
    }
}
