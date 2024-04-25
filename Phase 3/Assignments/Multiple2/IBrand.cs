using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple2
{
    public interface IBrand
    {
        public string BrandName { get; set; }
        public string EngineNumber  { get; set; }
        public string ChasisNumber  { get; set; }

        public void ShowDetails();
    }
}