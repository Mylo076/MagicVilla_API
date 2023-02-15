using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> RegistrationAsync<T>(RegistrationRequestDTO objToCreate);
        Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
    }
}
