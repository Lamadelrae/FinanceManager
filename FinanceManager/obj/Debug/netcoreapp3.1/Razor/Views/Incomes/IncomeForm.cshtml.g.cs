#pragma checksum "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Incomes\IncomeForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "435e2985c5059f16549972ea8fbe45b6a1983ecb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incomes_IncomeForm), @"mvc.1.0.view", @"/Views/Incomes/IncomeForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"435e2985c5059f16549972ea8fbe45b6a1983ecb", @"/Views/Incomes/IncomeForm.cshtml")]
    public class Views_Incomes_IncomeForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinanceManager.Models.ViewModels.IncomeFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div style=\"position: fixed; top: 50%; left: 50%; transform: translate(-50%, -50%);\">\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 4 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Incomes\IncomeForm.cshtml"
         if (string.IsNullOrEmpty(Model.Id) != true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <form action=\"/Incomes/InactivateIncome\" method=\"post\">\r\n                ");
#nullable restore
#line 7 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Incomes\IncomeForm.cshtml"
           Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-danger\"><i class=\"fas fa-folder-minus\"></i></button> Inactivate\r\n            </form>\r\n");
#nullable restore
#line 10 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Incomes\IncomeForm.cshtml"
        }   

#line default
#line hidden
#nullable disable
            WriteLiteral("        <form action=\"/Incomes/SubmitIncome\" method=\"post\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Incomes\IncomeForm.cshtml"
       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label>Description</label>\r\n                ");
#nullable restore
#line 15 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Incomes\IncomeForm.cshtml"
           Write(Html.TextBoxFor(m => m.Description, new { Class = "form-control", Type = "text", Required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Value</label>\r\n                ");
#nullable restore
#line 19 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Incomes\IncomeForm.cshtml"
           Write(Html.TextBoxFor(m => m.Value, new { Class = "form-control", Required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    $(\"#Value\").maskMoney();\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinanceManager.Models.ViewModels.IncomeFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
