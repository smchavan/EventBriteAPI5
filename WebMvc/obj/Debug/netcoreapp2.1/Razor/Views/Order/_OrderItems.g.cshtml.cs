#pragma checksum "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4efff73b3fd68a07b55fc1b3907b8dff5f12bcac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order__OrderItems), @"mvc.1.0.view", @"/Views/Order/_OrderItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/_OrderItems.cshtml", typeof(AspNetCore.Views_Order__OrderItems))]
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
#line 1 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\_ViewImports.cshtml"
using WebMvc;

#line default
#line hidden
#line 2 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\_ViewImports.cshtml"
using WebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4efff73b3fd68a07b55fc1b3907b8dff5f12bcac", @"/Views/Order/_OrderItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82dfb9e8d9c1e15d2e9f7b4d3cf193b2b540299a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order__OrderItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMvc.Models.OrderModels.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 194, true);
            WriteLiteral("\r\n\r\n<section class=\"esh-orders_new-section\">\r\n    <article class=\"esh-orders_new-titles row\">\r\n        <section class=\"esh-orders_new-title col-xs-12\">Order details</section>\r\n    </article>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
     for (int i = 0; i < Model.OrderItems.Count; i++)
    {
        var item = Model.OrderItems[i];


#line default
#line hidden
            BeginContext(339, 201, true);
            WriteLiteral("        <article class=\"esh-orders_new-items esh-orders_new-items--border row\">\r\n            <section class=\"esh-orders_new-item col-md-4 hidden-md-down\">\r\n                <img class=\"esh-basket-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 540, "\"", 562, 1);
#line 15 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 546, item.PictureUrl, 546, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(563, 39, true);
            WriteLiteral(">\r\n                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 602, "\"", 626, 1);
#line 16 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 610, item.PictureUrl, 610, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 627, "", 670, 1);
#line 16 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 633, "orderitems[" + i + "].PictureUrl", 633, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(670, 133, true);
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-xs-4\">\r\n                ");
            EndContext();
            BeginContext(804, 16, false);
#line 19 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
           Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(820, 38, true);
            WriteLiteral("\r\n                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 858, "\"", 883, 1);
#line 20 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 866, item.ProductName, 866, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 884, "", 928, 1);
#line 20 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 890, "orderitems[" + i + "].ProductName", 890, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(928, 135, true);
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-xs-1\">\r\n                $ ");
            EndContext();
            BeginContext(1064, 14, false);
#line 23 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
             Write(item.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1078, 38, true);
            WriteLiteral("\r\n                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1116, "\"", 1139, 1);
#line 24 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1124, item.UnitPrice, 1124, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 1140, "", 1182, 1);
#line 24 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1146, "orderitems[" + i + "].UnitPrice", 1146, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1182, 133, true);
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-xs-1\">\r\n                ");
            EndContext();
            BeginContext(1316, 10, false);
#line 27 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
           Write(item.Units);

#line default
#line hidden
            EndContext();
            BeginContext(1326, 38, true);
            WriteLiteral("\r\n                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1364, "\"", 1383, 1);
#line 28 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1372, item.Units, 1372, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 1384, "", 1422, 1);
#line 28 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1390, "orderitems[" + i + "].Units", 1390, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1422, 117, true);
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-xs-2\">$ ");
            EndContext();
            BeginContext(1540, 42, false);
#line 30 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
                                                                                   Write(Math.Round(item.Units * item.UnitPrice, 2));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 32, true);
            WriteLiteral("</section>\r\n        </article>\r\n");
            EndContext();
#line 32 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
    }

#line default
#line hidden
            BeginContext(1621, 502, true);
            WriteLiteral(@"</section>

<section class=""esh-orders_new-section esh-orders_new-section--right"">
    <article class=""esh-orders_new-titles row"">
        <section class=""esh-orders_new-title col-xs-9""></section>
        <section class=""esh-orders_new-title col-xs-2"">Total</section>
    </article>

    <article class=""esh-orders_new-items row"">
        <section class=""esh-orders_new-item col-xs-9""></section>
        <section class=""esh-orders_new-item esh-orders_new-item--mark col-xs-2"">
            $ ");
            EndContext();
            BeginContext(2124, 16, false);
#line 44 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
         Write(Model.OrderTotal);

#line default
#line hidden
            EndContext();
            BeginContext(2140, 34, true);
            WriteLiteral("\r\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2174, "\"", 2199, 1);
#line 45 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 2182, Model.OrderTotal, 2182, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2200, 65, true);
            WriteLiteral(" name=\"Total\"/>\r\n        </section>\r\n    </article>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMvc.Models.OrderModels.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
