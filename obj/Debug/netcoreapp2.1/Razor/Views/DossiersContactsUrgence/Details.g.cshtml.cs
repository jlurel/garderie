#pragma checksum "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5c2a0dbaea41d19d1d5e264efd76ff32cd3ad6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DossiersContactsUrgence_Details), @"mvc.1.0.view", @"/Views/DossiersContactsUrgence/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DossiersContactsUrgence/Details.cshtml", typeof(AspNetCore.Views_DossiersContactsUrgence_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5c2a0dbaea41d19d1d5e264efd76ff32cd3ad6d", @"/Views/DossiersContactsUrgence/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd06d82c8438d05622e08f6556b645a0b156553", @"/Views/_ViewImports.cshtml")]
    public class Views_DossiersContactsUrgence_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Garderie.Models.DossierContactUrgence>
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 135, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>DossierContactUrgence</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(227, 47, false);
#line 14 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LienParente));

#line default
#line hidden
            EndContext();
            BeginContext(274, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(318, 43, false);
#line 17 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml"
       Write(Html.DisplayFor(model => model.LienParente));

#line default
#line hidden
            EndContext();
            BeginContext(361, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(405, 43, false);
#line 20 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Visible));

#line default
#line hidden
            EndContext();
            BeginContext(448, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(492, 39, false);
#line 23 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml"
       Write(Html.DisplayFor(model => model.Visible));

#line default
#line hidden
            EndContext();
            BeginContext(531, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(575, 43, false);
#line 26 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact));

#line default
#line hidden
            EndContext();
            BeginContext(618, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(662, 49, false);
#line 29 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml"
       Write(Html.DisplayFor(model => model.Contact.ContactId));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 54, false);
#line 32 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DossierInscription));

#line default
#line hidden
            EndContext();
            BeginContext(809, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(853, 60, false);
#line 35 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml"
       Write(Html.DisplayFor(model => model.DossierInscription.DossierId));

#line default
#line hidden
            EndContext();
            BeginContext(913, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(960, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66a04ab2115943549e61c41f42a86180", async() => {
                BeginContext(1027, 4, true);
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
#line 40 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersContactsUrgence/Details.cshtml"
                           WriteLiteral(Model.DossierContactUrgenceId);

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
            BeginContext(1035, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1043, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d09e86b74ac4b04be760eb43a2b72d7", async() => {
                BeginContext(1065, 12, true);
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
            BeginContext(1081, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Garderie.Models.DossierContactUrgence> Html { get; private set; }
    }
}
#pragma warning restore 1591
