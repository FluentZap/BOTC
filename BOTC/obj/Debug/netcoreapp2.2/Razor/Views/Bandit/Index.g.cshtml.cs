#pragma checksum "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63f034b1826f1e2d8926bb468074366627a6f445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bandit_Index), @"mvc.1.0.view", @"/Views/Bandit/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bandit/Index.cshtml", typeof(AspNetCore.Views_Bandit_Index))]
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
#line 1 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/_ViewImports.cshtml"
using BanditsOfTheCoast.Solution;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/_ViewImports.cshtml"
using BanditsOfTheCoast.Solution.Models;

#line default
#line hidden
#line 3 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/_ViewImports.cshtml"
using BOTC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63f034b1826f1e2d8926bb468074366627a6f445", @"/Views/Bandit/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00c9bc0fc9c89c9ef57e28daefbedce64f19a7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Bandit_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bandit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Index.cshtml"
  
    ViewData["Title"] = "Crew Page";

#line default
#line hidden
            BeginContext(45, 69, true);
            WriteLiteral("\r\n<div class=\"splash-title\">\r\n    <h1 class=\"display-4\">Crew</h1>\r\n\r\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Index.cshtml"
       foreach(Bandit bandit in Model)
      {

#line default
#line hidden
            BeginContext(163, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(174, 288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63f034b1826f1e2d8926bb468074366627a6f4454398", async() => {
                BeginContext(245, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(247, 11, false);
#line 10 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Index.cshtml"
                                                                              Write(bandit.Name);

#line default
#line hidden
                EndContext();
                BeginContext(258, 6, true);
                WriteLiteral(" The\r\n");
                EndContext();
#line 11 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Index.cshtml"
         if(bandit.Stats.Strength > 9)
        {

#line default
#line hidden
                BeginContext(315, 31, true);
                WriteLiteral("          <span>Mighty</span>\r\n");
                EndContext();
#line 14 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Index.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(382, 29, true);
                WriteLiteral("          <span>Weak</span>\r\n");
                EndContext();
#line 18 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Index.cshtml"
        }

#line default
#line hidden
                BeginContext(422, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(431, 17, false);
#line 19 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Index.cshtml"
   Write(bandit.Stats.Name);

#line default
#line hidden
                EndContext();
                BeginContext(448, 10, true);
                WriteLiteral("\r\n        ");
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
#line 10 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Index.cshtml"
                                                          WriteLiteral(bandit.Id);

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
            BeginContext(462, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Index.cshtml"
      }

#line default
#line hidden
            BeginContext(477, 8, true);
            WriteLiteral("</div>\r\n");
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
