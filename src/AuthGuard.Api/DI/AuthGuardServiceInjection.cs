using AuthGuard.Bussiness.Services;
using AuthGuard.Bussiness.Services.Implementations;
using AuthGuard.Context.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AuthGuard.Api.DI
{
    public static class AuthGuardServiceInjection
    {
        public static void AddAuthGuardServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
