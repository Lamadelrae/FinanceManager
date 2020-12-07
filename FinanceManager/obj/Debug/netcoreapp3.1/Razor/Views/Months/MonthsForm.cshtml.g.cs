#pragma checksum "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec311d1eccc90be831d84c3f84dce3f57c18228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Months_MonthsForm), @"mvc.1.0.view", @"/Views/Months/MonthsForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec311d1eccc90be831d84c3f84dce3f57c18228", @"/Views/Months/MonthsForm.cshtml")]
    public class Views_Months_MonthsForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinanceManager.Models.ViewModels.MonthsFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<div class=\"row container\">\r\n    <div class=\"col\">\r\n        <h4>Id: ");
#nullable restore
#line 14 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("; Month: ");
#nullable restore
#line 14 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                             Write(Model.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <div class=\"container\">\r\n            <form action=\"/Incomes/SubmitIncome\" method=\"post\">\r\n                ");
#nullable restore
#line 17 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
           Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label>Salary</label>\r\n                    ");
#nullable restore
#line 20 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
               Write(Html.TextBoxFor(m => m.Salary, new { Class = "form-control", Type = "text", Required = true, Disabled = Model.SalaryIsManualInput != true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <button type=""submit"" class=""btn btn-primary"">Submit</button>
            </form>
        </div>
    </div>

    <div class=""col"">
        <h3>Incomes</h3>
        <form class=""form-inline"" action=""/Months/AddIncomeToMonth"" method=""post"">
            <input hidden id=""monthId"" name=""monthId""");
            BeginWriteAttribute("value", " value=\"", 952, "\"", 969, 1);
#nullable restore
#line 30 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
WriteAttributeValue("", 960, Model.Id, 960, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            ");
#nullable restore
#line 32 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
       Write(Html.DropDownList("incomeId", Model.Months_IncomesDropDown, new { Class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            &nbsp;
            <button type=""submit"" class=""btn btn-primary""><i class=""fas fa-plus""></i></button>
        </form>
        <br>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Description</th>
                    <th scope=""col"">Value</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 48 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                 foreach (var income in Model.Months_Incomes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 51 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                                   Write(income.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                       Write(income.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                       Write(income.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1857, "\"", 1907, 2);
            WriteAttributeValue("", 1864, "/Months/RemoveIncomeFromMonth?id=", 1864, 33, true);
#nullable restore
#line 54 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
WriteAttributeValue("", 1897, income.Id, 1897, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><i class=\"fas fa-trash-alt\"></i></a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"col\">\r\n        <h3>Bills</h3>\r\n        <form class=\"form-inline\" action=\"/Months/AddBillToMonth\" method=\"post\">\r\n\r\n            <input hidden id=\"monthId\" name=\"monthId\"");
            BeginWriteAttribute("value", " value=\"", 2260, "\"", 2277, 1);
#nullable restore
#line 65 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
WriteAttributeValue("", 2268, Model.Id, 2268, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            ");
#nullable restore
#line 67 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
       Write(Html.DropDownList("billId", Model.Months_BillsDropDown, new { Class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            &nbsp;
            <button type=""submit"" class=""btn btn-primary""><i class=""fas fa-plus""></i></button>
        </form>
        <br>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Description</th>
                    <th scope=""col"">Value</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 83 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                 foreach (var bill in Model.Months_Bills)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 86 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                                   Write(bill.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 87 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                       Write(bill.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 88 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                       Write(bill.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 3151, "\"", 3197, 2);
            WriteAttributeValue("", 3158, "/Months/RemoveBillFromMonth?id=", 3158, 31, true);
#nullable restore
#line 89 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
WriteAttributeValue("", 3189, bill.Id, 3189, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><i class=\"fas fa-trash-alt\"></i></a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 91 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"col\">\r\n        <label>Total Income</label>\r\n        ");
#nullable restore
#line 97 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
   Write(Html.TextBoxFor(m => m.TotalIncome, new { Class = "form-control", Disabled = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <label>Total Outcome</label>\r\n        ");
#nullable restore
#line 99 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
   Write(Html.TextBoxFor(m => m.TotalOutcome, new { Class = "form-control", Disabled = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <label>Total Profit</label>\r\n        ");
#nullable restore
#line 101 "C:\Users\Matthew Almeida\Source\Repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
   Write(Html.TextBoxFor(m => m.TotalProfit, new { Class = "form-control", Disabled = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n<script>\r\n    $(\"#TotalIncome\").maskMoney();\r\n    $(\"#TotalOutcome\").maskMoney();\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinanceManager.Models.ViewModels.MonthsFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
