using Microsoft.EntityFrameworkCore;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain;
using Microsoft.AspNetCore.Http;
using Emirates.Core.Application.CustomExceptions;

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
                throw new BusinessException("خطأ في قاعدة البيانات برجاء التواصل مع مدير النظام");
            }
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            //configurationBuilder.Properties<string>().HaveColumnType(EmiratesConstants.MaxColumnType);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Auction
            modelBuilder.Entity<Auction>(b =>
            {
                b.ToTable("Auctions", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.Title).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.Content).HasColumnType(EmiratesConstants.MaxColumnType).IsRequired();
                b.Property(x => x.ImageName).HasMaxLength(EmiratesConstants.MaxDescriptionLength);
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedAuctions).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedAuctions).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region Audience
            modelBuilder.Entity<Audience>(b =>
            {
                b.ToTable("Audiences", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedAudiences).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedAudiences).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Audiences());
            });
            #endregion

            #region BuildingType
            modelBuilder.Entity<BuildingType>(b =>
            {
                b.ToTable("BuildingTypes", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedBuildingTypes).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedBuildingTypes).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.BuildingTypes());
            });
            #endregion

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

                b.HasData(DefaultData.CaseTypes());
            });
            #endregion

            #region CommentStage
            modelBuilder.Entity<CommentStage>(b =>
            {
                b.ToTable("CommentStages", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.CanShowComment).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedCommentStages).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedCommentStages).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.CommentStages());
            });
            #endregion

            #region ContactUsMessage
            modelBuilder.Entity<ContactUsMessage>(b =>
            {
                b.ToTable("ContactUsMessages", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.FullName).HasMaxLength(EmiratesConstants.MaxShortLength).IsRequired();
                b.Property(x => x.Email).HasMaxLength(EmiratesConstants.MaxShortLength).IsRequired();
                b.Property(x => x.ContactUsMessageTypeId).IsRequired();
                b.Property(x => x.Title).HasMaxLength(EmiratesConstants.MaxNameLength).IsRequired();
                b.Property(x => x.Content).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.IsReplied).IsRequired().HasDefaultValue(false);

                b.HasOne<ContactUsMessageType>(x => x.ContactUsMessageType).WithMany(x => x.ContactUsMessages).HasForeignKey(x => x.ContactUsMessageTypeId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedContactUsMessages).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region ContactUsMessageType
            modelBuilder.Entity<ContactUsMessageType>(b =>
            {
                b.ToTable("ContactUsMessageTypes", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.HasData(DefaultData.ContactUsMessageTypes());
            });
            #endregion

            #region DefendantType
            modelBuilder.Entity<DefendantType>(b =>
            {
                b.ToTable("DefendantTypes", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedDefendantTypes).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedDefendantTypes).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.DefendantTypes());
            });
            #endregion

            #region DesignEvaluation
            modelBuilder.Entity<DesignEvaluation>(b =>
            {
                b.ToTable("DesignEvaluations", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.Evaluate).IsRequired();
            });
            #endregion

            #region EmiratesPrince
            modelBuilder.Entity<EmiratesPrince>(b =>
            {
                b.ToTable("EmiratesPrinces", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxDescriptionLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxDescriptionLength).IsRequired();
                b.Property(x => x.BehalfToAr).HasMaxLength(EmiratesConstants.MaxDescriptionLength);
                b.Property(x => x.BehalfToEn).HasMaxLength(EmiratesConstants.MaxDescriptionLength);
                b.Property(x => x.ImageName).HasMaxLength(EmiratesConstants.MaxDescriptionLength);
                b.Property(x => x.Cv).HasColumnType(EmiratesConstants.MaxColumnType);
                b.Property(x => x.FromDate).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedEmiratesPrinces).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedEmiratesPrinces).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.EmiratesPrinces());
            });
            #endregion

            #region Governorate
            modelBuilder.Entity<Governorate>(b =>
            {
                b.ToTable("Governorates", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.DescriptionAr).HasColumnType(EmiratesConstants.MaxColumnType).IsRequired();
                b.Property(x => x.DescriptionEn).HasColumnType(EmiratesConstants.MaxColumnType).IsRequired();
                b.Property(x => x.PhoneNumber).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.LocationLink).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.PortalLink).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.ImageName).HasMaxLength(EmiratesConstants.MaxDescriptionLength);
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedGovernorates).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedGovernorates).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Governorates());
            });
            #endregion

            #region MainPagePoints
            modelBuilder.Entity<MainPagePoints>(b =>
            {
                b.ToTable("MainPagePoints", EmiratesDbSchemas.DataManagement);
                
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.Order).IsRequired();
                b.Property(x => x.PageContentId).IsRequired();

                b.HasOne(p => p.PageContent).WithMany(p => p.MainPagePoints).HasForeignKey(p => p.PageContentId).OnDelete(DeleteBehavior.NoAction);

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

            #region News
            modelBuilder.Entity<News>(b =>
            {
                b.ToTable("News", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.Title).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.Content).HasColumnType(EmiratesConstants.MaxColumnType).IsRequired();
                b.Property(x => x.IsArabic).IsRequired();
                b.Property(x => x.NewsTypeId).IsRequired();
                b.Property(x => x.Date).IsRequired();
                b.Property(x => x.NewsOrigin).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.ImageName).HasMaxLength(EmiratesConstants.MaxDescriptionLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.OpenComments).IsRequired().HasDefaultValue(false);
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<NewsCateguery>(x => x.NewsCateguery).WithMany(x => x.News).HasForeignKey(x => x.NewsCategueryId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedNews).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedNews).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region NewsCateguery
            modelBuilder.Entity<NewsCateguery>(b =>
            {
                b.ToTable("NewsCategueries", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedNewsCategueries).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedNewsCategueries).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.NewsCategueries());
            });
            #endregion

            #region NewsComment
            modelBuilder.Entity<NewsComment>(b =>
            {
                b.ToTable("NewsComments", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.NewsId).IsRequired();
                b.Property(x => x.Comment).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.CommentStageId).IsRequired();
                b.Property(x => x.Email).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.CreatedByName).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.CreatedDate).IsRequired();

                b.HasOne<News>(x => x.News).WithMany(x => x.NewsComments).HasForeignKey(x => x.NewsId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<CommentStage>(x => x.CommentStage).WithMany(x => x.NewsComments).HasForeignKey(x => x.CommentStageId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedNewsComments).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region OpenDataCateguery
            modelBuilder.Entity<OpenDataCateguery>(b =>
            {
                b.ToTable("OpenDataCategueries", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.OpenDataSubCategueryId).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<OpenDataSubCateguery>(x => x.OpenDataSubCateguery).WithMany(x => x.OpenDataCategueries).HasForeignKey(x => x.OpenDataSubCategueryId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedOpenDataCategueries).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedOpenDataCategueries).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.OpenDataCategueries());
            });
            #endregion

            #region OpenDataReport
            modelBuilder.Entity<OpenDataReport>(b =>
            {
                b.ToTable("OpenDataReports", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.OpenDataCategueryId).IsRequired();
                b.Property(x => x.FileUrl).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<OpenDataCateguery>(x => x.OpenDataCateguery).WithMany(x => x.OpenDataReports).HasForeignKey(x => x.OpenDataCategueryId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedOpenDataReports).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedOpenDataReports).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region OpenDataRequest
            modelBuilder.Entity<OpenDataRequest>(b =>
            {
                b.ToTable("OpenDataRequests", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.FullName).HasMaxLength(EmiratesConstants.MaxShortLength).IsRequired();
                b.Property(x => x.Email).HasMaxLength(EmiratesConstants.MaxShortLength).IsRequired();
                b.Property(x => x.Title).HasMaxLength(EmiratesConstants.MaxNameLength).IsRequired();
                b.Property(x => x.Content).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.IsReplied).IsRequired().HasDefaultValue(false);

                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedOpenDataRequests).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region OpenDataSubCateguery
            modelBuilder.Entity<OpenDataSubCateguery>(b =>
            {
                b.ToTable("OpenDataSubCategueries", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedOpenDataSubCategueries).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedOpenDataSubCategueries).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.OpenDataSubCategueries());
            });
            #endregion

            #region PageContent
            modelBuilder.Entity<PageContent>(b =>
            {
                b.ToTable("PageContent", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.DescriptionAr).HasMaxLength(EmiratesConstants.MaxDescriptionLength).IsRequired();
                b.Property(x => x.DescriptionEn).HasMaxLength(EmiratesConstants.MaxDescriptionLength).IsRequired();
                b.Property(x => x.PageContentType).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasData(DefaultData.PageContents());

            });
            #endregion

            #region Poster
            modelBuilder.Entity<Poster>(b =>
            {
                b.ToTable("Posters", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.TitleAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.TitleEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.Order).IsRequired();
                b.Property(x => x.ImageName).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedPosters).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedPosters).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
                
                b.HasData(DefaultData.Posters());
            });
            #endregion

            #region Prison
            modelBuilder.Entity<Prison>(b =>
            {
                b.ToTable("Prisons", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedPrisons).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedPrisons).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Prisons());
            });
            #endregion

            #region Religion
            modelBuilder.Entity<Religion>(b =>
            {
                b.ToTable("Religions", EmiratesDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedReligions).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedReligions).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Religions());
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
                b.HasOne<RequestLandsInfringement>(x => x.RequestLandsInfringement).WithOne(x => x.Request).HasForeignKey<RequestLandsInfringement>(x => x.Id).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<RequestElectronicSummon>(x => x.RequestElectronicSummon).WithOne(x => x.Request).HasForeignKey<RequestElectronicSummon>(x => x.Id).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<RequestMarriageCertificate>(x => x.RequestMarriageCertificate).WithOne(x => x.Request).HasForeignKey<RequestMarriageCertificate>(x => x.Id).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<RequestJudgmentExecution>(x => x.RequestJudgmentExecution).WithOne(x => x.Request).HasForeignKey<RequestJudgmentExecution>(x => x.Id).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<RequestForeignersRealtyOwner>(x => x.RequestForeignersRealtyOwner).WithOne(x => x.Request).HasForeignKey<RequestForeignersRealtyOwner>(x => x.Id).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<RequestTreatmentRecommendation>(x => x.RequestTreatmentRecommendation).WithOne(x => x.Request).HasForeignKey<RequestTreatmentRecommendation>(x => x.Id).OnDelete(DeleteBehavior.NoAction);
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

            #region RequestElectronicSummon
            modelBuilder.Entity<RequestElectronicSummon>(b =>
            {
                b.ToTable("RequestElectronicSummons", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequestTypeId).IsRequired();
                b.Property(x => x.RequestTitle).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.RequestContent).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();

                b.HasOne<RequestType>(x => x.RequestType).WithMany(x => x.RequestElectronicSummons).HasForeignKey(x => x.RequestTypeId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region RequestForeignersRealtyOwner
            modelBuilder.Entity<RequestForeignersRealtyOwner>(b =>
            {
                b.ToTable("RequestForeignersRealtyOwners", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.BuildingTypeId).IsRequired();
                b.Property(x => x.GovernorateId).IsRequired();
                b.Property(x => x.District).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.ReligionId).IsRequired();
                b.Property(x => x.Address).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();

                b.HasOne<BuildingType>(x => x.BuildingType).WithMany(x => x.RequestForeignersRealtyOwners).HasForeignKey(x => x.BuildingTypeId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Governorate>(x => x.Governorate).WithMany(x => x.RequestForeignersRealtyOwners).HasForeignKey(x => x.GovernorateId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Religion>(x => x.Religion).WithMany(x => x.RequestForeignersRealtyOwners).HasForeignKey(x => x.ReligionId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region RequestJudgmentExecution
            modelBuilder.Entity<RequestJudgmentExecution>(b =>
            {
                b.ToTable("RequestJudgmentExecutions", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequesterType).IsRequired();
                b.Property(x => x.RequesterName).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.RequesterNationalId).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.DefendantTypeId).IsRequired();
                b.Property(x => x.LawsuitDate).IsRequired();
                b.Property(x => x.LawsuitNumber).HasMaxLength(EmiratesConstants.MaxNameLength).IsRequired();

                b.HasOne<DefendantType>(x => x.DefendantType).WithMany(x => x.RequestJudgmentExecutions).HasForeignKey(x => x.DefendantTypeId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region RequestMarriageCertificate
            modelBuilder.Entity<RequestMarriageCertificate>(b =>
            {
                b.ToTable("RequestMarriageCertificates", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequestTypeId).IsRequired();
                b.Property(x => x.EmployeeSide).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.JobOccupation).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.MaritalStatusId).IsRequired();
                b.Property(x => x.ChildrenCount).IsRequired();

                b.HasOne<RequestType>(x => x.RequestType).WithMany(x => x.RequestMarriageCertificates).HasForeignKey(x => x.RequestTypeId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<MaritalStatus>(x => x.MaritalStatus).WithMany(x => x.RequestMarriageCertificates).HasForeignKey(x => x.MaritalStatusId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region RequestLandsInfringement
            modelBuilder.Entity<RequestLandsInfringement>(b =>
            {
                b.ToTable("RequestLandsInfringements", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequestTypeId).IsRequired();
                b.Property(x => x.InstrumentNumber).HasMaxLength(EmiratesConstants.MaxShortLength).IsRequired();
                b.Property(x => x.EstimatedSpace).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.GovernorateId).IsRequired();
                b.Property(x => x.Address).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.Longitude).HasMaxLength(EmiratesConstants.MaxShortLength).IsRequired();
                b.Property(x => x.Latitude).HasMaxLength(EmiratesConstants.MaxShortLength).IsRequired();
                b.Property(x => x.InfringerName).HasMaxLength(EmiratesConstants.MaxNameLength);
                b.Property(x => x.InfringerDescription).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();

                b.HasOne<RequestType>(x => x.RequestType).WithMany(x => x.RequestLandsInfringements).HasForeignKey(x => x.RequestTypeId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Governorate>(x => x.Governorate).WithMany(x => x.RequestLandsInfringements).HasForeignKey(x => x.GovernorateId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region RequestPrisonersService
            modelBuilder.Entity<RequestPrisonersService>(b =>
            {
                b.ToTable("RequestPrisonersServices", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequestTypeId).IsRequired();
                b.Property(x => x.PrisonId).IsRequired();
                b.Property(x => x.CaseTypeId).IsRequired();

                b.HasOne<RequestType>(x => x.RequestType).WithMany(x => x.RequestPrisonersServices).HasForeignKey(x => x.RequestTypeId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Prison>(x => x.Prison).WithMany(x => x.RequestPrisonersServices).HasForeignKey(x => x.PrisonId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<CaseType>(x => x.CaseType).WithMany(x => x.RequestPrisonersServices).HasForeignKey(x => x.CaseTypeId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region RequestPrisonerTempRelease
            modelBuilder.Entity<RequestPrisonerTempRelease>(b =>
            {
                b.ToTable("RequestPrisonerTempReleases", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequestTypeId).IsRequired();
                b.Property(x => x.PrisonId).IsRequired();
                b.Property(x => x.CaseTypeId).IsRequired();

                b.HasOne<RequestType>(x => x.RequestType).WithMany(x => x.RequestPrisonerTempReleases).HasForeignKey(x => x.RequestTypeId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Prison>(x => x.Prison).WithMany(x => x.RequestPrisonerTempReleases).HasForeignKey(x => x.PrisonId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<CaseType>(x => x.CaseType).WithMany(x => x.RequestPrisonerTempReleases).HasForeignKey(x => x.CaseTypeId).OnDelete(DeleteBehavior.NoAction);
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

            #region RequestTreatmentRecommendation
            modelBuilder.Entity<RequestTreatmentRecommendation>(b =>
            {
                b.ToTable("RequestTreatmentRecommendations", EmiratesDbSchemas.RequestSehema);
                b.Property(x => x.RequestTypeId).IsRequired();
                b.Property(x => x.PatientType).IsRequired();
                b.Property(x => x.PatientName).HasMaxLength(EmiratesConstants.MaxLongNameLength);
                b.Property(x => x.PatientNationalId).HasMaxLength(EmiratesConstants.MaxShortLength);

                b.HasOne<RequestType>(x => x.RequestType).WithMany(x => x.RequestTreatmentRecommendations).HasForeignKey(x => x.RequestTypeId).OnDelete(DeleteBehavior.NoAction);
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
                b.ToTable("Roles", EmiratesDbSchemas.AuthSehema);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedRoles).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedRoles).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Roles());
            });
            #endregion

            #region Service
            modelBuilder.Entity<Service>(b =>
            {
                b.ToTable("Services", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.NameAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.SectorAr).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.SectorEn).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.DescriptionAr).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.DescriptionEn).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.RequestLink).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.WorkDays).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.ImageName).HasMaxLength(EmiratesConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.IsExternal).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedServices).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedServices).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Services());
            });
            #endregion

            #region ServiceAudience
            modelBuilder.Entity<ServiceAudience>(b =>
            {
                b.ToTable("ServiceAudiences", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.ServiceId).IsRequired();
                b.Property(x => x.AudienceId).IsRequired();

                b.HasOne<Service>(x => x.Service).WithMany(x => x.ServiceAudiences).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Audience>(x => x.Audience).WithMany(x => x.ServiceAudiences).HasForeignKey(x => x.AudienceId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedServiceAudiences).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region ServiceBenefit
            modelBuilder.Entity<ServiceBenefit>(b =>
            {
                b.ToTable("ServiceBenefits", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.ServiceId).IsRequired();
                b.Property(x => x.IsBenefit).IsRequired();

                b.HasOne<Service>(x => x.Service).WithMany(x => x.ServiceBenefits).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region ServiceCondition
            modelBuilder.Entity<ServiceCondition>(b =>
            {
                b.ToTable("ServiceConditions", EmiratesDbSchemas.DataManagement);
                b.Property(x => x.ServiceId).IsRequired();
                b.Property(x => x.Condition).HasMaxLength(EmiratesConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.Order).IsRequired();

                b.HasOne<Service>(x => x.Service).WithMany(x => x.ServiceConditions).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedServiceConditions).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedServiceConditions).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
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
                b.ToTable("Users", EmiratesDbSchemas.AuthSehema);
                b.Property(x => x.UserName).HasMaxLength(EmiratesConstants.MaxShortLength).IsRequired();

                b.Property(x => x.FirstNameAr).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.SecondNameAr).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.ThirdNameAr).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.LastNameAr).HasMaxLength(EmiratesConstants.MaxShortLength);

                b.Property(x => x.FirstNameEn).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.SecondNameEn).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.ThirdNameEn).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.LastNameEn).HasMaxLength(EmiratesConstants.MaxShortLength);

                b.Property(x => x.Email).HasMaxLength(EmiratesConstants.MaxNameLength);
                b.Property(x => x.PhoneNumber).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.PassportId).HasMaxLength(EmiratesConstants.MaxShortLength);
                b.Property(x => x.Address).HasMaxLength(EmiratesConstants.MaxMultiTextLength);
                b.Property(x => x.Last2Factor).HasMaxLength(EmiratesConstants.MaxShortLength);

                b.Property(x => x.IsActive).IsRequired();

                b.HasOne<Nationality>(x => x.Nationality).WithMany(x => x.Users).HasForeignKey(x => x.NationalityId).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Users());
            });
            #endregion

            #region UserRole
            modelBuilder.Entity<UserRole>(b =>
            {
                b.ToTable("UserRoles", EmiratesDbSchemas.AuthSehema);
                b.Property(x => x.UserId).IsRequired();
                b.Property(x => x.RoleId).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.User).WithMany(x => x.UserRoles).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Role>(x => x.Role).WithMany(x => x.UserRoles).HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedUserRoles).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedUserRoles).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.UserRoles());
            });
            #endregion

        }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Audience> Audiences { get; set; }
        public DbSet<BuildingType> BuildingTypes { get; set; }
        public DbSet<CaseType> CaseTypes { get; set; }
        public DbSet<CommentStage> CommentStages { get; set; }
        public DbSet<ContactUsMessage> ContactUsMessages { get; set; }
        public DbSet<ContactUsMessageType> ContactUsMessageTypes { get; set; }
        public DbSet<DefendantType> DefendantTypes { get; set; }
        public DbSet<DesignEvaluation> DesignEvaluations { get; set; }
        public DbSet<EmiratesPrince> EmiratesPrinces { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<MainPagePoints> MainPagePoints { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsCateguery> NewsCategueries { get; set; }
        public DbSet<NewsComment> NewsComments { get; set; }
        public DbSet<OpenDataCateguery> OpenDataCategueries { get; set; }
        public DbSet<OpenDataReport> OpenDataReports { get; set; }
        public DbSet<OpenDataRequest> OpenDataRequests { get; set; }
        public DbSet<OpenDataSubCateguery> OpenDataSubCategueries { get; set; }
        public DbSet<PageContent> PageContent { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<Prison> Prisons { get; set; }
        public DbSet<Religion> Religions { get; set; }

        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestAttachmentType> RequestAttachmentTypes { get; set; }
        public DbSet<RequestElectronicBoard> RequestElectronicBoards { get; set; }
        public DbSet<RequestElectronicSummon> RequestElectronicSummons { get; set; }
        public DbSet<RequestJudgmentExecution> RequestJudgmentExecutions { get; set; }
        public DbSet<RequestLandsInfringement> RequestLandsInfringements { get; set; }
        public DbSet<RequestMarriageCertificate> RequestMarriageCertificates { get; set; }
        public DbSet<RequestPrisonersService> RequestPrisonersServices { get; set; }
        public DbSet<RequestPrisonerTempRelease> RequestPrisonerTempReleases { get; set; }
        public DbSet<RequestStageLog> RequestStageLogs { get; set; }
        public DbSet<RequestTreatmentRecommendation> RequestTreatmentRecommendations { get; set; }
        public DbSet<RequestType> RequestType { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceAudience> ServiceAudiences { get; set; }
        public DbSet<ServiceBenefit> ServiceBenefits { get; set; }
        public DbSet<ServiceCondition> ServiceConditions { get; set; }
        public DbSet<ServiceRate> ServiceRates { get; set; }
        public DbSet<ServiceStage> ServiceStages { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<UploadedFile> UploadedFiles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


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
