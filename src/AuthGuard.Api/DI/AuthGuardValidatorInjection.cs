using AuthGuard.Common.Validators;
using AuthGuard.Contracts.Requests;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace AuthGuard.Api.DI
{
    public static class AuthGuardValidatorInjection
    {
        public static void AddValidatorInjection(this IServiceCollection services)
        {
            services.AddSingleton<IValidator<PostEmployeeRequest>, PostEmployeeRequestValidator>();
        }
    }
}
