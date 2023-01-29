
namespace Emirates.Core.Application.Dtos
{
    public class LetterAdvancedSearchRequedtDto
    {
        public int ExternalEntity { get; set; }
        public int SubExternalEntity { get; set; }
        public int SubSubExternalEntity { get; set; }
        public string SearchClass { get; set; }
        public string IntYear { get; set; }
        public string LetterNo { get; set; }
    }
}
