#pragma checksum "E:\T-4-12-2019\DoAnTMDT\DichVuGame\Views\Shared\Components\Balance\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dfbafae4400c597f487eec776e2d87dba339982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Balance_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Balance/Default.cshtml")]
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
#line 1 "E:\T-4-12-2019\DoAnTMDT\DichVuGame\Views\_ViewImports.cshtml"
using DichVuGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\T-4-12-2019\DoAnTMDT\DichVuGame\Views\_ViewImports.cshtml"
using DichVuGame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dfbafae4400c597f487eec776e2d87dba339982", @"/Views/Shared/Components/Balance/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983c4a7f1991df620ced787059c0b171deaefb73", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Balance_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DichVuGame.Models.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\nSố dư tài khoản<br />\r\n<i class=\"fas fa-wallet\"></i> Số dư: ");
#nullable restore
#line 4 "E:\T-4-12-2019\DoAnTMDT\DichVuGame\Views\Shared\Components\Balance\Default.cshtml"
                                Write(Model.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Coin.\r\n\r\n");
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
