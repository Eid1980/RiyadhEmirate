using AutoMapper;
using Emirates.Core.Application.Models.Request;
using Emirates.Core.Application.Models.Response.Nationality;
using Emirates.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Application.Mappers.AutoMapper.Profiles
{
    public class NationalityProfile : Profile
    {
        public NationalityProfile()
        {
            CreateMap<Nationality, NationalityResponse>()
                .ForMember(dest => dest.Nationality,
                    opt => opt.MapFrom(src => CultureInfo.CurrentUICulture.Name == CultureCodes.ar.ToString() ? src.NameAr : src.NameEn));
        }
        
    }
}
