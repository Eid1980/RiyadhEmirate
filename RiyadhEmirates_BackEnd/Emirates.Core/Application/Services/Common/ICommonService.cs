using Emirates.Core.Application.Dtos;

namespace Emirates.Core.Application.Services.Common
{
    public interface ICommonService
    {
        Task SendEmailAsync(MailRequestDto mailRequest);
    }
}
