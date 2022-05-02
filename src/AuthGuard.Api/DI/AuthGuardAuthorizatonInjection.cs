using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace AuthGuard.Api.DI
{
    public static class AuthGuardAuthorizatonInjection
    {
        public static void AddAuthorizationInjection(this IServiceCollection services)
        {

            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", options =>
                {
                    options.Authority = "https://localhost:5001";

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateAudience = false
                    };
                });


        }
    }
}
