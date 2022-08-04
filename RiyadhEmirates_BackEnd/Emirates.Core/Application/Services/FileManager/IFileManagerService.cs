using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;
using Emirates.Core.Application.Models.InternalPortal.Response.FileManager;

namespace Emirates.Core.Application.Services.InternalPortal.FileManager
{
    public interface IFileManagerService
    {
        int Upload(CreateUploadedFileModel createUploadedFileModel);
        void Delete(Guid fileId);
        void DeleteByEntityName(string entityId,string entityName);
        UploadedFileBase64Model GetById(Guid id);
        List<GetUploadedFileModel> GetByEntityId(string entityId);
        List<GetUploadedFileModel> GetByEntityName(string entityName);
        UploadedFileBase64Model Download(Guid fileId);
        void ChangeStatus(Guid fileId);
        List<GetUploadedFileModel> GetByEntityNameAndActive(string entityName);
        UploadedFileBase64Model GetBase64File(int entityId, string entityName);
        List<UploadedFileBase64Model> GetBase64BySubEntityName(string entityId, string entityName, string subEntityName);
    }
}
