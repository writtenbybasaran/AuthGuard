using AuthGuard.Bussiness.Mappers;
using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthGuard.Api.DI
{
    public static class AuthGuardAutoMapperInjection
    {
        public static void AddAutoMapperInjection(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(EmployeeMappers).Assembly);
        }
       
    }
}
