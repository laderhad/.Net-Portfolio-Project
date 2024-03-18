#pragma checksum "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Areas\Writer\Views\Message\SenderMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a38b94e6d8146b92cdd24e6cc49eec1d55c6cb0ab8373a0f8f2078fabb7203e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_SenderMessage), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/SenderMessage.cshtml")]
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
#line 1 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Areas\Writer\Views\Message\SenderMessage.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a38b94e6d8146b92cdd24e6cc49eec1d55c6cb0ab8373a0f8f2078fabb7203e1", @"/Areas/Writer/Views/Message/SenderMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Message_SenderMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Areas\Writer\Views\Message\SenderMessage.cshtml"
  
    ViewData["Title"] = "SenderMessage";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-24 grid-margin stretch-card"">
              <div class=""card"">
                <div class=""card-body"">
                  <h4 class=""card-title"">Gelen Kutusu</h4>
                  <div class=""table-responsive"" style=""overflow: hidden;"">
                    <table class=""table"" style=""overflow-x: hidden;"">
                      <thead>
                        <tr>
                          <th>#</th>
                          <th>Konu</th>
                          <th>Alıcı</th>
                          <th>Tarih</th>
                          <th>Detaylar</th>
                        </tr>
                      </thead>
                      <tbody>

");
#nullable restore
#line 25 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Areas\Writer\Views\Message\SenderMessage.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th>");
#nullable restore
#line 29 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Areas\Writer\Views\Message\SenderMessage.cshtml"
                                       Write(item.WriterMessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 30 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Areas\Writer\Views\Message\SenderMessage.cshtml"
                                       Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 31 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Areas\Writer\Views\Message\SenderMessage.cshtml"
                                       Write(item.Reciever);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 32 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Areas\Writer\Views\Message\SenderMessage.cshtml"
                                        Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1329, "\"", 1396, 2);
            WriteAttributeValue("", 1336, "/Writer/Message/ReceiverMessageDetails/", 1336, 39, true);
#nullable restore
#line 33 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Areas\Writer\Views\Message\SenderMessage.cshtml"
WriteAttributeValue("", 1375, item.WriterMessageID, 1375, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Mesajı Gör</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Areas\Writer\Views\Message\SenderMessage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                      </tbody>\r\n                    </table>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n\r\n");
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