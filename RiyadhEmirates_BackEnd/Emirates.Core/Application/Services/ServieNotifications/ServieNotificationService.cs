﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using X.PagedList;

namespace Emirates.Core.Application.Services.ServieNotifications
{
    public class ServieNotificationService : BaseService, IServieNotificationService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public ServieNotificationService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var servieNotification = _emiratesUnitOfWork.ServieNotifications.FirstOrDefault(l => l.Id.Equals(id), x => x.Service, x => x.Stage, x => x.ServieNotificationLogs);
            if (servieNotification == null)
                throw new NotFoundException(typeof(ServieNotification).Name);
            return GetResponse(data: _mapper.Map<GetServieNotificationDetailsDto>(servieNotification));
        }
        public IApiResponse GetServieNotificationLog(int id)
        {
            var servieNotifications = _emiratesUnitOfWork.ServieNotificationLogs.Where(l => l.ServieNotificationId == id);
            return GetResponse(data: _mapper.Map<List<GetServieNotificationLogListDto>>(servieNotifications));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.ServieNotifications.GetQueryable()
               .ProjectTo<GetServieNotificationListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetServieNotificationListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var ServieNotifications = _emiratesUnitOfWork.ServieNotifications.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetServieNotificationListDto>>(ServieNotifications));
        }

        public IApiResponse Create(CreateServieNotificationDto createModel)
        {
            if (_emiratesUnitOfWork.ServieNotifications.Where(x => x.ServiceId == createModel.ServiceId && x.StageId == createModel.StageId &&x.IsSMS == createModel.IsSMS && x.IsEmail == createModel.IsEmail).Any())
                throw new BusinessException("تم اضافة الرسالة مسبقا");

            var addedModel = _mapper.Map<ServieNotification>(createModel);
            _emiratesUnitOfWork.ServieNotifications.Add(addedModel);
            _emiratesUnitOfWork.Complete();
            ServieNotificationLog servieNotificationLog = new ServieNotificationLog
            {
                ServieNotificationId = addedModel.Id,
                Message = createModel.Message
            };
            _emiratesUnitOfWork.ServieNotificationLogs.Add(servieNotificationLog);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateServieNotificationDto updateModel)
        {
            var servieNotification = _emiratesUnitOfWork.ServieNotifications.FirstOrDefault(n => n.Id == updateModel.Id, x => x.ServieNotificationLogs.Where(e => e.EndDate == null));
            if (servieNotification == null)
                throw new NotFoundException(typeof(ServieNotification).Name);

            if (_emiratesUnitOfWork.ServieNotifications.Where(x => x.Id != updateModel.Id && x.ServiceId == updateModel.ServiceId && x.StageId == updateModel.StageId &&x.IsSMS == updateModel.IsSMS && x.IsEmail == updateModel.IsEmail).Any())
                throw new BusinessException("يوجد رسالة مضافة مسبقا على نفس البيانات");

            updateModel.IsSMS = servieNotification.IsSMS;
            updateModel.IsEmail = servieNotification.IsEmail;
            updateModel.IsDefault = servieNotification.IsDefault;
            _emiratesUnitOfWork.ServieNotifications.Update(servieNotification, _mapper.Map<ServieNotification>(updateModel));

            if (updateModel.Message != servieNotification.ServieNotificationLogs.FirstOrDefault()?.Message)
            {
                var logs = _emiratesUnitOfWork.ServieNotificationLogs.Where(x => x.ServieNotificationId == updateModel.Id && x.EndDate == null).ToList();
                foreach (var item in logs)
                {
                    item.EndDate = DateTime.Now;
                }
                _emiratesUnitOfWork.ServieNotificationLogs.Add(new ServieNotificationLog
                {
                    ServieNotificationId = updateModel.Id,
                    Message = updateModel.Message
                });
            }
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var servieNotification = _emiratesUnitOfWork.ServieNotifications.FirstOrDefault(n => n.Id == id);
            if (servieNotification == null)
                throw new NotFoundException(typeof(ServieNotification).Name);

            servieNotification.IsActive = !servieNotification.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var servieNotification = _emiratesUnitOfWork.ServieNotifications.FirstOrDefault(n => n.Id == id, x => x.ServieNotificationLogs);
            if (servieNotification == null)
                throw new NotFoundException(typeof(ServieNotification).Name);
            if(servieNotification.IsDefault)
                throw new BusinessException("لا يمكنك حذف هذا العنصر لكونه العنصر الافتراضي");

            _emiratesUnitOfWork.ServieNotificationLogs.RemoveRange(servieNotification.ServieNotificationLogs);
            _emiratesUnitOfWork.ServieNotifications.Remove(servieNotification);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}