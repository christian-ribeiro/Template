﻿using AutoMapper;

namespace Template.Arguments.AutoMapper;

public class MapperGeneric<TInput, TOutput> : Profile
{
    public MapperGeneric()
    {
        CreateMap<TInput, TOutput>().ReverseMap();
    }
}