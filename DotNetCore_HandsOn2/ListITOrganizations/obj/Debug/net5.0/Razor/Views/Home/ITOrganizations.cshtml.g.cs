#pragma checksum "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListITOrganizations\Views\Home\ITOrganizations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df82c9356c75dd1f9300f8a09b55eaf4f4690f81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ITOrganizations), @"mvc.1.0.view", @"/Views/Home/ITOrganizations.cshtml")]
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
#line 1 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListITOrganizations\Views\_ViewImports.cshtml"
using DotNetCore_HandsOn2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListITOrganizations\Views\_ViewImports.cshtml"
using DotNetCore_HandsOn2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df82c9356c75dd1f9300f8a09b55eaf4f4690f81", @"/Views/Home/ITOrganizations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e834c0cffe562d5c02326a34a06cca99d9d145ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ITOrganizations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListITOrganizations\Views\Home\ITOrganizations.cshtml"
  
    List<string> hydrabadOffice = new List<string>()
{
        "Microsoft www.microsoft.com",
        "CTS www.cognizant.com",
        "Google",
        "Amazon",
        "TCS"
    };
    string st = string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListITOrganizations\Views\Home\ITOrganizations.cshtml"
 foreach (var item in hydrabadOffice)
{
    if (item.Equals("Amazon"))
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
            WriteLiteral("    <div class=\"card-body shadow p-3 mb-5 bg-white rounded\">\r\n        <span");
            BeginWriteAttribute("style", " style=\"", 481, "\"", 492, 1);
#nullable restore
#line 24 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListITOrganizations\Views\Home\ITOrganizations.cshtml"
WriteAttributeValue("", 489, st, 489, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-body\">");
#nullable restore
#line 24 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListITOrganizations\Views\Home\ITOrganizations.cshtml"
                                       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\souna\source\repos\DotNetCore_HandsOn2\ListITOrganizations\Views\Home\ITOrganizations.cshtml"
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