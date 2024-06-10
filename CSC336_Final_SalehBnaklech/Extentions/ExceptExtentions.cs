using CSC336_Final_SalehBnaklech.Filter;

namespace CSC336_Final_SalehBnaklech.Extentions
{
    public static class ExceptExtentions
    {
        public static IServiceCollection AddExceptions(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });

            return services;
        }
    }
}
