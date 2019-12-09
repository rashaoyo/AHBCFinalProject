#pragma checksum "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/Recipe/ViewRecipes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb10469276ad721a1e0cf56dc5333b0f9ea38d71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_ViewRecipes), @"mvc.1.0.view", @"/Views/Recipe/ViewRecipes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipe/ViewRecipes.cshtml", typeof(AspNetCore.Views_Recipe_ViewRecipes))]
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
#line 1 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/_ViewImports.cshtml"
using AHBCFinalProject;

#line default
#line hidden
#line 2 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/_ViewImports.cshtml"
using AHBCFinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb10469276ad721a1e0cf56dc5333b0f9ea38d71", @"/Views/Recipe/ViewRecipes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ce663d494474ccfa74e0995c5c359b86b9ed2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_ViewRecipes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListOfRecipesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/Recipe/ViewRecipes.cshtml"
  
    ViewData["Title"] = "ViewRecipes";

#line default
#line hidden
            BeginContext(74, 161, true);
            WriteLiteral("\n<h1>View All Recipes</h1>\n\n<div>\n    <table>\n        <thead>\n            <tr>\n                <th>Title</th>\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 16 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/Recipe/ViewRecipes.cshtml"
             foreach (var recipe in Model.ListOfRecipes)
            {

#line default
#line hidden
            BeginContext(306, 70, true);
            WriteLiteral("                <tr>\n                    <td>\n                        ");
            EndContext();
            BeginContext(376, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb10469276ad721a1e0cf56dc5333b0f9ea38d714617", async() => {
                BeginContext(452, 12, false);
#line 20 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/Recipe/ViewRecipes.cshtml"
                                                                                              Write(recipe.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/Recipe/ViewRecipes.cshtml"
                                                                           WriteLiteral(recipe.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(468, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 23 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/Recipe/ViewRecipes.cshtml"
            }

#line default
#line hidden
            BeginContext(531, 36, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListOfRecipesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
