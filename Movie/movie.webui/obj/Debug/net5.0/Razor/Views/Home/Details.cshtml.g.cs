#pragma checksum "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6630a01fe82cc3358302ac6b53f3c7ffa1bb6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 2 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\_ViewImports.cshtml"
using movie.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\_ViewImports.cshtml"
using movie.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a6630a01fe82cc3358302ac6b53f3c7ffa1bb6c", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da40996a80ff0c2399f13732ae1da17a775c4e88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 400px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a6630a01fe82cc3358302ac6b53f3c7ffa1bb6c5204", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css""
        integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.6.1/css/all.css""
        integrity=""sha384-gfdkjb5BdAXd+lj+gudLWI+BXq4IuLW5IT+brZEZsLFm++aCMlF1V92rMkPaX4PP"" crossorigin=""anonymous"">
    <title>");
#nullable restore
#line 13 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
      Write(Model.director.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a6630a01fe82cc3358302ac6b53f3c7ffa1bb6c6350", async() => {
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
                WriteLiteral(" ");
                WriteLiteral(@"
    <style>
        body {
            background-image: linear-gradient(to right bottom,
                    /*renk efekti ve bu efek nerden nereye de??i??sin*/
                    rgba(243, 240, 240, 0.85),
                    rgba(243, 240, 240, 0.95)), url(""https://cdn5.vectorstock.com/i/1000x1000/77/84/stage-director-on-set-pop-art-vector-19267784.jpg"");
            background-repeat: no-repeat;
            background-position: top;
            background-size: cover;
            background-attachment: fixed;
            /*sabit arkaplann*/
            transition: all 5s ease;
            font-family: Arial, Helvetica, sans-serif;

        }

        h1,
        h3,h5 {
            font-weight: bold;
            font-family: 'Times New Roman', Times, serif;
        }
      

        .images img {
            width: 100%;
            height: 100%;
            max-height: 100%;
            max-width: 100%;
            border-radius: 10px;
            box-shadow: rgba(100, 100, ");
                WriteLiteral("111, 0.2) 0px 7px 29px 0px;\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a6630a01fe82cc3358302ac6b53f3c7ffa1bb6c9391", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 51 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div class=\"container mt-5\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <h1 class=\"mb-2 mt-2\" style=\"text-align:center;border-bottom: 2px solid rgba(36, 7, 11, 0.1);\">\r\n                    ");
#nullable restore
#line 57 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
               Write(Model.director.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n                <div class=\"images\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a6630a01fe82cc3358302ac6b53f3c7ffa1bb6c10478", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2250, "~/images/", 2250, 9, true);
#nullable restore
#line 60 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 2259, Model.director.avatar_2, 2259, 24, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"mt-2\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 2369, "\"", 2396, 1);
#nullable restore
#line 63 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
WriteAttributeValue("", 2376, Model.director.??mdb, 2376, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""color:#F5C618;""><i class=""fab fa-imdb fa-3x""
                            style=""float:center;padding-left:40%""></i></a>
                </div>
            </div>

            <div class=""col-md-8 mt-3"">
                <br><br>
                <p style=""color:gray;"">");
#nullable restore
#line 70 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
                                  Write(Model.director.ozet);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>\r\n                   ");
#nullable restore
#line 72 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
              Write(Html.Raw(@Model.director.description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"container\">\r\n        <h3 style=\"text-align:center\" class=\"mt-5 mb-3\">Pop??ler Filmler</h3>\r\n        <hr>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 81 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
             foreach (var item in Model.director.movies)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""col-md-4 mb-3"">
                    <div class=""card"" style=""width: 18rem;border-radius: 10px;box-shadow: rgba(50, 50, 93, 0.25) 0px 30px 60px -12px inset, rgba(0, 0, 0, 0.3) 0px 18px 36px -18px inset;"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a6630a01fe82cc3358302ac6b53f3c7ffa1bb6c14165", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3350, "~/images/", 3350, 9, true);
#nullable restore
#line 85 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 3359, item.img, 3359, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title pb-3\" style=\"text-align:center;border-bottom: 2px solid rgba(36, 7, 11, 0.1);\">");
#nullable restore
#line 87 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
                                                                                                                            Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 88 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
                                            Write(item.ozet);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 3706, "\"", 3740, 2);
                WriteAttributeValue("", 3713, "/home/movieDetails/", 3713, 19, true);
#nullable restore
#line 89 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
WriteAttributeValue("", 3732, item.id, 3732, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info\"\r\n                            style=\"display:block;float: center;\">??ncele</a>\r\n                        </div>\r\n                    </div> \r\n                </div>\r\n");
#nullable restore
#line 94 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n    ");
#nullable restore
#line 99 "C:\Users\User\Desktop\WebDeveloper\Dersler\Movie\movie.webui\Views\Home\Details.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"



    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
        integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo""
        crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js""
        integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49""
        crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js""
        integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy""
        crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
