#pragma checksum "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b063dc39fc7e2dd0e05e08bd9b53a76994416440"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClinicalSpecialtyFront_Details), @"mvc.1.0.view", @"/Views/ClinicalSpecialtyFront/Details.cshtml")]
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
#line 1 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\_ViewImports.cshtml"
using HealthAppFrontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\_ViewImports.cshtml"
using HealthAppFrontend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b063dc39fc7e2dd0e05e08bd9b53a76994416440", @"/Views/ClinicalSpecialtyFront/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977d62f7d4857fff6952e4a9584fdb4b68923d97", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ClinicalSpecialtyFront_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthAppFrontend.Models.ClinicalSpecialtyFront>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>ClinicalSpecialtyFront</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.field));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml"
       Write(Html.DisplayFor(model => model.field));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml"
       Write(Html.DisplayFor(model => model.specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml"
       Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 40 "C:\academia\Proyectos\Tercer Proyecto\App\HealthApp_Backend\HealthAppFrontend\Views\ClinicalSpecialtyFront\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new {  id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b063dc39fc7e2dd0e05e08bd9b53a769944164407265", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthAppFrontend.Models.ClinicalSpecialtyFront> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
