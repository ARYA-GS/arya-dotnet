using Arya.Contracts.Dtos.Requests;
using Arya.Contracts.Dtos.Responses;

namespace Arya.Infraestructure.Data.Repositories.Interfaces
{
    public interface IClimaticEventRepository
    {
        Task<ClimaticEventResponseDto> AddAsync(ClimaticEventRequestDto requestDto);
        Task<bool> DeleteByEventCodeAsync(string eventCode);
        Task<IEnumerable<ClimaticEventResponseDto>> GetAllAsync();
        Task<ClimaticEventResponseDto?> GetByEventCodeAsync(string eventCode);
        Task<ClimaticEventResponseDto?> UpdateByEventCodeAsync(string eventCode, ClimaticEventRequestDto requestDto);
    }
}