#pragma checksum "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aae7e1306e89d865db075523d39b830cb7dbcd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewUserPreferences), @"mvc.1.0.view", @"/Views/User/ViewUserPreferences.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ViewUserPreferences.cshtml", typeof(AspNetCore.Views_User_ViewUserPreferences))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aae7e1306e89d865db075523d39b830cb7dbcd1", @"/Views/User/ViewUserPreferences.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ce663d494474ccfa74e0995c5c359b86b9ed2a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ViewUserPreferences : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserPreferencesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewRecipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
  
    ViewData["Title"] = "ViewUserPreferences";

#line default
#line hidden
            BeginContext(85, 31, true);
            WriteLiteral("\n<h1>ViewUserPreferences</h1>\n\n");
            EndContext();
            BeginContext(116, 980, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aae7e1306e89d865db075523d39b830cb7dbcd14398", async() => {
                BeginContext(171, 37, true);
                WriteLiteral("\n    <h2>Diets</h2>\n    Gluten-Free: ");
                EndContext();
                BeginContext(209, 16, false);
#line 11 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
            Write(Model.GlutenFree);

#line default
#line hidden
                EndContext();
                BeginContext(225, 22, true);
                WriteLiteral("<br />\n    Ketogenic: ");
                EndContext();
                BeginContext(248, 15, false);
#line 12 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
          Write(Model.Ketogenic);

#line default
#line hidden
                EndContext();
                BeginContext(263, 23, true);
                WriteLiteral("<br />\n    Vegetarian: ");
                EndContext();
                BeginContext(287, 16, false);
#line 13 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
           Write(Model.Vegetarian);

#line default
#line hidden
                EndContext();
                BeginContext(303, 29, true);
                WriteLiteral("<br />\n    Lacto-Vegetarian: ");
                EndContext();
                BeginContext(333, 21, false);
#line 14 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
                 Write(Model.LactoVegetarian);

#line default
#line hidden
                EndContext();
                BeginContext(354, 27, true);
                WriteLiteral("<br />\n    Ovo-Vegetarian: ");
                EndContext();
                BeginContext(382, 19, false);
#line 15 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
               Write(Model.OvoVegetarian);

#line default
#line hidden
                EndContext();
                BeginContext(401, 18, true);
                WriteLiteral("<br />\n    Vegan: ");
                EndContext();
                BeginContext(420, 11, false);
#line 16 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
      Write(Model.Vegan);

#line default
#line hidden
                EndContext();
                BeginContext(431, 24, true);
                WriteLiteral("<br />\n    Pescetarian: ");
                EndContext();
                BeginContext(456, 17, false);
#line 17 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
            Write(Model.Pescetarian);

#line default
#line hidden
                EndContext();
                BeginContext(473, 18, true);
                WriteLiteral("<br />\n    Paleo: ");
                EndContext();
                BeginContext(492, 11, false);
#line 18 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
      Write(Model.Paleo);

#line default
#line hidden
                EndContext();
                BeginContext(503, 19, true);
                WriteLiteral("<br />\n    Primal: ");
                EndContext();
                BeginContext(523, 12, false);
#line 19 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
       Write(Model.Primal);

#line default
#line hidden
                EndContext();
                BeginContext(535, 20, true);
                WriteLiteral("<br />\n    Whole30: ");
                EndContext();
                BeginContext(556, 13, false);
#line 20 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
        Write(Model.Whole30);

#line default
#line hidden
                EndContext();
                BeginContext(569, 45, true);
                WriteLiteral("<br />\n\n    <h2>Intolerances</h2>\n    Dairy: ");
                EndContext();
                BeginContext(615, 11, false);
#line 23 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
      Write(Model.Dairy);

#line default
#line hidden
                EndContext();
                BeginContext(626, 16, true);
                WriteLiteral("<br />\n    Egg: ");
                EndContext();
                BeginContext(643, 9, false);
#line 24 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
    Write(Model.Egg);

#line default
#line hidden
                EndContext();
                BeginContext(652, 19, true);
                WriteLiteral("<br />\n    Gluten: ");
                EndContext();
                BeginContext(672, 12, false);
#line 25 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
       Write(Model.Gluten);

#line default
#line hidden
                EndContext();
                BeginContext(684, 18, true);
                WriteLiteral("<br />\n    Grain: ");
                EndContext();
                BeginContext(703, 11, false);
#line 26 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
      Write(Model.Grain);

#line default
#line hidden
                EndContext();
                BeginContext(714, 19, true);
                WriteLiteral("<br />\n    Peanut: ");
                EndContext();
                BeginContext(734, 12, false);
#line 27 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
       Write(Model.Peanut);

#line default
#line hidden
                EndContext();
                BeginContext(746, 20, true);
                WriteLiteral("<br />\n    Seafood: ");
                EndContext();
                BeginContext(767, 13, false);
#line 28 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
        Write(Model.Seafood);

#line default
#line hidden
                EndContext();
                BeginContext(780, 19, true);
                WriteLiteral("<br />\n    Sesame: ");
                EndContext();
                BeginContext(800, 12, false);
#line 29 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
       Write(Model.Sesame);

#line default
#line hidden
                EndContext();
                BeginContext(812, 22, true);
                WriteLiteral("<br />\n    Shellfish: ");
                EndContext();
                BeginContext(835, 15, false);
#line 30 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
          Write(Model.Shellfish);

#line default
#line hidden
                EndContext();
                BeginContext(850, 16, true);
                WriteLiteral("<br />\n    Soy: ");
                EndContext();
                BeginContext(867, 9, false);
#line 31 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
    Write(Model.Soy);

#line default
#line hidden
                EndContext();
                BeginContext(876, 20, true);
                WriteLiteral("<br />\n    Sulfite: ");
                EndContext();
                BeginContext(897, 13, false);
#line 32 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
        Write(Model.Sulfite);

#line default
#line hidden
                EndContext();
                BeginContext(910, 21, true);
                WriteLiteral("<br />\n    Tree Nut: ");
                EndContext();
                BeginContext(932, 13, false);
#line 33 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
         Write(Model.TreeNut);

#line default
#line hidden
                EndContext();
                BeginContext(945, 18, true);
                WriteLiteral("<br />\n    Wheat: ");
                EndContext();
                BeginContext(964, 11, false);
#line 34 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
      Write(Model.Wheat);

#line default
#line hidden
                EndContext();
                BeginContext(975, 33, true);
                WriteLiteral("<br />\n    Excluded Ingredients: ");
                EndContext();
                BeginContext(1009, 25, false);
#line 35 "/Users/edwardsosnoski/Projects/GrandCircus/AHBCFinalProject/AHBCFinalProject/Views/User/ViewUserPreferences.cshtml"
                     Write(Model.ExcludedIngredients);

#line default
#line hidden
                EndContext();
                BeginContext(1034, 55, true);
                WriteLiteral("<br />\n\n    <button type=\"submit\">Get Recipes</button>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserPreferencesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
