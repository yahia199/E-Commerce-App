#pragma checksum "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4e6a4994f73360b20bbfe10f306ba07c80edf87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Index.cshtml", typeof(AspNetCore.Views_Orders_Index))]
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
#line 2 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
using App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e6a4994f73360b20bbfe10f306ba07c80edf87", @"/Views/Orders/Index.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "All orders";

#line default
#line hidden
            BeginContext(139, 368, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <p>
            <h4>your orders</h4>
        </p>
        <table class=""table"">
            <thead>
                <tr>
                    <th>Order ID</th>
                    <th>Items</th>
                    <th>Total</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 21 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
                 foreach (var order in Model)
                {

#line default
#line hidden
            BeginContext(573, 75, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">");
            EndContext();
            BeginContext(649, 8, false);
#line 24 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
                                            Write(order.Id);

#line default
#line hidden
            EndContext();
            BeginContext(657, 121, true);
            WriteLiteral("</td>\r\n                        <td class=\"align-middle\">\r\n                            <ul style=\"list-style-type:none\">\r\n");
            EndContext();
#line 27 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
                                 foreach (var item in order.OrderItems)
                                {

#line default
#line hidden
            BeginContext(886, 202, true);
            WriteLiteral("                                    <li>\r\n                                        <div class=\"alert alert-info\" role=\"alert\">\r\n                                            <span class=\"badge bg-success\">");
            EndContext();
            BeginContext(1089, 11, false);
#line 31 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
                                                                      Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1100, 9, true);
            WriteLiteral("</span> [");
            EndContext();
            BeginContext(1110, 24, false);
#line 31 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
                                                                                           Write(item.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 4, true);
            WriteLiteral("] - ");
            EndContext();
            BeginContext(1139, 17, false);
#line 31 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
                                                                                                                        Write(item.product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1156, 93, true);
            WriteLiteral("\r\n                                        </div>\r\n                                    </li>\r\n");
            EndContext();
#line 34 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1284, 145, true);
            WriteLiteral("                            </ul>\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
            EndContext();
            BeginContext(1430, 76, false);
#line 38 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
                       Write(order.OrderItems.Select(m => m.product.Price * m.Amount).Sum().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 41 "C:\Users\D-C\Desktop\LastEdit\E-Commerce-App\App\App\Views\Orders\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1585, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
