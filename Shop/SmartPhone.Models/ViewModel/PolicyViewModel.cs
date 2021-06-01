using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;

namespace SmartPhone.Models.ViewModel
{
    public class PolicyViewModel
    {
        public Policy policy { get; set; }
        public List<Policy> subPolicy { get; set; }
    }
}
