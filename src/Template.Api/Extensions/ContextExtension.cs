﻿using Microsoft.EntityFrameworkCore;
using Template.Arguments.General.Session;
using Template.Infrastructure.Persistence.Context;

namespace Template.Api.Extensions;

public static class ContextExtension
{
    public static IServiceCollection ConfigureContext(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>((serviceProvider, options) =>
        {
            var connectionString = SessionData.Configuration!.GetConnectionString("DefaultConnection");
            options.UseMySQL(connectionString!);
        });

        return services;
    }
}