#pragma checksum "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da847759895bdf9d9c2043dd0e94312241741db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProdutoNovo), @"mvc.1.0.view", @"/Views/Shared/_ProdutoNovo.cshtml")]
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
#line 1 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\_ViewImports.cshtml"
using exercicio_3_Alex_Ferreira_Santos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\_ViewImports.cshtml"
using exercicio_3_Alex_Ferreira_Santos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da847759895bdf9d9c2043dd0e94312241741db", @"/Views/Shared/_ProdutoNovo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9c382ba2c969b45fb9388a1325b572d98debda", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProdutoNovo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/_Produto.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/_Produto.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
  
    ViewData["Title"] = "Produtos";
    int a = 1;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2da847759895bdf9d9c2043dd0e94312241741db4911", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
 foreach (Produto item in Model.listaProd)
{
    a++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"produto\">\r\n");
#nullable restore
#line 11 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
         if(a<10){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label for=\"Novo\" id=\"novo\">Novo!</label>\r\n");
#nullable restore
#line 13 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 313, "\"", 329, 1);
#nullable restore
#line 14 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
WriteAttributeValue("", 319, item.foto, 319, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Produto\">\r\n        <button alt=\"Curtir\" class=\"icones curtir\" id=\"curtir\"></button>\r\n        <button alt=\"Carrinho\" class=\"icones loja\" id=\"carrinho\"></button>\r\n        <p>");
#nullable restore
#line 17 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
      Write(item.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
         if(item.promocao!=0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                <label for=\"preço antigo\" id=\"antigo\"><del>R$<strong>");
#nullable restore
#line 20 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
                                                                Write(item.preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></del></label>\r\n                <label for=\"preço atual\" id=\"atual\">R$");
#nullable restore
#line 21 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
                                                 Write(item.promocao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </p>\r\n");
#nullable restore
#line 23 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
         if(item.promocao==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>R$<strong>");
#nullable restore
#line 25 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
                    Write(item.preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n");
#nullable restore
#line 26 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
        }     

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\Casa\OneDrive\Documents\curso senac\UC-2\exercicio-3-Alex-Ferreira-Santos\Views\Shared\_ProdutoNovo.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2da847759895bdf9d9c2043dd0e94312241741db10080", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2da847759895bdf9d9c2043dd0e94312241741db11120", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
