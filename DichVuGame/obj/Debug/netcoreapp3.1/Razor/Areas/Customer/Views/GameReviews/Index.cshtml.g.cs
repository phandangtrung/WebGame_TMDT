#pragma checksum "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\Views\GameReviews\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f8100e019cd630504b80da7ddafc81e822365cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_GameReviews_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/GameReviews/Index.cshtml")]
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
#line 1 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\_ViewImports.cshtml"
using DichVuGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\_ViewImports.cshtml"
using DichVuGame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8100e019cd630504b80da7ddafc81e822365cc", @"/Areas/Customer/Views/GameReviews/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983c4a7f1991df620ced787059c0b171deaefb73", @"/Areas/Customer/_ViewImports.cshtml")]
    public class Areas_Customer_Views_GameReviews_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DichVuGame.Models.GameReview>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\Views\GameReviews\Index.cshtml"
  
    ViewData["Title"] = "Nhận xét của bạn";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<h5 style=\"text-align: center;font-family: Bahnschrift;\">Nhận xét của bạn</h5>\r\n<table class=\"table\" style=\"font-family: Bahnschrift;\">\r\n    <thead>\r\n        <tr>\r\n            <th> ");
#nullable restore
#line 13 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\Views\GameReviews\Index.cshtml"
            Write(Html.DisplayNameFor(model => model.FirstOrDefault().Game.GamePoster));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\Views\GameReviews\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().Review));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\Views\GameReviews\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().Star));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\Views\GameReviews\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 762, "\"", 789, 1);
#nullable restore
#line 27 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\Views\GameReviews\Index.cshtml"
WriteAttributeValue("", 768, item.Game.GamePoster, 768, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"150\" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\Views\GameReviews\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Review));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\Views\GameReviews\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Star));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\phamq\Desktop\HK2.3\tmdt\Cay\DichVuGame\Areas\Customer\Views\GameReviews\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DichVuGame.Models.GameReview>> Html { get; private set; }
    }
}
#pragma warning restore 1591