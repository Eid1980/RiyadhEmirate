namespace Emirates.Core.Application.Shared
{
    public interface IApiResponse
    {
        bool IsSuccess { get; set; }
        string Message { get; set; }
        object Data { get; set; }
    }
}
