using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Data
{
    public class NZC19CaseStatsService
    {
        public Task<NZC19CaseStatsData[]> GetCaseStatsAsync(DateTime startDate, string url)
        {
            string c19CaseStats = HttpClientAPI.HttpGet(url);

            NZC19CaseStatsData caseStats = HttpClientAPI.ToObject<NZC19CaseStatsData>(c19CaseStats);

            return Task.FromResult(Enumerable.Range(1, 1).Select(index => caseStats).ToArray());
        }
    }

}
