#pragma checksum "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Shared\_Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e52d0b9417ce726e623d1c67b638f778951f3e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Error), @"mvc.1.0.view", @"/Views/Shared/_Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Error.cshtml", typeof(AspNetCore.Views_Shared__Error))]
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
#line 1 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\_ViewImports.cshtml"
using ConcertTickets.Application;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\_ViewImports.cshtml"
using ConcertTickets.Application.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e52d0b9417ce726e623d1c67b638f778951f3e1", @"/Views/Shared/_Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f3dbad3b0f4beb609c64d5eda630d298edd63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Shared\_Error.cshtml"
   ViewBag.Title = "Sorry"; 

#line default
#line hidden
            BeginContext(30, 222, true);
            WriteLiteral("<div class=\"jumbotron\">\n    <h1>Sorry but there is no order/address on this url</h1>\n    <p>For any problems please contact us or leave feedback to help us improve</p>\n    <p>\n        <button class=\"btn btn-danger btn-lg\">");
            EndContext();
            BeginContext(253, 47, false);
#line 6 "C:\Users\User\Desktop\AspNetMvc-Homeworks\ConcertTicketsApp\ConcertTicketsApp\ConcertTickets.Application\Views\Shared\_Error.cshtml"
                                         Write(Html.ActionLink("Feedback", "Feedback", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(300, 28, true);
            WriteLiteral("</button>\n    </p>\n</div>\n\n\n");
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
