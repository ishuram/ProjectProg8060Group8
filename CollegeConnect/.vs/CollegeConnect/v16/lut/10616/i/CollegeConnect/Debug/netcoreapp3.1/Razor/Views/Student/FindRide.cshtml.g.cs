#pragma checksum "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e0f2c37666398f13eef12df96771a0bfa6afcd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_FindRide), @"mvc.1.0.view", @"/Views/Student/FindRide.cshtml")]
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
#line 1 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\_ViewImports.cshtml"
using CollegeConnect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\_ViewImports.cshtml"
using CollegeConnect.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e0f2c37666398f13eef12df96771a0bfa6afcd4", @"/Views/Student/FindRide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc892cf8a2abf6ce4c31aaf16fc258e1eb0a7f52", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_FindRide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataModels.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
  
    ViewData["Title"] = "FindRide";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>FindRide</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.DisplayNameFor(model => model.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.DisplayNameFor(model => model.Dest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.DisplayNameFor(model => model.SType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.DisplayFor(modelItem => item.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.DisplayFor(modelItem => item.SType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 52 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 53 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\ishur\source\repos\ishuram\ProjectProg8060Group8\CollegeConnect\CollegeConnect\Views\Student\FindRide.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataModels.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
