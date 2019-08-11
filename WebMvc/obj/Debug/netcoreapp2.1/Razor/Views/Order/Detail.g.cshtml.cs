#pragma checksum "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a01105533a881fc583371c7d032dd0e032649ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Detail), @"mvc.1.0.view", @"/Views/Order/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Detail.cshtml", typeof(AspNetCore.Views_Order_Detail))]
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
#line 1 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
using WebMvc.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a01105533a881fc583371c7d032dd0e032649ae", @"/Views/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82dfb9e8d9c1e15d2e9f7b4d3cf193b2b540299a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMvc.Models.OrderModels.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 5, true);
            WriteLiteral(" \r\n\r\n");
            EndContext();
#line 5 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
  
    ViewData["Title"] = "Order Detail";

#line default
#line hidden
            BeginContext(119, 37, true);
            WriteLiteral("<div class=\"esh-orders_detail\">\r\n    ");
            EndContext();
            BeginContext(157, 120, false);
#line 9 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
Write(await Html.PartialAsync("_Header", new List<Header>() { new Header() { Controller = "Event", Text = "Back to event" } }));

#line default
#line hidden
            EndContext();
            BeginContext(277, 631, true);
            WriteLiteral(@"
    <div class=""container"">
        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-3"">Order number</section>
                <section class=""esh-orders_detail-title col-xs-3"">Date</section>
                <section class=""esh-orders_detail-title col-xs-3"">Total</section>
                <section class=""esh-orders_detail-title col-xs-3"">Status</section>
            </article>
            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-3"">");
            EndContext();
            BeginContext(909, 13, false);
#line 19 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
                                                            Write(Model.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(922, 77, true);
            WriteLiteral("</section>\r\n                <section class=\"esh-orders_detail-item col-xs-3\">");
            EndContext();
            BeginContext(1000, 15, false);
#line 20 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
                                                            Write(Model.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(1015, 79, true);
            WriteLiteral("</section>\r\n                <section class=\"esh-orders_detail-item col-xs-3\">$ ");
            EndContext();
            BeginContext(1095, 30, false);
#line 21 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
                                                              Write(Math.Round(Model.OrderTotal,2));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 77, true);
            WriteLiteral("</section>\r\n                <section class=\"esh-orders_detail-item col-xs-3\">");
            EndContext();
            BeginContext(1203, 17, false);
#line 22 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
                                                            Write(Model.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1220, 412, true);
            WriteLiteral(@"</section>
            </article>
        </section>
        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-12"">Shiping address</section>
            </article>
            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-12"">");
            EndContext();
            BeginContext(1633, 13, false);
#line 30 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
                                                             Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1646, 36, true);
            WriteLiteral("</section>\r\n            </article>\r\n");
            EndContext();
            BeginContext(2033, 249, true);
            WriteLiteral("        </section>\r\n        <section class=\"esh-orders_detail-section\">\r\n            <article class=\"esh-orders_detail-titles row\">\r\n                <section class=\"esh-orders_detail-title col-xs-12\">ORDER DETAILS</section>\r\n            </article>\r\n");
            EndContext();
#line 43 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
             for (int i = 0; i < Model.OrderItems.Count; i++)
            {
                var item = Model.OrderItems[i];

#line default
#line hidden
            BeginContext(2409, 241, true);
            WriteLiteral("                <article class=\"esh-orders_detail-items esh-orders_detail-items--border row\">\r\n                    <section class=\"esh-orders_detail-item col-md-4 hidden-md-down\">\r\n                        <img class=\"esh-orders_detail-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2650, "\"", 2672, 1);
#line 48 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
WriteAttributeValue("", 2656, item.PictureUrl, 2656, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2673, 135, true);
            WriteLiteral(">\r\n                    </section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-4\">");
            EndContext();
            BeginContext(2809, 16, false);
#line 50 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
                                                                                               Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2825, 114, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-1\">$ ");
            EndContext();
            BeginContext(2940, 29, false);
#line 51 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
                                                                                                 Write(Math.Round(item.UnitPrice, 2));

#line default
#line hidden
            EndContext();
            BeginContext(2969, 112, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-1\">");
            EndContext();
            BeginContext(3082, 10, false);
#line 52 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
                                                                                               Write(item.Units);

#line default
#line hidden
            EndContext();
            BeginContext(3092, 114, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-2\">$ ");
            EndContext();
            BeginContext(3207, 42, false);
#line 53 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
                                                                                                 Write(Math.Round(item.Units * item.UnitPrice, 2));

#line default
#line hidden
            EndContext();
            BeginContext(3249, 40, true);
            WriteLiteral("</section>\r\n                </article>\r\n");
            EndContext();
#line 55 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(3304, 608, true);
            WriteLiteral(@"        </section>
        <section class=""esh-orders_detail-section esh-orders_detail-section--right"">
            <article class=""esh-orders_detail-titles esh-basket-titles--clean row"">
                <section class=""esh-orders_detail-title col-xs-9""></section>
                <section class=""esh-orders_detail-title col-xs-2"">TOTAL</section>
            </article>
            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-9""></section>
                <section class=""esh-orders_detail-item esh-orders_detail-item--mark col-xs-2"">$ ");
            EndContext();
            BeginContext(3913, 30, false);
#line 64 "C:\Users\smvnc\source\repos\EventBriteAPI5\WebMvc\Views\Order\Detail.cshtml"
                                                                                           Write(Math.Round(Model.OrderTotal,2));

#line default
#line hidden
            EndContext();
            BeginContext(3943, 76, true);
            WriteLiteral("</section>\r\n            </article>\r\n        </section>\r\n    </div>\r\n</div>\r\n");
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