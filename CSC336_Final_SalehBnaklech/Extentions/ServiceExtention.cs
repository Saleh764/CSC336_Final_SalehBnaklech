using BLL.Service.PilotService;
using BLL.services.FlightServices;
using BLL.services.PassengerServices;

namespace CSC336_Final_SalehBnaklech.Extentions
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddserviceExtenstion(this IServiceCollection services)
        {
            services.AddScoped<IPilotService ,PilotService>();
            services.AddScoped<IPassengerService,PassengerService>();
            services.AddScoped<IFlightSerivce,IFlightSerivce>();    
            return services;
        }
    }
}
