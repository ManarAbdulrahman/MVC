#pragma checksum "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e4a6269503b5220e230af80b84963131f0e4f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetById), @"mvc.1.0.view", @"/Views/Product/GetById.cshtml")]
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
#line 1 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\_ViewImports.cshtml"
using MyFirstProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\_ViewImports.cshtml"
using MyFirstProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e4a6269503b5220e230af80b84963131f0e4f8", @"/Views/Product/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4fb07c3c6731a45304b538d9381eb6547ac53a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyFirstProject.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetById</h1>\r\n<div class=\"container-fluid\">\r\n    <div class=\"card mb-3\" style=\"max-width: 540px;\">\r\n");
            WriteLiteral("        <div class=\"class-header\">\r\n            Product Details\r\n        </div>\r\n        <div class=\"row no-gutters\">\r\n            <div class=\"col-md-4\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 468, "", 489, 1);
#nullable restore
#line 17 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml"
WriteAttributeValue("", 473, Model.PhotoPath, 473, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\" alt=\"Product\"  width=\"300\" height=\"100%\" style=\"border-right:1px\" >\r\n            </div>\r\n            <div class=\"col-md-8\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 21 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h6 class=\"card-title\">Price: ");
#nullable restore
#line 22 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml"
                                             Write(String.Format("{0:C}", @Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <br />
                    <table class="" table-bordered w-100"">
                        <thead class=""text-sm-center"">
                            <tr>
                                <th class=""w-25"">Type</th>
                                <td>");
#nullable restore
#line 29 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml"
                               Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th class=\"w-25\">Water Resistent</th>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml"
                               Write(Model.WaterResistanr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th class=\"w-25\">Warrenty</th>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml"
                               Write(Model.Warrenty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th class=\"w-25\">Color</th>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml"
                               Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </thead>
                    </table>
                    <br />
                    <br />
                    <br />

                    <h5>Video</h5>
                    <div>
                        <video");
            BeginWriteAttribute("src", " src=\"", 2043, "\"", 2065, 1);
#nullable restore
#line 51 "C:\Users\Training\source\repos\MyFirstProject\MyFirstProject\Views\Product\GetById.cshtml"
WriteAttributeValue("", 2049, Model.VideoPath, 2049, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("width", " width=\"", 2066, "\"", 2074, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyFirstProject.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
