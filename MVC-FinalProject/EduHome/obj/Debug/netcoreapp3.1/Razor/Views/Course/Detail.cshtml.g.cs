#pragma checksum "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5df2317eb8a778c6f473c9f5c8dc478996a665ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Detail), @"mvc.1.0.view", @"/Views/Course/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df2317eb8a778c6f473c9f5c8dc478996a665ef", @"/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98c5becdebf98bcd12e5fb9b6debed59b5ea534", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("courses-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/blog-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/post/post1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/post/post2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/post/post3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
  
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
                                    <h2>courses details</h2> 
                                </div> 
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>    
		<!-- Banner Area End -->
        <!-- Blog Start -->
        <div class=""courses-details-area blog-area pt-150 pb-140"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-8"">
                        <div class=""courses-details"">
                            <div class=""courses-details-img"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5df2317eb8a778c6f473c9f5c8dc478996a665ef8073", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1073, "~/assets/img/course/", 1073, 20, true);
#nullable restore
#line 29 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
AddHtmlAttributeValue("", 1093, Model.Course.Image, 1093, 19, false);

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
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"course-details-content\">\r\n                                <h2>");
#nullable restore
#line 32 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                               Write(Model.Course.MainTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <p>");
#nullable restore
#line 33 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                              Write(Html.Raw(@Model.Course.MainDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <div class=\"course-details-left\">\r\n                                    <div class=\"single-course-left\">\r\n                                        <h3>about course</h3>\r\n                                        <p>");
#nullable restore
#line 37 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                      Write(Html.Raw(@Model.Course.AboutDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"single-course-left\">\r\n                                        <h3>how to apply</h3>\r\n                                        <p>");
#nullable restore
#line 41 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                      Write(Html.Raw(@Model.Course.ApplyDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"single-course-left\">\r\n                                        <h3>certification</h3>\r\n                                        <p class=\"margin\">");
#nullable restore
#line 45 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                                     Write(Html.Raw(@Model.Course.CertificationDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""course-details-right"">
                                    <h3>COURSE FEATURES</h3>
                                    <ul>
                                        <li>starts <span>");
#nullable restore
#line 51 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                                    Write(Model.Feature.Starts.ToString("dd, MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                        <li>duration <span>");
#nullable restore
#line 52 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                                      Write(Model.Feature.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                        <li>class duration <span>");
#nullable restore
#line 53 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                                            Write(Model.Feature.CourseDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                        <li>skill level <span>");
#nullable restore
#line 54 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                                         Write(Model.Feature.SkillLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                        <li>language <span>");
#nullable restore
#line 55 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                                      Write(Model.Feature.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                        <li>students <span>");
#nullable restore
#line 56 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                                      Write(Model.Feature.Students);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                        <li>assesments <span>");
#nullable restore
#line 57 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                                        Write(Model.Feature.Assesments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                    </ul>\r\n                                    <h3 class=\"red\">course fee $");
#nullable restore
#line 59 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                                                           Write(Model.Feature.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                </div>\r\n                            </div>    \r\n                              ");
#nullable restore
#line 62 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5df2317eb8a778c6f473c9f5c8dc478996a665ef16207", async() => {
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"single-blog-widget mb-50\">\r\n                                <h3>categories</h3>\r\n                                ");
#nullable restore
#line 80 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Views\Course\Detail.cshtml"
                           Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                            </div>\r\n                            <div class=\"single-blog-widget mb-50\">\r\n                                <div class=\"single-blog-banner\">\r\n                                    <a href=\"blog-details.html\" id=\"blog\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5df2317eb8a778c6f473c9f5c8dc478996a665ef18745", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5df2317eb8a778c6f473c9f5c8dc478996a665ef20345", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5df2317eb8a778c6f473c9f5c8dc478996a665ef22304", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5df2317eb8a778c6f473c9f5c8dc478996a665ef24256", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
