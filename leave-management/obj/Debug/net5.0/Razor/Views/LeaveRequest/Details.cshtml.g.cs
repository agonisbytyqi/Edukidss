#pragma checksum "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5783b910217eebdd3322aacdb59f28f6ecf06e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveRequest_Details), @"mvc.1.0.view", @"/Views/LeaveRequest/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\_ViewImports.cshtml"
using leave_management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\_ViewImports.cshtml"
using leave_management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5783b910217eebdd3322aacdb59f28f6ecf06e6", @"/Views/LeaveRequest/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7695ce6d7e3df9ac5ffa2eed790faf8bae9fa408", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveRequest_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<leave_management.Models.LeaveRequestVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApproveRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RejectRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
 if (Model.Approved == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\n        <h4 class=\"alert-heading\">Pending Approval</h4>\n        <p>\n            <strong>");
#nullable restore
#line 10 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingEmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 10 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                                                   Write(Model.RequestingEmployee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                                                                                       Write(Model.RequestingEmployee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <hr />\n        <p>\n            ");
#nullable restore
#line 14 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n");
#nullable restore
#line 17 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
}
else if (Model.Approved == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        <h4 class=\"alert-heading\">Approved by ");
#nullable restore
#line 21 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                         Write(Model.ApprovedBy.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                                     Write(Model.ApprovedBy.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <p>\n            <strong>");
#nullable restore
#line 23 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingEmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 23 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                                                   Write(Model.RequestingEmployee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                                                                                       Write(Model.RequestingEmployee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <hr />\n        <p>\n            ");
#nullable restore
#line 27 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 27 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n");
#nullable restore
#line 30 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        <h4 class=\"alert alert-heading\">Rejected by ");
#nullable restore
#line 34 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                               Write(Model.ApprovedBy.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                                           Write(Model.ApprovedBy.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <p>\n            <strong>");
#nullable restore
#line 36 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingEmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 36 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                                                   Write(Model.RequestingEmployee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 36 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                                                                                       Write(Model.RequestingEmployee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <hr />\n        <p>\n            ");
#nullable restore
#line 40 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 40 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n");
#nullable restore
#line 43 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            Employee Name\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 51 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestingEmployee.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 52 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestingEmployee.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 55 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 58 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 61 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 64 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Leave Type\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 70 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayFor(model => model.LeaveType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Number of days\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 76 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n");
#nullable restore
#line 81 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
     if (Model.Approved == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5783b910217eebdd3322aacdb59f28f6ecf06e616013", async() => {
                WriteLiteral("\n            <i class=\"fa fa-check\"></i>\n            Approve\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5783b910217eebdd3322aacdb59f28f6ecf06e618359", async() => {
                WriteLiteral("\n            <i class=\"fa fa-remove\"></i>\n            Reject\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 91 "C:\Users\BesiService\Desktop\G3A-EDUKIDS\leave-management\Views\LeaveRequest\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5783b910217eebdd3322aacdb59f28f6ecf06e620909", async() => {
                WriteLiteral("\n        <i class=\"fa fa-arrow-left\"></i>\n        Back to List\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<leave_management.Models.LeaveRequestVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
