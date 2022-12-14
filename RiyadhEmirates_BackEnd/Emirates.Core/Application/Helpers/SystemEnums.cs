
namespace Emirates.Core.Application.Helpers
{
    public class SystemEnums
    {
        public enum NewsTypes
        {
            EmiratesNews = 1,
            LatestNews = 2,
            Reports = 3
        }
        public enum Services
        {
            ElectronicBoard = 1,
            PrisonerTempRelease = 2,
            PrisonersServices = 3,
            ElectronicSummoning = 4
        }
        public enum Stages
        {
            Draft = 1,
            NewRequest = 2,
            CompleteDataFromRequester = 3,
            UnderProcessing = 4,
            RequestRejectedFromAdmin = 5,
            RequestRejected = 6,
            RequestApproved = 7
        }
    }
}
