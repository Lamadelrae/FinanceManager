#pragma checksum "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd44e751439e0a8f2deb763489379791d8027ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dd44e751439e0a8f2deb763489379791d8027ee", @"/Views/Home/Home.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinanceManager.Models.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h4>Home</h4>

<div class=""container"">
    <div class=""row"">
        <div class=""col-6"">
            <div class=""card"" style=""width: 18rem;"">
                <div class=""card-body"">
                    <h6 class=""card-subtitle mb-2 text-muted"">Total Bills Paid Quantity</h6>
                    <p class=""card-text"">");
#nullable restore
#line 10 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Home\Home.cshtml"
                                    Write(Model.BillsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>

        <div class=""col-6"">
            <div class=""card"" style=""width: 18rem;"">
                <div class=""card-body"">
                    <h6 class=""card-subtitle mb-2 text-muted"">Total Incomes Paid Quantity</h6>
                    <p class=""card-text"">");
#nullable restore
#line 19 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Home\Home.cshtml"
                                    Write(Model.IncomesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
    </div>

    <br>
    <div class=""row"">
        <div class=""col-6"">
            <div class=""card"" style=""width: 18rem;"">
                <div class=""card-body"">
                    <h6 class=""card-subtitle mb-2 text-muted"">Total Incomes Paid Value</h6>
                    <p class=""card-text"">");
#nullable restore
#line 31 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Home\Home.cshtml"
                                    Write(Model.TotalIncomesPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>

        <div class=""col-6"">
            <div class=""card"" style=""width: 18rem;"">
                <div class=""card-body"">
                    <h6 class=""card-subtitle mb-2 text-muted"">Total Bills Paid Value</h6>
                    <p class=""card-text"">");
#nullable restore
#line 40 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Home\Home.cshtml"
                                    Write(Model.TotalBillsPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinanceManager.Models.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
