#pragma checksum "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.IService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "334792a0cbb88f43f1240df548ed7209776d6d5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Tibos_IService), @"mvc.1.0.view", @"/Views/Template/Tibos.IService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334792a0cbb88f43f1240df548ed7209776d6d5a", @"/Views/Template/Tibos.IService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b91508deb01f38f78115b27c3e8cd059deeb5e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Tibos_IService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TableConfig>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <pre>\r\nusing FLShop.BusinessModel.Model;\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing FLShop.IService;\r\n\r\n//EFX Code Generation Template 1.0\r\n//author:Tibos\r\n//blog:www.cnblogs.com/Tibos\r\n//Entity Code Generation Template\r\nnamespace ");
#nullable restore
#line 12 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.IService.cshtml"
     Write(Model.NameSapce);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n\tpublic interface ");
#nullable restore
#line 14 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.IService.cshtml"
                Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(":IBaseService<");
#nullable restore
#line 14 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.IService.cshtml"
                                              Write(Model.TableName);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n\t{\r\n\r\n        \r\n\t}\r\n}\r\n</pre>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TableConfig> Html { get; private set; }
    }
}
#pragma warning restore 1591
