#pragma checksum "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Home\StudioDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d9c00aeb79fc7b7ecc9659eda2c4bc0470cc5e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_StudioDetails), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/StudioDetails.cshtml")]
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
#line 1 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\_ViewImports.cshtml"
using DichVuGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\_ViewImports.cshtml"
using DichVuGame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9c00aeb79fc7b7ecc9659eda2c4bc0470cc5e3", @"/Areas/Customer/Views/Home/StudioDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983c4a7f1991df620ced787059c0b171deaefb73", @"/Areas/Customer/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_StudioDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DichVuGame.Models.Studio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Home\StudioDetails.cshtml"
  
    ViewData["Title"] = "StudioDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container"">
        <div class=""card"">
            <div class=""container-fliud"">
                <div class=""wrapper row"">
                    <div class=""preview col-md-6"">
                            <div class=""tab-pane active"" id=""pic-1""><img");
            BeginWriteAttribute("src", " src=\"", 351, "\"", 374, 1);
#nullable restore
#line 11 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Home\StudioDetails.cshtml"
WriteAttributeValue("", 357, Model.StudioLogo, 357, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                    </div>\r\n                    <div class=\"details col-md-6\">\r\n                        <h3 class=\"product-title\">");
#nullable restore
#line 14 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Home\StudioDetails.cshtml"
                                             Write(Model.Studioname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <div class=""rating"">
                            <div class=""stars"">
                                <span class=""fa fa-star checked""></span>
                                <span class=""fa fa-star checked""></span>
                                <span class=""fa fa-star checked""></span>
                                <span class=""fa fa-star""></span>
                                <span class=""fa fa-star""></span>
                            </div>
                            <span class=""review-no"">41 reviews</span>
                        </div>
                        <p class=""product-description"">");
#nullable restore
#line 25 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Home\StudioDetails.cshtml"
                                                  Write(Model.Describe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <h4 class=""price"">current price: <span>$180</span></h4>
                        <p class=""vote""><strong>91%</strong> of buyers enjoyed this product! <strong>(87 votes)</strong></p>
                        <h5 class=""colors"">
                            colors:
                            <span class=""color orange not-available"" data-toggle=""tooltip"" title=""Not In store""></span>
                            <span class=""color green""></span>
                            <span class=""color blue""></span>
                        </h5>
                        <div class=""action"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d9c00aeb79fc7b7ecc9659eda2c4bc0470cc5e37330", async() => {
                WriteLiteral("Mua game của studio ngay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-q", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Home\StudioDetails.cshtml"
                                                                                                          WriteLiteral(Model.Studioname);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["q"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-q", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["q"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DichVuGame.Models.Studio> Html { get; private set; }
    }
}
#pragma warning restore 1591
