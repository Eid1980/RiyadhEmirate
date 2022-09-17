using AutoMapper;
using Microsoft.Extensions.Configuration;
using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;
using Emirates.Core.Application.Models.InternalPortal.Response.FileManager;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using Emirates.Core.Domain.Interfaces.Repositories;

namespace Emirates.Core.Application.Services.InternalPortal.FileManager
{
    public class FileManagerService : IFileManagerService
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IFileUploaderService _fileUploaderService;

        public FileManagerService(IEmiratesUnitOfWork EmiratesUnitOfWork,
            IConfiguration config, IMapper mapper,
            IFileUploaderService fileUploaderService)
        {
            _fileUploaderService = fileUploaderService;
            _emiratesUnitOfWork = EmiratesUnitOfWork;
            _config = config;
            _mapper = mapper;
        }

        public int Upload(CreateUploadedFileModel createUploadedFileModel)
        {
            List<CreateUploadedFileModel> uploadedFiles = new();

            foreach (var file in createUploadedFileModel.Files)
            {
                if (file.Length > 0)
                {
                    createUploadedFileModel.OriginalName = file.FileName;
                    createUploadedFileModel.Extention = Path.GetExtension(file.FileName).ToLower();

                    if (!_fileUploaderService.ExculdedFiles.Contains(createUploadedFileModel.Extention))
                    {
                        createUploadedFileModel.Name = _fileUploaderService.UploadedFile(file, _config.GetSection("FileUploadPaths:UploadedFiles").Value);
                        var model = _mapper.Map<UploadedFile>(createUploadedFileModel);
                        model.IsActive = true;
                        uploadedFiles.Add(createUploadedFileModel);

                        _emiratesUnitOfWork.UploadedFiles.Add(model);
                    }
                }
            }

            int res = _emiratesUnitOfWork.Complete();
            if (res < 1)
            {
                // DELETE FILES
                foreach (var file in uploadedFiles)
                    _fileUploaderService.DeleteFile(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
            }

            return res;
        }
        public void ChangeStatus(Guid fileId)
        {
            var uploadedFile = _emiratesUnitOfWork.UploadedFiles.FirstOrDefault(f => f.Id == fileId);
            uploadedFile.IsActive = !uploadedFile.IsActive;
            int res = _emiratesUnitOfWork.Complete();
        }
        public void Delete(Guid fileId)
        {
            var uploadedFile = _emiratesUnitOfWork.UploadedFiles.FirstOrDefault(f => f.Id == fileId);

            _emiratesUnitOfWork.UploadedFiles.Remove(fileId);
            _fileUploaderService.DeleteFile(_config.GetSection("FileUploadPaths:UploadedFiles").Value + uploadedFile.Name);

            int res = _emiratesUnitOfWork.Complete();
        }
        public void DeleteByEntityName(string entityId, string entityName)
        {
            var uploadedFile = _emiratesUnitOfWork.UploadedFiles
                .FirstOrDefault(f => f.EntityId == entityId && f.EntityName == entityName);
            
            if (uploadedFile != null)
            {
                _emiratesUnitOfWork.UploadedFiles.Remove(uploadedFile);
                _fileUploaderService.DeleteFile(_config.GetSection("FileUploadPaths:UploadedFiles").Value + uploadedFile.Name);

                int res = _emiratesUnitOfWork.Complete();
            }
        }

        public UploadedFileBase64Model GetById(Guid id)
        {
            try
            {
                var uploadedFile = _emiratesUnitOfWork.UploadedFiles.FirstOrDefault(f => f.Id.Equals(id) && f.IsActive);
                if (uploadedFile == null)
                    return null;
                var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + uploadedFile.Name);
                var base64String = Convert.ToBase64String(bytes);
                return new UploadedFileBase64Model()
                {
                    FileName = uploadedFile.OriginalName,
                    Extention = uploadedFile.Extention,
                    Base64File = uploadedFile.Extention == ".pdf" || uploadedFile.Extention == ".docx" || uploadedFile.Extention == ".doc" || uploadedFile.Extention == ".xls" || uploadedFile.Extention == ".xlsx"
                                     ? base64String : $"data:image/{uploadedFile.Extention.Substring(1)};base64," + base64String,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<GetUploadedFileModel> GetByEntityId(string entityId)
        {
            try
            {
                var uploadedFiles = _emiratesUnitOfWork.UploadedFiles.Where(f => f.EntityId == entityId && f.IsActive);
                return _mapper.Map<List<GetUploadedFileModel>>(uploadedFiles);
            }
            catch (Exception)
            {
                return null;
            }
           
        }
        public List<GetUploadedFileModel> GetByEntityName(string entityName)
        {
            try
            {
                var uploadedFiles = _emiratesUnitOfWork.UploadedFiles.Where(f => f.EntityName == entityName);
                var mappedModels = _mapper.Map<List<GetUploadedFileModel>>(uploadedFiles);
                foreach (var file in mappedModels)
                {
                    var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                    var base64File = Convert.ToBase64String(bytes);
                    file.Base64File = file.Extention == ".pdf"
                                     || file.Extention == ".docx"
                                     || file.Extention == ".doc"
                                     || file.Extention == ".xls"
                                     || file.Extention == ".xlsx"
                                     ? base64File : $"data:image/{file.Extention.Substring(1)};base64," + base64File;
                }

                return mappedModels;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<GetUploadedFileModel> GetByEntityNameAndActive(string entityName)
        {
            try
            {
                var uploadedFiles = _emiratesUnitOfWork.UploadedFiles.Where(f => f.EntityName == entityName && f.IsActive);
                var mappedModels = _mapper.Map<List<GetUploadedFileModel>>(uploadedFiles);
                foreach (var file in mappedModels)
                {
                    var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                    var base64File = Convert.ToBase64String(bytes);
                    file.Base64File = file.Extention == ".pdf"
                                     || file.Extention == ".docx"
                                     || file.Extention == ".doc"
                                     || file.Extention == ".xls"
                                     || file.Extention == ".xlsx"
                                     ? base64File : $"data:image/{file.Extention.Substring(1)};base64," + base64File;
                }

                return mappedModels;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public UploadedFileBase64Model Download(Guid fileId)
        {
            try
            {
                var file = _emiratesUnitOfWork.UploadedFiles.
                    FirstOrDefault(f => f.Id == fileId);

                var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                var base64String = Convert.ToBase64String(bytes);

                return new UploadedFileBase64Model()
                {
                    FileName = file.OriginalName,
                    Base64File = file.Extention == ".pdf"
                                     || file.Extention == ".docx"
                                     || file.Extention == ".doc"
                                     || file.Extention == ".xls"
                                     || file.Extention == ".xlsx"
                                     ? base64String : $"data:image/{file.Extention.Substring(1)};base64," + base64String,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
        public UploadedFileBase64Model GetBase64File(int entityId, string entityName)
        {
            try
            {
                var file = _emiratesUnitOfWork.UploadedFiles.FirstOrDefault(f => f.EntityId == entityId.ToString() && f.EntityName == entityName && f.IsActive);
                if(file == null)
                    return null;
                var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                var base64String = Convert.ToBase64String(bytes);
                return new UploadedFileBase64Model()
                {
                    FileName = file.OriginalName,
                    Base64File = file.Extention == ".pdf" || file.Extention == ".docx" || file.Extention == ".doc" || file.Extention == ".xls" || file.Extention == ".xlsx"
                                     ? base64String : file.Extention == ".svg" ? "data:image/svg+xml;base64," + base64String : $"data:image/{file.Extention.Substring(1)};base64," + base64String,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public UploadedFileBase64Model GetBase64File(Guid entityId, string entityName)
        {
            try
            {
                var file = _emiratesUnitOfWork.UploadedFiles.FirstOrDefault(f => f.EntityId == entityId.ToString() && f.EntityName == entityName && f.IsActive);
                if (file == null)
                    return null;
                var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                var base64String = Convert.ToBase64String(bytes);
                return new UploadedFileBase64Model()
                {
                    FileName = file.OriginalName,
                    Base64File = file.Extention == ".pdf" || file.Extention == ".docx" || file.Extention == ".doc" || file.Extention == ".xls" || file.Extention == ".xlsx"
                                     ? base64String : file.Extention == ".svg" ? "data:image/svg+xml;base64," + base64String : $"data:image/{file.Extention.Substring(1)};base64," + base64String,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<UploadedFileBase64Model> GetBase64BySubEntityName(string entityId, string entityName, string subEntityName)
        {
            try
            {
                List<UploadedFileBase64Model> fileList = new();

                var files = _emiratesUnitOfWork.UploadedFiles
                    .Where(f => f.EntityId == entityId
                    && f.EntityName == entityName
                    && f.SubEntityName == subEntityName
                    && f.IsActive);

                foreach (var file in files)
                {
                    var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                    var base64String = Convert.ToBase64String(bytes);
                    fileList.Add(new UploadedFileBase64Model()
                    {
                        FileName = file.OriginalName,
                        Base64File = file.Extention == ".pdf"
                                     || file.Extention == ".docx"
                                     || file.Extention == ".doc"
                                     || file.Extention == ".xls"
                                     || file.Extention == ".xlsx"
                                     ? base64String : $"data:image/{file.Extention.Substring(1)};base64," + base64String,
                    });
                }

                return fileList;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
