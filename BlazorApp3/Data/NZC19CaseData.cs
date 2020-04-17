using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Data
{
    public class NZC19CaseData
    {
        public int CaseNumber { get; set; }
        public DateTime ReportedDate { get; set; }

        public string LocationName { get; set; }
        public string Gender { get; set; }
        public string LastCityBeforeNZ { get; set; }

        public string FlightNumber { get; set; }
        public string CaseType { get; set; }

        public class IsTravelRelated
        {   public bool Valid { get; set; }
            public bool Value { get; set; }
        }

    }
}
