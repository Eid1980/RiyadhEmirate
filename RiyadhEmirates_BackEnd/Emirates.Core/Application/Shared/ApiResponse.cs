namespace Emirates.Core.Application.Shared
{
    public class ApiResponse : IApiResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
