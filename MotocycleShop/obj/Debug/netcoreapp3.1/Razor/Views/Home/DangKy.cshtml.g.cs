#pragma checksum "D:\Nam 2\ASP\MotocycleShop\MotocycleShop\Views\Home\DangKy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbc01b623b6c763488d23bebaf9593b37fde1e1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DangKy), @"mvc.1.0.view", @"/Views/Home/DangKy.cshtml")]
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
#line 1 "D:\Nam 2\ASP\MotocycleShop\MotocycleShop\Views\_ViewImports.cshtml"
using MotocycleShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nam 2\ASP\MotocycleShop\MotocycleShop\Views\_ViewImports.cshtml"
using MotocycleShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc01b623b6c763488d23bebaf9593b37fde1e1f", @"/Views/Home/DangKy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81036f314cef62b10c33f5160f9bda049163eeae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DangKy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DangKy.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Nam 2\ASP\MotocycleShop\MotocycleShop\Views\Home\DangKy.cshtml"
   ViewData["Title"] = "DangKy"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dbc01b623b6c763488d23bebaf9593b37fde1e1f4225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<section class=""vh-100 gradient-custom"">
    <div class=""container py-5 h-100"">
        <div class=""row justify-content-center align-items-center h-100"">
            <div class=""col-12 col-lg-9 col-xl-7"">
                <div class=""card shadow-2-strong card-registration"" style=""border-radius: 15px;"">
                    <div class=""card-body p-4 p-md-5"">
                        <h3 class=""mb-4 pb-2 pb-md-0 mb-md-5"">Đăng Ký</h3>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbc01b623b6c763488d23bebaf9593b37fde1e1f5818", async() => {
                WriteLiteral(@"

                            <div class=""row"">
                                <div class=""col-md-6 mb-4"">

                                    <div class=""form-outline"">
                                        <input type=""text"" id=""firstName"" class=""form-control form-control-lg"" />
                                        <label class=""form-label"" for=""firstName"">Họ</label>
                                    </div>

                                </div>
                                <div class=""col-md-6 mb-4"">

                                    <div class=""form-outline"">
                                        <input type=""text"" id=""lastName"" class=""form-control form-control-lg"" />
                                        <label class=""form-label"" for=""lastName"">Tên</label>
                                    </div>

                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""c");
                WriteLiteral(@"ol-md-6 mb-4 d-flex align-items-center"">

                                    <div class=""form-outline datepicker w-100"">
                                        <input type=""text""
                                               class=""form-control form-control-lg""
                                               id=""birthdayDate"" />
                                        <label for=""birthdayDate"" class=""form-label"">Ngày Sinh</label>
                                    </div>

                                </div>
                                <div class=""col-md-6 mb-4"">

                                    <h6 class=""mb-2 pb-1"">Giới Tính</h6>



                                    <div class=""form-check form-check-inline"">
                                        <input class=""form-check-input""
                                               type=""radio""
                                               name=""inlineRadioOptions""
                                               id=""maleGender""
");
                WriteLiteral(@"                                               value=""option1"" checked />
                                        <label class=""form-check-label"" for=""maleGender"">Nam</label>
                                    </div>
                                    <div class=""form-check form-check-inline"">
                                        <input class=""form-check-input""
                                               type=""radio""
                                               name=""inlineRadioOptions""
                                               id=""femaleGender""
                                               value=""option2"" />
                                        <label class=""form-check-label"" for=""femaleGender"">Nữ</label>
                                    </div>

                                    <div class=""form-check form-check-inline"">
                                        <input class=""form-check-input""
                                               type=""radio""
                   ");
                WriteLiteral(@"                            name=""inlineRadioOptions""
                                               id=""otherGender""
                                               value=""option3"" />
                                        <label class=""form-check-label"" for=""otherGender"">Khác</label>
                                    </div>

                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""col-md-6 mb-4 pb-2"">

                                    <div class=""form-outline"">
                                        <input type=""email"" id=""emailAddress"" class=""form-control form-control-lg"" />
                                        <label class=""form-label"" for=""emailAddress"">Email</label>
                                    </div>

                                </div>
                                <div class=""col-md-6 mb-4 pb-2"">

                                    <div class=""form-outl");
                WriteLiteral(@"ine"">
                                        <input type=""tel"" id=""phoneNumber"" class=""form-control form-control-lg"" />
                                        <label class=""form-label"" for=""phoneNumber"">SĐT</label>
                                    </div>

                                </div>
                            </div>



                            <div class=""mt-4 pt-2"">
                                <input class=""btn btn-primary btn-lg"" type=""submit"" value=""Đăng Ký"" />
                            </div>

                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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