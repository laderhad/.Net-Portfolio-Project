#pragma checksum "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "57a857d3fcdcce686de126a1241587eee47a25193f798e581b081120e320265d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\_ViewImports.cshtml"
using Core_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\_ViewImports.cshtml"
using Core_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"57a857d3fcdcce686de126a1241587eee47a25193f798e581b081120e320265d", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c5836cdd383ced21474d1d0e1b85f20b662c606dd1f3876e78c3a34a614d3a77", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"section pt-4 px-3 px-lg-4\" id=\"about\">\r\n  <div class=\"container-narrow\">\r\n");
#nullable restore
#line 5 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n          <div class=\"col-md-6\">\r\n            <h2 class=\"h4 my-2\">");
#nullable restore
#line 9 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 10 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml"
          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"row mt-3\">\r\n              <div class=\"col-sm-2\">\r\n                <div class=\"pb-1\">Yaş:</div>\r\n              </div>\r\n              <div class=\"col-sm-10\">\r\n                    <div class=\"pb-1 fw-bolder\">");
#nullable restore
#line 16 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml"
                                           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n              </div>\r\n              <div class=\"col-sm-2\">\r\n                <div class=\"pb-1\">Email:</div>\r\n              </div>\r\n              <div class=\"col-sm-10\">\r\n                <div class=\"pb-1 fw-bolder\">");
#nullable restore
#line 22 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml"
                                       Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n              </div>\r\n              <div class=\"col-sm-2\">\r\n                <div class=\"pb-1\">Telefon:</div>\r\n              </div>\r\n              <div class=\"col-sm-10\">\r\n                <div class=\"pb-1 fw-bolder\">");
#nullable restore
#line 28 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml"
                                       Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n              </div>\r\n              <div class=\"col-sm-2\">\r\n                <div class=\"pb-1\">Adres:</div>\r\n              </div>\r\n              <div class=\"col-sm-10\">\r\n                <div class=\"pb-1 fw-bolder\">");
#nullable restore
#line 34 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml"
                                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n          <div class=\"col-md-5 offset-md-1\" data-aos=\"fade-left\" data-aos-delay=\"100\"><img class=\"avatar img-fluid mt-2\"");
            BeginWriteAttribute("src", " src=\"", 1465, "\"", 1485, 1);
#nullable restore
#line 38 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml"
WriteAttributeValue("", 1471, item.ImageUrl, 1471, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"400\" alt=\"Utku Kerem Kalaycı\"/></div>\r\n        </div>\r\n");
#nullable restore
#line 40 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\AboutList\Default.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591