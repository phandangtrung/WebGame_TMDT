#pragma checksum "D:\New folder (3)\WebGame_TMDT\DichVuGame\Views\Shared\Components\Username\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19dd7310d73893cbef3e0e927bcd3f928758d5d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Username_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Username/Default.cshtml")]
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
#line 1 "D:\New folder (3)\WebGame_TMDT\DichVuGame\Views\_ViewImports.cshtml"
using DichVuGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder (3)\WebGame_TMDT\DichVuGame\Views\_ViewImports.cshtml"
using DichVuGame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19dd7310d73893cbef3e0e927bcd3f928758d5d0", @"/Views/Shared/Components/Username/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983c4a7f1991df620ced787059c0b171deaefb73", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Username_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DichVuGame.Models.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("Chào ");
#nullable restore
#line 2 "D:\New folder (3)\WebGame_TMDT\DichVuGame\Views\Shared\Components\Username\Default.cshtml"
Write(Model.User);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"far fa-user\"></i>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DichVuGame.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
