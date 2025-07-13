using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Parameters
{
    public class RequestParameter
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        


        public RequestParameter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}