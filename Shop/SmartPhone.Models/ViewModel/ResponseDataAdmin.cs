using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Models.EF
{
    public class ResponseDataAdmin<T>
    {
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int pageCount { get; set; }
        public int? Total { get; set; }
        public List<T> data { get; set; }

    }
}
