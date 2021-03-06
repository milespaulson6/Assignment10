#pragma checksum "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed661481ca71a38ac9a85ac6b7c831d3bb5368ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Miles\source\repos\Assignment10\Views\_ViewImports.cshtml"
using Assignment10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Miles\source\repos\Assignment10\Views\_ViewImports.cshtml"
using Assignment10.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Miles\source\repos\Assignment10\Views\_ViewImports.cshtml"
using Assignment10.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed661481ca71a38ac9a85ac6b7c831d3bb5368ab", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"199e4e7a0109d67a8c68bacf4b0295522127f8c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Assignment10.Infrastructure.PaginationTagHelper __Assignment10_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to the Bowling League</h1>\r\n    <br />\r\n    <br />\r\n    <h2 class=\"display-4\">");
#nullable restore
#line 10 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                     Write(Model.TeamCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    <br />
    <br />
    
        <table class=""table-hover table-striped table-bordered table-layout: auto"">
            <thead class=""text-center"">
                <tr><th>FirstName</th><th>Middle</th><th>LastName</th><th>Address</th><th>City</th><th>State</th><th>Zipcode</th><th>Phone #</th></tr>
            </thead>

            <tbody class=""text-center"">
");
#nullable restore
#line 20 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                 foreach (var x in Model.Bowlers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                       Write(x.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                       Write(x.BowlerMiddleInit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                       Write(x.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                       Write(x.BowlerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                       Write(x.BowlerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                       Write(x.BowlerState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                       Write(x.BowlerZip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                       Write(x.BowlerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n       \r\n    \r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed661481ca71a38ac9a85ac6b7c831d3bb5368ab6869", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            __Assignment10_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Assignment10.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Assignment10_Infrastructure_PaginationTagHelper);
#nullable restore
#line 39 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumberingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __Assignment10_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-teamtype", "Assignment10.Infrastructure.PaginationTagHelper", "KeyValuePairs"));
            }
#nullable restore
#line 40 "C:\Users\Miles\source\repos\Assignment10\Views\Home\Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs["teamtype"] = Model.TeamCategory;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-teamtype", __Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs["teamtype"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
