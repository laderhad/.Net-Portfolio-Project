#pragma checksum "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ce0510d90aa35e26cb32072ec441552402c9e55269eb6cb1f72f8df6ea77f5e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMessage_SenderMessageList), @"mvc.1.0.view", @"/Views/AdminMessage/SenderMessageList.cshtml")]
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
#line 1 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ce0510d90aa35e26cb32072ec441552402c9e55269eb6cb1f72f8df6ea77f5e6", @"/Views/AdminMessage/SenderMessageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c5836cdd383ced21474d1d0e1b85f20b662c606dd1f3876e78c3a34a614d3a77", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminMessage_SenderMessageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml"
  
    ViewData["Title"] = "SenderMessageList";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-lg-10 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazar-Admin Gelen Kutusu</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Alıcı</th>
                            <th>Konu</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Mesajı Gör</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 31 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml"
                                       Write(item.WriterMessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 32 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml"
                                       Write(item.ReceiverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 33 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml"
                                       Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 34 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml"
                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1275, "\"", 1336, 2);
            WriteAttributeValue("", 1282, "/AdminMessage/AdminMessageDelete/", 1282, 33, true);
#nullable restore
#line 35 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml"
WriteAttributeValue("", 1315, item.WriterMessageID, 1315, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1429, "\"", 1491, 2);
            WriteAttributeValue("", 1436, "/AdminMessage/AdminMessageDetails/", 1436, 34, true);
#nullable restore
#line 36 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml"
WriteAttributeValue("", 1470, item.WriterMessageID, 1470, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Mesajı Gör</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\AdminMessage\SenderMessageList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591