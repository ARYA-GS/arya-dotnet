﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Arya.Contracts.Dtos.Requests;
using Arya.Contracts.Dtos.Responses;
using Arya.Domain.Entities;
using Arya.Infraestructure.Data.AppData;
using Arya.Infraestructure.Data.Repositories.Interfaces;

namespace Arya.Infraestructure.Data.Repositories;

public class ClimaticEventRepository : IClimaticEventRepository
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;

    public ClimaticEventRepository(ApplicationContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ClimaticEventResponseDto> AddAsync(ClimaticEventRequestDto requestDto)
    {
        var eventEntity = _mapper.Map<ClimaticEvent>(requestDto);

        _context.Add(eventEntity);
        await _context.SaveChangesAsync();

        var responseDto = _mapper.Map<ClimaticEventResponseDto>(eventEntity);

        return responseDto;
    }

    public async Task<IEnumerable<ClimaticEventResponseDto>> GetAllAsync()
    {
        var events = await _context.Events.ToListAsync();
        var responseDtos = _mapper.Map<IEnumerable<ClimaticEventResponseDto>>(events);
        return responseDtos;
    }

    public async Task<ClimaticEventResponseDto?> GetByEventCodeAsync(string eventCode)
    {
        var eventEntity = await _context.Events.FirstOrDefaultAsync(e => e.EventCode == eventCode);
        if (eventEntity == null) return null;

        var responseDto = _mapper.Map<ClimaticEventResponseDto>(eventEntity);
        return responseDto;
    }

    public async Task<ClimaticEventResponseDto?> UpdateByEventCodeAsync(string eventCode, ClimaticEventRequestDto requestDto)
    {
        var eventEntity = await _context.Events.FirstOrDefaultAsync(e => e.EventCode == eventCode);
        if (eventEntity == null) return null;

        eventEntity.Type = requestDto.Type;
        eventEntity.Description = requestDto.Description;
        eventEntity.EventTime = requestDto.EventTime;
        eventEntity.Latitude = requestDto.Latitude;
        eventEntity.Longitude = requestDto.Longitude;
        eventEntity.RiskLevel = requestDto.RiskLevel;

        await _context.SaveChangesAsync();

        var responseDto = _mapper.Map<ClimaticEventResponseDto>(eventEntity);
        return responseDto;
    }

    public async Task<bool> DeleteByEventCodeAsync(string eventCode)
    {
        var eventEntity = await _context.Events.FirstOrDefaultAsync(e => e.EventCode == eventCode);
        if (eventEntity == null) return false;

        _context.Events.Remove(eventEntity);
        await _context.SaveChangesAsync();

        return true;
    }
}
