﻿namespace Emirates.Core.Application.Dtos.Search
{
    public class SearchModel
    {
        public List<SearchField> SearchFields { get; set; } = new List<SearchField>();
        public string OrderBy { get; set; }
        public string OrderType { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
