#pragma checksum "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72ee52d6b19095979b235c0a2721acdcd9679825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Course_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Course/Detail.cshtml")]
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
#line 1 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\_ViewImports.cshtml"
using EduHome.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ee52d6b19095979b235c0a2721acdcd9679825", @"/Areas/Admin/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb1c774db372f29c4fefb87b48df7f1de3dac21", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-panel"">        
        <div class=""content-wrapper"">
          <div class=""row"">
            <div class=""col-md-6 grid-margin stretch-card"">
              <div class=""card"">

                <div class=""card-body"" style=""background-color: #B2BABB"">
                  <h4 class=""card-title"">");
#nullable restore
#line 13 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                                    Write(Model.MainTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n                  <ul>\r\n                      \r\n                  \r\n                  <li>\r\n                       Image: <br> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72ee52d6b19095979b235c0a2721acdcd96798255259", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 536, "~/assets/img/course/", 536, 20, true);
#nullable restore
#line 19 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
AddHtmlAttributeValue("", 556, Model.Image, 556, 12, false);

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
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                      Main Description: ");
#nullable restore
#line 22 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                                   Write(Model.MainDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                       About Description: ");
#nullable restore
#line 25 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                                     Write(Model.AboutDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                       Apply Description: ");
#nullable restore
#line 28 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                                     Write(Model.ApplyDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                   <li>\r\n                       Certification Description: ");
#nullable restore
#line 31 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                                             Write(Model.CertificationDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                       Assesments: ");
#nullable restore
#line 34 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                              Write(Model.Feature.Assesments);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                      Duration: ");
#nullable restore
#line 37 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                           Write(Model.Feature.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                      CourseDuration: ");
#nullable restore
#line 40 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                                 Write(Model.Feature.CourseDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                      Language: ");
#nullable restore
#line 43 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                           Write(Model.Feature.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                     Students: ");
#nullable restore
#line 46 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                          Write(Model.Feature.Students);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                      Starts: ");
#nullable restore
#line 49 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                         Write(Model.Feature.Starts.ToString("dd, MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                      SkillLevel: ");
#nullable restore
#line 52 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                             Write(Model.Feature.SkillLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  <li>\r\n                    Price: ");
#nullable restore
#line 55 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                      Write(Model.Feature.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  \r\n                  <br><br>\r\n                  <li>-----Categories-----</li><br>\r\n");
#nullable restore
#line 60 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                  foreach (var item in Model.CourseCategories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <li>\r\n                      Category Name : ");
#nullable restore
#line 63 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                                 Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                   <br><br><br>\r\n");
#nullable restore
#line 66 "C:\Users\HP\OneDrive\Masaüstü\Backend\MVC-Final\MVC-FinalProject\EduHome\Areas\Admin\Views\Course\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </ul>\r\n                  \r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72ee52d6b19095979b235c0a2721acdcd967982512522", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n              </div>\r\n            </div>\r\n             </div>\r\n              </div>\r\n            </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
