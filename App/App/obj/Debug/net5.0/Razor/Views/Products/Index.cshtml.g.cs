#pragma checksum "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49157ba1704bcebe72625b31c6339c8273083b15"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49157ba1704bcebe72625b31c6339c8273083b15", @"/Views/Products/Index.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(94, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(139, 18, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
            EndContext();
#line 10 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Administrator"))
{

#line default
#line hidden
            BeginContext(231, 58, true);
            WriteLiteral("<p>\r\n    <a href=\"/products/create\">Create New</a>\r\n</p>\r\n");
            EndContext();
#line 15 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
}

#line default
#line hidden
            BeginContext(292, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(377, 40, false);
#line 20 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(417, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(473, 41, false);
#line 23 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(514, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(570, 47, false);
#line 26 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(617, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(673, 44, false);
#line 29 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(717, 57, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(775, 44, false);
#line 33 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(819, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
            BeginContext(922, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(971, 39, false);
#line 41 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1066, 40, false);
#line 44 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1162, 46, false);
#line 47 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1267, "\"", 1319, 2);
#line 50 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
WriteAttributeValue(" ", 1273, Html.DisplayFor(modelItem => item.ImageUrl), 1274, 44, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1318, "", 1319, 1, true);
            EndWriteAttribute();
            BeginContext(1320, 68, true);
            WriteLiteral(" width=200 />\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1389, 46, false);
#line 53 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1494, "\"", 1531, 2);
            WriteAttributeValue("", 1501, "/products/details/?id=", 1501, 22, true);
#line 57 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
WriteAttributeValue("", 1523, item.Id, 1523, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1532, 14, true);
            WriteLiteral(">Details</a>\r\n");
            EndContext();
#line 58 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
                 if (User.Identity.IsAuthenticated && User.IsInRole("Administrator"))
                {

#line default
#line hidden
            BeginContext(1652, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1670, "\"", 1704, 2);
            WriteAttributeValue("", 1677, "/products/edit/?id=", 1677, 19, true);
#line 60 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
WriteAttributeValue("", 1696, item.Id, 1696, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1705, 29, true);
            WriteLiteral(">Edit</a>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1734, "\"", 1770, 2);
            WriteAttributeValue("", 1741, "/products/delete/?id=", 1741, 21, true);
#line 61 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
WriteAttributeValue("", 1762, item.Id, 1762, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1771, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 62 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1801, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 62 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
                   if (User.Identity.IsAuthenticated && User.IsInRole("Customer")){


#line default
#line hidden
            BeginContext(1871, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1889, "\"", 1938, 2);
            WriteAttributeValue("", 1896, "/Orders/AddItemToShoppingCart/?id=", 1896, 34, true);
#line 64 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
WriteAttributeValue("", 1930, item.Id, 1930, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1939, 8, true);
            WriteLiteral(">Add</a>");
            EndContext();
#line 64 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
                                                                            }

#line default
#line hidden
            BeginContext(1950, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 68 "C:\Users\D-C\Desktop\MVC project\E-Commerce-App\App\App\Views\Products\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1989, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
