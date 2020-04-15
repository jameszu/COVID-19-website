using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Data
{
    public class NZC19CaseStatsData
    {
        public int ConfirmedCasesTotal { get; set; }
        public int ConfirmedCasesNew24h { get; set; }

        public int ProbableCasesTotal { get; set; }
        public int ProbableCasesNew24h { get; set; }

        public int RecoveredCasesTotal { get; set; }
        public int RecoveredCasesNew24h { get; set; }

        public int HospitalisedCasesTotal { get; set; }
        public int HospitalisedCasesNew24h { get; set; }

        public int DeathCasesTotal { get; set; }
        public int DeathCasesNew24h { get; set; }
    }
}
