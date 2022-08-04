using Emirates.Core.Application.Interfaces.Response;
using System.Globalization;

namespace Emirates.Core.Application.Interfaces.BaseController
{
    public interface IBaseController
    {
        CultureInfo GetCurrentCulture { get; }
        CultureInfo GetCurrentUICulture { get; }

        IResponse<TReturnedEntity> GetResponse<TReturnedEntity>(TReturnedEntity entity, string message = null)
            where TReturnedEntity : class;
    }

    public interface IBaseController<TService> : IBaseController
        where TService : class
    {
        TService Service { get; }
    }
}
