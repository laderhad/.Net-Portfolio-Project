#pragma checksum "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\ContactSubplace\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e4431bd0e2a802ee6fad66753bd9cb584297ee57df073fe388f56e4e18db6fd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactSubplace_Index), @"mvc.1.0.view", @"/Views/ContactSubplace/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e4431bd0e2a802ee6fad66753bd9cb584297ee57df073fe388f56e4e18db6fd4", @"/Views/ContactSubplace/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c5836cdd383ced21474d1d0e1b85f20b662c606dd1f3876e78c3a34a614d3a77", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ContactSubplace_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Contact>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\ContactSubplace\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\ContactSubplace\Index.cshtml"
 using (Html.BeginForm("Index", "ContactSubplace", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 grid-margin stretch-card\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <p class=\"card-description\"> Alt İletişim Bilgileri Düzenleme Paneli </p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4431bd0e2a802ee6fad66753bd9cb584297ee57df073fe388f56e4e18db6fd44659", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label>ID</label>\r\n                        ");
#nullable restore
#line 19 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\ContactSubplace\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.ContactID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label>Başlık</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\ContactSubplace\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label>Telefon</label>\r\n                        ");
#nullable restore
#line 27 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\ContactSubplace\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label>Mail</label>\r\n                        ");
#nullable restore
#line 31 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\ContactSubplace\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label>Açıklama</label>\r\n                        ");
#nullable restore
#line 35 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\ContactSubplace\Index.cshtml"
                   Write(Html.TextAreaFor(x => x.Description, 6, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <button type=\"submit\" class=\"btn btn-primary mr-2\">Kaydet</button>\r\n                        <button class=\"btn btn-dark\">İptal</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 43 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\ContactSubplace\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Contact> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591