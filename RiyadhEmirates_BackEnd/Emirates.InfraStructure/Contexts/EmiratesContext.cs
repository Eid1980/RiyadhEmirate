using Microsoft.EntityFrameworkCore;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain;
using Microsoft.AspNetCore.Http;

namespace Emirates.InfraStructure.Contexts
{
    public class EmiratesContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public EmiratesContext()
        {

        }
        public EmiratesContext(IHttpContextAccessor httpContextAccessor, DbContextOptions<EmiratesContext> options) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        //public override int SaveChanges()
        //{
        //    var userId = GetUserId();
        //    var currentDate = DateTime.Now;

        //    this.ChangeTracker.DetectChanges();
        //    var added = this.ChangeTracker.Entries()
        //                .Where(t => t.State == EntityState.Added)
        //                .Select(t => t.Entity)
        //                .ToArray();

        //    foreach (var entity in added)
        //    {
        //        if (entity is AuditData)
        //        {
        //            var track = entity as AuditData;
        //            track.CreationDate = currentDate;
        //            track.CreatedBy =(userId != null) ? userId.Value : null;
        //        }
        //    }

        //    var modified = this.ChangeTracker.Entries()
        //                .Where(t => t.State == EntityState.Modified)
        //                .Select(t => t.Entity)
        //                .ToArray();

        //    foreach (var entity in modified)
        //    {
        //        if (entity is AuditData)
        //        {
        //            var track = entity as AuditData;
        //            Entry(track).Property(p => p.CreatedBy).IsModified = false;
        //            Entry(track).Property(p => p.CreationDate).IsModified = false;
        //            track.ModifiedBy = userId;
        //            track.ModificationDate = currentDate;
        //        }
        //    }
        //    return base.SaveChanges();
        //}
        public override int SaveChanges()
        {
            try
            {
                ChangeTracker.DetectChanges();
                foreach (var entry in ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
                {
                    _Logging.ApplyAudit(entry, GetUserId().Value);
                }
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            //configurationBuilder.Properties<string>().HaveColumnType(EmiratesConstants.MaxColumnType);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region CaseType
            modelBuilder.Entity<CaseType>(b =>
            {
                b.ToTable("CaseTypes", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedCaseTypes).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedCaseTypes).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region Governorate
            modelBuilder.Entity<Governorate>(b =>
            {
                b.ToTable("Governorates", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedGovernorates).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedGovernorates).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Governorates());
            });
            #endregion

            #region MaritalStatus
            modelBuilder.Entity<MaritalStatus>(b =>
            {
                b.ToTable("MaritalStatuses", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedMaritalStatuses).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedMaritalStatuses).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
                
                b.HasData(DefaultData.MaritalStatuses());
            });
            #endregion

            #region Nationality
            modelBuilder.Entity<Nationality>(b =>
            {
                b.ToTable("Nationalities", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.Code).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.Iso2).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.DialCode).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedNationalities).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Nationalities());
            });
            #endregion

            #region NewsTypes
            modelBuilder.Entity<NewsType>(b =>
            {
                b.ToTable("NewsTypes", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.TitleAr).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.TitleEn).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.Date).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasIndex(x => x.NewsTypeCode).IsUnique();
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedNewsType).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedNewsType).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
                    
                b.HasData(DefaultData.NewsTypes());

            });
            #endregion

            #region News
            modelBuilder.Entity<News>(b =>
            {
                b.ToTable("News", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.TitleAr).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.TitleEn).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.DescriptionAr).HasColumnType(EmiratesConstants.MaxColumnType).IsRequired();
                b.Property(x => x.DescriptionEn).HasColumnType(EmiratesConstants.MaxColumnType).IsRequired();
                b.Property(x => x.Date).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

               
                b.HasOne<NewsType>(x => x.NewsTypesCode).WithMany(x => x.News).HasForeignKey(x => x.NewsTypeId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedNews).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedNews).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region Request
            modelBuilder.HasSequence<long>("RequestNumberSequence", EmiratesDbSchemas.RequestSehema).StartsAt(100000).IncrementsBy(1);
            modelBuilder.Entity<RequestNumberSequence>().HasNoKey().ToSqlQuery($"SELECT NEXT VALUE FOR {EmiratesDbSchemas.RequestSehema}.RequestNumberSequence AS [Value]");

            modelBuilder.Entity<Request>(b =>
            {
                b.ToTable("Requests", EmiratesDbSchemas.RequestSehema);                
                b.Property(x => x.ServiceId).IsRequired();
                b.Property(x => x.RequestNumber).HasMaxLength(EmiratesConstants.MaxShortLength).IsRequired();
                b.Property(x => x.RequestDate).IsRequired();
                b.Property(x => x.StageId).IsRequired();
                b.Property(x => x.Notes).HasMaxLength(EmiratesConstants.MaxMultiTextLength);
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();
                b.HasIndex(x => x.CreatedDate);

                b.HasOne<Service>(x => x.Service).WithMany(x => x.Requests).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Stage>(x => x.Stage).WithMany(x => x.Requests).HasForeignKey(x => x.StageId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x=>x.CreatedUser).WithMany(x => x.CreatedRequests).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedRequests).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasOne<RequestElectronicBoard>(x => x.RequestElectronicBoard).WithOne(x => x.Request).HasForeignKey<RequestElectronicBoard>(x => x.Id).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<RequestPrisonerTempRelease>(x => x.RequestPrisonerTempRelease).WithOne(x => x.Request).HasForeignKey<RequestPrisonerTempRelease>(x => x.Id).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<RequestPrisonersService>(x => x.RequestPrisonersService).WithOne(x => x.Request).HasForeignKey<RequestPrisonersService>(x => x.Id).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region RequestAttachmentType
            modelBuilder.Entity<RequestAttachmentType>(b =>
            {
                b.ToTable("RequestAttachmentTypes", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.ServiceId).IsRequired();
                b.Property(x => x.ExtentionAllowed).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.IsRequired).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<Service>(x => x.Service).WithMany(x => x.RequestAttachmentTypes).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedRequestAttachmentTypes).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedRequestAttachmentTypes).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

            });
            #endregion

            #region RequestElectronicBoard
            modelBuilder.Entity<RequestElectronicBoard>(b =>
            {
                b.ToTable("RequestElectronicBoards", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequestTypeId).IsRequired();
                b.Property(x => x.RequestTitle).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.RequestContent).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();

                b.HasOne<RequestType>(x => x.RequestType).WithMany(x => x.RequestElectronicBoards).HasForeignKey(x => x.RequestTypeId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region RequestPrisonersService
            modelBuilder.Entity<RequestPrisonersService>(b =>
            {
                b.ToTable("RequestPrisonersServices", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequestTypeId).IsRequired();
                b.Property(x => x.PresonName).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.CaseTypeId).IsRequired();

                b.HasOne<RequestType>(x => x.RequestType).WithMany(x => x.RequestPrisonersServices).HasForeignKey(x => x.RequestTypeId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<CaseType>(x => x.CaseType).WithMany(x => x.RequestPrisonersServices).HasForeignKey(x => x.CaseTypeId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region RequestPrisonerTempRelease
            modelBuilder.Entity<RequestPrisonerTempRelease>(b =>
            {
                b.ToTable("RequestPrisonerTempReleases", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequestTypeId).IsRequired();
                b.Property(x => x.PresonName).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.CaseTypeId).IsRequired();

                b.HasOne<RequestType>(x => x.RequestType).WithMany(x => x.RequestPrisonerTempReleases).HasForeignKey(x => x.RequestTypeId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<CaseType>(x => x.CaseType).WithMany(x => x.RequestPrisonerTempReleases).HasForeignKey(x => x.CaseTypeId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region Stage
            modelBuilder.Entity<Stage>(b =>
            {
                b.ToTable("Stages", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.CanEdit).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedStages).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedStages).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Stages());
            });
            #endregion

            #region RequestStageLog
            modelBuilder.Entity<RequestStageLog>(b =>
            {
                b.ToTable("RequestStageLogs", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequestId).IsRequired();
                b.Property(x => x.StageId).IsRequired();
                b.Property(x => x.Notes).HasMaxLength(EmiratesConstants.MaxMultiTextLength);
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<Request>(x => x.Request).WithMany(x => x.RequestStageLogs).HasForeignKey(x => x.RequestId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Stage>(x => x.Stage).WithMany(x => x.RequestStageLogs).HasForeignKey(x => x.StageId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedRequestStageLogs).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedRequestStageLogs).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region RequestType
            modelBuilder.Entity<RequestType>(b =>
            {
                b.ToTable("RequestTypes", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.ServiceId).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<Service>(x => x.Service).WithMany(x => x.RequestTypes).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedRequestTypes).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedRequestTypes).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.RequestTypes());
            });
            #endregion

            #region Role
            modelBuilder.Entity<Role>(b =>
            {
                b.ToTable("Roles", EmiratesDbSchemas.SecuritySehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedRoles).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedRoles).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region Service
            modelBuilder.Entity<Service>(b =>
            {
                b.ToTable("Services", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.TitleAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.TitleEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.DescriptionAr).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.DescriptionEn).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.RequestLink).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedServices).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedServices).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Services());
            });
            #endregion

            #region ServiceRate
            modelBuilder.Entity<ServiceRate>(b =>
            {
                b.ToTable("ServiceRates", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.ServiceId).IsRequired();
                b.Property(x => x.StarsCount).IsRequired();
                b.Property(x => x.Notes).HasMaxLength(EmiratesConstants.MaxMultiTextLength);

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedServiceRates).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region ServiceStage
            modelBuilder.Entity<ServiceStage>(b =>
            {
                b.ToTable("ServiceStages", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.ServiceId).IsRequired();
                b.Property(x => x.StageId).IsRequired();
                b.Property(x => x.RequesterUrl).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.AdminUrl).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<Service>(x => x.Service).WithMany(x => x.ServiceStages).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Stage>(x => x.Stage).WithMany(x => x.ServiceStages).HasForeignKey(x => x.StageId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedServiceStages).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedServiceStages).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.ServiceStages());
            });
            #endregion

            #region UploadedFile
            modelBuilder.Entity<UploadedFile>(b =>
            {
                b.ToTable("UploadedFiles", EmiratesDbSchemas.FileManager);
                b.Property(x => x.EntityId).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.EntityName).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.SubEntityName).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.Name).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.OriginalName).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.Extention).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.IsActive).IsRequired();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedUploadedFiles).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedUploadedFiles).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

            });
            #endregion

            #region User
            modelBuilder.Entity<User>(b =>
            {
                b.ToTable("Users", EmiratesDbSchemas.SecuritySehema);
                b.Property(x => x.UserName).HasMaxLength(EmiratesConstants.MaxShortLength).IsRequired();

                b.Property(x => x.FirstNameAr).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.SecondNameAr).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.ThirdNameAr).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.LastNameAr).HasMaxLength(EmiratesConstants.MaxShortLength);

                b.Property(x => x.FirstNameEn).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.SecondNameEn).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.ThirdNameEn).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.LastNameEn).HasMaxLength(EmiratesConstants.MaxShortLength);

                b.Property(x => x.EmployeeSide).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.JobOccupation).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.Email).HasMaxLength(EmiratesConstants.MaxNameLength);
                b.Property(x => x.PhoneNumber).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.PassportId).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.Address).HasMaxLength(EmiratesConstants.MaxMultiTextLength);
                b.Property(x => x.Last2Factor).HasMaxLength(EmiratesConstants.MaxShortLength);

                b.Property(x => x.IsActive).IsRequired();

                b.HasOne<Nationality>(x => x.Nationality).WithMany(x => x.Users).HasForeignKey(x => x.NationalityId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<MaritalStatus>(x => x.MaritalStatus).WithMany(x => x.Users).HasForeignKey(x => x.MaritalStatusId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Governorate>(x => x.Governorate).WithMany(x => x.Users).HasForeignKey(x => x.GovernorateId).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Users());
            });
            #endregion
        }

        public DbSet<CaseType> CaseTypes { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsType> NewTypes { get; set; }

        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestAttachmentType> RequestAttachmentTypes { get; set; }
        public DbSet<RequestElectronicBoard> RequestElectronicBoards { get; set; }
        public DbSet<RequestPrisonersService> RequestPrisonersServices { get; set; }
        public DbSet<RequestPrisonerTempRelease> RequestPrisonerTempReleases { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<RequestStageLog> RequestStageLogs { get; set; }
        public DbSet<RequestType> RequestType { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<RolesScreen> RolesScreens { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceRate> ServiceRates { get; set; }
        public DbSet<ServiceStage> ServiceStages { get; set; }
        public DbSet<UploadedFile> UploadedFiles { get; set; }
        public DbSet<User> User { get; set; }


        private int? GetUserId()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                int.TryParse(_httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToLower().Contains("userid")).Value, out int userId);
                return userId;
            }
            return 1;
        }
    }
}
