#pragma checksum "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1ab63abb46edd610f85a891625421a9375d4759"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lamp_Edit), @"mvc.1.0.view", @"/Views/Lamp/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1ab63abb46edd610f85a891625421a9375d4759", @"/Views/Lamp/Edit.cshtml")]
    public class Views_Lamp_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Lamp>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("PageScripts", async() => {
                WriteLiteral("\r\n    <script src=\"Scripts/BaseEntityPages.js\"></script>\r\n");
            }
            );
            WriteLiteral("\r\n<h2>Edit Lamp</h2>\r\n\r\n");
#nullable restore
#line 14 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <hr />\r\n    ");
#nullable restore
#line 20 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 24 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
   Write(Html.LabelFor(model => model.Label, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 26 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
       Write(Html.EditorFor(model => model.Label, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 27 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Label, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 33 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
   Write(Html.LabelFor(model => model.LampCode, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 35 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
       Write(Html.EditorFor(model => model.LampCode, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 36 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.LampCode, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
            WriteLiteral("    ");
#nullable restore
#line 41 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
Write(Html.Partial("~/Views/Shared/_ParametersView.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 49 "D:\GitRepositories\HandlingInfiniteNumberOfParameters\WorkingWithIndefiniteNumberOfParameters\Views\Lamp\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Lamp> Html { get; private set; }
    }
}
#pragma warning restore 1591
