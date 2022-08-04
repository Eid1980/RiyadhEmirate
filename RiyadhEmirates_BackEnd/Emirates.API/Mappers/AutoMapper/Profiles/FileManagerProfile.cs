using AutoMapper;
using Emirates.API.Dtos.InternalPortal.Request.UploadedFile;
using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;

namespace Emirates.API.Mappers.AutoMapper.Profiles
{
    public class FileManagerProfile : Profile
    {
        public FileManagerProfile()
        {
            CreateMap<CreateUploadedFileDto, CreateUploadedFileModel>();
        }
    }
}
