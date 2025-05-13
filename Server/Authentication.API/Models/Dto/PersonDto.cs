using Authentication.API.Models.Domain;

namespace Authentication.API.Models.Dto
{
    public class PersonDto
    {
        public Guid Id { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public int RoleId { get; set; }
    }
}
