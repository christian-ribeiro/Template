﻿using AutoMapper;
using Template.Arguments.AutoMapper;
using Template.Domain.Interface.Repository;
using Template.Domain.Interface.Service;
using Template.Domain.Service;
using Template.Infrastructure.Persistence.Repository;

namespace Template.Api.Extensions;

public static class DependencyInjectionExtension
{
    public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
    {
        var configure = new MapperConfiguration(config => { config.AddProfile(new MapperGeneric<object, object>()); });
        IMapper mapperGeneric = configure.CreateMapper();
        services.AddSingleton(mapperGeneric);
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        #region Services
        services.AddScoped<IUserService, UserService>();
        #endregion

        #region Repositories
        services.AddScoped<IUserRepository, UserRepository>();
        #endregion

        return services;
    }
}