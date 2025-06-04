using Arya.Contracts.Dtos.Requests;
using Arya.Contracts.Dtos.Responses;

public interface IUserRepository
{
    Task<UserResponseDto> AddAsync(UserRequestDto requestDto);
    Task<bool> DeleteByCpfAsync(string cpf);
    Task<IEnumerable<UserResponseDto>> GetAllAsync();
    Task<UserResponseDto?> GetByCpfAsync(string cpf);
    Task<UserResponseDto?> UpdateByCpfAsync(string cpf, UserRequestDto requestDto);
}
