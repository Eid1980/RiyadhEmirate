using System.Globalization;

namespace Emirates.Core.Application.Services.Shared
{
    public interface ILocalizationService
    {
        string GetCurrentCultureName { get; }
        string GetCurrentUICultureName { get; }
        CultureInfo GetCurrentCulture { get; }
        CultureInfo GetCurrentUICulture { get; }
    }
}
