#pragma checksum "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "973feaba74a3bace3e57d41c773a58a83f0225a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Armas_Index), @"mvc.1.0.view", @"/Views/Armas/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973feaba74a3bace3e57d41c773a58a83f0225a3", @"/Views/Armas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Armas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.ArmaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--Namespace da classe de Modelo para esta view-->\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 7 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 8 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Configuração para exibir mensagem de erro -->\r\n");
#nullable restore
#line 10 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 13 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 14 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
  ViewBag.Title = "Armas"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Título da página para o navegador-->\r\n<h2>Relação de Armas</h2><!--Título da página-->\r\n<p>\r\n    <!--Links apontando para views na mesma pasta-->\r\n    ");
#nullable restore
#line 20 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
Write(Html.ActionLink("Criar Nova Arma", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr><!--Títulos das colunas da tabela-->        \r\n        <th>");
#nullable restore
#line 24 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th>");
#nullable restore
#line 25 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th>");
#nullable restore
#line 26 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \r\n        <th>");
#nullable restore
#line 27 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PersonagemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th></th>\r\n    </tr>\r\n    <!--Looping para escrever os dados na tabela-->\r\n");
#nullable restore
#line 31 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 34 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td>");
#nullable restore
#line 36 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td>");
#nullable restore
#line 37 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PersonagemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>           \r\n            <td><!--Coluna para Links/botões-->\r\n                ");
#nullable restore
#line 39 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = item.Id } ));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 40 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
           Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 41 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
           Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id }
                    , new { onclick = "return confirm('Deseja realmente deletar esta Arma ?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Etec\DS\RpgMvc\Views\Armas\Index.cshtml"
    }    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.ArmaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591