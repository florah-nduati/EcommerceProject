using ShoppingCart.Infrastructure.Options;
using ShoppingCart.Presentation;

namespace ShoppingCart.App.ExtensionsMethod
{
    public static class RegisterControllerExtensions
    {
        public static IServiceCollection RegisterController(this IServiceCollection services)
        {
            services.AddControllers()
            .AddApplicationPart(AssemblyReference.assembly)
            .AddNewtonsoftJson(options =>
         {
             options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
             options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
         });
            return services;
        }

        public static IServiceCollection RegisterOptions(this IServiceCollection services)
        {
            services.ConfigureOptions<DatabaseOptionsSetup>();
            return services;

        }
    }
}
