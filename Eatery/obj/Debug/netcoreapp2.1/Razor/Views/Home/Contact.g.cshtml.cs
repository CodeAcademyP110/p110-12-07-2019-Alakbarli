#pragma checksum "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f0014b8f285d8e5104bd9690b23fea09960ea57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 7 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Contact.cshtml"
using Eatery.DAL;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f0014b8f285d8e5104bd9690b23fea09960ea57", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1775fe8f68e1354639192164db2cbcd52964ed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialViewStaticSlider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(83, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24807e7259844ab59465c290bf9f1cc5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 9 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.StaticSlider.FirstOrDefault(x => x.ActionName == "contact");

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
            BeginContext(200, 509, true);
            WriteLiteral(@"

<section class=""section element-animate"">
    <div class=""clearfix mb-5 pb-5"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12 text-center heading-wrap"">
                    <h2>Get In Touch</h2>
                    <span class=""back-text"">Contact Form</span>
                </div>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6"">
                ");
            EndContext();
            BeginContext(709, 1660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98f1ea7faefd411aae15e33abec55a6e", async() => {
                BeginContext(740, 1622, true);
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-md-6 form-group"">
                            <label for=""name"">Name</label>
                            <input type=""text"" id=""name"" class=""form-control "">
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label for=""phone"">Phone</label>
                            <input type=""text"" id=""phone"" class=""form-control "">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12 form-group"">

                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12 form-group"">
                            <label for=""email"">Email</label>
                            <input type=""email"" id=""email"" class=""form-control "">
                        </div>
                    </div>
                    <di");
                WriteLiteral(@"v class=""row"">
                        <div class=""col-md-12 form-group"">
                            <label for=""message"">Write Message</label>
                            <textarea name=""message"" id=""message"" class=""form-control "" cols=""30"" rows=""8""></textarea>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6 form-group"">
                            <input type=""submit"" value=""Send Message"" class=""btn btn-primary"">
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2369, 352, true);
            WriteLiteral(@"
            </div>

            <div class=""col-lg-6 pl-2 pl-lg-5"">

                <div class=""col-md-8 mx-auto contact-form-contact-info"">
                    <h4 class=""mb-5"">Contact Details</h4>
                    <p class=""d-flex"">
                        <span class=""ion-ios-location icon mr-5""></span>
                        <span>");
            EndContext();
            BeginContext(2722, 39, false);
#line 67 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Contact.cshtml"
                         Write(Model.Contacts.FirstOrDefault().Address);

#line default
#line hidden
            EndContext();
            BeginContext(2761, 182, true);
            WriteLiteral("</span>\r\n                    </p>\r\n\r\n                    <p class=\"d-flex\">\r\n                        <span class=\"ion-ios-telephone icon mr-5\"></span>\r\n                        <span>");
            EndContext();
            BeginContext(2944, 37, false);
#line 72 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Contact.cshtml"
                         Write(Model.Contacts.FirstOrDefault().Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2981, 181, true);
            WriteLiteral("</span>\r\n                    </p>\r\n\r\n                    <p class=\"d-flex\">\r\n                        <span class=\"ion-android-mail icon mr-5\"></span>\r\n                        <span>");
            EndContext();
            BeginContext(3163, 37, false);
#line 77 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Contact.cshtml"
                         Write(Model.Contacts.FirstOrDefault().Email);

#line default
#line hidden
            EndContext();
            BeginContext(3200, 125, true);
            WriteLiteral("</span>\r\n                    </p>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n");
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
