#pragma checksum "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "101ca21d882c7fd1aefec253379df79e012ee74f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"101ca21d882c7fd1aefec253379df79e012ee74f", @"/Views/Products/Index.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(94, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(139, 18, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
            EndContext();
#line 10 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
     if (User.Identity.IsAuthenticated && User.IsInRole("Administrator"))
    {

#line default
#line hidden
            BeginContext(239, 70, true);
            WriteLiteral("    <p>\r\n        <a href=\"/products/create\">Create New</a>\r\n    </p>\r\n");
            EndContext();
#line 15 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(316, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(421, 40, false);
#line 20 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(461, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(529, 41, false);
#line 23 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(570, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(638, 47, false);
#line 26 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(685, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(753, 44, false);
#line 29 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(797, 69, true);
            WriteLiteral("\r\n\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(867, 44, false);
#line 33 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(911, 79, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1034, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1095, 39, false);
#line 41 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1202, 40, false);
#line 44 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1310, 46, false);
#line 47 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 71, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1427, "\"", 1479, 2);
#line 50 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
WriteAttributeValue(" ", 1433, Html.DisplayFor(modelItem => item.ImageUrl), 1434, 44, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1478, "", 1479, 1, true);
            EndWriteAttribute();
            BeginContext(1480, 38, true);
            WriteLiteral(" width=200 />\r\n                </td>\r\n");
            EndContext();
            BeginContext(1636, 46, true);
            WriteLiteral("                <td>\r\n\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1682, "\"", 1719, 2);
            WriteAttributeValue("", 1689, "/products/details/?id=", 1689, 22, true);
#line 57 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
WriteAttributeValue("", 1711, item.Id, 1711, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1720, 16, true);
            WriteLiteral(">Details</a>\r\n\r\n");
            EndContext();
#line 59 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Administrator"))
                    {

#line default
#line hidden
            BeginContext(1850, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1872, "\"", 1906, 2);
            WriteAttributeValue("", 1879, "/products/edit/?id=", 1879, 19, true);
#line 61 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
WriteAttributeValue("", 1898, item.Id, 1898, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1907, 33, true);
            WriteLiteral(">Edit</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1940, "\"", 1976, 2);
            WriteAttributeValue("", 1947, "/products/delete/?id=", 1947, 21, true);
#line 62 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
WriteAttributeValue("", 1968, item.Id, 1968, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1977, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 63 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2013, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 65 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Customer")){


#line default
#line hidden
            BeginContext(2104, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2126, "\"", 2175, 2);
            WriteAttributeValue("", 2133, "/Orders/AddItemToShoppingCart/?id=", 2133, 34, true);
#line 67 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
WriteAttributeValue("", 2167, item.Id, 2167, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2176, 8, true);
            WriteLiteral(">Add</a>");
            EndContext();
#line 67 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
                                                                                }

#line default
#line hidden
            BeginContext(2187, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 71 "C:\Users\LEGION\Source\Repos\E-Commerce-App\App\App\Views\Products\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2238, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<App.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
