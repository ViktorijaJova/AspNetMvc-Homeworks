#pragma checksum "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "925bc2c5bba400094eda780ead4de7b7df7f5cc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"925bc2c5bba400094eda780ead4de7b7df7f5cc5", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1b5672b3741a8e55ac097f3897fc31a33d13ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\About.cshtml"
   
    ViewBag.Title = "About Us"; 

#line default
#line hidden
            BeginContext(39, 165, true);
            WriteLiteral("<div class=\"jumbotron\">\n    <h1>About Us</h1>\n    <p>We are the best company and have 1000 employees around the world!</p>\n    <button class=\"btn btn-danger btn-lg\">");
            EndContext();
            BeginContext(205, 47, false);
#line 7 "C:\Users\User\Desktop\New folder\PizzaApp\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\About.cshtml"
                                     Write(Html.ActionLink("Feedback", "Feedback", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(252, 17, true);
            WriteLiteral("</button>\n</div>\n");
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