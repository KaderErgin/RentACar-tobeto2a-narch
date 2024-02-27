using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NArchitecture.Core.Persistence.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BaseDb")));
        services.AddDbMigrationApplier(buildServices => buildServices.GetRequiredService<BaseDbContext>());

        services.AddScoped<IEmailAuthenticatorRepository, EmailAuthenticatorRepository>();
        services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
        services.AddScoped<IOtpAuthenticatorRepository, OtpAuthenticatorRepository>();
        services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();
        services.AddScoped<IBrandRepository, BrandRepository>();//brand
        services.AddScoped<ICarRepository,CarRepository>(); //car
        services.AddScoped<ICorporateCustomerRepository, CorporateCustomerRepository>();//CorporateCustomer  
        services.AddScoped<ICustomerRepository, CustomerRepository>();//Customer
        services.AddScoped<IFuelRepository, FuelRepository>();//Fuel
        services.AddScoped<IIndividualCustomerRepository, IndividualCustomerRepository>();//IndividualCustomer
        services.AddScoped<IModelRepository, ModelRepository>();//Model
        services.AddScoped<ITransmissionRepository, TransmissionRepository>();//Transmission

        return services;
    }
}