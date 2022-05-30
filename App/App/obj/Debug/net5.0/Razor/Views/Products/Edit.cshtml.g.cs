#pragma checksum "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bea7782b19fbeba9690896a35f19d4a2fd072df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Edit), @"mvc.1.0.view", @"/Views/Products/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Edit.cshtml", typeof(AspNetCore.Views_Products_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bea7782b19fbeba9690896a35f19d4a2fd072df", @"/Views/Products/Edit.cshtml")]
    public class Views_Products_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(69, 1645, true);
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Product</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label""></label>
                <input asp-for=""Price"" class=""form-control"" />
                <span asp-validation-for=""Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""De");
            WriteLiteral(@"scription"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryId"" class=""control-label""></label>
                <select asp-for=""CategoryId"" class=""form-control"" asp-items=""ViewBag.CategoryId""></select>
                <span asp-validation-for=""CategoryId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1732, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
