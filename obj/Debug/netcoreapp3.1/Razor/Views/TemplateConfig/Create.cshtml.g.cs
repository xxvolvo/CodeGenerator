#pragma checksum "C:\Users\YihaoXin\源代码\CodeGenerator\Views\TemplateConfig\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac76095bd9977eb673d281f8070d46a01507fe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TemplateConfig_Create), @"mvc.1.0.view", @"/Views/TemplateConfig/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac76095bd9977eb673d281f8070d46a01507fe7", @"/Views/TemplateConfig/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b91508deb01f38f78115b27c3e8cd059deeb5e7", @"/Views/_ViewImports.cshtml")]
    public class Views_TemplateConfig_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TemplateConfig>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\TemplateConfig\Create.cshtml"
  
    ViewData["Title"] = "创建";
    Layout = "/Views/Shared/_IFrame.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\TemplateConfig\Create.cshtml"
Write(Html.Partial("~/Views/TemplateConfig/_CreateOrEdit.cshtml", Model));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TemplateConfig> Html { get; private set; }
    }
}
#pragma warning restore 1591
