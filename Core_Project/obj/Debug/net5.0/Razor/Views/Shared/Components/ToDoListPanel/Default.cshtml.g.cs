#pragma checksum "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\ToDoListPanel\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "af5b87ba7538ab1f3511106d78c049c721cb49754809630b66dce4e29335dd1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ToDoListPanel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ToDoListPanel/Default.cshtml")]
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
#line 1 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\ToDoListPanel\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"af5b87ba7538ab1f3511106d78c049c721cb49754809630b66dce4e29335dd1f", @"/Views/Shared/Components/ToDoListPanel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c5836cdd383ced21474d1d0e1b85f20b662c606dd1f3876e78c3a34a614d3a77", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ToDoListPanel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDoList>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""col-md-12 col-xl-4 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <h4 class=""card-title"">Yapılacaklar Listesi</h4>
                    <div class=""add-items d-flex"">
                      <input type=""text"" class=""form-control todo-list-input"" placeholder=""enter task.."">
                      <button class=""add btn btn-primary todo-list-add-btn"">Ekle</button>
                    </div>
                    <div class=""list-wrapper"">
                      <ul class=""d-flex flex-column-reverse text-white todo-list todo-list-custom"">
");
#nullable restore
#line 16 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\ToDoListPanel\Default.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                              <div class=\"form-check form-check-primary\">\r\n                                <label class=\"form-check-label\">\r\n                                  <input class=\"checkbox\" type=\"checkbox\"> ");
#nullable restore
#line 21 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\ToDoListPanel\Default.cshtml"
                                                                      Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n                              </div>\r\n                              <i class=\"remove mdi mdi-close-box\"></i>\r\n                            </li>\r\n");
#nullable restore
#line 25 "C:\Users\Kerem\source\repos\Core_Project\Core_Project\Views\Shared\Components\ToDoListPanel\Default.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                       \r\n                      </ul>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDoList>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
