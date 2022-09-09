using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Application.Services.ServiceConditions
{
    public interface IServiceConditionService
    {
        IApiResponse GetById(int id);
        IApiResponse GetByServiceId(int serviceId);
        IApiResponse Create(CreateServiceConditionDto createModel);
        IApiResponse Update(UpdateServiceConditionDto updateModel);
        IApiResponse Delete(int id);
    }
}
