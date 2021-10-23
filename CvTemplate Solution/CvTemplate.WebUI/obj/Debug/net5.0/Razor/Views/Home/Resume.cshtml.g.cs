#pragma checksum "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cd27529cce4d70856ed6fe897d49f46df062acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resume), @"mvc.1.0.view", @"/Views/Home/Resume.cshtml")]
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
#line 4 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using CvTemplate.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using CvTemplate.Application.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using CvTemplate.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using CvTemplate.Domain.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using CvTemplate.Application.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using CvTemplate.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd27529cce4d70856ed6fe897d49f46df062acf", @"/Views/Home/Resume.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ea3f6ea9d0387d7afd5c355a53175b8fdc7dc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Resume : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResumeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
  
    ViewData["Title"] = "Resume";
    var index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"resume\">\r\n    <div class=\"inside-sec\">\r\n        <!-- BIO AND SKILLS -->\r\n        <h5 class=\"tittle\">Bio & Skills</h5>\r\n        <div class=\"bio-info padding-30\">\r\n            ");
#nullable restore
#line 12 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
       Write(Html.Raw(Model.Bio.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"skills\">\r\n");
#nullable restore
#line 14 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                 foreach (var item in Enum.GetValues<SkillType>())
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                     if (Model.JobCategories.Where(x => x.SkillType.ToString() == item.ToString()).ToList().Count >= 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 class=\"margin-top-30\">");
#nullable restore
#line 19 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                             Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 20 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                     


                    foreach (var category in Model.JobCategories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"panel-group accordion\"");
            BeginWriteAttribute("id", " id=\"", 805, "\"", 826, 2);
            WriteAttributeValue("", 810, "accordion-", 810, 10, true);
#nullable restore
#line 25 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
WriteAttributeValue("", 820, index, 820, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h6>\r\n");
#nullable restore
#line 27 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                 if (category.SkillType == item)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                               Write(category.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                  
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </h6>\r\n");
#nullable restore
#line 32 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                             foreach (var skill in Model.Skills)
                            {

                                if (category.SkillType == item && skill.JobCategoryId == category.Id && skill.IsBar == false)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""panel panel-default"">
                                        <div class=""row"">
                                            <div class=""col-sm-4"">
                                                <!-- PANEL HEADING -->
                                                <div class=""panel-heading"">
                                                    <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion-");
#nullable restore
#line 42 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                                                                                          Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"collapsed\"");
            BeginWriteAttribute("href", " href=\"", 1847, "\"", 1873, 2);
            WriteAttributeValue("", 1854, "#collapseOne-", 1854, 13, true);
#nullable restore
#line 42 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
WriteAttributeValue("", 1867, index, 1867, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 42 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                                                                                                                                                Write(skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> </h4>
                                                </div>
                                            </div>

                                            <!-- Skillls Bars -->
                                            <div class=""col-sm-8"">
                                                <div class=""progress"">
                                                    <div class=""progress-bar"" role=""progressbar""");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2312, "\"", 2340, 1);
#nullable restore
#line 49 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
WriteAttributeValue("", 2328, skill.Level, 2328, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 2379, "\"", 2408, 3);
            WriteAttributeValue("", 2387, "width:", 2387, 6, true);
#nullable restore
#line 49 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
WriteAttributeValue(" ", 2393, skill.Level, 2394, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2406, "%;", 2406, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"sr-only\">");
#nullable restore
#line 49 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                                                                                                                                                                                    Write(skill.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("% Complete</span> </div>\r\n                                                </div>\r\n\r\n                                                <!-- Skillls Text -->\r\n                                                <div");
            BeginWriteAttribute("id", " id=\"", 2652, "\"", 2675, 2);
            WriteAttributeValue("", 2657, "collapseOne-", 2657, 12, true);
#nullable restore
#line 53 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
WriteAttributeValue("", 2669, index, 2669, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n");
#nullable restore
#line 54 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                      index++; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"panel-body\">\r\n                                                        <p>");
#nullable restore
#line 56 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                      Write(skill.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
");
#nullable restore
#line 62 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                }
                                if(category.SkillType == item && skill.JobCategoryId == category.Id && skill.IsBar == true) 
                                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"ethical\">\r\n                                        <a href=\"#.\">");
#nullable restore
#line 66 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                Write(skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </div>\r\n");
#nullable restore
#line 68 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                    
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 72 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <!-- Professional Experience -->
    <div class=""inside-sec margin-top-30"">
        <!-- Professional Experience -->
        <h5 class=""tittle"">Professional Experience</h5>
        <div class=""padding-30 exp-history"">

            <!-- Wordpress Developer -->


");
#nullable restore
#line 89 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
             foreach (var item in Model.Experiences)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"exp\">\r\n                    <div class=\"media-left\"> <span class=\"sun\">");
#nullable restore
#line 92 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                          Write(item.StartingDate.ToString("M.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 92 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                                                                  Write(item.EndingDate.ToString("M.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </div>\r\n                    <div class=\"media-body\">\r\n\r\n                        <!-- COmpany Logo -->\r\n                        <div class=\"company-logo\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cd27529cce4d70856ed6fe897d49f46df062acf17397", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4489, "~/uploads/images/", 4489, 17, true);
#nullable restore
#line 96 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
AddHtmlAttributeValue("", 4506, item.ImageUrl, 4506, 14, false);

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
            WriteLiteral(" </div>\r\n                        <h6>");
#nullable restore
#line 97 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>");
#nullable restore
#line 98 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                      Write(item.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 99 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                      Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"margin-top-10\">");
#nullable restore
#line 100 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                            Write(item.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 103 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <!-- Academic Background -->\r\n    <div class=\"inside-sec margin-top-30\">\r\n        <!-- Academic Background -->\r\n        <h5 class=\"tittle\">Academic Background</h5>\r\n        <div class=\"padding-30 exp-history\">\r\n");
#nullable restore
#line 112 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
             foreach (var item in Model.AcademicBackGrounds)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"exp\">\r\n                    <div class=\"media-left\"> <span class=\"sun\">");
#nullable restore
#line 115 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                          Write(item.StartingDate.ToString("M.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 115 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                                                                                  Write(item.EndingDate.ToString("M.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </div>\r\n                    <div class=\"media-body\">\r\n                        <!-- COmpany Logo -->\r\n                        <div class=\"company-logo\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cd27529cce4d70856ed6fe897d49f46df062acf22103", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5501, "~/uploads/images/", 5501, 17, true);
#nullable restore
#line 119 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
AddHtmlAttributeValue("", 5518, item.ImageUrl, 5518, 14, false);

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
            WriteLiteral("\r\n                            <span class=\"diploma\"><i class=\"fa fa-graduation-cap\"></i> Download Diploma</span>\r\n                        </div>\r\n                        <h6>");
#nullable restore
#line 122 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>");
#nullable restore
#line 123 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                      Write(item.Qualification);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 123 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                           Write(item.University);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 124 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                      Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"margin-top-10\">");
#nullable restore
#line 125 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
                                            Write(item.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 128 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Resume.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResumeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
