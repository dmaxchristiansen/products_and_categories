#pragma checksum "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/Category/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62e5a3db20b5a258475f8cebe9a8e14af22f328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Show), @"mvc.1.0.view", @"/Views/Category/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Show.cshtml", typeof(AspNetCore.Views_Category_Show))]
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
#line 1 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/_ViewImports.cshtml"
using ProductsAndCategories;

#line default
#line hidden
#line 2 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/_ViewImports.cshtml"
using ProductsAndCategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62e5a3db20b5a258475f8cebe9a8e14af22f328", @"/Views/Category/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3772dd1aab0a113eef9daa4fd8f7fdb8a407ef7", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssociateCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Association", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 39, true);
            WriteLiteral("<h1 class=\"text-center display-1 mb-4\">");
            EndContext();
            BeginContext(56, 10, false);
#line 2 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/Category/Show.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(66, 86, true);
            WriteLiteral("</h1>\n<div class=\"row\">\n    <div class=\"col\">\n        <h2>Products:</h2>\n        <ul>\n");
            EndContext();
#line 7 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/Category/Show.cshtml"
             foreach (var association in Model.Associations)
            {

#line default
#line hidden
            BeginContext(227, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(248, 24, false);
#line 9 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/Category/Show.cshtml"
               Write(association.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(272, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 10 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/Category/Show.cshtml"
            }

#line default
#line hidden
            BeginContext(292, 85, true);
            WriteLiteral("        </ul>\n    </div>\n    <div class=\"col\">\n        <h2>Add Product:</h2>\n        ");
            EndContext();
            BeginContext(377, 590, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a62e5a3db20b5a258475f8cebe9a8e14af22f3286007", async() => {
                BeginContext(457, 92, true);
                WriteLiteral("\n            <div class=\"form-group\">\n                <input type=\"hidden\" name=\"CategoryId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 549, "\"", 574, 1);
#line 17 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/Category/Show.cshtml"
WriteAttributeValue("", 557, Model.CategoryId, 557, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(575, 65, true);
                WriteLiteral(">\n                <select name=\"ProductId\" class=\"form-control\">\n");
                EndContext();
#line 19 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/Category/Show.cshtml"
                     foreach (var product in ViewBag.Unrelated)
                    {

#line default
#line hidden
                BeginContext(726, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(750, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a62e5a3db20b5a258475f8cebe9a8e14af22f3287360", async() => {
                    BeginContext(786, 12, false);
#line 21 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/Category/Show.cshtml"
                                                      Write(product.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 21 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/Category/Show.cshtml"
                           WriteLiteral(product.ProductId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(807, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 22 "/Users/danielchristiansen/Documents/CodingDojo/CSharpStack/ASP/ProductsAndCategories/Views/Category/Show.cshtml"
                    }

#line default
#line hidden
                BeginContext(830, 130, true);
                WriteLiteral("                </select>\n            </div>\n            <input type=\"submit\" value=\"Add\" class=\"btn btn-primary btn-lg\">\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(967, 18, true);
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
