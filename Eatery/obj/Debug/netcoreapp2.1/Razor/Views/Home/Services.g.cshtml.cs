#pragma checksum "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d07ba930dff0bc3ccb966f4b2d68dc561ae1a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Services), @"mvc.1.0.view", @"/Views/Home/Services.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Services.cshtml", typeof(AspNetCore.Views_Home_Services))]
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
#line 1 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\_ViewImports.cshtml"
using Eatery;

#line default
#line hidden
#line 2 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\_ViewImports.cshtml"
using Eatery.Models;

#line default
#line hidden
#line 7 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Services.cshtml"
using Eatery.DAL;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d07ba930dff0bc3ccb966f4b2d68dc561ae1a9", @"/Views/Home/Services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1775fe8f68e1354639192164db2cbcd52964ed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Services : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialViewStaticSlider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Shared/EatingTypePartialView.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Services.cshtml"
  
    ViewData["Title"] = "Services";

#line default
#line hidden
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(90, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d3bdedb034a4fc18879f3f19f1a712b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 10 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Services.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.StaticSlider.FirstOrDefault(x => x.ActionName == "Services");

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(208, 124, true);
            WriteLiteral("\r\n\r\n    <section class=\"section bg-light element-animate\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
            EndContext();
#line 15 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Services.cshtml"
                 foreach (var Et in Model.EatingTypes)
                {

#line default
#line hidden
            BeginContext(407, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(427, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "23aa1b3c623047de9931b19ae19a3ee8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 17 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Services.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Et);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(498, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Services.cshtml"
                }

#line default
#line hidden
            BeginContext(519, 58, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
