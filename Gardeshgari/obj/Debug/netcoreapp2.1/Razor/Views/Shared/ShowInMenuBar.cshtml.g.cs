#pragma checksum "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\ShowInMenuBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90de4cad446c64332899c3ba8c135f5010e3e6bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ShowInMenuBar), @"mvc.1.0.view", @"/Views/Shared/ShowInMenuBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ShowInMenuBar.cshtml", typeof(AspNetCore.Views_Shared_ShowInMenuBar))]
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
#line 1 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\_ViewImports.cshtml"
using DataLayer.ViewModels.Utility;

#line default
#line hidden
#line 1 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\ShowInMenuBar.cshtml"
using DataLayer.Repositories.Repository;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90de4cad446c64332899c3ba8c135f5010e3e6bd", @"/Views/Shared/ShowInMenuBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571ac168b1ca3ddbe9fb088dbcf07b905db462b6", @"/_ViewImports.cshtml")]
    public class Views_Shared_ShowInMenuBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 111, true);
            WriteLiteral("\r\n\r\n<ul>\r\n    <li><a href=\"/\"> صفحه اصلی </a></li>\r\n    <li>\r\n        <span>نقاط گردشگری</span>\r\n        <ul>\r\n");
            EndContext();
#line 10 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\ShowInMenuBar.cshtml"
             foreach (var item in pages.Getallpagegroup())
            {


#line default
#line hidden
            BeginContext(256, 31, true);
            WriteLiteral("                <li><a href=\"\">");
            EndContext();
            BeginContext(288, 15, false);
#line 13 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\ShowInMenuBar.cshtml"
                          Write(item.GroupTitle);

#line default
#line hidden
            EndContext();
            BeginContext(303, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 14 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\ShowInMenuBar.cshtml"
            }

#line default
#line hidden
            BeginContext(329, 33, true);
            WriteLiteral("        </ul>\r\n\r\n    </li>\r\n</ul>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPageGroup pages { get; private set; }
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
