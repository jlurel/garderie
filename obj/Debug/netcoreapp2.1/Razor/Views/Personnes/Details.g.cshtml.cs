#pragma checksum "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb6e19709463eb3e888f023aefa048eb5b1be4ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personnes_Details), @"mvc.1.0.view", @"/Views/Personnes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personnes/Details.cshtml", typeof(AspNetCore.Views_Personnes_Details))]
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
#line 1 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/_ViewImports.cshtml"
using Garderie;

#line default
#line hidden
#line 2 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/_ViewImports.cshtml"
using Garderie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb6e19709463eb3e888f023aefa048eb5b1be4ea", @"/Views/Personnes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd06d82c8438d05622e08f6556b645a0b156553", @"/Views/_ViewImports.cshtml")]
    public class Views_Personnes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Garderie.Models.Personne>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Personne</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(201, 39, false);
#line 14 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(240, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(284, 35, false);
#line 17 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(319, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(363, 42, false);
#line 20 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(405, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(449, 38, false);
#line 23 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(487, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(531, 40, false);
#line 26 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sexe));

#line default
#line hidden
            EndContext();
            BeginContext(571, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(615, 36, false);
#line 29 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Sexe));

#line default
#line hidden
            EndContext();
            BeginContext(651, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(695, 49, false);
#line 32 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateNaissance));

#line default
#line hidden
            EndContext();
            BeginContext(744, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(788, 45, false);
#line 35 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayFor(model => model.DateNaissance));

#line default
#line hidden
            EndContext();
            BeginContext(833, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(877, 43, false);
#line 38 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumSecu));

#line default
#line hidden
            EndContext();
            BeginContext(920, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(964, 39, false);
#line 41 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayFor(model => model.NumSecu));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1047, 43, false);
#line 44 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Visible));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1134, 39, false);
#line 47 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Visible));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1217, 49, false);
#line 50 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discriminator));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1310, 45, false);
#line 53 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Discriminator));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1402, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e6589b30884af191dfcadb34e5b248", async() => {
                BeginContext(1456, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/Personnes/Details.cshtml"
                           WriteLiteral(Model.PersonneId);

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
            BeginContext(1464, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1472, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e8ebe3d02574359811f09e29615bdba", async() => {
                BeginContext(1494, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1510, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Garderie.Models.Personne> Html { get; private set; }
    }
}
#pragma warning restore 1591