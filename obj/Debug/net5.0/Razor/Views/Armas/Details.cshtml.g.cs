#pragma checksum "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "958857f6dd24c6e03f6c707810f3742408fe8498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Armas_Details), @"mvc.1.0.view", @"/Views/Armas/Details.cshtml")]
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
#line 1 "C:\Etec\DS\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Etec\DS\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"958857f6dd24c6e03f6c707810f3742408fe8498", @"/Views/Armas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Armas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.ArmaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
  
    ViewBag.Title = "Detalhes da Arma";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Detalhes da Arma</h2>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>");
#nullable restore
#line 9 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 10 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>");
#nullable restore
#line 12 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 13 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>    \r\n\r\n        <dt>");
#nullable restore
#line 15 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 16 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>");
#nullable restore
#line 18 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PersonagemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 19 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
       Write(Html.DisplayFor(model => model.PersonagemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>    \r\n    </dl>\r\n</div>\r\n<p>\r\n    <!--");
#nullable restore
#line 23 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
   Write(Html.ActionLink("Editar", "Edit", new { id = Model.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |-->\r\n    ");
#nullable restore
#line 24 "C:\Etec\DS\RpgMvc\Views\Armas\Details.cshtml"
Write(Html.ActionLink("Retornar", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.ArmaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591