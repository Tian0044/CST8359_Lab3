#pragma checksum "C:\Users\tiffe\Desktop\CS-555\CST8359net\3\Lab3(1)\Lab3-net\Lab3\Views\Home\Count.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d822bfc067eb7d98fce545bcf843aba7e8fdc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Count), @"mvc.1.0.view", @"/Views/Home/Count.cshtml")]
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
#line 1 "C:\Users\tiffe\Desktop\CS-555\CST8359net\3\Lab3(1)\Lab3-net\Lab3\Views\_ViewImports.cshtml"
using Lab3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d822bfc067eb7d98fce545bcf843aba7e8fdc5", @"/Views/Home/Count.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a751612b2fc984c26e731dce5dcbeb6ea8d86a72", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Count : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tiffe\Desktop\CS-555\CST8359net\3\Lab3(1)\Lab3-net\Lab3\Views\Home\Count.cshtml"
   Layout = "_Layout";
    ViewData["Title"] = "Count";
    int i = 10;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>10 green bottles</h3>\r\n<table>\r\n");
#nullable restore
#line 8 "C:\Users\tiffe\Desktop\CS-555\CST8359net\3\Lab3(1)\Lab3-net\Lab3\Views\Home\Count.cshtml"
       while (i > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 12 "C:\Users\tiffe\Desktop\CS-555\CST8359net\3\Lab3(1)\Lab3-net\Lab3\Views\Home\Count.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" green bottles hanging on the wall\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "C:\Users\tiffe\Desktop\CS-555\CST8359net\3\Lab3(1)\Lab3-net\Lab3\Views\Home\Count.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" green bottles hanging on the wall\r\n            </td>\r\n            <td>\r\n                And if one green bottle should accidentally fall\r\n            </td>\r\n\r\n            <td>\r\n                There\'ll be ");
#nullable restore
#line 22 "C:\Users\tiffe\Desktop\CS-555\CST8359net\3\Lab3(1)\Lab3-net\Lab3\Views\Home\Count.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" green bottles hanging on the wall\r\n\r\n            </td>\r\n\r\n         </tr>\r\n");
#nullable restore
#line 27 "C:\Users\tiffe\Desktop\CS-555\CST8359net\3\Lab3(1)\Lab3-net\Lab3\Views\Home\Count.cshtml"
            i--;

            }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591