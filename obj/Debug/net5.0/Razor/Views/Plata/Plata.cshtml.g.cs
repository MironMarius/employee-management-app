#pragma checksum "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53811efa45de12102854a44049474374faff6d77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plata_Plata), @"mvc.1.0.view", @"/Views/Plata/Plata.cshtml")]
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
#line 1 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\_ViewImports.cshtml"
using TeoLic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\_ViewImports.cshtml"
using TeoLic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\_ViewImports.cshtml"
using Licenta.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\_ViewImports.cshtml"
using Licenta;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53811efa45de12102854a44049474374faff6d77", @"/Views/Plata/Plata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3b4fccc9ef28c20299d76e7ce1a3a87fc845d68", @"/Views/_ViewImports.cshtml")]
    public class Views_Plata_Plata : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IstoricPlataDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
   ViewBag.Title = "Plata";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
   Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "53811efa45de12102854a44049474374faff6d774463", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""container-fluid d-flex justify-content-between"">
                    <div class=""col-md-3"">
                        <p class=""mt-5 mb-2""><b>ELECTROALFA</b></p>
                        <p> Calea Națională 15<br />Botoșani<br />România</p>
                    </div>

                    <div class=""col-md-3 pr-0"">
                        <p class=""mt-5 mb-2 text-right""><b>Data platii: ");
#nullable restore
#line 19 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                                                                   Write(Model.ZiPlata.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                        <p class=\"text-right\">Anul de taxa: ");
#nullable restore
#line 20 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                                                       Write(Model.An);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />Luna:");
#nullable restore
#line 20 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                                                                                 Write(Model.LunaPlata);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <br /><br />\r\n\r\n                <div class=\"col-md-12 row\">\r\n                    <div class=\"col-md-8\"><h5>Numele angajatului: ");
#nullable restore
#line 26 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                                                             Write(Model.Nume);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5></div>

                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12 table-responsive-md"">
                    <table class=""table table-striped"">
                        <thead class=""table-dark"">
                            <tr>
                                <th>Venituri</th>
                                <th>Ore</th>
                                <th>Rata</th>
                                <th>Suma</th>
                                <th>Taxe</th>
                                <th>Suma</th>
                            </tr>

                        </thead>
                        <tbody>
                            <tr>
                                <td><b>Program normal: </b></td>
                                <td>");
#nullable restore
#line 47 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.OreContract.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.RataOra.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.SalariuContractual.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>Taxe:</td>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.TaxeSalariale.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td><b>Peste program: </b></td>\r\n                                <td>");
#nullable restore
#line 56 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.OreExtra.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.RataOra.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.PlataExtra.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>Taxe:</td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td><b>Total:</b></td>\r\n                                <td>");
#nullable restore
#line 64 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.OreLucrate.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 65 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.RataOra.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 66 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.CastiguriTotale.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>Taxe:</td>\r\n                                <td>");
#nullable restore
#line 68 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                               Write(Model.TotalTaxe.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                            
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class=""table-dark""><b>Salariu net:</b></td>
                                <td> ");
#nullable restore
#line 77 "C:\Users\TEO\Desktop\LICENTA\TeoLic\Views\Plata\Plata.cshtml"
                                Write(Model.PlataNeta.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n\r\n                    </tbody>\r\n                    </table>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IstoricPlataDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
