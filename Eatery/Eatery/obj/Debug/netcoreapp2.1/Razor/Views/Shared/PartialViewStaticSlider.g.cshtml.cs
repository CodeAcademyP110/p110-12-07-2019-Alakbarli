#pragma checksum "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Shared\PartialViewStaticSlider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e443e21cc9e4ce387edfcbd6704026fc5267fdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialViewStaticSlider), @"mvc.1.0.view", @"/Views/Shared/PartialViewStaticSlider.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PartialViewStaticSlider.cshtml", typeof(AspNetCore.Views_Shared_PartialViewStaticSlider))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e443e21cc9e4ce387edfcbd6704026fc5267fdf", @"/Views/Shared/PartialViewStaticSlider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1775fe8f68e1354639192164db2cbcd52964ed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViewStaticSlider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StaticSlider>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 95, true);
            WriteLiteral("<section class=\"home-slider-loop-false  inner-page owl-carousel\">\r\n    <div class=\"slider-item\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 116, "\"", 167, 4);
            WriteAttributeValue("", 124, "background-image:", 124, 17, true);
            WriteAttributeValue(" ", 141, "url(\'/img/", 142, 11, true);
#line 3 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Shared\PartialViewStaticSlider.cshtml"
WriteAttributeValue("", 152, Model.Image, 152, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 164, "\');", 164, 3, true);
            EndWriteAttribute();
            BeginContext(168, 225, true);
            WriteLiteral(">\r\n\r\n        <div class=\"container\">\r\n            <div class=\"row slider-text align-items-center justify-content-center\">\r\n                <div class=\"col-md-8 text-center col-sm-12 element-animate\">\r\n                    <h1>");
            EndContext();
            BeginContext(394, 13, false);
#line 8 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Shared\PartialViewStaticSlider.cshtml"
                   Write(Model.Heading);

#line default
#line hidden
            EndContext();
            BeginContext(407, 95, true);
            WriteLiteral("</h1>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StaticSlider> Html { get; private set; }
    }
}
#pragma warning restore 1591
