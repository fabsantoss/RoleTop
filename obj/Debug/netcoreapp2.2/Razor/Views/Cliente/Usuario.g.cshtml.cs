#pragma checksum "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11ddb5bb980e65f9c584eb6b9ebc59ce257e1b8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Usuario), @"mvc.1.0.view", @"/Views/Cliente/Usuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Usuario.cshtml", typeof(AspNetCore.Views_Cliente_Usuario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ddb5bb980e65f9c584eb6b9ebc59ce257e1b8e", @"/Views/Cliente/Usuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Usuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.UsuarioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
  
    ViewData["Title"] = "Evento - RoleTop";

#line default
#line hidden
            BeginContext(99, 163, true);
            WriteLiteral("<main>\r\n                    <h2>Minha Conta!</h2>\r\n                        <br />\r\n    \r\n                            <br />\r\n                        \r\n            ");
            EndContext();
            BeginContext(262, 2914, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11ddb5bb980e65f9c584eb6b9ebc59ce257e1b8e4401", async() => {
                BeginContext(327, 193, true);
                WriteLiteral("\r\n\r\n                <div>\r\n                    <label form=\"nome\">Nome completo:</label>\r\n                    <br>\r\n                    <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"6\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 520, "\"", 547, 1);
#line 16 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
WriteAttributeValue("", 528, Model.Cliente.Nome, 528, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(548, 879, true);
                WriteLiteral(@" name=""nome"">
                </div>

                <div>
                    <label for=""email"">E-mail:</label>
                    <br />
                    <input id=""email"" type=""text"" name=""email"" />
                    </div>

                <div>
                    <label for=""data do evento"">Data do evento: </label>
                    <br />
                    <input id=""data do evento"" type=""date"" name=""data_evento""/>
                </div>
    
                <div>
                    <label for=""horario"">Horário: </label>
                    <br />
                    <input id=""data do evento"" type=""time"" name=""horario""/>
                </div>

                <label for=""Tipo de eventos"">Tipo de evento:</label>
                <br />
                    <select id='tiposDeEvento' name=""tiposDeEvento"">
                    ");
                EndContext();
                BeginContext(1427, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11ddb5bb980e65f9c584eb6b9ebc59ce257e1b8e6315", async() => {
                    BeginContext(1462, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1480, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                     foreach (var tiposDeEvento in Model.TiposDeEventos)
                    {

#line default
#line hidden
                BeginContext(1579, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1603, 115, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11ddb5bb980e65f9c584eb6b9ebc59ce257e1b8e8777", async() => {
                    BeginContext(1638, 18, false);
#line 43 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                     Write(tiposDeEvento.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1656, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1662, 19, false);
#line 43 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                                             Write(tiposDeEvento.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(1681, 28, true);
                    WriteLiteral("\r\n\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 43 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                          WriteLiteral(tiposDeEvento.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1718, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 46 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                    }

#line default
#line hidden
                BeginContext(1743, 903, true);
                WriteLiteral(@"                    </select>  
                    
                
                <br />
                    <label for=""descricao"">Descrição do evento:</label>
                    <br/>
                    <textarea name=""descricao"" id=""descricao"" cols=""10"" rows=""5""  placeholder=""Descrição do evento""  style=""width: 20em ""></textarea>
                    <br /> 
            
                    <label for=""forma_de_pagamento"">Forma de paagamento:</label>
                    <br/>
                    <textarea name=""forma_de_pagamento"" id=""forma_de_pagamento"" cols=""3"" rows=""2""  placeholder=""Forma de pagamento""  style=""width: 10em ""></textarea>
                    <br />
                    <label for=""Serviços adicionais"">Serviços adicionais:</label> 
                    <br />

                <select id=""servicosAdiconais"" name=""servicosAdiconais"">
                    ");
                EndContext();
                BeginContext(2646, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11ddb5bb980e65f9c584eb6b9ebc59ce257e1b8e12599", async() => {
                    BeginContext(2681, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2699, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 65 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                     foreach (var servicosAdicionais in Model.ServicosAdicionais)
                    {

#line default
#line hidden
                BeginContext(2807, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2831, 130, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11ddb5bb980e65f9c584eb6b9ebc59ce257e1b8e15071", async() => {
                    BeginContext(2871, 23, false);
#line 67 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                          Write(servicosAdicionais.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2894, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2900, 24, false);
#line 67 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                                                       Write(servicosAdicionais.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(2924, 28, true);
                    WriteLiteral("\r\n\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 67 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                          WriteLiteral(servicosAdicionais.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2961, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 70 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                    }

#line default
#line hidden
                BeginContext(2986, 183, true);
                WriteLiteral("                    </select>  \r\n                    <br />\r\n                    <br />\r\n                    <input type=\"submit\" value=\"Finalizar Cadastro do evento\">\r\n\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 11 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
AddHtmlAttributeValue("", 290, Url.Action("Registrar", "Usuario"), 290, 35, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3176, 451, true);
            WriteLiteral(@"
            <br>
            <br>
            <h2>Historico dos meus eventos</h2>
            <table>
        <thead>
            <tr>
                <th>Tipos De Evento</th>
                <th>Serviços Adicionais</th>
                <th>Data do Evento</th>
                <th>Horário</th>
                <th>Descrição do Evento</th>
                <th>Forma de Pagamento</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 92 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
             foreach( var evento in Model.Eventos)
            {

#line default
#line hidden
            BeginContext(3694, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(3741, 25, false);
#line 95 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.TiposDeEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3766, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3798, 30, false);
#line 96 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.ServicosAdicionais.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3828, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3860, 19, false);
#line 97 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.DataDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(3879, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3911, 14, false);
#line 98 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.Horario);

#line default
#line hidden
            EndContext();
            BeginContext(3925, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3957, 22, false);
#line 99 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.DescricaoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(3979, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4011, 23, false);
#line 100 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.FormaDePagamento);

#line default
#line hidden
            EndContext();
            BeginContext(4034, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 102 "C:\Users\52655460812\Documents\RoleTopMVC\Views\Cliente\Usuario.cshtml"
            }

#line default
#line hidden
            BeginContext(4079, 67, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n                </main>\r\n        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.UsuarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
