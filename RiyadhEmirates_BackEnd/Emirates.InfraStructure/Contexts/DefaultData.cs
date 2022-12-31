using Emirates.Core.Application.Shared;
using Emirates.Core.Domain.Entities;
using System.Text;

namespace Emirates.InfraStructure.Contexts
{
    public static class DefaultData
    {
        public static Audience[] Audiences()
        {
            Audience[] arrData = new Audience[3];
            arrData[0] = new Audience { Id = 1, NameAr = "مواطنين", NameEn = "Citizens", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new Audience { Id = 2, NameAr = "مقيمين", NameEn = "Residents", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new Audience { Id = 3, NameAr = "زائرين", NameEn = "Visitors", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static BuildingType[] BuildingTypes()
        {
            BuildingType[] arrData = new BuildingType[4];
            arrData[0] = new BuildingType { Id = 1, NameAr = "شقة", NameEn = "Apartment", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new BuildingType { Id = 2, NameAr = "فيلا", NameEn = "Villa", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new BuildingType { Id = 3, NameAr = "عمارة سكنية", NameEn = "Residential Building", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new BuildingType { Id = 4, NameAr = "مبنى تجاري", NameEn = "Commercial Building", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static Prison[] Prisons()
        {
            Prison[] arrData = new Prison[15];
            arrData[0] = new Prison { Id = 1, NameAr = "سجن الحاير", NameEn = "Al-Ha'ir Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new Prison { Id = 2, NameAr = "سجن الملز", NameEn = "Al-Malaz Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new Prison { Id = 3, NameAr = "سجن النساء", NameEn = "Women Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new Prison { Id = 4, NameAr = "سجن محافظة المجمعة", NameEn = "Majma'ah Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new Prison { Id = 5, NameAr = "سجن محافظة الزلفي", NameEn = "Az Zulfi Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new Prison { Id = 6, NameAr = "سجن محافظة الدوادمي", NameEn = "Dawadmi Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[6] = new Prison { Id = 7, NameAr = "سجن محافظة عفيف", NameEn = "Afif Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[7] = new Prison { Id = 8, NameAr = "سجن محافظة القويعية", NameEn = "Al Quwaiiyah Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[8] = new Prison { Id = 9, NameAr = "سجن محافظة الخرج", NameEn = "Al-Kharj Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[9] = new Prison { Id = 10, NameAr = "سجن محافظة حوطة بني تميم", NameEn = "Howtat Bani Tamim Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[10] = new Prison { Id = 11, NameAr = "سجن محافظة الأفلاج", NameEn = "Al-Aflaj Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[11] = new Prison { Id = 12, NameAr = "سجن محافظة وادي الدواسر", NameEn = "Wadi ad-Dawasir Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[12] = new Prison { Id = 13, NameAr = "سجن محافظة شقراء", NameEn = "Shaqra Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[13] = new Prison { Id = 14, NameAr = "سجن محافظة الوافدين", NameEn = "Al Wafedien Governorate Prison", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[14] = new Prison { Id = 15, NameAr = "اصلاحية الرياض", NameEn = "Riyadh Reformatory", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static CaseType[] CaseTypes()
        {
            CaseType[] arrData = new CaseType[1];
            arrData[0] = new CaseType { Id = 1, NameAr = "قضية جنائية", NameEn = "Criminal Case", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static CommentStage[] CommentStages()
        {
            CommentStage[] arrData = new CommentStage[3];
            arrData[0] = new CommentStage { Id = 1, NameAr = "جديد", NameEn = "New", CanShowComment = false, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new CommentStage { Id = 2, NameAr = "معتمد", NameEn = "Approved", CanShowComment = false, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new CommentStage { Id = 3, NameAr = "مرفوض", NameEn = "Rejected", CanShowComment = false, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static ContactUsMessageType[] ContactUsMessageTypes()
        {
            ContactUsMessageType[] arrData = new ContactUsMessageType[3];
            arrData[0] = new ContactUsMessageType { Id = 1, NameAr = "سؤال", NameEn = "Question", IsActive = true};
            arrData[1] = new ContactUsMessageType { Id = 2, NameAr = "اقتراح", NameEn = "Suggestion", IsActive = true};
            arrData[2] = new ContactUsMessageType { Id = 3, NameAr = "طلب مساعدة", NameEn = "Help", IsActive = true};
            return arrData;
        }
        public static EmiratesPrince[] EmiratesPrinces()
        {
            EmiratesPrince[] arrData = new EmiratesPrince[14];
            arrData[0] = new EmiratesPrince { Id = 1, NameAr = "الأمير ناصر بن عبد العزيز", NameEn = "Prince Naser bin Abdul-Aziz", FromDate = new DateTime(1937, 1, 1), ToDate = new DateTime(1947, 5, 28), ImageName = "PrinceNasir.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new EmiratesPrince { Id = 2, NameAr = "الأمير سلطان  بن عبد العزيز", NameEn = "Prince Sultan bin Abdul-Aziz", FromDate = new DateTime(1947, 5, 29), ToDate = new DateTime(1952, 12, 19), ImageName = "PrinceSultan.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new EmiratesPrince { Id = 3, NameAr = "الأمير نايف بن عبد العزيز", NameEn = "Prince Naif bin Abdul-Aziz", BehalfToAr = "الأمير ​سلطان", BehalfToEn = "prince Sultan bin Abdul-Aziz", FromDate = new DateTime(1952, 3, 3), ToDate = new DateTime(1952, 12, 19), ImageName = "Princenayef.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new EmiratesPrince { Id = 4, NameAr = "الأمير نايف بن عبد العزيز", NameEn = "Prince Naif bin Abdul-Aziz", FromDate = new DateTime(1952, 12, 20), ToDate = new DateTime(1955, 4, 18), ImageName = "Princenayef.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new EmiratesPrince { Id = 5, NameAr = "الملك سلمان بن عبد العزيز", NameEn = "King Salman bin Abdul-Aziz", BehalfToAr = "الأمير نايف", BehalfToEn = "prince Naif", FromDate = new DateTime(1954, 3, 16), ToDate = new DateTime(1955, 4, 17), ImageName = "Princesalman.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new EmiratesPrince { Id = 6, NameAr = "الملك سلمان بن عبد العزيز", NameEn = "King Salman bin Abdul-Aziz", FromDate = new DateTime(1955, 4, 18), ToDate = new DateTime(1960, 9, 22), ImageName = "Princesalman.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[6] = new EmiratesPrince { Id = 7, NameAr = "الأمير تركي بن عبد العزيز", NameEn = "Prince Turki bin Abdul-Aziz", BehalfToAr = "الملك سلمان", BehalfToEn = "king Salman", FromDate = new DateTime(1957, 10, 10), ToDate = new DateTime(1960, 10, 31), ImageName = "PrinceTurki.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[7] = new EmiratesPrince { Id = 8, NameAr = "الأمير فواز بن عبد العزيز", NameEn = "Prince Fawaz bin Abdul-Aziz", FromDate = new DateTime(1960, 12, 26), ToDate = new DateTime(1961, 7, 20), ImageName = "PrinceFawaz.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[8] = new EmiratesPrince { Id = 9, NameAr = "الأمير بدر بن عبد العزيز", NameEn = "Prince Badr bin Abdul-Aziz", FromDate = new DateTime(1961, 9, 11), ToDate = new DateTime(1963, 1, 20), ImageName = "Princebadr.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[9] = new EmiratesPrince { Id = 10, NameAr = "الملك سلمان بن عبد العزيز", NameEn = "King Salman bin Abdul-Aziz", FromDate = new DateTime(1963, 2, 5), ToDate = new DateTime(2011, 11, 5), ImageName = "Princesalman.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[10] = new EmiratesPrince { Id = 11, NameAr = "الأمير سطام بن عبد العزيز", NameEn = "Prince Sattam bin Abdul-Aziz", FromDate = new DateTime(2011, 11, 5), ToDate = new DateTime(2013, 2, 12), ImageName = "PrinceSatam.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[11] = new EmiratesPrince { Id = 12, NameAr = "الأمير خالد بن ​بندر بن عبد العزيز", NameEn = "Prince khalid bin Bandar bin Abdul-Aziz", FromDate = new DateTime(2013, 2, 14), ToDate = new DateTime(2014, 5, 15), ImageName = "PrinceKhaledBandar.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[12] = new EmiratesPrince { Id = 13, NameAr = "الأمير تركي بن عبدالله بن عبد العزيز", NameEn = "Prince ​Turki bin Abdullah bin Abdul-Aziz", FromDate = new DateTime(2014, 5, 15), ToDate = new DateTime(2015, 1, 29), ImageName = "PrinceTurkiBinAbdullah.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[13] = new EmiratesPrince { Id = 14, NameAr = "الأمير فيصل بن بندر بن عبد العزيز", NameEn = "Prince Faisal bin Bandar bin Abdul-Aziz", FromDate = new DateTime(2015, 1, 29), ImageName = "PrinceFaisalBandar.jpg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static NewsCateguery[] NewsCategueries()
        {
            NewsCateguery[] arrData = new NewsCateguery[4];
            arrData[0] = new NewsCateguery { Id = 1, NameAr = "غير مصنف", NameEn = "Not Categuerized", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new NewsCateguery { Id = 2, NameAr = "أخبار الأمير", NameEn = "Prince News", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new NewsCateguery { Id = 3, NameAr = "أخبار النائب", NameEn = "Deputy News", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new NewsCateguery { Id = 4, NameAr = "أخبار الإمارة", NameEn = "Emirate News", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static Religion[] Religions()
        {
            Religion[] arrData = new Religion[1];
            arrData[0] = new Religion { Id = 1, NameAr = "مسلم", NameEn = "Muslem", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static Role[] Roles()
        {
            Role[] arrData = new Role[7];
            arrData[0] = new Role { Id = 1, NameAr = "مدير عام النظام", NameEn = "Super System Admin", IsActive = false, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new Role { Id = 2, NameAr = "مدير النظام", NameEn = "System Admin", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new Role { Id = 3, NameAr = "صلاحيات الأخبار", NameEn = "News Permission", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new Role { Id = 4, NameAr = "صلاحيات الاعدادات", NameEn = "Setting Permission", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new Role { Id = 5, NameAr = "صلاحيات المستخدمين", NameEn = "Users Permission", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new Role { Id = 6, NameAr = "مراجعة الطلبات", NameEn = "Request Review", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[6] = new Role { Id = 7, NameAr = "مراجعة طلبات شامل", NameEn = "Shamel Request Review", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static DefendantType[] DefendantTypes()
        {
            DefendantType[] arrData = new DefendantType[3];
            arrData[0] = new DefendantType { Id = 1, NameAr = "فرد", NameEn = "Individual", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new DefendantType { Id = 2, NameAr = "شركة", NameEn = "Company", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new DefendantType { Id = 3, NameAr = "جهة حكومية", NameEn = "Governate", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static MaritalStatus[] MaritalStatuses()
        {
            MaritalStatus[] arrData = new MaritalStatus[4];
            arrData[0] = new MaritalStatus { Id = 1, NameAr = "أعزب", NameEn = "Single", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new MaritalStatus { Id = 2, NameAr = "متزوج", NameEn = "Married", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new MaritalStatus { Id = 3, NameAr = "مطلق", NameEn = "Divorced", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new MaritalStatus { Id = 4, NameAr = "أرمل", NameEn = "Widower", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static Governorate[] Governorates()
        {
            Governorate[] arrData = new Governorate[23];
            arrData[0] = new Governorate { Id = 1, NameAr = "مدينة الرياض مقر الإمارة", NameEn = "Emirate of Riyadh City", 
                DescriptionAr = "مدينة الرياض مقر الإمارة", 
                DescriptionEn = "Emirate of Riyadh City", 
                IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new Governorate { Id = 2, NameAr = "محافظةالدرعية", NameEn = "Diriyah Governorate", 
                DescriptionAr = "هي المحافظة الأولى في المملكة و يحدها من الشمال محافظة حريملاء و من الجنوب محافظة ضرما ومدينة الرياض و من الشرق مدينة الرياض و من الغرب حريملاء و محافظة ضرما وتبلغ مساحتها 2020 كلم2 و يبلغ عدد سكانها 73668 نسمة ( ثلاثة وسبعون ألفا و ستمائة وثمانية وستون ) نسمة و هي عاصمة الدولة السعودية الأولى و الثانية و يوجد بها بيوت أثرية للأسرة السعودية المالكة بنيت قديما على أنقاض مدينة حجر عاصمة اليمامة .", 
                DescriptionEn = "The first governorate in the kingdom. Al-Deri’yaa borders are Hraymlaa from the north, Derma governorate and Riyadh city from the south, Riyadh city from the east, and Hraymlaa and Derma from the west. Its area is 2020 square kilometers. Its population is 73668 people (seventy three thousand, six hundred, and sixty eight). It is the capital of the first and second Saudi state. It has archaeological houses of the Saudi governing family built on the ruins of Hajar city the capital of Al-Yamama.", 
                PortalLink = "http://www.aldoriyah.gov.sa/", PhoneNumber = "0114861400", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new Governorate { Id = 3, NameAr = "محافظةالخرج", NameEn = "Al-Kharj Governorate", 
                DescriptionAr = "وتقع جنوب منطقة الرياض و يحدها من الشرق المنطقة الشرقية و من الغرب محافظة المزاحمية و محافظة الحريق و من الجنوب محافظة الأفلاج و من الشمال مدينة الرياض . و تبلغ مساحتها 19790كلم2 و يبلغ عدد سكانها 376325 نسمة و من الآثار و الأماكن التاريخية بمحافظة الخرج ـ قصر مشرف ـ بلدة اليمامة", 
                DescriptionEn = "It lies in the south of Riyadh region. Its borders are the eastern region from the east, Al-Mzahmya governorate and Al-Hareeq governorate from the west, Al-Aflaj from the south, and Riyadh from the north. Its area is 19790 square kilometers and its population is 376325 people. The historical monuments and places in it includes Musharraf palace and Al-Yamama town.", 
                PortalLink = "http://www.alkharj.gov.sa/", PhoneNumber = "0115483800",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new Governorate { Id = 4, NameAr = "محافظةالدوادمي", NameEn = "Dawadmi Governorate", 
                DescriptionAr = "ويحدها من الشمال منطقة القصيم و من الجنوب محافظة القويعية و من الغرب منطقة القصيم و محافظة عفيف ، ومن الشرق محافظة شقراء و محافظة مرات. و تبلغ مساحتها 30580كلم2 ـ و يبلغ عدد سكانها 217305 نسمة ، و من الآثار القديمة بمحافظة الدوادمى ـ قصر الملك عبد العزيز _ رحمه الله .", 
                DescriptionEn = "Its borders are Qaseem from the north, Al-Quwai’iyah governorate from the south, Qaseem and Afeef regionsfrom the west, and Shaqra governorate and Mrat village from the east. Its area is 30580 square kilometers and its population is 217305 people. It includes ancient monuments like king Abdul-Aziz palace – may Allah have mercy on him.", 
                PortalLink = "http://www.alduwadimi.gov.sa/", PhoneNumber = "​0116421057",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new Governorate { Id = 5, NameAr = "محافظةالمجمعة", NameEn = "Al Majma'ah Governorate", 
                DescriptionAr = "و يحدها من الشمال المنطقة الشرقية و منطقة القصيم و من الجنوب محافظة ثادق ومحافظة شقراء و من الشرق محافظة رماح و من الغرب محافظة الزلفى و محافظة الغاط ، و تبلغ مساحتها 30000 كلم2 ـ و يبلغ عدد سكانها 133285 نسمة و من الأماكن التاريخية بمحافظة المجمعة قلعة قديمة تسمى _ المرقب .",
                DescriptionEn = "Its borders are the eastern region and Qaseem from the north, Thadig and Shaqra governorates from the south, Rammah governorate from the east, and Zulfi and Al-Ghat governorates from the west. Its area is 30000 square kilometers and its population is 133285 people. It includes ancient places like an ancient castle called Al-Marqab", 
                PortalLink = "http://www.almajmah.gov.sa/", PhoneNumber = "0164321000",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new Governorate { Id = 6, NameAr = "محافظةالقويعية", NameEn = "Al Quwaiiyah Governorate", 
                DescriptionAr = "و يحدها من الشمال محافظة الدوادمى و محافظة مرات و من الجنوب محافظة وادي الدواسر و من الشرق محافظة الحريق و محافظة المزاحمية و محافظة الأفلاج و من الغرب محافظة عفيف ، و تبلغ مساحتها 50580 كلم2 ـ و يبلغ عـدد سكانها 126161 نسمة .", 
                DescriptionEn = "It is borders are Al-Dawadmy governorate and Mrat village from the north, Wadi Al-Dawaser governorate from the south, Al-Hareeq, Al-Muzahmeya, and Al-Aflaj governorates from the east , and Affef governorate from the west. Its area is 50580 square kilometers and its population is 126161 people.", 
                PortalLink = "http://www.alquwayiyah.gov.sa/", PhoneNumber = "0116520830",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[6] = new Governorate { Id = 7, NameAr = "محافظة وادي الدواسر", NameEn = "Wadi ad-Dawasir Governorate", 
                DescriptionAr = "و يحدها من الشمال محافظة القويعية و من الجنوب منطقة نجران و من الشرق محافظة السليل و محافظة الأفلاج و من الغرب منطقة عسير ومنطقة مكة المكرمة ـ و تبلغ مساحتها 48900 كلم2 ـ و يبلغ عدد سكانها 106152 نسمة ، و من الآثار و الأماكن التاريخية في المحافظة ـ قصر الحكومة في الخماسين ـ و قصر باطوق و بهجة .", 
                DescriptionEn = "Its borders are Al-Quway’iah governorate from the north, Najran governorate from the south, Saleel and Al-Aflaj governorates from the east, and Aseer and Mecca from the west. Its area is 48900 square kilometers and its population is 106152 people. It includes historical monuments and places like Al-Khamaseen government palace and Batook and Bahga palace.", 
                PortalLink = "http://www.wadiaddawasir.gov.sa/", PhoneNumber = "0117840292",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[7] = new Governorate { Id = 8, NameAr = "محافظةالأفلاج", NameEn = "Al-Aflaj Governorate", 
                DescriptionAr = "و يحدها من الشمال محافظة الخرج و محافظة حوطة بنى تميم ومن الجنوب محافظة السليل و من الشرق المنطقة الشرقية و من الغرب محافظة وادي الدواسر و محافظة القويعية و تبلغ مساحتها 54120كم2 و يبلغ عدد سكانها حسب تعداد 1431هـ ـ 68201 نسمة ، و من الآثار و الأماكن التاريخية بالمحافظة ـ جبل التوباد ـ و قصر سلمى .", 
                DescriptionEn = "Its borders are Al-Kharj and Hotat Bani Tameem governorates from the north, Al-Saleel governorate from the south, the eastern region from the east, and Wadi Al-Dawaser and Al-Quway’iyah governorate from the west. Its area is 54120 square kilometers and its population is 68201 people according to 1431 census. It includes historical monuments and places like Tupad mountain and Salma palace.", 
                PortalLink = "http://www.alaflaj.gov.sa/", PhoneNumber = "0116820144",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[8] = new Governorate { Id = 9, NameAr = "محافظةالزلفي", NameEn = "Az Zulfi Governorate", 
                DescriptionAr = "و يحدها من الشمال و الغرب منطقة القصيم و من الجنوب محافظة الغاط ومن الشرق محافظة المجمعة و تبلغ مساحتها 5540 كلم 2 و يبلغ عدد سكانها 69294 نسمة .", 
                DescriptionEn = "borders are Qaseem region from the north and the west, Al-Ghat governorate from the south, and Al-Majma’ah governorate from the east. Its area is 5540 square kilometers and its population is 69294 people.", 
                PortalLink = "http://www.alzulfi.gov.sa/", PhoneNumber = "0164222222",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[9] = new Governorate {Id = 10, NameAr = "محافظة شـقراء", NameEn = "Shaqra Governorate", 
                DescriptionAr = "و يحدها من الشمال محافظة الغاط و من الجنوب محافظة مرات و من الشرق محافظة المجمعة و محافظة ثادق ومن الغرب محافظة الدوادمى ـ و تبلغ مساحتها 4110 كلم2 ـ و يبلغ عدد سكانها 40541 نسمة .", 
                DescriptionEn = "Its borders are Al-Ghat governorate from the north, Mrat village from the south, Al-Majma’ah and Thadeq governorates from the east, and Al-Dawadmy governorate from the west. Its area is 4110 square kilometers and its population is 40541 people.", 
                PortalLink = "http://www.shaqra.gov.sa/", PhoneNumber = "0116222225",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[10] = new Governorate { Id = 11, NameAr = "محافظة حوطة بني تميم", NameEn = "Howtat Bani Tamim Governorate", 
                DescriptionAr = "ويحدها من الشمال محافظة الخرج و محافظة الحريق و من الجنوب محافظة الأفلاج و من الشرق محافظة الخرج و الأفلاج و من الغرب محافظة الحريق ، و تبلغ مساحتها 7350كلم2 ـ و يبلغ عدد سكانها 43300 نسمة ، و يوجد بمركز الحلوة التابع لمحافظة حوطة بنى تميم قلعة الإمام تركي .", 
                DescriptionEn = "Its borders are Al-Kharj and Al-Hareeq governorates from the north, Al-Aflaj governorate from the south, Al-Kharj and Al-Aflaj governorates from the east, and Al-Hareeq governorate from the west. Its area is 7350 square kilometers and its population is 43300 people. In Al-Helwa village following Hotat Bani Tameem governorate, there is Imam Turki castle.",
                PortalLink = "http://www.alhotah.gov.sa/", PhoneNumber = "0115550624",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[11] = new Governorate { Id = 12, NameAr = "محافظة عفيـف", NameEn = "Afif Governorate", 
                DescriptionAr = "ويحدها من الشمال منطقة القصيم و من الجنوب منطقة مكة المكرمة و من الشرق محافظة القويعية و محافظة الدوادمى و من الغرب منطقة المدينة المنورة ـ و تبلغ مساحتها 26810 كلم2 ويبلغ عدد سكانها 77978 نسمة .", 
                DescriptionEn = "Its borders are Al-Qaseem region from the north, Mecca region from the south, Al-Quway’iya  and Al-Dawadmygovernorates from the east, and Medina region from the west. Its area is 26810 square kilometers and its population is 77978 people.", 
                PortalLink = "http://www.afif.gov.sa/", PhoneNumber = "0117221474",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[12] = new Governorate { Id = 13, NameAr = "محافظةالسليل", NameEn = "As Sulayyil Governorate",
                DescriptionAr = "و يحدها من الشمال محافظة الأفلاج و من الجنوب منطقة نجران و من الشرق المنطقة الشرقية و من الغرب محافظة وادي الدواسر و تبلغ مساحتها 42420كلم2 ـ و يبلغ عدد سكانها 36383 نسمة .",
                DescriptionEn = "Its borders are Al-Aflaj governorate from the north, Najran region from the south, the eastern region from the east, and Wadi Al-Dawaser governorate from the west. Its area is 42420 square kilometers and its population is 36383 people. It includes historical monuments like Al-Faw famous village.", 
                PortalLink = "http://www.alsulayyl.gov.sa/", PhoneNumber = "0117821965",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[13] = new Governorate { Id = 14, NameAr = "محافظة ضـرمـا", NameEn = "Dhurma Governorate",
                DescriptionAr = "يحدها من الشمال محافظة الدرعية و محافظة حريملاء ومن الجنوب محافظة المزاحمية و من الشرق مدينة الرياض و محافظة الدرعية ومن الغرب محافظة مرات ـ و تبلغ مساحتها 2060 كلم2 ـ و يبلغ عدد سكانها 24429 نسمة .",
                DescriptionEn = "Its borders are Deri’yah and Hraymla governorates from the north, Al-Muzahmeya governorate from the south, Riyadh city and Deri’yah governorate from the east, and Mrat village from the west. Its area is 2060 square kilometers and its population is 24429 people.", 
                PortalLink = "http://www.duruma.gov.sa/", PhoneNumber = "0115221204",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[14] = new Governorate { Id = 15, NameAr = "محافظةالمزاحمية", NameEn = "Al-Muzahmiya Governorate",
                DescriptionAr = "و يحدها من الشمال محافظة ضرما و من الجنوب محافظة الحريق و من الشرق مدينة الرياض و محافظة الخرج و من الغرب محافظة القويعية و وتبلغ مساحتها 3580 كلم2 ـ و يبلغ عدد سكانها 39865 نسمة .",
                DescriptionEn = "Its borders are Dharma governorate from the north, Al-Hareeq governorate from the south, Riyadh city and Al-Kharj governorate from the east, and Al-Quway’iyah governorate from the west. Its area is 3580 square kilometers and its population is 39865 people.", 
                PortalLink = "http://www.almuzahmiyah.gov.sa/", PhoneNumber = "0115230485",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[15] = new Governorate { Id = 16, NameAr = "محافظة رمـاح", NameEn = "Rumah Governorate", 
                DescriptionAr = "يحـدها من الشمال المنطقة الشرقية و من الجنوب مدينة الرياض و من الشرق المنطقة الشرقية و من الغرب محافظة المجمعة و محافظة ثادق ومحافظة حريملاء ـ و تبلغ مساحتها 15900 كلم2 ـ و يبلغ عدد سكانها 28055 نسمة .", 
                DescriptionEn = "Its borders are the eastern region from the north, Riyadh city from the south, the eastern region from the east, and Majma’ah, Thadig, and Hraymla governorates from the west. Its area is 15900 square kilometers and its population is 28055 people.", 
                PortalLink = "http://www.rumah.gov.sa/", PhoneNumber = "0115521166",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[16] = new Governorate { Id = 17, NameAr = "محافظة ثـادق", NameEn = "Thadiq Governorate", 
                DescriptionAr = " و يحدها من الشمال محافظة المجمعة و من الجنوب محافظة حريملاء و من الشرق محافظة حريملاء و من الغرب محافظة شقراء و محافظة مرات ـ و تبلغ مساحتها 5600 كلم2 ـ و يبلغ عدد سكانها 17165 نسمة .", 
                DescriptionEn = "Its borders are Al-Majma’ah governorate from the north, Hraymla governorate from the south, Hraymla governorate from the east, and Shaqra governorate and Mrat village from the west. Its area is 5600 square kilometers and its population is 17165 people.", 
                PortalLink = "http://www.thadiq.gov.sa/", PhoneNumber = "0164439670",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[17] = new Governorate { Id = 18, NameAr = "محافظة حـريملاء", NameEn = "Huraymila Governorate", 
                DescriptionAr = "و يحدها من الشمال محافظة رماح و محافظة ثادق و من الجنوب محافظة الدرعية و محافظة ضرما و من الشرق مدينة الرياض و محافظة رماح و من الغرب محافظة ثادق ـ وتبلغ مساحتها 1480 كلم2 ـ و يبلغ عدد سكانها 15324 نسمة ، و من الآثار التاريخية بمحافظة حريملاء ـ منزل الإمام محمد بن عبد الوهاب ـ و جامع القراشة و جبل القطار .", 
                DescriptionEn = "Its borders are Rmah and Thadig governorates from the north, Diri’yah and Dharma governorates from the south, Riyadh city and Rmah governorate from the east, and Thadig governorate from the west. Its area is 1480 square kilometers and its population is 15324 people. It includes historical monuments like Imam Muhammad bin Abdul-Wahab house, Al-Quarasha mosque, and Al-Qetar mountain.", 
                PortalLink = "http://www.huraymila.gov.sa/", PhoneNumber = "0115260540",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[18] = new Governorate { Id = 19, NameAr = "محافظةالحريق", NameEn = "Al Hariq Governorate",
                DescriptionAr = "و يحدها من الشمال محافظة المزاحمية و محافظة الخرج و من الجنوب محافظة حوطة بنى تميم و محافظة االأفلاج و من الشرق محافظة الخرج و محافظة حوطة بنى تميم و من الغرب محافظة القويعية و تبلغ مساحتها 6790كلم2 ـ و يبلغ عدد سكانها 14750 نسمة .", 
                DescriptionEn = "Its borders are Al-Muzahmeya and Al-Kharj governorates from the north, Hotat Bani Tammem and Al-Aflaj governorates from the south, Al-Kharj and Hotat Bani Tamaam governorates from the east, and Al-Quway’iyah governorate from the west. Its area is 6790 square kilometers and its population is 14750 people.",
                PortalLink = "http://www.alhariq.gov.sa/", PhoneNumber = "0115370449",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[19] = new Governorate { Id = 20, NameAr = "محافظةالغـاط", NameEn = "Al Ghat Governorate", 
                DescriptionAr = " و يحدها من الشمال محافظة الزلفى و من الجنوب محافظة شقراء و من الشرق محافظة المجمعة و من الغرب منطقة القصيم ـ و تبلغ مساحتها 2690 كلم2 .",
                DescriptionEn = "Its borders are Al-Zulfi governorate from the north, Shaqra governorate from the south, Al-Majma’ah governorate from the east, and Qaseem region from the west. Its area is 2690 square kilometers.", 
                PortalLink = "http://www.alghat.gov.sa/", PhoneNumber = "0164421011",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[20] = new Governorate { Id = 21, NameAr = "محافظة مرات", NameEn = "Marat Governorate", 
                DescriptionAr = @"تقع في منطقة الرياض إلى الشمال الغربي من مدينة الرياض بين دائرة عرض 40 - 25 درجة شمالاً وبين خط طول 45 - 45 درجة شرقاً تبعد عن مدينة الرياض : 143 كم تقريباً ، مساحتها الجغرافية حسب النطاق الإداري ( 90×100 كم) .
                                  يحد مرات من الجنوب محافظتا القويعية وضرما ، ومن الشمال محافظة شقراء ومن الشرق محافظتا ثادق وحريملاء ، ومن الغرب محافظة الدوادمي",
                DescriptionEn = @"It is located in the Riyadh region, to the northwest of the
                                  city of Riyadh, between latitude 40-25 degrees north and longitude 45-45 degrees east. It is approximately 143 km away from the city of Riyadh. Its geographical area is according to the administrative range (90 x 100 km)
                                  Murat is bordered on the south by the governorates of Al-Quway'iyah and Darma, on the north by Shaqra governorate, on the east by the governorates of Thadiq and Huraymila, and on the west by Al-Dawadmi governorate", 
                PhoneNumber = "0116231175",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[21] = new Governorate { Id = 22, NameAr = "محافظة الدلم", NameEn = "Ad-Dilam Governorate", 
                DescriptionAr = " يبلغ عدد سكان محافظة الدلم 80000 نسمة , ومن المعالم والاثار بمحافظة الدلم غار الامام تركي - موقعة الدلم عام 1320 هـ - سوق الدلم (المسحب) -جبل ابو ولد- غابة الضاحي - برج وسور الدلم - آثار وعيون خفس دغرة - منتزة وثيلان - آثار الفريع بزميقة .", 
                DescriptionEn = " The population of Ad Dilam Governorate is 80,000 people. Among the monuments and monuments in Ad Dilam Governorate are the Ghar of Imam Turki - the Battle of Ad Dilam in 1320 AH - the Ad Dilam Market (Al-Mashab) – Jabal Abu Walad – Al Dhahi Forest – Tower and Walls of Dulm – Ruins and Oyoun Khafs Dagra – Park and Thaylan – the ruins of Al-Fari’ Bzmika.", 
                PhoneNumber = "0115416115",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[22] = new Governorate { Id = 23, NameAr = "محافظة الرين", NameEn = "Rayn Governorate", 
                DescriptionAr = " تقع غرب مدينة الرياض ويحدها من الشمال محافظة المزاحمية ومن الجنوب محافظة وادي الدواسر ومن الشرق محافظة الحريق ومن الغرب محافظة القويعية ومن الجنوب الشرقي محافظة حوطة بني تميم ومحافظة الافلاج وتبلغ مساحتها 40 الف كلم2 تقريباً - ويبلغ عدد سكانها40 الف نسمة تقريباً ومن المعالم بمحافظة الرين (جبل دساس - جبال الحصاة - جبل بتران - جبال عريقية - وادي الرين - وادي الركا - وادي السرة - وادي العمق - هضبة الموزر)", 
                DescriptionEn = " It is located west of the city of Riyadh and is bordered to the north by Al-Muzahimiyah Governorate, to the south by Wadi Al-Dawasir Governorate, to the east by Al-Hariq Governorate, to the west by Al-Quway’iyah Governorate, to the southeast by Hotat Bani Tamim Governorate and Al-Aflaj Governorate, with an area of ​​approximately 40,000 km2 and a population of approximately 40,000 people. Dasas - Al-Hassa Mountains - Betran Mountain - Areqi Mountains - Wadi Al-Rain - Wadi Al-Raka - Wadi Al-Surra - Wadi Al-Amq - Al-Mozer Plateau)", 
                PhoneNumber = "0116590355",IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static Nationality[] Nationalities()
        {
            Nationality[] arrData = new Nationality[190];
            arrData[0] = new Nationality { Id = 1, NameAr = "الامارات العربية", NameEn = "Arab Emirates", IsActive = true, Code = "101", Iso2 = "ae", DialCode = "971", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new Nationality { Id = 2, NameAr = "الاردن", NameEn = "Jordan", IsActive = true, Code = "102", Iso2 = "jo", DialCode = "962", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new Nationality { Id = 3, NameAr = "البحرين", NameEn = "Bahrain", IsActive = true, Code = "103", Iso2 = "bh", DialCode = "973", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new Nationality { Id = 4, NameAr = "سوريا", NameEn = "Syria", IsActive = true, Code = "104", Iso2 = "sy", DialCode = "963", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new Nationality { Id = 5, NameAr = "العراق", NameEn = "Iraq", IsActive = true, Code = "105", Iso2 = "iq", DialCode = "964", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new Nationality { Id = 6, NameAr = "عمان", NameEn = "Oman", IsActive = true, Code = "106", Iso2 = "om", DialCode = "968", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[6] = new Nationality { Id = 7, NameAr = "فلسطين", NameEn = "Palestine", IsActive = true, Code = "107", Iso2 = "ps", DialCode = "970", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[7] = new Nationality { Id = 8, NameAr = "قطر", NameEn = "Qatar", IsActive = true, Code = "108", Iso2 = "qa", DialCode = "974", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[8] = new Nationality { Id = 9, NameAr = "الكويت", NameEn = "Kuwait", IsActive = true, Code = "109", Iso2 = "kw", DialCode = "965", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[9] = new Nationality { Id = 10, NameAr = "لبنان", NameEn = "Lebanon", IsActive = true, Code = "110", Iso2 = "lb", DialCode = "961", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[10] = new Nationality { Id = 11, NameAr = "اليمن", NameEn = "Yemen", IsActive = true, Code = "111", Iso2 = "ye", DialCode = "967", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[11] = new Nationality { Id = 12, NameAr = "العربية السعودية", NameEn = "Saudi Arabia", IsActive = true, Code = "113", Iso2 = "sa", DialCode = "966", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[12] = new Nationality { Id = 13, NameAr = "تونس", NameEn = "Tunisia", IsActive = true, Code = "201", Iso2 = "tn", DialCode = "216", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[13] = new Nationality { Id = 14, NameAr = "الجزائر", NameEn = "Algeria", IsActive = true, Code = "202", Iso2 = "dz", DialCode = "213", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[14] = new Nationality { Id = 15, NameAr = "جيبوتى", NameEn = "Djibouti", IsActive = true, Code = "203", Iso2 = "dj", DialCode = "253", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[15] = new Nationality { Id = 16, NameAr = "السودان", NameEn = "Sudan", IsActive = true, Code = "204", Iso2 = "sd", DialCode = "249", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[16] = new Nationality { Id = 17, NameAr = "الصومال", NameEn = "Somalia", IsActive = true, Code = "205", Iso2 = "so", DialCode = "252", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[17] = new Nationality { Id = 18, NameAr = "ليبيا", NameEn = "Libya", IsActive = true, Code = "206", Iso2 = "ly", DialCode = "218", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[18] = new Nationality { Id = 19, NameAr = "مصر", NameEn = "Egypt", IsActive = true, Code = "207", Iso2 = "eg", DialCode = "20", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[19] = new Nationality { Id = 20, NameAr = "المغرب", NameEn = "Morocco", IsActive = true, Code = "208", Iso2 = "ma", DialCode = "212", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[20] = new Nationality { Id = 21, NameAr = "موريتانيا", NameEn = "Mauritania", IsActive = true, Code = "209", Iso2 = "mr", DialCode = "222", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[21] = new Nationality { Id = 22, NameAr = "افغانستان", NameEn = "Afghanistan", IsActive = true, Code = "301", Iso2 = "af", DialCode = "93", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[22] = new Nationality { Id = 23, NameAr = "اندونيسيا", NameEn = "Indonesia", IsActive = true, Code = "302", Iso2 = "id", DialCode = "62", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[23] = new Nationality { Id = 24, NameAr = "ايران", NameEn = "Iran", IsActive = true, Code = "303", Iso2 = "ir", DialCode = "98", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[24] = new Nationality { Id = 25, NameAr = "باكستان", NameEn = "Pakistan", IsActive = true, Code = "304", Iso2 = "pk", DialCode = "92", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[25] = new Nationality { Id = 26, NameAr = "بنجلاديش", NameEn = "Bangladesh", IsActive = true, Code = "305", Iso2 = "bd", DialCode = "880", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[26] = new Nationality { Id = 27, NameAr = "بروني", NameEn = "Brunei", IsActive = true, Code = "306", Iso2 = "bn", DialCode = "673", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[27] = new Nationality { Id = 28, NameAr = "جمهورية ميانمار", NameEn = "Myanmar", IsActive = true, Code = "307", Iso2 = "mm", DialCode = "95", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[28] = new Nationality { Id = 29, NameAr = "تايلند", NameEn = "Thailand", IsActive = true, Code = "308", Iso2 = "th", DialCode = "66", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[29] = new Nationality { Id = 30, NameAr = "تركيا", NameEn = "Turkey", IsActive = true, Code = "309", Iso2 = "tr", DialCode = "90", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[30] = new Nationality { Id = 31, NameAr = "جزر مالديف", NameEn = "Maldives", IsActive = true, Code = "310", Iso2 = "mv", DialCode = "960", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[31] = new Nationality { Id = 32, NameAr = "روسيا الاتحادية", NameEn = "Russia", IsActive = true, Code = "311", Iso2 = "ru", DialCode = "7", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[32] = new Nationality { Id = 33, NameAr = "سنغافورة", NameEn = "Singapore", IsActive = true, Code = "312", Iso2 = "sg", DialCode = "65", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[33] = new Nationality { Id = 34, NameAr = "سري لنكا", NameEn = "Sri Lanka", IsActive = true, Code = "313", Iso2 = "lk", DialCode = "94", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[34] = new Nationality { Id = 35, NameAr = "الفلبين", NameEn = "Philippines", IsActive = true, Code = "315", Iso2 = "ph", DialCode = "63", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[35] = new Nationality { Id = 36, NameAr = "فيتنام", NameEn = "Vietnam", IsActive = true, Code = "316", Iso2 = "vn", DialCode = "84", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[36] = new Nationality { Id = 37, NameAr = "كمبوديا", NameEn = "Cambodia", IsActive = true, Code = "317", Iso2 = "kh", DialCode = "855", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[37] = new Nationality { Id = 38, NameAr = "كوريا الجنوبية", NameEn = "South Korea", IsActive = true, Code = "318", Iso2 = "kr", DialCode = "82", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[38] = new Nationality { Id = 39, NameAr = "ماليزيا", NameEn = "Malaysia", IsActive = true, Code = "319", Iso2 = "my", DialCode = "60", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[39] = new Nationality { Id = 40, NameAr = "نيبال", NameEn = "Nepal", IsActive = true, Code = "320", Iso2 = "np", DialCode = "977", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[40] = new Nationality { Id = 41, NameAr = "الهند", NameEn = "India", IsActive = true, Code = "321", Iso2 = "in", DialCode = "91", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[41] = new Nationality { Id = 42, NameAr = "هونج كونج", NameEn = "Hong Kong", IsActive = true, Code = "322", Iso2 = "hk", DialCode = "852", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[42] = new Nationality { Id = 43, NameAr = "اليابان", NameEn = "Japan", IsActive = true, Code = "323", Iso2 = "jp", DialCode = "81", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[43] = new Nationality { Id = 44, NameAr = "بهوتان", NameEn = "Bhutan", IsActive = true, Code = "324", Iso2 = "bt", DialCode = "975", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[44] = new Nationality { Id = 45, NameAr = "الصين الشعبية", NameEn = "China", IsActive = true, Code = "325", Iso2 = "cn", DialCode = "86", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[45] = new Nationality { Id = 46, NameAr = "قبرص", NameEn = "Cyprus", IsActive = true, Code = "326", Iso2 = "cy", DialCode = "357", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[46] = new Nationality { Id = 47, NameAr = "كوريا الشمالية", NameEn = "North Korea", IsActive = true, Code = "328", Iso2 = "kp", DialCode = "850", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[47] = new Nationality { Id = 48, NameAr = "لاوس", NameEn = "Laos", IsActive = true, Code = "329", Iso2 = "la", DialCode = "856", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[48] = new Nationality { Id = 49, NameAr = "منغوليا", NameEn = "Mongolia", IsActive = true, Code = "330", Iso2 = "mn", DialCode = "976", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[49] = new Nationality { Id = 50, NameAr = "ماكاو", NameEn = "Macao", IsActive = true, Code = "331", Iso2 = "mo", DialCode = "853", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[50] = new Nationality { Id = 51, NameAr = "تركستان", NameEn = "Turkistan", IsActive = false, Code = "332", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[51] = new Nationality { Id = 52, NameAr = "القبائل النازحة", NameEn = "Tribes Emigrated", IsActive = false, Code = "335", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[52] = new Nationality { Id = 53, NameAr = "كازاخستان", NameEn = "Kazakhstan", IsActive = true, Code = "336", Iso2 = "kz", DialCode = "7", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[53] = new Nationality { Id = 54, NameAr = "ازبكستان", NameEn = "Uzbekistan", IsActive = true, Code = "337", Iso2 = "uz", DialCode = "998", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[54] = new Nationality { Id = 55, NameAr = "تركمانستان", NameEn = "Turkmenistan", IsActive = true, Code = "338", Iso2 = "tm", DialCode = "993", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[55] = new Nationality { Id = 56, NameAr = "طاجكستان", NameEn = "Tajikistan", IsActive = true, Code = "339", Iso2 = "tj", DialCode = "992", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[56] = new Nationality { Id = 57, NameAr = "قرغيزستان", NameEn = "kyrgyzstan", IsActive = false, Code = "340", Iso2 = "kg", DialCode = "996", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[57] = new Nationality { Id = 58, NameAr = "اذربيجان", NameEn = "Azerbaijan", IsActive = true, Code = "343", Iso2 = "az", DialCode = "994", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[58] = new Nationality { Id = 59, NameAr = "الشاشان", NameEn = "Chechnya", IsActive = false, Code = "344", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[59] = new Nationality { Id = 60, NameAr = "داغستان", NameEn = "Dagestan", IsActive = false, Code = "345", Iso2 = "da", DialCode = "872", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[60] = new Nationality { Id = 61, NameAr = "انقوش", NameEn = "Anquosh", IsActive = false, Code = "346", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[61] = new Nationality { Id = 62, NameAr = "تتارستان", NameEn = "Tatarstan", IsActive = false, Code = "347", Iso2 = "ta", DialCode = "7", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[62] = new Nationality { Id = 63, NameAr = "تيمور الشرقية", NameEn = "East Timor", IsActive = false, Code = "349", Iso2 = "tp", DialCode = "670", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[63] = new Nationality { Id = 64, NameAr = "اثيوبيا", NameEn = "Ethiopia", IsActive = true, Code = "401", Iso2 = "et", DialCode = "251", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[64] = new Nationality { Id = 65, NameAr = "اوغندة", NameEn = "Uganda", IsActive = true, Code = "402", Iso2 = "ug", DialCode = "256", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[65] = new Nationality { Id = 66, NameAr = "بوتسوانا", NameEn = "Botswana", IsActive = true, Code = "403", Iso2 = "bw", DialCode = "267", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[66] = new Nationality { Id = 67, NameAr = "بورندي", NameEn = "Burundi", IsActive = true, Code = "404", Iso2 = "bi", DialCode = "257", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[67] = new Nationality { Id = 68, NameAr = "تشاد", NameEn = "Chad", IsActive = true, Code = "405", Iso2 = "td", DialCode = "235", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[68] = new Nationality { Id = 69, NameAr = "تنزانيا", NameEn = "Tanzania", IsActive = true, Code = "406", Iso2 = "tz", DialCode = "255", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[69] = new Nationality { Id = 70, NameAr = "توجو", NameEn = "Togo", IsActive = true, Code = "407", Iso2 = "tg", DialCode = "228", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[70] = new Nationality { Id = 71, NameAr = "جابون", NameEn = "Answer", IsActive = true, Code = "408", Iso2 = "ga", DialCode = "241", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[71] = new Nationality { Id = 72, NameAr = "غامبيا", NameEn = "Gambia", IsActive = true, Code = "409", Iso2 = "gm", DialCode = "220", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[72] = new Nationality { Id = 73, NameAr = "جزر القمر", NameEn = "Comoros", IsActive = true, Code = "410", Iso2 = "km", DialCode = "269", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[73] = new Nationality { Id = 74, NameAr = "جنوب افريقيا", NameEn = "South Africa", IsActive = true, Code = "411", Iso2 = "za", DialCode = "27", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[74] = new Nationality { Id = 75, NameAr = "ناميبيا", NameEn = "Namibia", IsActive = true, Code = "412", Iso2 = "na", DialCode = "264", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[75] = new Nationality { Id = 76, NameAr = "بنين", NameEn = "Benin", IsActive = true, Code = "413", Iso2 = "bj", DialCode = "229", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[76] = new Nationality { Id = 77, NameAr = "رواندا", NameEn = "Rwanda", IsActive = true, Code = "414", Iso2 = "rw", DialCode = "250", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[77] = new Nationality { Id = 78, NameAr = "زمبابوي", NameEn = "Zimbabwe", IsActive = true, Code = "415", Iso2 = "zw", DialCode = "263", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[78] = new Nationality { Id = 79, NameAr = "زائير", NameEn = "Zaire", IsActive = false, Code = "416", Iso2 = "zr", DialCode = "243", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[79] = new Nationality { Id = 80, NameAr = "زامبيا", NameEn = "Zambia", IsActive = true, Code = "417", Iso2 = "zm", DialCode = "260", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[80] = new Nationality { Id = 81, NameAr = "ساحل العاج", NameEn = "Ivory Coast", IsActive = false, Code = "418", Iso2 = "ci", DialCode = "225", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[81] = new Nationality { Id = 82, NameAr = "السنغال", NameEn = "Senegal", IsActive = true, Code = "419", Iso2 = "sn  221", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[82] = new Nationality { Id = 83, NameAr = "سيراليون", NameEn = "Sierra Leone", IsActive = true, Code = "420", Iso2 = "sl", DialCode = "232", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[83] = new Nationality { Id = 84, NameAr = "غانا", NameEn = "Ghana", IsActive = true, Code = "421", Iso2 = "gh", DialCode = "233", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[84] = new Nationality { Id = 85, NameAr = "غينيا", NameEn = "Guinea", IsActive = true, Code = "422", Iso2 = "gn", DialCode = "224", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[85] = new Nationality { Id = 86, NameAr = "غينيابيساو", NameEn = "Guinea Bissau", IsActive = true, Code = "423", Iso2 = "gw", DialCode = "245", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[86] = new Nationality { Id = 87, NameAr = "بوركينافاسو", NameEn = "Burkina Faso", IsActive = true, Code = "424", Iso2 = "bf", DialCode = "226", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[87] = new Nationality { Id = 88, NameAr = "الكاميرون", NameEn = "Cameroon", IsActive = true, Code = "425", Iso2 = "cm", DialCode = "237", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[88] = new Nationality { Id = 89, NameAr = "جمهورية الكونغو الديمقراطية", NameEn = "Congo(DRC)", IsActive = true, Code = "426", Iso2 = "cd", DialCode = "243", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[89] = new Nationality { Id = 90, NameAr = "كينيا", NameEn = "Kenya", IsActive = true, Code = "427", Iso2 = "ke", DialCode = "254", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[90] = new Nationality { Id = 91, NameAr = "ليسوتو", NameEn = "Lesotho", IsActive = true, Code = "428", Iso2 = "ls", DialCode = "266", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[91] = new Nationality { Id = 92, NameAr = "ليبيريا", NameEn = "Liberia", IsActive = true, Code = "429", Iso2 = "lr", DialCode = "231", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[92] = new Nationality { Id = 93, NameAr = "مالي", NameEn = "Mali", IsActive = true, Code = "430", Iso2 = "ml", DialCode = "223", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[93] = new Nationality { Id = 94, NameAr = "ملاوي", NameEn = "Malawi", IsActive = true, Code = "432", Iso2 = "mw", DialCode = "265", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[94] = new Nationality { Id = 95, NameAr = "موريشيوس", NameEn = "Mauritius", IsActive = true, Code = "433", Iso2 = "mu", DialCode = "230", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[95] = new Nationality { Id = 96, NameAr = "موزمبيق", NameEn = "Mozambique", IsActive = true, Code = "434", Iso2 = "mz", DialCode = "258", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[96] = new Nationality { Id = 97, NameAr = "نيجيريا", NameEn = "Nigeria", IsActive = true, Code = "435", Iso2 = "ng", DialCode = "234", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[97] = new Nationality { Id = 98, NameAr = "النيجر", NameEn = "Niger", IsActive = true, Code = "436", Iso2 = "ne", DialCode = "227", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[98] = new Nationality { Id = 99, NameAr = "افريقيا الوسطى", NameEn = "Central Africa", IsActive = true, Code = "437", Iso2 = "cf", DialCode = "236", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[99] = new Nationality { Id = 100, NameAr = "انجولا", NameEn = "Angola", IsActive = true, Code = "438", Iso2 = "ao", DialCode = "244", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[100] = new Nationality { Id = 101, NameAr = "الجزر الكاريبية الهولندية", NameEn = "Caribbean Netherlands", IsActive = true, Code = "439", Iso2 = "bq", DialCode = "599", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[101] = new Nationality { Id = 102, NameAr = "غينيا الاستوائية", NameEn = "Equatorial Guinea", IsActive = true, Code = "440", Iso2 = "gq", DialCode = "240", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[102] = new Nationality { Id = 103, NameAr = "ملاجاسي", NameEn = "Mlajasi", IsActive = false, Code = "441", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[103] = new Nationality { Id = 104, NameAr = "ساوتومي/برنسبى", NameEn = "S? o Tomé and Pr? ncipe", IsActive = true, Code = "442", Iso2 = "st", DialCode = "239", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[104] = new Nationality { Id = 105, NameAr = "جزر سيشل", NameEn = "Seychelles Islands", IsActive = true, Code = "443", Iso2 = "sc", DialCode = "248", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[105] = new Nationality { Id = 106, NameAr = "سوزيلاند", NameEn = "Swaziland", IsActive = false, Code = "444", Iso2 = "sz", DialCode = "268", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[106] = new Nationality { Id = 107, NameAr = "ارتيريا", NameEn = "Eritrea", IsActive = true, Code = "449", Iso2 = "er", DialCode = "291", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[107] = new Nationality { Id = 108, NameAr = "جمهورية جنوب السودان", NameEn = "Republic of South Sudan", IsActive = false, Code = "453", Iso2 = "ss", DialCode = "211", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[108] = new Nationality { Id = 109, NameAr = "كاب فيرد(الراس الاخضر)", NameEn = "Cape Verde", IsActive = true, Code = "454", Iso2 = "cv", DialCode = "238", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[109] = new Nationality { Id = 110, NameAr = "اسبانيا", NameEn = "Spain", IsActive = true, Code = "501", Iso2 = "es", DialCode = "34", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[110] = new Nationality { Id = 111, NameAr = "البانيا", NameEn = "Albania", IsActive = true, Code = "502", Iso2 = "al", DialCode = "355", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[111] = new Nationality { Id = 112, NameAr = "المانيا", NameEn = "Germany", IsActive = true, Code = "503", Iso2 = "de", DialCode = "49", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[112] = new Nationality { Id = 113, NameAr = "ايرلندا", NameEn = "Ireland", IsActive = true, Code = "504", Iso2 = "ie", DialCode = "353", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[113] = new Nationality { Id = 114, NameAr = "ايطاليا", NameEn = "Italy", IsActive = true, Code = "505", Iso2 = "it", DialCode = "39", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[114] = new Nationality { Id = 115, NameAr = "المملكة المتحدة", NameEn = "United Kingdom", IsActive = true, Code = "506", Iso2 = "gb", DialCode = "44", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[115] = new Nationality { Id = 116, NameAr = "البرتغال", NameEn = "Portugal", IsActive = true, Code = "507", Iso2 = "pt", DialCode = "351", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[116] = new Nationality { Id = 117, NameAr = "بلغاريا", NameEn = "Bulgaria", IsActive = true, Code = "508", Iso2 = "bg", DialCode = "359", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[117] = new Nationality { Id = 118, NameAr = "بلجيكا", NameEn = "Belgium", IsActive = true, Code = "509", Iso2 = "be", DialCode = "32", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[118] = new Nationality { Id = 119, NameAr = "بولندا", NameEn = "Poland", IsActive = true, Code = "510", Iso2 = "pl", DialCode = "48", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[119] = new Nationality { Id = 120, NameAr = "الدانمارك", NameEn = "Denmark", IsActive = true, Code = "512", Iso2 = "dk", DialCode = "45", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[120] = new Nationality { Id = 121, NameAr = "رومانيا", NameEn = "Romania", IsActive = true, Code = "513", Iso2 = "ro", DialCode = "40", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[121] = new Nationality { Id = 122, NameAr = "السويد", NameEn = "Sweden", IsActive = true, Code = "514", Iso2 = "se", DialCode = "46", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[122] = new Nationality { Id = 123, NameAr = "سويسرا", NameEn = "Switzerland", IsActive = true, Code = "515", Iso2 = "ch", DialCode = "41", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[123] = new Nationality { Id = 124, NameAr = "فرنسا", NameEn = "France", IsActive = true, Code = "516", Iso2 = "fr", DialCode = "33", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[124] = new Nationality { Id = 125, NameAr = "فنلندا", NameEn = "Finland", IsActive = true, Code = "517", Iso2 = "fi", DialCode = "358", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[125] = new Nationality { Id = 126, NameAr = "صربيا", NameEn = "Serbia", IsActive = true, Code = "518", Iso2 = "rs", DialCode = "381", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[126] = new Nationality { Id = 127, NameAr = "هولندا", NameEn = "Netherlands", IsActive = true, Code = "519", Iso2 = "nl", DialCode = "31", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[127] = new Nationality { Id = 128, NameAr = "اليونان", NameEn = "Greece", IsActive = true, Code = "521", Iso2 = "gr", DialCode = "30", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[128] = new Nationality { Id = 129, NameAr = "اندورا", NameEn = "Andorra", IsActive = true, Code = "522", Iso2 = "ad", DialCode = "376", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[129] = new Nationality { Id = 130, NameAr = "النمسا", NameEn = "Austria", IsActive = true, Code = "523", Iso2 = "at", DialCode = "43", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[130] = new Nationality { Id = 131, NameAr = "الجبل الأ سود", NameEn = "Montenegro", IsActive = true, Code = "524", Iso2 = "me", DialCode = "382", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[131] = new Nationality { Id = 132, NameAr = "هنغاريا", NameEn = "Hungary", IsActive = true, Code = "525", Iso2 = "hu", DialCode = "36", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[132] = new Nationality { Id = 133, NameAr = "ايسلندا", NameEn = "Iceland", IsActive = true, Code = "526", Iso2 = "is", DialCode = "354", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[133] = new Nationality { Id = 134, NameAr = "ليختنشتين", NameEn = "Liechtenstein", IsActive = true, Code = "527", Iso2 = "li", DialCode = "423", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[134] = new Nationality { Id = 135, NameAr = "لوكسمبورغ", NameEn = "Luxembourg", IsActive = true, Code = "528", Iso2 = "lu", DialCode = "352", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[135] = new Nationality { Id = 136, NameAr = "مالطا", NameEn = "Malta", IsActive = true, Code = "529", Iso2 = "mt", DialCode = "356", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[136] = new Nationality { Id = 137, NameAr = "موناكو", NameEn = "Monaco", IsActive = true, Code = "530", Iso2 = "mc", DialCode = "377", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[137] = new Nationality { Id = 138, NameAr = "النرويج", NameEn = "Norway", IsActive = true, Code = "531", Iso2 = "no", DialCode = "47", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[138] = new Nationality { Id = 139, NameAr = "سان مارينو", NameEn = "San Marino", IsActive = true, Code = "532", Iso2 = "sm", DialCode = "378", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[139] = new Nationality { Id = 140, NameAr = "مدينة الفاتيكان", NameEn = "Vatican City", IsActive = true, Code = "533", Iso2 = "va", DialCode = "39", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[140] = new Nationality { Id = 141, NameAr = "جبل طارق", NameEn = "Gibraltar", IsActive = true, Code = "534", Iso2 = "gi", DialCode = "350", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[141] = new Nationality { Id = 142, NameAr = "اوكرانيا", NameEn = "Ukraine", IsActive = true, Code = "536", Iso2 = "ua", DialCode = "380", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[142] = new Nationality { Id = 143, NameAr = "روسيا البيضاء", NameEn = "Byelorussia", IsActive = false, Code = "537", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[143] = new Nationality { Id = 144, NameAr = "ارمينيا", NameEn = "Armenia", IsActive = true, Code = "539", Iso2 = "am", DialCode = "374", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[144] = new Nationality { Id = 145, NameAr = "مولدافيا", NameEn = "Moldova", IsActive = true, Code = "540", Iso2 = "md", DialCode = "373", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[145] = new Nationality { Id = 146, NameAr = "جورجيا", NameEn = "Georgia", IsActive = true, Code = "541", Iso2 = "ge", DialCode = "995", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[146] = new Nationality { Id = 147, NameAr = "ليتوانيا", NameEn = "Lithuania", IsActive = true, Code = "542", Iso2 = "lt", DialCode = "370", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[147] = new Nationality { Id = 148, NameAr = "استونيا", NameEn = "Estonia", IsActive = true, Code = "543", Iso2 = "ee", DialCode = "372", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[148] = new Nationality { Id = 149, NameAr = "لاتفيا", NameEn = "Latvia", IsActive = true, Code = "544", Iso2 = "lv", DialCode = "371", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[149] = new Nationality { Id = 150, NameAr = "البوسنة والهرسك", NameEn = "Bosnia / Herzegovina", IsActive = true, Code = "545", Iso2 = "ba", DialCode = "387", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[150] = new Nationality { Id = 151, NameAr = "كرواتيا", NameEn = "Croatia", IsActive = true, Code = "546", Iso2 = "hr", DialCode = "385", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[151] = new Nationality { Id = 152, NameAr = "سلوفينيا", NameEn = "Slovenia", IsActive = true, Code = "547", Iso2 = "si", DialCode = "386", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[152] = new Nationality { Id = 153, NameAr = "مقدونيا", NameEn = "Macedonia", IsActive = true, Code = "549", Iso2 = "mk", DialCode = "389", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[153] = new Nationality { Id = 154, NameAr = "تشيك", NameEn = "Czech Republic", IsActive = true, Code = "552", Iso2 = "cz", DialCode = "420", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[154] = new Nationality { Id = 155, NameAr = "سلوفاكيا", NameEn = "Slovakia", IsActive = true, Code = "553", Iso2 = "sk", DialCode = "421", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[155] = new Nationality { Id = 156, NameAr = "جزر فيرو", NameEn = "Faroe Islands", IsActive = true, Code = "554", Iso2 = "fo", DialCode = "298", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[156] = new Nationality { Id = 157, NameAr = "ميتروبوليتان فرنسية", NameEn = "France Metropolitan", IsActive = false, Code = "555", Iso2 = "fx", DialCode = "33", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[157] = new Nationality { Id = 158, NameAr = "الولايات المتحدة", NameEn = "United States", IsActive = true, Code = "601", Iso2 = "us", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[158] = new Nationality { Id = 159, NameAr = "الارجنتين", NameEn = "Argentina", IsActive = true, Code = "602", Iso2 = "ar", DialCode = "54", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[159] = new Nationality { Id = 160, NameAr = "بربادوس", NameEn = "Barbados", IsActive = true, Code = "603", Iso2 = "bb", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[160] = new Nationality { Id = 161, NameAr = "البرازيل", NameEn = "Brazil", IsActive = true, Code = "604", Iso2 = "br", DialCode = "55", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[161] = new Nationality { Id = 162, NameAr = "بنما", NameEn = "Panama", IsActive = true, Code = "605", Iso2 = "pa", DialCode = "507", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[162] = new Nationality { Id = 163, NameAr = "ترينداد وتوباجو", NameEn = "Trinidad and Tobago", IsActive = true, Code = "606", Iso2 = "tt", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[163] = new Nationality { Id = 164, NameAr = "جامايكا", NameEn = "Jamaica", IsActive = true, Code = "607", Iso2 = "jm", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[164] = new Nationality { Id = 165, NameAr = "جوانا", NameEn = "Joanna", IsActive = false, Code = "608", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[165] = new Nationality { Id = 166, NameAr = "فنزويلا", NameEn = "Venezuela", IsActive = true, Code = "609", Iso2 = "ve", DialCode = "58", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[166] = new Nationality { Id = 167, NameAr = "كندا", NameEn = "Canada", IsActive = true, Code = "610", Iso2 = "ca", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[167] = new Nationality { Id = 168, NameAr = "كولمبيا", NameEn = "Columbia", IsActive = true, Code = "611", Iso2 = "co", DialCode = "57", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[168] = new Nationality { Id = 169, NameAr = "جزر البهاما", NameEn = "Bahamas", IsActive = true, Code = "612", Iso2 = "bs", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[169] = new Nationality { Id = 170, NameAr = "كوستاريكا", NameEn = "Costa Rica", IsActive = true, Code = "613", Iso2 = "cr", DialCode = "506", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[170] = new Nationality { Id = 171, NameAr = "كوبا", NameEn = "Cuba", IsActive = true, Code = "614", Iso2 = "cu", DialCode = "53", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[171] = new Nationality { Id = 172, NameAr = "دومينيكا", NameEn = "Dominica", IsActive = true, Code = "615", Iso2 = "dm", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[172] = new Nationality { Id = 173, NameAr = "جمهورية دمينكان", NameEn = "Republic Dominica", IsActive = true, Code = "616", Iso2 = "do", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[173] = new Nationality { Id = 174, NameAr = "السلفادور", NameEn = "El Salvador", IsActive = true, Code = "617", Iso2 = "sv", DialCode = "503", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[174] = new Nationality { Id = 175, NameAr = "جرانادا", NameEn = "Granada", IsActive = true, Code = "618", Iso2 = "gd", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[175] = new Nationality { Id = 176, NameAr = "جواتيمالا", NameEn = "Guatemala", IsActive = true, Code = "619", Iso2 = "gt", DialCode = "502", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[176] = new Nationality { Id = 177, NameAr = "هايتي", NameEn = "Haiti", IsActive = true, Code = "620", Iso2 = "ht", DialCode = "509", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[177] = new Nationality { Id = 178, NameAr = "هوندوراس", NameEn = "Honduras", IsActive = true, Code = "621", Iso2 = "hn", DialCode = "504", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[178] = new Nationality { Id = 179, NameAr = "المكسيك", NameEn = "Mexico", IsActive = true, Code = "622", Iso2 = "mx", DialCode = "52", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[179] = new Nationality { Id = 180, NameAr = "نيكاراجوا", NameEn = "Nicaragua", IsActive = true, Code = "623", Iso2 = "ni", DialCode = "505", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[180] = new Nationality { Id = 181, NameAr = "سانت لوسيا", NameEn = "Saint Lucia", IsActive = true, Code = "624", Iso2 = "lc", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[181] = new Nationality { Id = 182, NameAr = "سان فينسنت", NameEn = "Saint Vincent", IsActive = true, Code = "625", Iso2 = "vc", DialCode = "1", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[182] = new Nationality { Id = 183, NameAr = "بوليفيا", NameEn = "Bolivia", IsActive = true, Code = "626", Iso2 = "bo", DialCode = "591", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[183] = new Nationality { Id = 184, NameAr = "شيلي", NameEn = "Chile", IsActive = true, Code = "627", Iso2 = "cl", DialCode = "56", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[184] = new Nationality { Id = 185, NameAr = "اكوادور", NameEn = "Ecuador", IsActive = true, Code = "628", Iso2 = "ec", DialCode = "593", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[185] = new Nationality { Id = 186, NameAr = "باراجواي", NameEn = "Paraguay", IsActive = true, Code = "629", Iso2 = "py", DialCode = "595", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[186] = new Nationality { Id = 187, NameAr = "بيرو", NameEn = "Peru", IsActive = true, Code = "630", Iso2 = "pe", DialCode = "51", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[187] = new Nationality { Id = 188, NameAr = "استراليا", NameEn = "Australia", IsActive = true, Code = "701", Iso2 = "au", DialCode = "61", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[188] = new Nationality { Id = 189, NameAr = "نيوزيلندا", NameEn = "New Zealand", IsActive = true, Code = "702", Iso2 = "nz", DialCode = "64", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[189] = new Nationality { Id = 190, NameAr = "أوروغواي", NameEn = "Uruguay", IsActive = true, Code = "703", Iso2 = "yu", DialCode = "598", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            return arrData;
        }
        public static OpenDataCateguery[] OpenDataCategueries()
        {
            OpenDataCateguery[] arrData = new OpenDataCateguery[4];
            arrData[0] = new OpenDataCateguery { Id = 1, NameAr = "تقارير الخدمات الإلكترونية", NameEn = "E-Services Reports", OpenDataSubCategueryId = 2, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new OpenDataCateguery { Id = 2, NameAr = "تقارير المعاملات", NameEn = "Transaction Reports", OpenDataSubCategueryId = 2, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new OpenDataCateguery { Id = 3, NameAr = "المعاملات لصفة صاحب المعاملة", NameEn = "Transactions for the owner of the transaction", OpenDataSubCategueryId = 2, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new OpenDataCateguery { Id = 4, NameAr = "الحصر", NameEn = "Limitation", OpenDataSubCategueryId = 1, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static OpenDataSubCateguery[] OpenDataSubCategueries()
        {
            OpenDataSubCateguery[] arrData = new OpenDataSubCateguery[4];
            arrData[0] = new OpenDataSubCateguery { Id = 1, NameAr = "سنوي", NameEn = "Annual", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new OpenDataSubCateguery { Id = 2, NameAr = "نصف سنوي", NameEn = "Semi-annual", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new OpenDataSubCateguery { Id = 3, NameAr = "ربع سنوي", NameEn = "Quarterly", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new OpenDataSubCateguery { Id = 4, NameAr = "شهري", NameEn = "Monthly", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }

        public static Poster[] Posters()
        {
            Poster[] arrData = new Poster[1];
            arrData[0] = new Poster { Id = 1, TitleAr = "يوم بدينا", TitleEn = "Day We Start", Order = 1, ImageName = "slider.png", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static Stage[] Stages()
        {
            Stage[] arrData = new Stage[7];
            arrData[0] = new Stage { Id = 1, NameAr = "مسودة", NameEn = "Draft", CanEdit = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new Stage { Id = 2, NameAr = "طلب جديد", NameEn = "New Request", CanEdit = false, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new Stage { Id = 3, NameAr = "استكمال البيانات من مقدم الطلب", NameEn = "Complete Data From Requester", CanEdit = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new Stage { Id = 4, NameAr = "تحت الإجراء", NameEn = "Under Processing", CanEdit = false, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new Stage { Id = 5, NameAr = "الطلب مرفوض من مدير النظام", NameEn = "Request Rejected From Admin", CanEdit = false, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new Stage { Id = 6, NameAr = "الطلب مرفوض", NameEn = "Request Rejected", CanEdit = false, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[6] = new Stage { Id = 7, NameAr = "الطلب معتمد", NameEn = "Request Approved", CanEdit = false, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static RequestType[] RequestTypes()
        {
            RequestType[] arrData = new RequestType[35];
            arrData[0] = new RequestType { Id = 1, NameAr = "حضور زواج", NameEn = "حضور زواج", ServiceId = 2, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new RequestType { Id = 2, NameAr = "زيارة الوالدين والأهل", NameEn = "زيارة الوالدين والأهل", ServiceId = 2, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new RequestType { Id = 3, NameAr = "زيارة مريض", NameEn = "زيارة مريض", ServiceId = 2, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new RequestType { Id = 4, NameAr = "تسجيل في الجامعة", NameEn = "تسجيل في الجامعة", ServiceId = 2, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new RequestType { Id = 5, NameAr = "عزاء", NameEn = "عزاء", ServiceId = 2, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new RequestType { Id = 6, NameAr = "العلاج والتنويم", NameEn = "العلاج والتنويم", ServiceId = 2, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            
            arrData[6] = new RequestType { Id = 7, NameAr = "إبعاد سجين لبلادة", NameEn = "إبعاد سجين لبلادة", ServiceId = 3, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[7] = new RequestType { Id = 8, NameAr = "إعفاء من الإبعاد", NameEn = "إعفاء من الإبعاد", ServiceId = 3, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[8] = new RequestType { Id = 9, NameAr = "إعفاء من باقي المحكومية لسجين", NameEn = "إعفاء من باقي المحكومية لسجين", ServiceId = 3, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[9] = new RequestType { Id = 10, NameAr = "إفراج صحي لسجين", NameEn = "إفراج صحي لسجين", ServiceId = 3, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[10] = new RequestType { Id = 11, NameAr = "إنهاء قضايا الأحداث الاجانب", NameEn = "إنهاء قضايا الأحداث الاجانب", ServiceId = 3, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[11] = new RequestType { Id = 12, NameAr = "تثبيت سجين في سجنه", NameEn = "تثبيت سجين في سجنه", ServiceId = 3, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[12] = new RequestType { Id = 13, NameAr = "ترحيل سجين", NameEn = "ترحيل سجين", ServiceId = 3, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[13] = new RequestType { Id = 14, NameAr = "زيارة خاصة لسجين", NameEn = "زيارة خاصة لسجين", ServiceId = 3, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[14] = new RequestType { Id = 15, NameAr = "زيارة خاصة مكتبية لسجين", NameEn = "زيارة خاصة مكتبية لسجين", ServiceId = 3, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[15] = new RequestType { Id = 16, NameAr = "طلب نقل سجين", NameEn = "طلب نقل سجين", ServiceId = 3, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            arrData[16] = new RequestType { Id = 17, NameAr = "اقتراح", NameEn = "اقتراح", ServiceId = 4, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[17] = new RequestType { Id = 18, NameAr = "شكوى", NameEn = "شكوى", ServiceId = 4, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[18] = new RequestType { Id = 19, NameAr = "طلب", NameEn = "طلب", ServiceId = 4, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            arrData[19] = new RequestType { Id = 20, NameAr = "زراعي", NameEn = "زراعي", ServiceId = 5, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[20] = new RequestType { Id = 21, NameAr = "سكني", NameEn = "سكني", ServiceId = 5, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[21] = new RequestType { Id = 22, NameAr = "تجاري", NameEn = "تجاري", ServiceId = 5, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[22] = new RequestType { Id = 23, NameAr = "أملاك عامة", NameEn = "أملاك عامة", ServiceId = 5, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            arrData[23] = new RequestType { Id = 24, NameAr = "اقتراح", NameEn = "اقتراح", ServiceId = 1, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[24] = new RequestType { Id = 25, NameAr = "شكوى", NameEn = "شكوى", ServiceId = 1, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[25] = new RequestType { Id = 26, NameAr = "طلب", NameEn = "طلب", ServiceId = 1, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            
            arrData[26] = new RequestType { Id = 27, NameAr = "زواج السعودية من أجنبي", NameEn = "زواج السعودية من أجنبي", ServiceId = 7, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[27] = new RequestType { Id = 28, NameAr = "زواج السعودي من دولة المغرب", NameEn = "زواج السعودي من دولة المغرب", ServiceId = 7, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[28] = new RequestType { Id = 29, NameAr = "زواج السعودي من غير سعودية مقيمة بالمملكة", NameEn = "زواج السعودي من غير سعودية مقيمة بالمملكة", ServiceId = 7, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[29] = new RequestType { Id = 30, NameAr = "زواج السعودي من غير سعودية مولودة بالمملكة", NameEn = "زواج السعودي من غير سعودية مولودة بالمملكة", ServiceId = 7, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[30] = new RequestType { Id = 31, NameAr = "زواج السعودية من غير سعودي مقيم بالمملكة", NameEn = "زواج السعودية من غير سعودي مقيم بالمملكة", ServiceId = 7, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[31] = new RequestType { Id = 32, NameAr = "زواج السعودية من غير سعودي مولود بالمملكة", NameEn = "زواج السعودية من غير سعودي مولود بالمملكة", ServiceId = 7, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[32] = new RequestType { Id = 33, NameAr = "زواج السعودي من غير سعودية من خارج المملكة", NameEn = "زواج السعودي من غير سعودية من خارج المملكة", ServiceId = 7, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            arrData[33] = new RequestType { Id = 34, NameAr = "العلاج النفسي", NameEn = "العلاج النفسي", ServiceId = 9, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[34] = new RequestType { Id = 35, NameAr = "علاج الإدمان", NameEn = "علاج الإدمان", ServiceId = 9, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            return arrData;
        }
        public static Service[] Services()
        {
            Service[] arrData = new Service[9];
            arrData[0] = new Service { Id = 1, NameAr = "المجلس الالكتروني", NameEn = "Electronic Board", SectorAr = "المجلس الالكتروني", SectorEn = "المجلس الالكتروني", DescriptionAr = "المجلس الالكتروني", DescriptionEn = "المجلس الالكتروني", RequestLink = "/home/grm", IsExternal = true, WorkDays = "10", ImageName = "e-council.png", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new Service { Id = 2, NameAr = "الخروج المؤقت لسجين", NameEn = "Prisoner Temp Release", SectorAr = "الخروج المؤقت لسجين", SectorEn = "الخروج المؤقت لسجين", DescriptionAr = "الخروج المؤقت لسجين", DescriptionEn = "الخروج المؤقت لسجين", RequestLink = "/eservice/prisoner-temp-release", WorkDays = "10", ImageName = "prisoner.svg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new Service { Id = 3, NameAr = "خدمات السجناء", NameEn = "Prisoners Services", SectorAr = "خدمات السجناء", SectorEn = "خدمات السجناء", DescriptionAr = "خدمات السجناء", DescriptionEn = "خدمات السجناء", RequestLink = "/eservice/prisoners-services", WorkDays = "10", ImageName = "prisoner.svg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new Service { Id = 4, NameAr = "الاستدعاء الإلكتروني", NameEn = "Electronic Summon", SectorAr = "الاستدعاء الإلكتروني", SectorEn = "الاستدعاء الإلكتروني", DescriptionAr = "الاستدعاء الإلكتروني", DescriptionEn = "الاستدعاء الإلكتروني", RequestLink = "/eservice/electronic-summon", WorkDays = "10", ImageName = "contract.svg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new Service { Id = 5, NameAr = "التعديات على الأراضي الحكومية", NameEn = "Infringements On Government Land", SectorAr = "التعديات على الأراضي الحكومية", SectorEn = "التعديات على الأراضي الحكومية", DescriptionAr = "التعديات على الأراضي الحكومية", DescriptionEn = "التعديات على الأراضي الحكومية", RequestLink = "/eservice/lands-infringement", WorkDays = "10", ImageName = "contract.svg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new Service { Id = 6, NameAr = "انفاذ الحكم الشرعي", NameEn = "Judgment Execution", SectorAr = "انفاذ الحكم الشرعي", SectorEn = "انفاذ الحكم الشرعي", DescriptionAr = "انفاذ الحكم الشرعي", DescriptionEn = "انفاذ الحكم الشرعي", RequestLink = "/eservice/judgment-execution", WorkDays = "10", ImageName = "magnifying-glass.svg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[6] = new Service { Id = 7, NameAr = "توثيق زواج", NameEn = "Marriage Certificate", SectorAr = "توثيق زواج", SectorEn = "توثيق زواج", DescriptionAr = "توثيق زواج", DescriptionEn = "توثيق زواج", RequestLink = "/eservice/marriage-certificate", WorkDays = "10", ImageName = "couple.svg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[7] = new Service { Id = 8, NameAr = "تملك عقار للأجانب", NameEn = "Realty Ownership For Foreigners", SectorAr = "تملك عقار للأجانب", SectorEn = "تملك عقار للأجانب", DescriptionAr = "تملك عقار للأجانب", DescriptionEn = "تملك عقار للأجانب", RequestLink = "/eservice/foreigners-realty-owner", WorkDays = "10", ImageName = "magnifying-glass.svg", IsActive = false, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[8] = new Service { Id = 9, NameAr = "طلب علاج", NameEn = "Treatment Recommendation", SectorAr = "طلب علاج", SectorEn = "طلب علاج", DescriptionAr = "طلب علاج", DescriptionEn = "طلب علاج", RequestLink = "/eservice/treatment-recommendation", WorkDays = "10", ImageName = "magnifying-glass.svg", IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static ServiceStage[] ServiceStages()
        {
            ServiceStage[] arrData = new ServiceStage[70];
            arrData[0] = new ServiceStage { Id = 1, ServiceId = 2, StageId = 1, RequesterUrl = "/eservice/prisoner-temp-release", AdminUrl = "/admin/eservice-admin/prisoner-temp-release-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new ServiceStage { Id = 2, ServiceId = 2, StageId = 2, RequesterUrl = "/eservice/prisoner-temp-release-view", AdminUrl = "/admin/eservice-admin/prisoner-temp-release-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new ServiceStage { Id = 3, ServiceId = 2, StageId = 3, RequesterUrl = "/eservice/prisoner-temp-release", AdminUrl = "/admin/eservice-admin/prisoner-temp-release-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new ServiceStage { Id = 4, ServiceId = 2, StageId = 4, RequesterUrl = "/eservice/prisoner-temp-release-view", AdminUrl = "/admin/eservice-admin/prisoner-temp-release-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new ServiceStage { Id = 5, ServiceId = 2, StageId = 5, RequesterUrl = "/eservice/prisoner-temp-release-view", AdminUrl = "/admin/eservice-admin/prisoner-temp-release-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new ServiceStage { Id = 6, ServiceId = 2, StageId = 6, RequesterUrl = "/eservice/prisoner-temp-release-view", AdminUrl = "/admin/eservice-admin/prisoner-temp-release-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[6] = new ServiceStage { Id = 7, ServiceId = 2, StageId = 7, RequesterUrl = "/eservice/prisoner-temp-release-view", AdminUrl = "/admin/eservice-admin/prisoner-temp-release-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            arrData[7] = new ServiceStage { Id = 8, ServiceId = 3, StageId = 1, RequesterUrl = "/eservice/prisoners-services", AdminUrl = "/admin/eservice-admin/prisoners-services-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[8] = new ServiceStage { Id = 9, ServiceId = 3, StageId = 2, RequesterUrl = "/eservice/prisoners-services-view", AdminUrl = "/admin/eservice-admin/prisoners-services-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[9] = new ServiceStage { Id = 10, ServiceId = 3, StageId = 3, RequesterUrl = "/eservice/prisoners-services", AdminUrl = "/admin/eservice-admin/prisoners-services-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[10] = new ServiceStage { Id = 11, ServiceId = 3, StageId = 4, RequesterUrl = "/eservice/prisoners-services-view", AdminUrl = "/admin/eservice-admin/prisoners-services-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[11] = new ServiceStage { Id = 12, ServiceId = 3, StageId = 5, RequesterUrl = "/eservice/prisoners-services-view", AdminUrl = "/admin/eservice-admin/prisoners-services-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[12] = new ServiceStage { Id = 13, ServiceId = 3, StageId = 6, RequesterUrl = "/eservice/prisoners-services-view", AdminUrl = "/admin/eservice-admin/prisoners-services-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[13] = new ServiceStage { Id = 14, ServiceId = 3, StageId = 7, RequesterUrl = "/eservice/prisoners-services-view", AdminUrl = "/admin/eservice-admin/prisoners-services-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            arrData[14] = new ServiceStage { Id = 15, ServiceId = 3, StageId = 1, RequesterUrl = "/eservice/electronic-summoning", AdminUrl = "/admin/eservice-admin/electronic-summoning-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[15] = new ServiceStage { Id = 16, ServiceId = 3, StageId = 2, RequesterUrl = "/eservice/electronic-summoning-view", AdminUrl = "/admin/eservice-admin/electronic-summoning-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[16] = new ServiceStage { Id = 17, ServiceId = 3, StageId = 3, RequesterUrl = "/eservice/electronic-summoning", AdminUrl = "/admin/eservice-admin/electronic-summoning-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[17] = new ServiceStage { Id = 18, ServiceId = 3, StageId = 4, RequesterUrl = "/eservice/electronic-summoning-view", AdminUrl = "/admin/eservice-admin/electronic-summoning-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[18] = new ServiceStage { Id = 19, ServiceId = 3, StageId = 5, RequesterUrl = "/eservice/electronic-summoning-view", AdminUrl = "/admin/eservice-admin/electronic-summoning-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[19] = new ServiceStage { Id = 20, ServiceId = 3, StageId = 6, RequesterUrl = "/eservice/electronic-summoning-view", AdminUrl = "/admin/eservice-admin/electronic-summoning-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[20] = new ServiceStage { Id = 21, ServiceId = 3, StageId = 7, RequesterUrl = "/eservice/electronic-summoning-view", AdminUrl = "/admin/eservice-admin/electronic-summoning-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            arrData[21] = new ServiceStage { Id = 22, ServiceId = 4, StageId = 1, RequesterUrl = "/eservice/electronic-summon", AdminUrl = "/admin/eservice-admin/electronic-summon-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[22] = new ServiceStage { Id = 23, ServiceId = 4, StageId = 2, RequesterUrl = "/eservice/electronic-summon-view", AdminUrl = "/admin/eservice-admin/electronic-summon-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[23] = new ServiceStage { Id = 24, ServiceId = 4, StageId = 3, RequesterUrl = "/eservice/electronic-summon", AdminUrl = "/admin/eservice-admin/electronic-summon-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[24] = new ServiceStage { Id = 25, ServiceId = 4, StageId = 4, RequesterUrl = "/eservice/electronic-summon-view", AdminUrl = "/admin/eservice-admin/electronic-summon-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[25] = new ServiceStage { Id = 26, ServiceId = 4, StageId = 5, RequesterUrl = "/eservice/electronic-summon-view", AdminUrl = "/admin/eservice-admin/electronic-summon-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[26] = new ServiceStage { Id = 27, ServiceId = 4, StageId = 6, RequesterUrl = "/eservice/electronic-summon-view", AdminUrl = "/admin/eservice-admin/electronic-summon-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[27] = new ServiceStage { Id = 28, ServiceId = 4, StageId = 7, RequesterUrl = "/eservice/electronic-summon-view", AdminUrl = "/admin/eservice-admin/electronic-summon-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            arrData[28] = new ServiceStage { Id = 29, ServiceId = 5, StageId = 1, RequesterUrl = "/eservice/lands-infringement", AdminUrl = "/admin/eservice-admin/lands-infringement-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[29] = new ServiceStage { Id = 30, ServiceId = 5, StageId = 2, RequesterUrl = "/eservice/lands-infringement-view", AdminUrl = "/admin/eservice-admin/lands-infringement-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[30] = new ServiceStage { Id = 31, ServiceId = 5, StageId = 3, RequesterUrl = "/eservice/lands-infringement", AdminUrl = "/admin/eservice-admin/lands-infringement-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[31] = new ServiceStage { Id = 32, ServiceId = 5, StageId = 4, RequesterUrl = "/eservice/lands-infringement-view", AdminUrl = "/admin/eservice-admin/lands-infringement-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[32] = new ServiceStage { Id = 33, ServiceId = 5, StageId = 5, RequesterUrl = "/eservice/lands-infringement-view", AdminUrl = "/admin/eservice-admin/lands-infringement-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[33] = new ServiceStage { Id = 34, ServiceId = 5, StageId = 6, RequesterUrl = "/eservice/lands-infringement-view", AdminUrl = "/admin/eservice-admin/lands-infringement-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[34] = new ServiceStage { Id = 35, ServiceId = 5, StageId = 7, RequesterUrl = "/eservice/lands-infringement-view", AdminUrl = "/admin/eservice-admin/lands-infringement-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            
            arrData[35] = new ServiceStage { Id = 36, ServiceId = 6, StageId = 1, RequesterUrl = "/eservice/judgment-execution", AdminUrl = "/admin/eservice-admin/judgment-execution-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[36] = new ServiceStage { Id = 37, ServiceId = 6, StageId = 2, RequesterUrl = "/eservice/judgment-execution-view", AdminUrl = "/admin/eservice-admin/judgment-execution-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[37] = new ServiceStage { Id = 38, ServiceId = 6, StageId = 3, RequesterUrl = "/eservice/judgment-execution", AdminUrl = "/admin/eservice-admin/judgment-execution-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[38] = new ServiceStage { Id = 39, ServiceId = 6, StageId = 4, RequesterUrl = "/eservice/judgment-execution-view", AdminUrl = "/admin/eservice-admin/judgment-execution-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[39] = new ServiceStage { Id = 40, ServiceId = 6, StageId = 5, RequesterUrl = "/eservice/judgment-execution-view", AdminUrl = "/admin/eservice-admin/judgment-execution-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[40] = new ServiceStage { Id = 41, ServiceId = 6, StageId = 6, RequesterUrl = "/eservice/judgment-execution-view", AdminUrl = "/admin/eservice-admin/judgment-execution-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[41] = new ServiceStage { Id = 42, ServiceId = 6, StageId = 7, RequesterUrl = "/eservice/judgment-execution-view", AdminUrl = "/admin/eservice-admin/judgment-execution-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            
            arrData[42] = new ServiceStage { Id = 43, ServiceId = 7, StageId = 1, RequesterUrl = "/eservice/marriage-certificate", AdminUrl = "/admin/eservice-admin/marriage-certificate-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[43] = new ServiceStage { Id = 44, ServiceId = 7, StageId = 2, RequesterUrl = "/eservice/marriage-certificate-view", AdminUrl = "/admin/eservice-admin/marriage-certificate-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[44] = new ServiceStage { Id = 45, ServiceId = 7, StageId = 3, RequesterUrl = "/eservice/marriage-certificate", AdminUrl = "/admin/eservice-admin/marriage-certificate-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[45] = new ServiceStage { Id = 46, ServiceId = 7, StageId = 4, RequesterUrl = "/eservice/marriage-certificate-view", AdminUrl = "/admin/eservice-admin/marriage-certificate-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[46] = new ServiceStage { Id = 47, ServiceId = 7, StageId = 5, RequesterUrl = "/eservice/marriage-certificate-view", AdminUrl = "/admin/eservice-admin/marriage-certificate-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[47] = new ServiceStage { Id = 48, ServiceId = 7, StageId = 6, RequesterUrl = "/eservice/marriage-certificate-view", AdminUrl = "/admin/eservice-admin/marriage-certificate-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[48] = new ServiceStage { Id = 49, ServiceId = 7, StageId = 7, RequesterUrl = "/eservice/marriage-certificate-view", AdminUrl = "/admin/eservice-admin/marriage-certificate-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            
            arrData[49] = new ServiceStage { Id = 50, ServiceId = 8, StageId = 1, RequesterUrl = "/eservice/foreigners-realty-owner", AdminUrl = "/admin/eservice-admin/foreigners-realty-owner-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[50] = new ServiceStage { Id = 51, ServiceId = 8, StageId = 2, RequesterUrl = "/eservice/foreigners-realty-owner-view", AdminUrl = "/admin/eservice-admin/foreigners-realty-owner-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[51] = new ServiceStage { Id = 52, ServiceId = 8, StageId = 3, RequesterUrl = "/eservice/foreigners-realty-owner", AdminUrl = "/admin/eservice-admin/foreigners-realty-owner-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[52] = new ServiceStage { Id = 53, ServiceId = 8, StageId = 4, RequesterUrl = "/eservice/foreigners-realty-owner-view", AdminUrl = "/admin/eservice-admin/foreigners-realty-owner-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[53] = new ServiceStage { Id = 54, ServiceId = 8, StageId = 5, RequesterUrl = "/eservice/foreigners-realty-owner-view", AdminUrl = "/admin/eservice-admin/foreigners-realty-owner-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[54] = new ServiceStage { Id = 55, ServiceId = 8, StageId = 6, RequesterUrl = "/eservice/foreigners-realty-owner-view", AdminUrl = "/admin/eservice-admin/foreigners-realty-owner-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[55] = new ServiceStage { Id = 56, ServiceId = 8, StageId = 7, RequesterUrl = "/eservice/foreigners-realty-owner-view", AdminUrl = "/admin/eservice-admin/foreigners-realty-owner-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            
            arrData[56] = new ServiceStage { Id = 57, ServiceId = 9, StageId = 1, RequesterUrl = "/eservice/treatment-recommendation", AdminUrl = "/admin/eservice-admin/treatment-recommendation-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[57] = new ServiceStage { Id = 58, ServiceId = 9, StageId = 2, RequesterUrl = "/eservice/treatment-recommendation-view", AdminUrl = "/admin/eservice-admin/treatment-recommendation-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[58] = new ServiceStage { Id = 59, ServiceId = 9, StageId = 3, RequesterUrl = "/eservice/treatment-recommendation", AdminUrl = "/admin/eservice-admin/treatment-recommendation-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[59] = new ServiceStage { Id = 60, ServiceId = 9, StageId = 4, RequesterUrl = "/eservice/treatment-recommendation-view", AdminUrl = "/admin/eservice-admin/treatment-recommendation-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[60] = new ServiceStage { Id = 61, ServiceId = 9, StageId = 5, RequesterUrl = "/eservice/treatment-recommendation-view", AdminUrl = "/admin/eservice-admin/treatment-recommendation-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[61] = new ServiceStage { Id = 62, ServiceId = 9, StageId = 6, RequesterUrl = "/eservice/treatment-recommendation-view", AdminUrl = "/admin/eservice-admin/treatment-recommendation-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[62] = new ServiceStage { Id = 63, ServiceId = 9, StageId = 7, RequesterUrl = "/eservice/treatment-recommendation-view", AdminUrl = "/admin/eservice-admin/treatment-recommendation-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };


            arrData[63] = new ServiceStage { Id = 64, ServiceId = 1, StageId = 1, RequesterUrl = "/eservice/electronic-council", AdminUrl = "/admin/eservice-admin/electronic-council-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[64] = new ServiceStage { Id = 65, ServiceId = 1, StageId = 2, RequesterUrl = "/eservice/electronic-council-view", AdminUrl = "/admin/eservice-admin/electronic-council-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[65] = new ServiceStage { Id = 66, ServiceId = 1, StageId = 3, RequesterUrl = "/eservice/electronic-council", AdminUrl = "/admin/eservice-admin/electronic-council-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[66] = new ServiceStage { Id = 67, ServiceId = 1, StageId = 4, RequesterUrl = "/eservice/electronic-council-view", AdminUrl = "/admin/eservice-admin/electronic-council-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[67] = new ServiceStage { Id = 68, ServiceId = 1, StageId = 5, RequesterUrl = "/eservice/electronic-council-view", AdminUrl = "/admin/eservice-admin/electronic-council-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[68] = new ServiceStage { Id = 69, ServiceId = 1, StageId = 6, RequesterUrl = "/eservice/electronic-council-view", AdminUrl = "/admin/eservice-admin/electronic-council-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[69] = new ServiceStage { Id = 70, ServiceId = 1, StageId = 7, RequesterUrl = "/eservice/electronic-council-view", AdminUrl = "/admin/eservice-admin/electronic-council-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            //arrData[63] = new ServiceStage { Id = 64, ServiceId = 1, StageId = 1, RequesterUrl = "/e-council/update", AdminUrl = "", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            //arrData[64] = new ServiceStage { Id = 65, ServiceId = 1, StageId = 2, RequesterUrl = "/e-council/electronic-board-view", AdminUrl = "/admin/eservice-admin/electronic-council-admin-preview-step", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            //arrData[65] = new ServiceStage { Id = 66, ServiceId = 1, StageId = 3, RequesterUrl = "/e-council/update", AdminUrl = "/admin/eservice-admin/electronic-summon-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            //arrData[66] = new ServiceStage { Id = 67, ServiceId = 1, StageId = 4, RequesterUrl = "/e-council/electronic-board-view", AdminUrl = "/admin/eservice-admin/electronic-council-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            //arrData[67] = new ServiceStage { Id = 68, ServiceId = 1, StageId = 5, RequesterUrl = "/e-council/electronic-board-view", AdminUrl = "/admin/eservice-admin/electronic-council-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            //arrData[68] = new ServiceStage { Id = 69, ServiceId = 1, StageId = 6, RequesterUrl = "/e-council/electronic-board-view", AdminUrl = "/admin/eservice-admin/electronic-council-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            //arrData[69] = new ServiceStage { Id = 70, ServiceId = 1, StageId = 7, RequesterUrl = "/e-council/electronic-board-view", AdminUrl = "/admin/eservice-admin/electronic-council-admin-view", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };

            return arrData;
        }
        public static ServieNotification[] ServieNotifications()
        {
            ServieNotification[] arrData = new ServieNotification[12];
            arrData[0] = new ServieNotification { Id = 1, StageId = 2, IsSMS = true, IsEmail = false, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new ServieNotification { Id = 2, StageId = 3, IsSMS = true, IsEmail = false, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new ServieNotification { Id = 3, StageId = 4, IsSMS = true, IsEmail = false, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new ServieNotification { Id = 4, StageId = 5, IsSMS = true, IsEmail = false, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new ServieNotification { Id = 5, StageId = 6, IsSMS = true, IsEmail = false, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new ServieNotification { Id = 6, StageId = 7, IsSMS = true, IsEmail = false, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[6] = new ServieNotification { Id = 7, StageId = 2, IsSMS = false, IsEmail = true, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[7] = new ServieNotification { Id = 8, StageId = 3, IsSMS = false, IsEmail = true, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[8] = new ServieNotification { Id = 9, StageId = 4, IsSMS = false, IsEmail = true, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[9] = new ServieNotification { Id = 10, StageId = 5, IsSMS = false, IsEmail = true, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[10] = new ServieNotification { Id = 11, StageId = 6, IsSMS = false, IsEmail = true, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[11] = new ServieNotification { Id = 12, StageId = 7, IsSMS = false, IsEmail = true, IsDefault = true, IsActive = true, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static ServieNotificationLog[] ServieNotificationLogs()
        {
            ServieNotificationLog[] arrData = new ServieNotificationLog[12];
            arrData[0] = new ServieNotificationLog { Id = 1, ServieNotificationId = 1, Message = "عزيزي المستفيد نفيدكم بتقديم طلبكم رقم(رقم الطلب) بنجاح وسيتم اشعاركم في حالة الرد على الطلب.", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new ServieNotificationLog { Id = 2, ServieNotificationId = 2, Message = "عزيزي المستفيد نفيدكم بارجاع طلبكم رقم (رقم الطلب) فضلا مراجعة الملاحظات واعادة ارسال الطلب.", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[2] = new ServieNotificationLog { Id = 3, ServieNotificationId = 3, Message = "عزيزي المستفيد نفيدكم بأن طلبكم رقم (رقم الطلب) قيد المراجعة.", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[3] = new ServieNotificationLog { Id = 4, ServieNotificationId = 4, Message = "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[4] = new ServieNotificationLog { Id = 5, ServieNotificationId = 5, Message = "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[5] = new ServieNotificationLog { Id = 6, ServieNotificationId = 6, Message = "عزيزي المستفيد نفيدكم بأنه تمت  الموافقة على طلبكم رقم (رقم الطلب).", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[6] = new ServieNotificationLog { Id = 7, ServieNotificationId = 7, Message = "عزيزي المستفيد نفيدكم بتقديم طلبكم رقم(رقم الطلب) بنجاح وسيتم اشعاركم في حالة الرد على الطلب.", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[7] = new ServieNotificationLog { Id = 8, ServieNotificationId = 8, Message = "عزيزي المستفيد نفيدكم بارجاع طلبكم رقم (رقم الطلب) فضلا مراجعة الملاحظات واعادة ارسال الطلب.", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[8] = new ServieNotificationLog { Id = 9, ServieNotificationId = 9, Message = "عزيزي المستفيد نفيدكم بأن طلبكم رقم (رقم الطلب) قيد المراجعة.", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[9] = new ServieNotificationLog { Id = 10, ServieNotificationId = 10, Message = "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[10] = new ServieNotificationLog { Id = 11, ServieNotificationId = 11, Message = "عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم (رقم الطلب) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[11] = new ServieNotificationLog { Id = 12, ServieNotificationId = 12, Message = "عزيزي المستفيد نفيدكم بأنه تمت  الموافقة على طلبكم رقم (رقم الطلب).", CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }
        public static User[] Users()
        {
            User[] arrData = new User[2];

            using var hmac = new System.Security.Cryptography.HMACSHA512();
            var passwordSalt = hmac.Key;
            var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("P@ssw0rd"));
            arrData[0] = new User
            {
                Id = 1,
                UserName = "superadmin",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                BirthDate = new DateTime(2022, 10, 1),
                FirstNameAr = "مدير",
                SecondNameAr = "عام",
                ThirdNameAr = "النظام",
                LastNameAr = "النظام",
                FirstNameEn = "Super",
                SecondNameEn = "System",
                ThirdNameEn = "Admin",
                LastNameEn = "Admin",
                IsMale = true,
                Email = "superadmin@gmail.com",
                PhoneNumber = "0500000000",
                IsEmployee = true,
                IsDataComplete = true,
                IsActive = true
            };
            arrData[1] = new User
            {
                Id = 2,
                UserName = "admin",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                BirthDate = new DateTime(1989, 1, 1),
                FirstNameAr = "مدير",
                SecondNameAr = "النظام",
                ThirdNameAr = "النظام",
                LastNameAr = "النظام",
                FirstNameEn = "System",
                SecondNameEn = "Admin",
                ThirdNameEn = "Admin",
                LastNameEn = "Admin",
                IsMale = true,
                Email = "admin@yahoo.com",
                PhoneNumber = "0500000001",
                IsEmployee = false,
                IsDataComplete = true,
                IsActive = true
            };
            return arrData;
        }
        public static UserRole[] UserRoles()
        {
            UserRole[] arrData = new UserRole[2];
            arrData[0] = new UserRole { Id = 1, UserId = 1, RoleId = 1, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            arrData[1] = new UserRole { Id = 2, UserId = 2, RoleId = 2, CreatedBy = 1, CreatedDate = new DateTime(2022, 10, 1) };
            return arrData;
        }

        public static PageContent[] PageContents()
        {
            PageContent[] arrData = new PageContent[2];
            arrData[0] = new PageContent
            {
                Id = 1,
                DescriptionAr = "عن الاماره",
                DescriptionEn = "About us",
                PageContentType = SystemEnums.PageContentTypeEnum.AboutUs.ToString(),
                CreatedBy = 1,
                CreatedDate = new DateTime(2022, 10, 1)
            };
            arrData[1] = new PageContent
            {
                Id = 2,
                DescriptionAr = "القسم النسوي",
                DescriptionEn = "Woman sections",
                PageContentType = SystemEnums.PageContentTypeEnum.WomanSection.ToString(),
                CreatedBy = 1,
                CreatedDate = new DateTime(2022, 10, 1)
            };
            return arrData;
        }
    }
}
