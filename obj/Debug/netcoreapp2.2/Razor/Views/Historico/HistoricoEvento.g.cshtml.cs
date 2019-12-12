#pragma checksum "C:\Users\52655460812\Documents\RoleTopMVC\Views\Historico\HistoricoEvento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e58e571d9755bcfe47a73dad4b43b2f5ad73399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Historico_HistoricoEvento), @"mvc.1.0.view", @"/Views/Historico/HistoricoEvento.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Historico/HistoricoEvento.cshtml", typeof(AspNetCore.Views_Historico_HistoricoEvento))]
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
#line 1 "C:\Users\52655460812\Documents\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\52655460812\Documents\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e58e571d9755bcfe47a73dad4b43b2f5ad73399", @"/Views/Historico/HistoricoEvento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Historico_HistoricoEvento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.HistoricoVIewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Historico\HistoricoEvento.cshtml"
  
    ViewData["Title"] = "Cliente - RoleTop";
    ViewData["H2"] = "Historico de Eventos";

#line default
#line hidden
            BeginContext(148, 18, true);
            WriteLiteral("\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(167, 14, false);
#line 8 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Historico\HistoricoEvento.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(181, 329, true);
            WriteLiteral(@"</h2>
    <table>
        <thead>
            <tr>
                <th>Tipos De Evento</th>
                <th>Data do Evento</th>
                <th>Descrição do Evento</th>
                <th>Forma de Pagamento</th>
                <th>Serviços Adicionais</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 20 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Historico\HistoricoEvento.cshtml"
             foreach (var evento in Model.Eventos)
            {

#line default
#line hidden
            BeginContext(577, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(624, 25, false);
#line 23 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Historico\HistoricoEvento.cshtml"
                   Write(evento.TiposDeEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(649, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(681, 19, false);
#line 24 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Historico\HistoricoEvento.cshtml"
                   Write(evento.DataDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(700, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(732, 23, false);
#line 25 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Historico\HistoricoEvento.cshtml"
                   Write(evento.FormaDePagamento);

#line default
#line hidden
            EndContext();
            BeginContext(755, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(787, 30, false);
#line 26 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Historico\HistoricoEvento.cshtml"
                   Write(evento.ServicosAdicionais.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(817, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Historico\HistoricoEvento.cshtml"
            }

#line default
#line hidden
            BeginContext(862, 39, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.HistoricoVIewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
