using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CSC336_Final_SalehBnaklech.Extentions
{
    public static class StartUpExtentions
    {
        public static IServiceCollection addDb(this IServiceCollection Services, ConfigurationManager configr)
        {
            var ConnectionString = configr.GetConnectionString("DefultConnection");
            Services.AddDbContext<AirplaneSystemContext>(options =>
            options.UseSqlServer(ConnectionString)
            );
            return Services;
        }
    }
}
