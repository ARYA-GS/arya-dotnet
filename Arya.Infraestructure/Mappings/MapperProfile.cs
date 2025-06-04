using AutoMapper;
using Arya.Contracts.Dtos.Requests;
using Arya.Contracts.Dtos.Responses;
using Arya.Domain.Entities;

namespace Arya.Infraestructure.Mappings;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<User, UserRequestDto>().ReverseMap();
        CreateMap<User, UserResponseDto>().ReverseMap();

        CreateMap<ClimaticEvent, ClimaticEventRequestDto>().ReverseMap();
        CreateMap<ClimaticEvent, ClimaticEventResponseDto>().ReverseMap();

        CreateMap<SafeResource, SafeResourceRequestDto>().ReverseMap();
        CreateMap<SafeResource, SafeResourceResponseDto>().ReverseMap();
    }
}
