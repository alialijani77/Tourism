#pragma checksum "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowLastNewsComponents\ShowLastNewsComponents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdf3f918a3ba060085c88a86308ede82c54bccaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShowLastNewsComponents_ShowLastNewsComponents), @"mvc.1.0.view", @"/Views/Shared/Components/ShowLastNewsComponents/ShowLastNewsComponents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ShowLastNewsComponents/ShowLastNewsComponents.cshtml", typeof(AspNetCore.Views_Shared_Components_ShowLastNewsComponents_ShowLastNewsComponents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf3f918a3ba060085c88a86308ede82c54bccaf", @"/Views/Shared/Components/ShowLastNewsComponents/ShowLastNewsComponents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571ac168b1ca3ddbe9fb088dbcf07b905db462b6", @"/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShowLastNewsComponents_ShowLastNewsComponents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataLayer.Model.Pages>>
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
            BeginContext(43, 182, true);
            WriteLiteral("\r\n<!-- last news -->\r\n<section class=\"last-news-section border-radius margin-top-60\">\r\n    <header><i class=\"icons icon-doc-2\"></i>  <h3>آخرین آخبار ارسالی</h3> </header>\r\n    <ul>\r\n");
            EndContext();
#line 7 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowLastNewsComponents\ShowLastNewsComponents.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(274, 34, true);
            WriteLiteral("            <li>\r\n                ");
            EndContext();
            BeginContext(308, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5b9607d85fd94cdf82c3f132a51c2bbf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 340, "~/ImagesFolder/", 340, 15, true);
#line 10 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowLastNewsComponents\ShowLastNewsComponents.cshtml"
AddHtmlAttributeValue("", 355, item.ImageName, 355, 15, false);

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
            BeginContext(372, 25, true);
            WriteLiteral("\r\n                <h2> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 397, "\"", 423, 2);
            WriteAttributeValue("", 404, "/Pages/", 404, 7, true);
#line 11 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowLastNewsComponents\ShowLastNewsComponents.cshtml"
WriteAttributeValue("", 411, item.PageID, 411, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(424, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(427, 10, false);
#line 11 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowLastNewsComponents\ShowLastNewsComponents.cshtml"
                                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(437, 53, true);
            WriteLiteral(" </a></h2>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(491, 20, false);
#line 13 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowLastNewsComponents\ShowLastNewsComponents.cshtml"
               Write(item.PageDescription);

#line default
#line hidden
            EndContext();
            BeginContext(511, 107, true);
            WriteLiteral("\r\n                </p>\r\n                <span class=\"date-publish\"><i class=\"fa fa-calendar\"></i> انتشار : ");
            EndContext();
            BeginContext(619, 26, false);
#line 15 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowLastNewsComponents\ShowLastNewsComponents.cshtml"
                                                                              Write(item.CreateTime.ToShamsi());

#line default
#line hidden
            EndContext();
            BeginContext(645, 28, true);
            WriteLiteral(" </span>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 673, "\"", 699, 2);
            WriteAttributeValue("", 680, "/Pages/", 680, 7, true);
#line 16 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowLastNewsComponents\ShowLastNewsComponents.cshtml"
WriteAttributeValue("", 687, item.PageID, 687, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(700, 75, true);
            WriteLiteral(" class=\"more-link\"><i class=\"icons icon-more\"></i></a>\r\n            </li>\r\n");
            EndContext();
#line 18 "C:\Users\alia\source\repos\Gardeshgari\Gardeshgari\Views\Shared\Components\ShowLastNewsComponents\ShowLastNewsComponents.cshtml"
        }

#line default
#line hidden
            BeginContext(786, 47, true);
            WriteLiteral("    </ul>\r\n</section>\r\n<!-- End last news -->\r\n");
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
