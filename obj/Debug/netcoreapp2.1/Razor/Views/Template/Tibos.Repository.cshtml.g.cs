#pragma checksum "C:\Users\YihaoXin\源代码\EFX.Core\CodeGenerator\Views\Template\Tibos.Repository.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d8178690f8522d7c3e948dbabef7b2843bfb97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Tibos_Repository), @"mvc.1.0.view", @"/Views/Template/Tibos.Repository.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Template/Tibos.Repository.cshtml", typeof(AspNetCore.Views_Template_Tibos_Repository))]
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
#line 1 "C:\Users\YihaoXin\源代码\EFX.Core\CodeGenerator\Views\_ViewImports.cshtml"
using CodeGenerator;

#line default
#line hidden
#line 2 "C:\Users\YihaoXin\源代码\EFX.Core\CodeGenerator\Views\_ViewImports.cshtml"
using CodeGenerator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d8178690f8522d7c3e948dbabef7b2843bfb97", @"/Views/Template/Tibos.Repository.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b91508deb01f38f78115b27c3e8cd059deeb5e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Tibos_Repository : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TableConfig>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 334, true);
            WriteLiteral(@"    <pre>
using DotNetCore.CAP;
using FLShop.BusinessModel.Model;
using FLShop.Common.config;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

//EFX Code Generation Template 1.0
//author:Tibos
//blog:www.cnblogs.com/Tibos
//Entity Code Generation Template
namespace ");
            EndContext();
            BeginContext(355, 15, false);
#line 15 "C:\Users\YihaoXin\源代码\EFX.Core\CodeGenerator\Views\Template\Tibos.Repository.cshtml"
     Write(Model.NameSapce);

#line default
#line hidden
            EndContext();
            BeginContext(370, 27, true);
            WriteLiteral("\r\n{\r\n\tpublic partial class ");
            EndContext();
            BeginContext(398, 14, false);
#line 17 "C:\Users\YihaoXin\源代码\EFX.Core\CodeGenerator\Views\Template\Tibos.Repository.cshtml"
                    Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(412, 16, true);
            WriteLiteral(":FuluRepository<");
            EndContext();
            BeginContext(430, 15, false);
#line 17 "C:\Users\YihaoXin\源代码\EFX.Core\CodeGenerator\Views\Template\Tibos.Repository.cshtml"
                                                    Write(Model.TableName);

#line default
#line hidden
            EndContext();
            BeginContext(446, 25, true);
            WriteLiteral(">\r\n    {\r\n        public ");
            EndContext();
            BeginContext(473, 14, false);
#line 19 "C:\Users\YihaoXin\源代码\EFX.Core\CodeGenerator\Views\Template\Tibos.Repository.cshtml"
           Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(488, 133, true);
            WriteLiteral("(IOptions<Common.config.MySqlConnection> MySqlConnectionString):base(MySqlConnectionString)\r\n        {\r\n\r\n        }\r\n    }\r\n}\r\n</pre>");
            EndContext();
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