using System;

namespace Emirates.Core.Application.Dtos
{
    public class RequestChangeStageDto
    {
        public Guid Id { get; set; }
        public int StageId { get; set; }
        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
