using System;

namespace OnionArchitectureApp.Application.Wrappers
{
    public class PagedResponse<T> : ServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        // T tipinde response içeriği olan constructor
        public PagedResponse(T value, int pageNumber, int pageSize) : base(value)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        // Parametreli ama içerik verilmeden çağrılırsa
        public PagedResponse(int pageNumber, int pageSize) : base(default!)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        // Parametresiz constructor (varsayılan sayfa 1, boyut 10)
        public PagedResponse() : base(default!)
        {
            PageNumber = 1;
            PageSize = 10;
        }
    }
}
