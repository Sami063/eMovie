#pragma checksum "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d44efe08853f280e7b43299aecf84bfffe6ce8a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cinema_Cinema), @"mvc.1.0.view", @"/Views/Cinema/Cinema.cshtml")]
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
#line 1 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\_ViewImports.cshtml"
using eMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\_ViewImports.cshtml"
using eMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d44efe08853f280e7b43299aecf84bfffe6ce8a2", @"/Views/Cinema/Cinema.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd84eaccfa09144048eb6b8edd001a737e172fc2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cinema_Cinema : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eMovie.Models.Cinema>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d44efe08853f280e7b43299aecf84bfffe6ce8a23876", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
  
    ViewData["Title"] = "Available Cinemas";

#line default
#line hidden
#nullable disable
                WriteLiteral("        <!-- Header -->\r\n        <meta name=\"viewport\" content=\"mobile\" />\r\n        <title>Index</title>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d44efe08853f280e7b43299aecf84bfffe6ce8a25205", async() => {
                WriteLiteral("\r\n\r\n        <!-- Search form for cinemas -->\r\n\r\n\r\n<div class=\"col-12 border p-0 mt-3\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d44efe08853f280e7b43299aecf84bfffe6ce8a25565", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
         if(Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <table class=\"table table-striped border table-dark\">\r\n                <tr class=\"table-primary\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 25 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.CinemaLogo));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 28 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.Name));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.Description));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
                 foreach (var cinema in Model)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <img");
                    BeginWriteAttribute("src", " src=\"", 1083, "\"", 1121, 1);
#nullable restore
#line 39 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
WriteAttributeValue("", 1089, Url.Content(@cinema.CinemaLogo), 1089, 32, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" width=\"200\" /> \r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
                       Write(Html.DisplayFor(c => cinema.Name));

#line default
#line hidden
#nullable disable
                    WriteLiteral(" \r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
                       Write(Html.DisplayFor(c => cinema.Description));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"btn btn-success btn-sm text-white\">\r\n                                ");
#nullable restore
#line 49 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
                           Write(Html.ActionLink("Detail", "Detail", new { id = cinema.Id }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"btn btn-danger btn-sm text-white\">\r\n                                ");
#nullable restore
#line 52 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { id = cinema.Id } ));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("            </table>\r\n");
#nullable restore
#line 58 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
        } 
        else
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <h1> No Cinemas Available in this moment :( </h1>\r\n");
#nullable restore
#line 62 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Cinema\Cinema.cshtml"
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</div>\r\n\r\n\r\n<style>\r\n    .form-outline {\r\n       \r\n        display: inline-flex;\r\n    }\r\n</style>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eMovie.Models.Cinema>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
