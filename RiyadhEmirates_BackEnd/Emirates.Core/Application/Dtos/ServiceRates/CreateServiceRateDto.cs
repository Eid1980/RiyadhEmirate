using System;

namespace Emirates.Core.Application.Dtos
{
    public class CreateServiceRateDto
    {
        public int ServiceId { get; set; }
        public int StarsCount { get; set; }
        public string Notes { get; set; }
    }
}
