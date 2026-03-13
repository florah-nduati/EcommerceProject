using ShoppingCart.Presentation;

namespace ShoppingCart.App.ExtensionsMethod
{
    public static class RegisterControllerExtensions
    {
            public static IServiceCollection RegisterController(this IServiceCollection services)
            {
                services.AddControllers()
                .AddApplicationPart(AssemblyReference.assembly);
                return services;
            }
    }
}
