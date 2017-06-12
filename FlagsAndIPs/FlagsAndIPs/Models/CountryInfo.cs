using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs.Models
{
    public class CountryInfo
    {
        public CountryInfo(string countryName, string capitalName, string code)
        {
            this.CountryName = countryName;
            this.CapitalName = capitalName;
            this.Code = code;
         
        }

        public string CountryName { get; set; }
        public string CapitalName { get; set; }
        public string Code { get; set; }
      
    }
}