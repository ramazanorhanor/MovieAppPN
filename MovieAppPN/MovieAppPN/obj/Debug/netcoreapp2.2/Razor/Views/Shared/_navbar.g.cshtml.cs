#pragma checksum "D:\UdemyKurslar\TicaretkursuCoreMVC\MovieAppVS\MovieAppPN\MovieAppPN\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a948c9d7ce5663320866f5a427409c0bfad36d75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_navbar.cshtml", typeof(AspNetCore.Views_Shared__navbar))]
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
#line 1 "D:\UdemyKurslar\TicaretkursuCoreMVC\MovieAppVS\MovieAppPN\MovieAppPN\Views\_ViewImports.cshtml"
using MovieAppPN;

#line default
#line hidden
#line 2 "D:\UdemyKurslar\TicaretkursuCoreMVC\MovieAppVS\MovieAppPN\MovieAppPN\Views\_ViewImports.cshtml"
using MovieAppPN.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a948c9d7ce5663320866f5a427409c0bfad36d75", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a5fce55b265ee49be384b1a8c93140744cdae92", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(185, 453, true);
            WriteLiteral(@"
<div class=""navbar navbar-expand-sm bg-primary navbar-dark"">
    <div class=""container"">
        <a href=""/"" class=""navbar-brand"">Movie App</a>
        <ul class=""navbar-nav"">

            <li class=""nav-item"">
                <a href=""/login"" class=""nav-link"">Login</a>
            </li>
            <li class=""nav-item"">
                <a href=""/register"" class=""nav-link"">Register</a>
            </li>
        </ul>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591