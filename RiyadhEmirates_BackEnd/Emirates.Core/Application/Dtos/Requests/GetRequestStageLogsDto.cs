using System;

namespace Emirates.Core.Application.Dtos
{
    public class GetRequestStageLogsDto
    {
        public string StageName { get; set; }
        public string Notes { get; set; }
        public string CreatedByName { get; set; }
        public string CreatedDate { get; set; }
    }
}
