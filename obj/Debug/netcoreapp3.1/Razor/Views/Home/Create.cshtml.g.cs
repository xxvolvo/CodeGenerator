#pragma checksum "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Home\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2579c303c7a469c12eaff82d68e2308a1ba92d11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
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
#line 1 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\_ViewImports.cshtml"
using CodeGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\_ViewImports.cshtml"
using CodeGenerator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2579c303c7a469c12eaff82d68e2308a1ba92d11", @"/Views/Home/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b91508deb01f38f78115b27c3e8cd059deeb5e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SqlConnect>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Home\Create.cshtml"
  
    ViewData["Title"] = "创建";
    Layout = "/Views/Shared/_IFrame.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Home\Create.cshtml"
Write(Html.Partial("~/Views/Home/_CreateOrEdit.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SqlConnect> Html { get; private set; }
    }
}
#pragma warning restore 1591