using BLL.Mapping;

namespace CSC336_Final_SalehBnaklech.Extentions
{
    public static class AutoMapper
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection Services)
        {
            Services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MapperProfile());
            }, typeof(Program));

            return Services;

        }
    }
}
