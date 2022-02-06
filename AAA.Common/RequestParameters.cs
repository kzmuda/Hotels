using System;
using System.ComponentModel.DataAnnotations;

namespace AAA.Common
{
    public class RequestParameters
    {
        private const int MAX_PAGE_SIZE = 2;
        private int _pageSize;
        public int PageNumber { get; set; } = 1;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value <= MAX_PAGE_SIZE ? value : MAX_PAGE_SIZE;
        }
    }
}
