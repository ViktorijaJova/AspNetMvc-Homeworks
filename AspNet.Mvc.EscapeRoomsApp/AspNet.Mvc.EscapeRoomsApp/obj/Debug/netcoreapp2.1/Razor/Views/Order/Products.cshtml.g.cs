#pragma checksum "C:\Users\User\Desktop\AspNetMvc-Homeworks\AspNet.Mvc.EscapeRoomsApp\AspNet.Mvc.EscapeRoomsApp\Views\Order\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56e0877e835fd15287f7ad8fc968d25a74f46f55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Products), @"mvc.1.0.view", @"/Views/Order/Products.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Products.cshtml", typeof(AspNetCore.Views_Order_Products))]
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
#line 1 "C:\Users\User\Desktop\AspNetMvc-Homeworks\AspNet.Mvc.EscapeRoomsApp\AspNet.Mvc.EscapeRoomsApp\Views\_ViewImports.cshtml"
using AspNet.Mvc.EscapeRoomsApp;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\AspNetMvc-Homeworks\AspNet.Mvc.EscapeRoomsApp\AspNet.Mvc.EscapeRoomsApp\Views\_ViewImports.cshtml"
using AspNet.Mvc.EscapeRoomsApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e0877e835fd15287f7ad8fc968d25a74f46f55", @"/Views/Order/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501b3eaf7837ff102e73366003c1cfd5ee303db9", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNet.Mvc.EscapeRoomsApp.Models.ViewModals.Products.ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_orderItemPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(82, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\User\Desktop\AspNetMvc-Homeworks\AspNet.Mvc.EscapeRoomsApp\AspNet.Mvc.EscapeRoomsApp\Views\Order\Products.cshtml"
  
    ViewData["Title"] = "Escape Rooms";

#line default
#line hidden
            BeginContext(134, 111, true);
            WriteLiteral("\r\n<h2>Escape Rooms Details:</h2>\r\n\r\n\r\n\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-12\">\r\n        <h3>We have  ");
            EndContext();
            BeginContext(246, 24, false);
#line 15 "C:\Users\User\Desktop\AspNetMvc-Homeworks\AspNet.Mvc.EscapeRoomsApp\AspNet.Mvc.EscapeRoomsApp\Views\Order\Products.cshtml"
                Write(Model.TotalNumberOfRooms);

#line default
#line hidden
            EndContext();
            BeginContext(270, 43, true);
            WriteLiteral(" total number of rooms</h3>\r\n        <ol>\r\n");
            EndContext();
#line 17 "C:\Users\User\Desktop\AspNetMvc-Homeworks\AspNet.Mvc.EscapeRoomsApp\AspNet.Mvc.EscapeRoomsApp\Views\Order\Products.cshtml"
             foreach (var product in Model.EscapeRooms)
            {

#line default
#line hidden
            BeginContext(385, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(401, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "737349c29fa24b7397b7a33e74607791", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 19 "C:\Users\User\Desktop\AspNetMvc-Homeworks\AspNet.Mvc.EscapeRoomsApp\AspNet.Mvc.EscapeRoomsApp\Views\Order\Products.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => product);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(452, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "C:\Users\User\Desktop\AspNetMvc-Homeworks\AspNet.Mvc.EscapeRoomsApp\AspNet.Mvc.EscapeRoomsApp\Views\Order\Products.cshtml"
            }

#line default
#line hidden
            BeginContext(469, 35, true);
            WriteLiteral("        </ol>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNet.Mvc.EscapeRoomsApp.Models.ViewModals.Products.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
