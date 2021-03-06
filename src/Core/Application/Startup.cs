global using Ardalis.Specification;
global using FluentValidation;
global using FSH.WebApi.Application.Common.Events;
global using FSH.WebApi.Application.Common.Exceptions;
global using FSH.WebApi.Application.Common.FileStorage;
global using FSH.WebApi.Application.Common.Interfaces;
global using FSH.WebApi.Application.Common.Models;
global using FSH.WebApi.Application.Common.Persistence;
global using FSH.WebApi.Application.Common.Specification;
global using FSH.WebApi.Application.Common.Validation;
global using FSH.WebApi.Domain.Catalog.Brands;
global using FSH.WebApi.Domain.Catalog.Products;
global using FSH.WebApi.Domain.Common;
global using FSH.WebApi.Domain.Common.Contracts;
global using FSH.WebApi.Domain.Multitenancy;
global using FSH.WebApi.Shared.Notifications;
global using MediatR;
global using Microsoft.Extensions.Localization;
global using Microsoft.Extensions.Logging;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace FSH.WebApi.Application;

public static class Startup
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        return services
            .AddValidatorsFromAssembly(assembly)
            .AddMediatR(assembly);
    }
}