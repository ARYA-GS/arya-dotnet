﻿using Arya.Contracts.Dtos.Requests;
using Arya.Contracts.Dtos.Responses;

namespace Arya.Application.Services.Interfaces;

public interface IUserService
{
    Task<UserResponseDto> AddUserAsync(UserRequestDto requestDto);
    Task<bool> DeleteUserByCpfAsync(string cpf);
    Task<IEnumerable<UserResponseDto>> GetAllUsersAsync();
    Task<UserResponseDto?> GetUserByCpfAsync(string cpf);
    Task<UserResponseDto?> UpdateUserByCpfAsync(string cpf, UserRequestDto requestDto);
}