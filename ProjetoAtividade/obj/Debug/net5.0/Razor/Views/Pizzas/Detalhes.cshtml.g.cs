#pragma checksum "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac6fd7d1483f512bd2a6dca02891b697bb9ec3af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizzas_Detalhes), @"mvc.1.0.view", @"/Views/Pizzas/Detalhes.cshtml")]
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
#line 1 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\_ViewImports.cshtml"
using ProjetoAtividade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\_ViewImports.cshtml"
using ProjetoAtividade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac6fd7d1483f512bd2a6dca02891b697bb9ec3af", @"/Views/Pizzas/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8b5c2863722473f588398a17ef6907ae19371b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pizzas_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pizza>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tamanhos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Atores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedidos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdicionarCarrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes da pizza";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8"">
        <div class=""card mb-12"">
            <div class=""row g-0"">
                <div class=""col-md-12"">
                    <div class=""card-header text-white bg-info"">
                        <p class=""card-text"">
                            <h5 class=""card-title"">
                                ");
#nullable restore
#line 15 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                           Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6fd7d1483f512bd2a6dca02891b697bb9ec3af7162", async() => {
                WriteLiteral("<i class=\"fa-regular fa-pen-to-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                            </h5>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 783, "\"", 803, 1);
#nullable restore
#line 22 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
WriteAttributeValue("", 789, Model.FotoUrl, 789, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 817, "\"", 834, 1);
#nullable restore
#line 22 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
WriteAttributeValue("", 823, Model.Nome, 823, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <p class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                        Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">\r\n                            <b>Tamanho: </b>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6fd7d1483f512bd2a6dca02891b697bb9ec3af11179", async() => {
                WriteLiteral("\r\n                                ");
#nullable restore
#line 30 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                           Write(Model.Tamanho.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                                                                 WriteLiteral(Model.TamanhoId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                        </p>\r\n                        <p class=\"card-text\"><b>Estréia: </b>");
#nullable restore
#line 33 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                                        Write(Model.DataCadastro.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><b>Até: </b>");
#nullable restore
#line 34 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                                    Write(Model.DataAlteracao.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <p>
                            <b>Situação: </b>                           
                        </p>
                        <p class=""card-text"">
                            <b>Atores: </b>
                            <hr />
                            <div class=""row"">
");
#nullable restore
#line 42 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                 foreach (var pizza_sabor in Model.PizzaSabores)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"column text-center\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2084, "\"", 2113, 1);
#nullable restore
#line 45 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
WriteAttributeValue("", 2090, pizza_sabor.Sabor.Nome, 2090, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\r\n                                        <br />\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6fd7d1483f512bd2a6dca02891b697bb9ec3af16213", async() => {
#nullable restore
#line 47 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                                                                                                              Write(pizza_sabor.Sabor.Nome);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                                                                           WriteLiteral(pizza_sabor.Sabor.SaborId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 49 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </p>

                    </div>
                </div>
                <div class=""col-md-12"">
                    <div class=""card-footer"">
                        <p class=""card-text"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6fd7d1483f512bd2a6dca02891b697bb9ec3af19639", async() => {
                WriteLiteral("\r\n                                Lista de Filmes\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6fd7d1483f512bd2a6dca02891b697bb9ec3af20983", async() => {
                WriteLiteral("\r\n                               <i class=\"fa-solid fa-cart-arrow-down\"></i> Adicionar (");
#nullable restore
#line 64 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                                                                 Write(Model.Preco.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2903, "btn", 2903, 3, true);
            AddHtmlAttributeValue(" ", 2906, "btn-success", 2907, 12, true);
            AddHtmlAttributeValue(" ", 2918, "text-white", 2919, 11, true);
#nullable restore
#line 61 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
AddHtmlAttributeValue("  ", 2929, (DateTime.Now > Model.DataAlteracao) ? "disabled" : "", 2931, 57, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\mrfok\OneDrive - SENAC - SP\Área de Trabalho\PRESCON\GITHUB\AtividadePizzaria\ProjetoAtividade\Views\Pizzas\Detalhes.cshtml"
                                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pizza> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
