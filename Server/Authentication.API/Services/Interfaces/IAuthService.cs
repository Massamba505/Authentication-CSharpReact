using Authentication.API.Models.Domain;
using Authentication.API.Models.Dto;

namespace Authentication.API.Services.Interfaces;

public interface IAuthService
{
    Task<Person?> RegisterAsync(PersonDto person);
    Task<Person?> LoginAsync(PersonDto person);
}
