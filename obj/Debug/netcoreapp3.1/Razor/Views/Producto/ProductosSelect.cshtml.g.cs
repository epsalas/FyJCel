#pragma checksum "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "488e6916c3a1306b3b14d542d73d5f4473aad05b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_ProductosSelect), @"mvc.1.0.view", @"/Views/Producto/ProductosSelect.cshtml")]
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
#line 1 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\_ViewImports.cshtml"
using FyJCel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\_ViewImports.cshtml"
using FyJCel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"488e6916c3a1306b3b14d542d73d5f4473aad05b", @"/Views/Producto/ProductosSelect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba09d8f07e0801623da7733e814a171bdcd5c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_ProductosSelect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FyJCel.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductosGrabar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- bootstrap Navbar  !-->
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"">
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
<!--
<h2>Lista Productos</h2>
-->
<style>
* {
  box-sizing: border-box;
}

.zoom {
  padding: 50px;
  background-color: white;
  transition: transform .2s;
  width: 200px;
  height: 100px;
  margin: 0 auto;
}

.zoom:hover {
  -ms-transform: scale(1.5); /* IE 9 */
  -webkit-transform: scale(1.5); /* Safari 3-8 */
  transform: scale(1.5); 
}
</style>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "488e6916c3a1306b3b14d542d73d5f4473aad05b5142", async() => {
                WriteLiteral("\r\n  \r\n<table border=\"1\" width=\"1100\">\r\n    <tr>\r\n        <!-- <td width=\"200\">Logo EASYMAR</td> -->\r\n        <td wisth=\"900\">\r\n            <nav class=\"navbar navbar-expand-sm bg-dark navbar-dark\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "488e6916c3a1306b3b14d542d73d5f4473aad05b5634", async() => {
                    WriteLiteral(@"
                    <input width=""700"" class=""form-control mr-sm-2"" type=""text"" placeholder=""Search"">
                    <button class=""btn btn-success"" type=""submit"">Search</button>&nbsp
                    <button type=""submit"" class=""btn btn-primary"">Grabar</button>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            </nav>
        </td>
    </tr>
</table>

<table class=""table table-hover"">
    <thead class=""thead-dark"">
        <tr>
                <!-- <th scope=""col"">
                    #
                </th> -->
                <th scope=""col"">
                    Nombre del Producto<!--");
#nullable restore
#line 57 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml"
                                      Write(Html.DisplayNameFor(model => model.prod_nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("-->\r\n                </th>\r\n                <th scope=\"col\">\r\n                    Detalles <!--");
#nullable restore
#line 60 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml"
                            Write(Html.DisplayNameFor(model => model.prod_detalle));

#line default
#line hidden
#nullable disable
                WriteLiteral("-->\r\n                </th>\r\n                <th scope=\"col\">\r\n                    Imagen del Producto <!--");
#nullable restore
#line 63 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml"
                                       Write(Html.DisplayNameFor(model => model.prod_imagen));

#line default
#line hidden
#nullable disable
                WriteLiteral("-->\r\n                </th>\r\n                <th scope=\"col\">\r\n                    Precio <!--");
#nullable restore
#line 66 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml"
                          Write(Html.DisplayNameFor(model => model.prod_precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("-->\r\n                </th>\r\n                <th scope=\"col\">\r\n                    Cantidad\r\n                </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 75 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td><strong>\r\n                ");
#nullable restore
#line 79 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml"
           Write(Html.DisplayFor(modelItem => item.prod_nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n            </td>\r\n            <td>\r\n                <textarea disabled cols=\"75\" rows=\"6\" style=\"resize: none; border-style: none;\">");
#nullable restore
#line 82 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml"
                                                                                           Write(Html.DisplayFor(modelItem => item.prod_detalle));

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n            </td>\r\n            <td class=\"zoom\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 2809, "\"", 2862, 1);
#nullable restore
#line 85 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml"
WriteAttributeValue("", 2815, Html.DisplayFor(modelItem => item.prod_imagen), 2815, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  width=\"350\" height=\"200\">\r\n            </td>  \r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml"
           Write(Html.DisplayFor(modelItem => item.prod_precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td width=\"4ss0\">\r\n                <input type=\"text\" name=\"cantidades\"");
                BeginWriteAttribute("value", " value=\"", 3098, "\"", 3106, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </td>\r\n                                 \r\n        </tr>\r\n");
#nullable restore
#line 95 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ProductosSelect.cshtml"
}        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FyJCel.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
