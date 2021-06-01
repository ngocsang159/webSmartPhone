using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Models.EF
{
    public class GetViewData
    {
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public string Search { get; set; }

    }
}
