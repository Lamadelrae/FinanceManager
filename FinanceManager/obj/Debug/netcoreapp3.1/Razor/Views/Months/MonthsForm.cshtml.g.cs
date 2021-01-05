#pragma checksum "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc2a01172dcfff94213b8588748aea952a8bf48"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc2a01172dcfff94213b8588748aea952a8bf48", @"/Views/Months/MonthsForm.cshtml")]
    public class Views_Months_MonthsForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinanceManager.Models.ViewModels.MonthsFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<div class=\"row container\">\r\n    <div class=\"col\">\r\n        <h4>Id: ");
#nullable restore
#line 14 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("; Month: ");
#nullable restore
#line 14 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                             Write(Model.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <div class=\"container\">\r\n            <form action=\"/Months/SaveSalary\">\r\n                <input hidden id=\"monthId\" name=\"monthId\"");
            BeginWriteAttribute("value", " value=\"", 360, "\"", 377, 1);
#nullable restore
#line 17 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
WriteAttributeValue("", 368, Model.Id, 368, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                ");
#nullable restore
#line 19 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
           Write(Html.CheckBoxFor(m => m.SalaryIsManualInput));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Salary is Manual Input\r\n\r\n                <div class=\"form-group\">\r\n                    <label>Salary</label>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                       
                        var helper = Model.SalaryIsManualInput ? (object)new { Class = "form-control", Type = "Text", Required = true }
                         : new { Class = "form-control", Type = "Text", Required = true, Disabled = true};
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 29 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
               Write(Html.TextBoxFor(m => m.Salary, helper));

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
            BeginWriteAttribute("value", " value=\"", 1254, "\"", 1271, 1);
#nullable restore
#line 39 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
WriteAttributeValue("", 1262, Model.Id, 1262, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            ");
#nullable restore
#line 41 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
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
#line 57 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                 foreach (var income in Model.Months_Incomes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 60 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                                   Write(income.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 61 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                       Write(income.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 62 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                       Write(income.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2159, "\"", 2209, 2);
            WriteAttributeValue("", 2166, "/Months/RemoveIncomeFromMonth?id=", 2166, 33, true);
#nullable restore
#line 63 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
WriteAttributeValue("", 2199, income.Id, 2199, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><i class=\"fas fa-trash-alt\"></i></a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"col\">\r\n        <h3>Bills</h3>\r\n        <form class=\"form-inline\" action=\"/Months/AddBillToMonth\" method=\"post\">\r\n\r\n            <input hidden id=\"monthId\" name=\"monthId\"");
            BeginWriteAttribute("value", " value=\"", 2562, "\"", 2579, 1);
#nullable restore
#line 74 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
WriteAttributeValue("", 2570, Model.Id, 2570, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            ");
#nullable restore
#line 76 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
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
#line 92 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                 foreach (var bill in Model.Months_Bills)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 95 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                                   Write(bill.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 96 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                       Write(bill.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 97 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                       Write(bill.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 3453, "\"", 3499, 2);
            WriteAttributeValue("", 3460, "/Months/RemoveBillFromMonth?id=", 3460, 31, true);
#nullable restore
#line 98 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
WriteAttributeValue("", 3491, bill.Id, 3491, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><i class=\"fas fa-trash-alt\"></i></a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 100 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"col\">\r\n        <label>Total Income</label>\r\n        ");
#nullable restore
#line 106 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
   Write(Html.TextBoxFor(m => m.TotalIncome, new { Class = "form-control", Disabled = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <label>Total Outcome</label>\r\n        ");
#nullable restore
#line 108 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
   Write(Html.TextBoxFor(m => m.TotalOutcome, new { Class = "form-control", Disabled = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <label>Total Profit</label>\r\n        ");
#nullable restore
#line 110 "C:\Users\matthew.almeida\source\repos\FinanceManager\FinanceManager\Views\Months\MonthsForm.cshtml"
   Write(Html.TextBoxFor(m => m.TotalProfit, new { Class = "form-control", Disabled = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n<script>\r\n    $(\"#Salary\").maskMoney();\r\n    $(\"#TotalIncome\").maskMoney();\r\n    $(\"#TotalOutcome\").maskMoney();\r\n</script>");
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
