#pragma checksum "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a773735fa5d1f430dc185503e2ed62ff8fb642cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratos_BuscarPorInmuebles), @"mvc.1.0.view", @"/Views/Contratos/BuscarPorInmuebles.cshtml")]
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
#line 1 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\_ViewImports.cshtml"
using Inmobiliaria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\_ViewImports.cshtml"
using Inmobiliaria.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a773735fa5d1f430dc185503e2ed62ff8fb642cf", @"/Views/Contratos/BuscarPorInmuebles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf381669dde6995b9201d231bb8643b95e5b7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratos_BuscarPorInmuebles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inmobiliaria.Models.Contrato>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarPorInmuebles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
      
        ViewData["Title"] = "BuscarPorInmuebles";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>BuscarPorInmuebles</h1>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a773735fa5d1f430dc185503e2ed62ff8fb642cf4739", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a773735fa5d1f430dc185503e2ed62ff8fb642cf5013", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 12 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Inmueble</label>\r\n                    <select class=\"form-control\" name=\"IdInmueble\">\r\n");
#nullable restore
#line 16 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
                         foreach (var item in (IList<Inmueble>)ViewBag.Inmuebles)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a773735fa5d1f430dc185503e2ed62ff8fb642cf7268", async() => {
#nullable restore
#line 18 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
                                                         Write(item.Direccion + " " + item.TipoInmueble);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
                               WriteLiteral(item.IdInmueble);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"buscar\" class=\"btn btn-primary\" />\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 32 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
   Write(ViewBag.Cartel);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <table class=""table"">
        <thead>
            <tr>
                
                <th>
                    Fecha Alta
                </th>
                <th>
                    Fecha Baja
                </th>
                <th>
                    Garante
                </th>
                <th>
                    Inquilino
                </th>
                <th>
                    Inmueble Precio
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 57 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    \r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FechaAlta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FechaBaja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
                    Write(item.garante.Nombre+" "+ item.garante.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
                    Write(item.inquilino.Nombre+" "+ item.inquilino.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
                    Write(item.inmueble.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                   \r\n                </tr>\r\n");
#nullable restore
#line 78 "C:\Users\Ivana\Source\Repos\ivana007\PruebaInmobiliaria\Inmobiliaria\Views\Contratos\BuscarPorInmuebles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inmobiliaria.Models.Contrato>> Html { get; private set; }
    }
}
#pragma warning restore 1591
