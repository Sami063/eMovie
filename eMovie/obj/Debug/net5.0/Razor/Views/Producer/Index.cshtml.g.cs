#pragma checksum "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4bf30b3034474aab8cb9a05607ca09d16078ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producer_Index), @"mvc.1.0.view", @"/Views/Producer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4bf30b3034474aab8cb9a05607ca09d16078ff8", @"/Views/Producer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd84eaccfa09144048eb6b8edd001a737e172fc2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Producer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eMovie.Models.Producer>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
  
    ViewData["Title"] = "Available Producers";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Search field for Producers -->\r\n<h3> Welcome to the producers page! </h3>\r\n<div class=\"container\">\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4bf30b3034474aab8cb9a05607ca09d16078ff85406", async() => {
                WriteLiteral("Create Producer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4bf30b3034474aab8cb9a05607ca09d16078ff86705", async() => {
                WriteLiteral(@"
            <span class=""btn-group"" style=""width: 200px;"">
                <input class=""form-control"" type=""text"" name=""findProducer"" placeholder=""Search"" />
            </span>
            <input class=""p-1 ml-2 btn btn-sm btn-info"" type=""submit"" value=""Find"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n</div>\r\n\r\n<div class=\"col-12 border p-0 mt-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4bf30b3034474aab8cb9a05607ca09d16078ff88718", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
         if(Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <table class=\"table table-striped border table-dark\">\r\n                <tr class=\"table-primary\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.ProfileURL));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 35 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.Bio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 41 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.Movies));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n\r\n");
#nullable restore
#line 45 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
                 foreach (var producer in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 1661, "\"", 1701, 1);
#nullable restore
#line 49 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
WriteAttributeValue("", 1667, Url.Content(@producer.ProfileURL), 1667, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"90\"; height= \"90\" /> \r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 52 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
                       Write(Html.DisplayFor(p => producer.FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
                       Write(Html.DisplayFor(p => producer.Bio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"btn btn-success btn-sm text-white\">\r\n                                ");
#nullable restore
#line 62 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
                           Write(Html.ActionLink("Detail", "Detail", new { id = producer.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"btn btn-danger btn-sm text-white\">\r\n                                ");
#nullable restore
#line 67 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { id = producer.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n");
#nullable restore
#line 73 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
        } 
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h1> No Actors found </h1>\r\n");
#nullable restore
#line 77 "C:\Users\Samuel\Documents\eMovie\eMovie\eMovie\Views\Producer\Index.cshtml"
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<style>\r\n    img {\r\n        width: 100px;\r\n        height: 100px;\r\n        border-top: 0; \r\n        border-bottom: 0;\r\n        border-left: 0;\r\n        border-radius: 50%;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eMovie.Models.Producer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
