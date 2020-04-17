using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Data
{
    public class NZC19CaseService
    {
        public Task<IList<NZC19CaseData>> GetCasesAsync(string url)
        {
            string C19Cases = HttpClientAPI.HttpGet(url);

            IList<NZC19CaseData> C19casesData = HttpClientAPI.ToObject<IList<NZC19CaseData>>(C19Cases);

            return Task.FromResult(C19casesData);
        }

    }
}
