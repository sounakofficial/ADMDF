#pragma checksum "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\Home\EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88932335dcbbfdf811aa774bfd5bd4542627c313"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmployeeList), @"mvc.1.0.view", @"/Views/Home/EmployeeList.cshtml")]
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
#line 1 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\_ViewImports.cshtml"
using ListWithPartialView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\_ViewImports.cshtml"
using ListWithPartialView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88932335dcbbfdf811aa774bfd5bd4542627c313", @"/Views/Home/EmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a4e9ce7751d2463f085e666a1c5a3c0facd7362", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\Home\EmployeeList.cshtml"
  
    ViewData["Title"] = "EmployeeList";
    string st = null;
    var elist = new List<Employee>()
{
                new Employee{ Id=1, Name="John", Salary=10000, IsPermanent=true},
                new Employee{ Id=2, Name="Smith", Salary=5000, IsPermanent=false},
                new Employee{ Id=3, Name="Mark", Salary=5000, IsPermanent=false},
                new Employee{ Id=4, Name="Mary", Salary=5000, IsPermanent=false},
            };

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>From Partial View</h2>
<hr />
<div class=""row display-4"">
    <span class=""col-md-3 h3 pb-md-3"">Id</span>
    <span class=""col-md-3 h3 pb-md-3"">Name</span>
    <span class=""col-md-3 h3 pb-md-3"">Salary</span>
    <span class=""col-md-3 h3 pb-md-3"">IsPermanent</span>
</div>

");
#nullable restore
#line 22 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\Home\EmployeeList.cshtml"
 foreach (var item in elist)
{
    if (item.IsPermanent == true)
    {
        st = "font-weight:bold";
    }
    else
    {
        st = string.Empty;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row \"");
            BeginWriteAttribute("style", " style=\"", 938, "\"", 949, 1);
#nullable restore
#line 32 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\Home\EmployeeList.cshtml"
WriteAttributeValue("", 946, st, 946, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <span class=\"col-md-3 mb-3\">");
#nullable restore
#line 33 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\Home\EmployeeList.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"col-md-3 mb-3\">");
#nullable restore
#line 34 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\Home\EmployeeList.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"col-md-3 mb-3\">");
#nullable restore
#line 35 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\Home\EmployeeList.cshtml"
                               Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"col-md-3 mb-3\">");
#nullable restore
#line 36 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\Home\EmployeeList.cshtml"
                               Write(item.IsPermanent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListWithPartialView\Views\Home\EmployeeList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
