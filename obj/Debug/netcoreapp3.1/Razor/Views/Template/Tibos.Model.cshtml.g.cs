#pragma checksum "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f29c01afa116d9403241367aef70c6e6b63a07e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Tibos_Model), @"mvc.1.0.view", @"/Views/Template/Tibos.Model.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f29c01afa116d9403241367aef70c6e6b63a07e", @"/Views/Template/Tibos.Model.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b91508deb01f38f78115b27c3e8cd059deeb5e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Tibos_Model : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TableConfig>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml"
   
    string functionStr = Model.TableName.Substring(0, 1).ToLower() + Model.TableName.Substring(1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <pre>\r\nusing System;\r\nusing System.ComponentModel.DataAnnotations.Schema;\r\n//EFX Code Generation Template 1.0\r\n//author:Tibos\r\n//blog:www.cnblogs.com/Tibos\r\n//Entity Code Generation Template\r\nnamespace ");
#nullable restore
#line 14 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml"
     Write(Model.NameSapce);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    [Table(\"");
#nullable restore
#line 16 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml"
       Write(functionStr);

#line default
#line hidden
#nullable disable
            WriteLiteral("\")]\r\n\t//");
#nullable restore
#line 17 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml"
 Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\tpublic class ");
#nullable restore
#line 18 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml"
            Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(":BaseEntity\r\n    {\r\n");
#nullable restore
#line 20 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml"
     foreach (var item in Model.ColumnConfig)
    {
        if (item.PropName == "Id") { continue; }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        /// <summary>\r\n\t\t/// ");
#nullable restore
#line 26 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml"
       Write(Html.Raw(item.Remark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        /// </summary>\r\n        public virtual ");
#nullable restore
#line 28 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml"
                  Write(item.CsType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml"
                               Write(item.PropName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        {\r\n            get; \r\n            set; \r\n        }  \r\n        ");
#nullable restore
#line 33 "C:\Users\YihaoXin\源代码\CodeGenerator\Views\Template\Tibos.Model.cshtml"
               
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    }\r\n}\r\n</pre>");
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