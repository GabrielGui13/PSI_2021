#pragma checksum "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "851d460fd0c549e8bc396e69938108e81cf06124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Edit), @"mvc.1.0.view", @"/Views/Categoria/Edit.cshtml")]
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
#line 1 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\_ViewImports.cshtml"
using Projeto01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\_ViewImports.cshtml"
using Projeto01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"851d460fd0c549e8bc396e69938108e81cf06124", @"/Views/Categoria/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0035c053eb0191e27975ee92428384241b783c7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto01.Models.Categoria>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.min.unobtrosive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "851d460fd0c549e8bc396e69938108e81cf061244559", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>Edit</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "851d460fd0c549e8bc396e69938108e81cf061245584", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "851d460fd0c549e8bc396e69938108e81cf061245846", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "851d460fd0c549e8bc396e69938108e81cf061246945", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "851d460fd0c549e8bc396e69938108e81cf061248044", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
     using (Html.BeginForm()) { 
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
                                ;


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-horizontal\">\r\n            <h4>Categoria</h4>\r\n            <hr />\r\n            ");
#nullable restore
#line 20 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n            ");
#nullable restore
#line 21 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
       Write(Html.HiddenFor(model => model.CategoriaId));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
                                                          // Inclui na visão, de forma escondida, a informação do campo do modelo indicado.
            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 25 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
           Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
               Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new {@class = "form-control"}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Nome, "", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>

            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Alterar"" class=""btn btn-default"">
                </div>
            </div>
        </div>
");
#nullable restore
#line 38 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 40 "C:\Users\gabri\Documents\github\PSI_2021\Projeto01\Views\Categoria\Edit.cshtml"
   Write(Html.ActionLink("Retornar para lista", "Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>   \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto01.Models.Categoria> Html { get; private set; }
    }
}
#pragma warning restore 1591
