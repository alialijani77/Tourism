#pragma checksum "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowTopNewsComponents\ShowTopNewsComponents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d885bfa41379b0631acb6bbabf809e340620bddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShowTopNewsComponents_ShowTopNewsComponents), @"mvc.1.0.view", @"/Views/Shared/Components/ShowTopNewsComponents/ShowTopNewsComponents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ShowTopNewsComponents/ShowTopNewsComponents.cshtml", typeof(AspNetCore.Views_Shared_Components_ShowTopNewsComponents_ShowTopNewsComponents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d885bfa41379b0631acb6bbabf809e340620bddf", @"/Views/Shared/Components/ShowTopNewsComponents/ShowTopNewsComponents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571ac168b1ca3ddbe9fb088dbcf07b905db462b6", @"/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShowTopNewsComponents_ShowTopNewsComponents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataLayer.Model.Pages>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 170, true);
            WriteLiteral("\r\n<!-- most views news -->\r\n<section class=\"last-news-side border-radius\">\r\n    <header><i class=\"icons icon-star\"></i> <h3> پربازدیدترین اخبار </h3></header>\r\n    <ul>\r\n");
            EndContext();
#line 7 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowTopNewsComponents\ShowTopNewsComponents.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(262, 34, true);
            WriteLiteral("            <li>\r\n                ");
            EndContext();
            BeginContext(296, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0db6bbc9738b44bfb0f7fcc18ea20c75", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 328, "~/ImagesFolder/", 328, 15, true);
#line 10 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowTopNewsComponents\ShowTopNewsComponents.cshtml"
AddHtmlAttributeValue("", 343, item.ImageName, 343, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(360, 25, true);
            WriteLiteral("\r\n                <h2> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 385, "\"", 411, 2);
            WriteAttributeValue("", 392, "/Pages/", 392, 7, true);
#line 11 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowTopNewsComponents\ShowTopNewsComponents.cshtml"
WriteAttributeValue("", 399, item.PageID, 399, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(412, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(414, 10, false);
#line 11 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowTopNewsComponents\ShowTopNewsComponents.cshtml"
                                              Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(424, 42, true);
            WriteLiteral("</a></h2>\r\n                <span>انتشار : ");
            EndContext();
            BeginContext(467, 26, false);
#line 12 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowTopNewsComponents\ShowTopNewsComponents.cshtml"
                          Write(item.CreateTime.ToShamsi());

#line default
#line hidden
            EndContext();
            BeginContext(493, 28, true);
            WriteLiteral("</span>\r\n            </li>\r\n");
            EndContext();
#line 14 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowTopNewsComponents\ShowTopNewsComponents.cshtml"
        }

#line default
#line hidden
            BeginContext(532, 53, true);
            WriteLiteral("    </ul>\r\n</section>\r\n<!-- end most views news -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataLayer.Model.Pages>> Html { get; private set; }
    }
}
#pragma warning restore 1591
