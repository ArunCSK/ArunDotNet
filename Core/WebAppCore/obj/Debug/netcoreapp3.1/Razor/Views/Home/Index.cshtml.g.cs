#pragma checksum "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c9c854de6bbcadf609bc2487c3594d8f49594b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "d:\Project\Core\WebAppCore\Views\_ViewImports.cshtml"
using WebAppCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Project\Core\WebAppCore\Views\_ViewImports.cshtml"
using WebAppCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9c854de6bbcadf609bc2487c3594d8f49594b8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc02d91782d3ab687866e0a7fcf49275e4ae279", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppCore.Models.Employees>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    function AddEmployee()
    {
       // alert(""Clicked"");
    }
</script>

<div class=""row"">
    <div class=""col-md-6"">
        <div class=""row"">
            <div class=""col-md-6"" style=""text-align: right;"">
                ");
#nullable restore
#line 17 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
           Write(Html.Label("Name", "Name:"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 20 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(m => m.EmployeeName, new { id = "EmpName", @class = "form-control", placeholder = "Employee Name", style = "width: 100%;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <small>\r\n                    ");
#nullable restore
#line 24 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.EmployeeName,  "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </small>\r\n            </div>\r\n        </div>\r\n        <br/>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\" style=\"text-align: right;\">\r\n                ");
#nullable restore
#line 31 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
           Write(Html.Label("PhoneNo", "Phone :"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 34 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(m => m.PhoneNo, new { id = "PhoneNo", @class = "form-control", placeholder = "Phone Number", style = "width: 100%;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <small>\r\n                    ");
#nullable restore
#line 38 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.PhoneNo,  "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </small>\r\n            </div>\r\n        </div>\r\n        <br/>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\" style=\"text-align: right;\">\r\n                ");
#nullable restore
#line 45 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
           Write(Html.Label("City", "City :"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 48 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
           Write(Html.DropDownListFor(m => m.City, new SelectList(Model.City, "Key", "Value", "ME"),"- Please select your city -", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <small>\r\n                    ");
#nullable restore
#line 52 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.City,  "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </small>\r\n            </div>\r\n        </div>\r\n        <br/>\r\n        <div class=\"row\">\r\n             <div class=\"col-md-6\" style=\"text-align: right;\">\r\n                ");
#nullable restore
#line 59 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
           Write(Html.Label("Gender", "Gender :"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                 Male  \r\n            ");
#nullable restore
#line 63 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
       Write(Html.RadioButtonFor(m => m.Sex, "Male"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            Female  \r\n            ");
#nullable restore
#line 65 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
       Write(Html.RadioButtonFor(m => m.Sex, "Female"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            ");
#nullable restore
#line 66 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(m => m.Sex,  "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br/>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\" style=\"text-align: right;\">\r\n                ");
#nullable restore
#line 72 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
           Write(Html.Label("Email", "Email :"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 75 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(m => m.Email, new { id = "EmailId", @class = "form-control", placeholder = "Email", style = "width: 100%;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 76 "d:\Project\Core\WebAppCore\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Email,  "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        
        
    </div>
    <div class=""col-md-6 text-center"">
        <label for=""upload""></label> 
    </div>
</div>
<br/>
<div class=""text-center"">
    <input type=""submit"" value=""Add Employee"" onclick=""AddEmployee();"" class=""btn btn-primary"">
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppCore.Models.Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591
