
namespace Emirates.Core.Application.Helpers
{
    public class SystemEnums
    {
        public enum NewsTypes
        {
            LatestNews = 1,
            GovernorateNews = 2,
            Reports = 3
        }
        public enum CommentStages
        {
            New = 1,
            Approved = 2,
            Rejected = 3
        }
        public enum Services
        {
            ElectronicBoard = 1,
            PrisonerTempRelease = 2,
            PrisonersServices = 3,
            ElectronicSummon = 4,
            LandsInfringement = 5,
            JudgmentExecution = 6,
            MarriageCertificate = 7,
            ForeignersRealtyOwner = 8,
            TreatmentRecommendation = 9
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

        public static class FileCateguery
        {
            public static string News = "news";
            public static string Posters = "posters";
            public static string Princes = "princes";
            public static string Governorates = "governorates";
            public static string Services = "services";
            public static string Auctions = "auctions";
        }
    }
}
