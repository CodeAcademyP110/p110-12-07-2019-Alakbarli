#pragma checksum "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Shared\EatingTypePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f5d495c2c132d25b780596d81eac11f827f44a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EatingTypePartialView), @"mvc.1.0.view", @"/Views/Shared/EatingTypePartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EatingTypePartialView.cshtml", typeof(AspNetCore.Views_Shared_EatingTypePartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f5d495c2c132d25b780596d81eac11f827f44a4", @"/Views/Shared/EatingTypePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1775fe8f68e1354639192164db2cbcd52964ed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EatingTypePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EatingType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 95, true);
            WriteLiteral("\r\n\r\n            <div class=\"col-md-6 mb-4 mb-lg-0 col-lg-3 text-center\">\r\n                <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 114, "\"", 167, 5);
#line 5 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Shared\EatingTypePartialView.cshtml"
WriteAttributeValue("", 122, Model.Icon, 122, 11, false);

#line default
#line hidden
            WriteAttributeValue(" ", 133, "display-4", 134, 10, true);
            WriteAttributeValue(" ", 143, "text-black", 144, 11, true);
            WriteAttributeValue(" ", 154, "d-block", 155, 8, true);
            WriteAttributeValue(" ", 162, "mb-4", 163, 5, true);
            EndWriteAttribute();
            BeginContext(168, 56, true);
            WriteLiteral("></span>\r\n                <h4 class=\"mb-4 text-primary\">");
            EndContext();
            BeginContext(225, 13, false);
#line 6 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Shared\EatingTypePartialView.cshtml"
                                         Write(Model.Heading);

#line default
#line hidden
            EndContext();
            BeginContext(238, 26, true);
            WriteLiteral("</h4>\r\n                <p>");
            EndContext();
            BeginContext(265, 13, false);
#line 7 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Shared\EatingTypePartialView.cshtml"
              Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(278, 56, true);
            WriteLiteral("</p>\r\n               \r\n            </div>\r\n           \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EatingType> Html { get; private set; }
    }
}
#pragma warning restore 1591
