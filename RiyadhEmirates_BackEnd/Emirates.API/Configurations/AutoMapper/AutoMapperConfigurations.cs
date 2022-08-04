using AutoMapper;
using System.Reflection;

namespace Emirates.API.Configurations.AutoMapper
{
    public class AutoMapperConfigurations
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.AddMaps(AppDomain.CurrentDomain.GetAssemblies()));
            return config.CreateMapper();
        }
    }
}
