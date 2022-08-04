using Emirates.Core.Application.Models.Response.Nationality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Application.Services.Nationality
{
    public interface INationalityService
    {
        List<NationalityResponse> GetAll();
    }
}
