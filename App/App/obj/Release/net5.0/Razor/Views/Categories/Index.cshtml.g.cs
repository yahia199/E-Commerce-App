#pragma checksum "C:\Users\LEGION\source\repos\E-Commerce-App\App\App\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da4bed17337e371c4aecfa1a4333f68d67d0a889"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Index.cshtml", typeof(AspNetCore.Views_Categories_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da4bed17337e371c4aecfa1a4333f68d67d0a889", @"/Views/Categories/Index.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LEGION\source\repos\E-Commerce-App\App\App\Views\Categories\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(922, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1334, 1284, true);
            WriteLiteral(@"
<div id=""category-index-style"">


    <div class=""category-container"">
        <img src=""https://images.pexels.com/photos/2872879/pexels-photo-2872879.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"">
        <div class=""links"">
            <a href=""/categories/edit/?id=2"">Edit</a>
            <a href=""/categories/details/?id=2"">Details</a>
            <a href=""/categories/delete/?id=2"">Delete</a>
        </div>

    </div>

    <div class=""category-container"">
        <img src=""https://images.pexels.com/photos/207589/pexels-photo-207589.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"">

        <div class=""links"">
            <a href=""/categories/edit/?id=3"">Edit</a>
            <a href=""/categories/details/?id=3"">Details</a>
            <a href=""/categories/delete/?id=3"">Delete</a>
        </div>

    </div>

    <div class=""category-container"">
        <img src=""https://images.pexels.com/photos/2253834/pexels-photo-2253834.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"">
");
            WriteLiteral(@"
        <div class=""links"">

            <a href=""/categories/edit/?id=1"">Edit</a>
            <a href=""/categories/details/?id=1"">Details</a>
            <a href=""/categories/delete/?id=1"">Delete</a>
        </div>

    </div>





    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<App.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
