#pragma checksum "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb71ef6cb6a7ddb58d00fb4e87dd490b96b1477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Details.cshtml", typeof(AspNetCore.Views_Order_Details))]
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
#line 1 "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Application;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Application.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.BusinessModels.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb71ef6cb6a7ddb58d00fb4e87dd490b96b1477", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1b5672b3741a8e55ac097f3897fc31a33d13ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Order\Details.cshtml"
   
    ViewBag.Title = "Order no. " + Model.Order.Id; 

#line default
#line hidden
            BeginContext(87, 14, true);
            WriteLiteral("<h1>Order No. ");
            EndContext();
            BeginContext(102, 14, false);
#line 5 "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Order\Details.cshtml"
         Write(Model.Order.Id);

#line default
#line hidden
            EndContext();
            BeginContext(116, 25, true);
            WriteLiteral("</h1>\n<h3>Delivery Info: ");
            EndContext();
            BeginContext(142, 13, false);
#line 6 "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Order\Details.cshtml"
              Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(155, 7, true);
            WriteLiteral(" (tel: ");
            EndContext();
            BeginContext(163, 11, false);
#line 6 "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Order\Details.cshtml"
                                   Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(174, 7, true);
            WriteLiteral(")</h3>\n");
            EndContext();
            BeginContext(182, 46, false);
#line 7 "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Order\Details.cshtml"
Write(Html.Partial("_orderItemPartial", Model.Order));

#line default
#line hidden
            EndContext();
            BeginContext(228, 1, true);
            WriteLiteral(";");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
