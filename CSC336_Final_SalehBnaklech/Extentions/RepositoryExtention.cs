using DAL.Repositories.FlightsRepositories;
using DAL.Repositories.Passengers;
using DAL.Repositories.PilotRepositories;
using DAL.Repositories.PilotRepository;

namespace CSC336_Final_SalehBnaklech.Extentions
{
    public static class RepositoryExtention
    {
        public static IServiceCollection AddRepositories(this IServiceCollection Services)
        {
            Services.AddScoped<IPilotRepository, PilotRepository>();
            Services.AddScoped<IPassengerRepository,PassengerRepository>();
            Services.AddScoped<IFlightsRepository, FlightsRepository>();
            return Services;

        }
    }
}
