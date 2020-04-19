#pragma checksum "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335dedf2a7a24f13a6f97432b1d754ff5a90ef78"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using BlazorApp3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using BlazorApp3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
using BlazorApp3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.PolarAreaChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
           
        private PolarAreaConfig _config;
        private ChartJsPolarAreaChart _polarChartJs;

        private PolarAreaConfig _config24;
        private ChartJsPolarAreaChart _polarChartJs24;

        private string caseStatsUrl = "https://nzcovid19api.xerra.nz/casestats/json";

        private PolarAreaConfig initCofig(string textString)
        {

            PolarAreaConfig _configTemp = new PolarAreaConfig
            {
                Options = new PolarAreaOptions
                {
                    Title = new OptionsTitle
                    {
                        Display = true,
                        Text = textString,
                    },
                    Responsive = true,
                    Animation = new ArcAnimation
                    {
                        AnimateRotate = true,
                        AnimateScale = true
                    }
                }
            };

            return _configTemp;
        }

        private PolarAreaDataset initPolarAreaSet(double[] areaSetData)
        {

            PolarAreaDataset polarAreaSet = new PolarAreaDataset
            {
                BackgroundColor = new[] { "red", "yellow", "blue", "green", "black" },
                BorderWidth = 2,
                HoverBackgroundColor = ColorUtil.RandomColorString(),
                HoverBorderColor = ColorUtil.RandomColorString(),
                HoverBorderWidth = 2,
                BorderColor = "#ffffff",
            };

            polarAreaSet.Data.AddRange(areaSetData);

            return polarAreaSet;
        }

        NZC19CaseStatsData[] cseStatsData;
        protected override async void OnInitialized()
        {
            _config = initCofig("TOTAL CASES");
            _config24 = initCofig("CASES NEW in 24 HOURS");


            _config.Data.Labels.AddRange(new[] { "ConfirmedCasesTotal", "ProbableCasesTotal", "RecoveredCasesTotal", "HospitalisedCasesTotal", "DeathCasesTotal" });
            _config24.Data.Labels.AddRange(new[] { "ConfirmedCasesNew24h", "ProbableCasesNew24h", "RecoveredCasesNew24h", "HospitalisedCasesNew24h", "DeathCasesNew24h" });

            cseStatsData = await CaseStatsService.GetCaseStatsAsync(DateTime.Now, caseStatsUrl);


            var polarAreaSet = initPolarAreaSet(new double[] { cseStatsData[0].ConfirmedCasesTotal, cseStatsData[0].ProbableCasesTotal, cseStatsData[0].RecoveredCasesTotal,
                        cseStatsData[0].HospitalisedCasesTotal, cseStatsData[0].DeathCasesTotal });
            _config.Data.Datasets.Add(polarAreaSet);


            var polarAreaSet24 = initPolarAreaSet(new double[] { cseStatsData[0].ConfirmedCasesNew24h, cseStatsData[0].ProbableCasesNew24h, cseStatsData[0].RecoveredCasesNew24h,
                        cseStatsData[0].HospitalisedCasesNew24h, cseStatsData[0].DeathCasesNew24h });
            _config24.Data.Datasets.Add(polarAreaSet24);

            StateHasChanged();
        }

      

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NZC19CaseStatsService CaseStatsService { get; set; }
    }
}
#pragma warning restore 1591
