using AutoMapper;
using Emirates.Core.Application.Models.Response.Nationality;
using Emirates.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Application.Services.Nationality
{
    public class NationalityService : INationalityService
    {
        private readonly IMapper _mapper;
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        public NationalityService(IEmiratesUnitOfWork emiratesUnitOfWork,
           IMapper mapper)
        {
            _mapper = mapper;
            _emiratesUnitOfWork = emiratesUnitOfWork;
        }
        public List<NationalityResponse> GetAll()
        {
            try
            {
                var data = _emiratesUnitOfWork.Nationalities.GetQueryable();
                return _mapper.Map<List<NationalityResponse>>(data);
            }
            catch (Exception ex)
            {
                //TODO
                // log the exception

                return null;
            }
        }
    }
}
