using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
	public interface IAuthService
	{
		Task<T> LoginAsync<T>(LoginRequestDTO objectToCreate);
		Task<T> RegisterAsync<T>(RegistrationRequestDTO objectToCreate);
	}
}
