#pragma checksum "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\showByCountVMsComponents\showByCountVMsComponents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbbff4c9cc40735145b498d7cd47bb8210d29a78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_showByCountVMsComponents_showByCountVMsComponents), @"mvc.1.0.view", @"/Views/Shared/Components/showByCountVMsComponents/showByCountVMsComponents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/showByCountVMsComponents/showByCountVMsComponents.cshtml", typeof(AspNetCore.Views_Shared_Components_showByCountVMsComponents_showByCountVMsComponents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbbff4c9cc40735145b498d7cd47bb8210d29a78", @"/Views/Shared/Components/showByCountVMsComponents/showByCountVMsComponents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571ac168b1ca3ddbe9fb088dbcf07b905db462b6", @"/_ViewImports.cshtml")]
    public class Views_Shared_Components_showByCountVMsComponents_showByCountVMsComponents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataLayer.ViewModels.VM.ShowByCountVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 146, true);
            WriteLiteral("\r\n\r\n<section class=\"category-section border-radius\">\r\n    <header><i class=\"fa fa-folder-open-o\"></i> <h3> دسته بندی ها </h3></header>\r\n    <ul>\r\n");
            EndContext();
#line 7 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\showByCountVMsComponents\showByCountVMsComponents.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(254, 28, true);
            WriteLiteral("            <li><a href=\"\"> ");
            EndContext();
            BeginContext(283, 15, false);
#line 9 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\showByCountVMsComponents\showByCountVMsComponents.cshtml"
                       Write(item.GroupTitle);

#line default
#line hidden
            EndContext();
            BeginContext(298, 8, true);
            WriteLiteral("  <span>");
            EndContext();
            BeginContext(307, 14, false);
#line 9 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\showByCountVMsComponents\showByCountVMsComponents.cshtml"
                                               Write(item.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(321, 18, true);
            WriteLiteral("</span></a></li>\r\n");
            EndContext();
#line 10 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\showByCountVMsComponents\showByCountVMsComponents.cshtml"
        }

#line default
#line hidden
            BeginContext(350, 21, true);
            WriteLiteral("    </ul>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataLayer.ViewModels.VM.ShowByCountVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
