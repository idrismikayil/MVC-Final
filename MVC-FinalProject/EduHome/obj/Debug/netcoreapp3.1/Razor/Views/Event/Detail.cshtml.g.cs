#pragma checksum "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e51e2fb79c2d9253a5dbeec0892b0ff9d1f9048"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Detail), @"mvc.1.0.view", @"/Views/Event/Detail.cshtml")]
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
#line 1 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e51e2fb79c2d9253a5dbeec0892b0ff9d1f9048", @"/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98c5becdebf98bcd12e5fb9b6debed59b5ea534", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("speaker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/blog-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/post/post1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/post/post2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/post/post3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""banner-area-wrapper"">
            <div class=""banner-area text-center"">	
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""banner-content-wrapper"">
                                <div class=""banner-content"">
                                    <h2>event / details</h2> 
                                </div> 
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>    
		<!-- Banner Area End -->
        <!-- Event Details Start -->
        <div class=""event-details-area blog-area pt-150 pb-140"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-8"">
                        <div class=""event-details"">
                            <div class=""event-details-img"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e51e2fb79c2d9253a5dbeec0892b0ff9d1f90488412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1075, "~/assets/img/event/", 1075, 19, true);
#nullable restore
#line 29 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 1094, Model.Event.Image, 1094, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"event-date\">\r\n                                    <h3>");
#nullable restore
#line 31 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                                   Write(Model.Event.Date.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>");
#nullable restore
#line 31 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                                                                       Write(Model.Event.Date.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>  \r\n                                </div>\r\n                            </div>\r\n                            <div class=\"event-details-content\">\r\n                                <h2>");
#nullable restore
#line 35 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                               Write(Model.Event.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <ul>\r\n                                    <li><span>time : </span>");
#nullable restore
#line 37 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                                                       Write(Model.Event.HourStart.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 37 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                                                                                                     Write(Model.Event.HourEnd.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li>");
#nullable restore
#line 38 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                                   Write(Model.Event.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                </ul>\r\n                                <p>");
#nullable restore
#line 40 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                              Write(Model.Event.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <div class=\"speakers-area fix\">\r\n                                    <h4>speakers</h4>\r\n");
#nullable restore
#line 43 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                                    foreach (var item in Model.Speakers)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       <div class=\"single-speaker\">\r\n                                        <div class=\"speaker-img\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e51e2fb79c2d9253a5dbeec0892b0ff9d1f904813313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2298, "~/assets/img/event/", 2298, 19, true);
#nullable restore
#line 47 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 2317, item.Image, 2317, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"speaker-name\">\r\n                                            <h5>");
#nullable restore
#line 50 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                                           Write(item.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p>");
#nullable restore
#line 51 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                                          Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\n");
#nullable restore
#line 54 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \r\n                                </div>\r\n                            </div>    \r\n                              ");
#nullable restore
#line 58 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                         Write(await Component.InvokeAsync("Reply"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 

                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""blog-sidebar right"">
                            <div class=""single-blog-widget mb-50"">
                                <h3>search</h3>
                                <div class=""blog-search"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e51e2fb79c2d9253a5dbeec0892b0ff9d1f904816860", async() => {
                WriteLiteral(@"
                                        <input type=""search"" placeholder=""Search..."" name=""search"" />
                                        <button type=""submit"">
                                            <span><i class=""fa fa-search""></i></span>
                                        </button>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"single-blog-widget mb-50\">\r\n                                <h3>categories</h3>\r\n                              ");
#nullable restore
#line 77 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Event\Detail.cshtml"
                         Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
                                   
                            </div>
                            <div class=""single-blog-widget mb-50"">
                                <div class=""single-blog-banner"">
                                    <a href=""blog-details.html"" id=""blog"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e51e2fb79c2d9253a5dbeec0892b0ff9d1f904819423", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                                    <h2>best<br> eductaion<br> theme</h2> 
                                </div>
                            </div>
                            <div class=""single-blog-widget mb-50"">
                                <h3>latest post</h3>
                                <div class=""single-post mb-30"">
                                    <div class=""single-post-img"">
                                        <a href=""blog-details.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e51e2fb79c2d9253a5dbeec0892b0ff9d1f904821023", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            <div class=""blog-hover"">
                                                <i class=""fa fa-link""></i>
                                            </div>
                                        </a>
                                    </div>
                                    <div class=""single-post-content"">
                                        <h4><a href=""blog-details.html"">English Language Course for you</a></h4>
                                        <p>By Alex  /  June 20, 2017</p>
                                    </div>
                                </div>
                                <div class=""single-post mb-30"">
                                    <div class=""single-post-img"">
                                        <a href=""blog-details.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e51e2fb79c2d9253a5dbeec0892b0ff9d1f904822982", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            <div class=""blog-hover"">
                                                <i class=""fa fa-link""></i>
                                            </div>
                                        </a>
                                    </div>
                                    <div class=""single-post-content"">
                                        <h4><a href=""blog-details.html"">Advance Web Design and Develop</a></h4>
                                        <p>By Alex  /  June 20, 2017</p>
                                    </div>
                                </div>
                                <div class=""single-post"">
                                    <div class=""single-post-img"">
                                        <a href=""blog-details.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e51e2fb79c2d9253a5dbeec0892b0ff9d1f904824934", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            <div class=""blog-hover"">
                                                <i class=""fa fa-link""></i>
                                            </div>
                                        </a>
                                    </div>
                                    <div class=""single-post-content"">
                                        <h4><a href=""blog-details.html"">English Language Course for you</a></h4>
                                        <p>By Alex  /  June 20, 2017</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""single-blog-widget"">
                                <h3>tags</h3>
                                <div class=""single-tag"">
                                    <a href=""blog-details.html"" class=""mr-10 mb-10"">course</a>
                                    <a href=""blog-details.html"" class=""mr-10 mb-10"">educatio");
            WriteLiteral(@"n</a>
                                    <a href=""blog-details.html"" class=""mb-10"">teachers</a>
                                    <a href=""blog-details.html"" class=""mr-10"">learning</a>
                                    <a href=""blog-details.html"" class=""mr-10"">university</a>
                                    <a href=""blog-details.html"">events</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
