#pragma checksum "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Auth\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7bfb0a8c7696621f3162c4904062154ad0e68f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_SignUp), @"mvc.1.0.view", @"/Views/Auth/SignUp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/SignUp.cshtml", typeof(AspNetCore.Views_Auth_SignUp))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7bfb0a8c7696621f3162c4904062154ad0e68f4", @"/Views/Auth/SignUp.cshtml")]
    public class Views_Auth_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(190, 229, true);
            WriteLiteral("<section class=\"section-sign-up\">\r\n    <div class=\"sign-up-card\">\r\n        <div class=\"view\">\r\n            <img src=\"https://images.pexels.com/photos/3769747/pexels-photo-3769747.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 419, "\"", 425, 0);
            EndWriteAttribute();
            BeginContext(426, 851, true);
            WriteLiteral(@">
            <span class=""check"">
                <i class=""fas fa-check""></i>
            </span>
        </div>
        <form  method=""post"" action=""/auth/SignUp"" class=""form"">
            <div class=""form-control"">
                <label for=""name"">Name:</label>
                <input name=""UserName"" id=""name"" type=""text"">
            </div>
            <div class=""form-control"">
                <label for=""email"">Email:</label>
                <input name=""Email"" id=""email"" type=""email"">
            </div>
            <div class=""form-control"">
                <label for=""name"">Password:</label>
                <input name=""Password"" id=""password"" type=""password"">
            </div>
            <div class=""form-control"">
                <button type=""submit"" class=""btn-sign-up"">Sign Up</button>
            </div>
");
            EndContext();
            BeginContext(1473, 39, true);
            WriteLiteral("        </form>\r\n    </div>\r\n</section>");
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
