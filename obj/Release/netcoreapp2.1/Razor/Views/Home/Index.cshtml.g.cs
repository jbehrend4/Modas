#pragma checksum "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9e020f266b2e2f3c46a313339cc6fa2a42000d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
using Microsoft.CodeAnalysis.CSharp.Syntax;

#line default
#line hidden
#line 2 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
using Modas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e020f266b2e2f3c46a313339cc6fa2a42000d0", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewEvents>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/client.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(110, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3968c99794bb4e968b75b8cadad303d3", async() => {
                BeginContext(116, 62, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>Modas</title>\r\n    ");
                EndContext();
                BeginContext(178, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb35bda41dfd410dbc50e704847d98f9", async() => {
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
                EndContext();
                BeginContext(228, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(234, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "20b3f553440c4e98ae0b06281f45700a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(290, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(296, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f115b16a4ef7497ba22d4504eecf812d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(345, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(354, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(356, 3896, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87322182cee4392b2ec7d8439c35e09", async() => {
                BeginContext(362, 302, true);
                WriteLiteral(@"

<div class=""container"">
    <table class=""table table-sm table-striped table-shadow mt-2"">
        <thead class=""bg-dark text-white"">
        <tr><th>Flag</th><th>Date</th><th style=""text-align: left"">Time</th><th style=""text-align: right"">Location</th></tr>
        </thead>
        <tbody>
");
                EndContext();
#line 21 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
         foreach (var e in Model.Events)
        {

#line default
#line hidden
                BeginContext(717, 18, true);
                WriteLiteral("            <tr>\r\n");
                EndContext();
#line 24 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                 if (e.Flagged == true)
                {

#line default
#line hidden
                BeginContext(795, 39, true);
                WriteLiteral("                    <td><span data-id=\"");
                EndContext();
                BeginContext(835, 9, false);
#line 26 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                  Write(e.EventId);

#line default
#line hidden
                EndContext();
                BeginContext(844, 16, true);
                WriteLiteral("\" data-checked=\"");
                EndContext();
                BeginContext(861, 9, false);
#line 26 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                                            Write(e.Flagged);

#line default
#line hidden
                EndContext();
                BeginContext(870, 36, true);
                WriteLiteral("\" class=\"fas fa-flag\"></span></td>\r\n");
                EndContext();
#line 27 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(925, 35, true);
                WriteLiteral("                <td><span data-id=\"");
                EndContext();
                BeginContext(961, 9, false);
#line 28 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                              Write(e.EventId);

#line default
#line hidden
                EndContext();
                BeginContext(970, 16, true);
                WriteLiteral("\" data-checked=\"");
                EndContext();
                BeginContext(987, 9, false);
#line 28 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                                        Write(e.Flagged);

#line default
#line hidden
                EndContext();
                BeginContext(996, 57, true);
                WriteLiteral(")\" class=\"far fa-flag\"></span></td>\r\n                <td>");
                EndContext();
                BeginContext(1054, 52, false);
#line 29 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
               Write(String.Format("{0: ddd, MMM dd, yyyy}", e.TimeStamp));

#line default
#line hidden
                EndContext();
                BeginContext(1106, 52, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align: left\">");
                EndContext();
                BeginContext(1159, 42, false);
#line 30 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                        Write(String.Format("{0:hh:mm tt}", e.TimeStamp));

#line default
#line hidden
                EndContext();
                BeginContext(1201, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align: right\">");
                EndContext();
                BeginContext(1255, 15, false);
#line 31 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                         Write(e.Location.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1270, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 33 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1307, 310, true);
                WriteLiteral(@"        </tbody>
    </table>
    <div class=""row mb-3"">
        <div class=""col-2"">
            <button class=""btn btn-outline-secondary page-back"" data-page=""1""><span class=""fas fa-angle-double-left""></span>&nbsp;First</button>
            <button class=""btn btn-outline-secondary page-back"" data-page=""");
                EndContext();
                BeginContext(1619, 24, false);
#line 39 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                                                       Write(Model.Pages.PreviousPage);

#line default
#line hidden
                EndContext();
                BeginContext(1644, 192, true);
                WriteLiteral("\"><span class=\"fas fa-angle-left\"></span>&nbsp;Prev</button>\r\n        </div>\r\n        <div class=\"col text-center\">\r\n            <div class=\"row\">\r\n                Events&nbsp;<div id=\"start\">");
                EndContext();
                BeginContext(1838, 26, false);
#line 43 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                        Write(Model.Pages.PageRangeStart);

#line default
#line hidden
                EndContext();
                BeginContext(1865, 33, true);
                WriteLiteral("</div>&nbsp;-&nbsp;<div id=\"end\">");
                EndContext();
                BeginContext(1900, 24, false);
#line 43 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                                                                                      Write(Model.Pages.PageRangeEnd);

#line default
#line hidden
                EndContext();
                BeginContext(1925, 54, true);
                WriteLiteral("</div>\r\n                &nbsp;of&nbsp;<div id=\"total\">");
                EndContext();
                BeginContext(1981, 23, false);
#line 44 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                          Write(Model.Pages.TotalEvents);

#line default
#line hidden
                EndContext();
                BeginContext(2005, 164, true);
                WriteLiteral("</div>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"col-2 text-right\">\r\n            <button class=\"btn btn-outline-secondary page-forward\" data-page=\"");
                EndContext();
                BeginContext(2171, 20, false);
#line 49 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                                                          Write(Model.Pages.NextPage);

#line default
#line hidden
                EndContext();
                BeginContext(2192, 141, true);
                WriteLiteral("\">Next&nbsp;<span class=\"fas fa-angle-right\"></span></button>\r\n            <button class=\"btn btn-outline-secondary page-forward\" data-page=\"");
                EndContext();
                BeginContext(2335, 22, false);
#line 50 "C:\Users\bitstudent\Source\Repos\Modas\Views\Home\Index.cshtml"
                                                                          Write(Model.Pages.TotalPages);

#line default
#line hidden
                EndContext();
                BeginContext(2358, 177, true);
                WriteLiteral("\">Last&nbsp;<span class=\"fas fa-angle-double-right\"></span></button>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script src=\"https://code.jquery.com/jquery-3.3.1.min.js\"></script>\r\n");
                EndContext();
                BeginContext(2535, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7728c7478fdd4390bf3d7be232bb8c8a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2580, 1665, true);
                WriteLiteral(@"
<script>
    $(function () {
        buttonController();
        $('.fa-flag').mouseenter(
            function() {
                if ($(this).data('checked')) {
                    $(this).data('checked', false);
                    $(this).removeClass('fas').addClass('far');
                } else {
                    $(this).data('checked', true);
                    $(this).removeClass('far').addClass('fas');
                }
            });
        $('.fa-flag').mouseleave(
            function() {
                if ($(this).data('checked')) {
                    $(this).data('checked', false);
                    $(this).removeClass('fas').addClass('far');
                } else {
                    $(this).data('checked', true);
                    $(this).removeClass('far').addClass('fas');
                }
            });


        $('.fa-flag').on('click',
            function() {
                if ($(this).data('checked')) {
                    $(this).data('che");
                WriteLiteral(@"cked', false);
                    $(this).removeClass('fas').addClass('far');
                } else {
                    $(this).data('checked', true);
                    $(this).removeClass('far').addClass('fas');
                }
            });


        $('.page-back, .page-forward').on('click', function () {
            location.href = ""page"" + $(this).data('page');
        });

        function buttonController() {
            $('.page-back').attr('disabled', $('#start').html() === ""1"");
            $("".page-forward"").attr('disabled', $('#end').html() === $('#total').html());
        }
    });
</script>
");
                EndContext();
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
            EndContext();
            BeginContext(4252, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewEvents> Html { get; private set; }
    }
}
#pragma warning restore 1591
