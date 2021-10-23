#pragma checksum "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5be49eb99124d65954a87f331a493b16a0abbe46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Portfolio), @"mvc.1.0.view", @"/Views/Home/Portfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be49eb99124d65954a87f331a493b16a0abbe46", @"/Views/Home/Portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ea3f6ea9d0387d7afd5c355a53175b8fdc7dc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Portfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectJobCategoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
  
    ViewData["Title"] = "Portfolio";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""portfolio"">
    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">PORTFOLIO</h5>

        <!-- PORTFOLIO -->
        <section class=""portfolio padding-top-50 padding-bottom-50"">
            <!-- Work Filter -->
            <ul class=""tabs portfolio-filter text-center margin-bottom-30"">
                <li class=""filter"" data-filter=""all"">all</li>
");
#nullable restore
#line 16 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
                 foreach (var item in Model.JobCategories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"filter\" data-filter=\".");
#nullable restore
#line 18 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 18 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n\r\n            <!-- PORTFOLIO ITEMS -->\r\n            <div id=\"Container\" class=\"item-space row col-3\">\r\n\r\n                <!-- ITEM -->\r\n");
#nullable restore
#line 30 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
                 foreach (var item in Model.Projects)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <article");
            BeginWriteAttribute("class", " class=\"", 1221, "\"", 1272, 4);
            WriteAttributeValue("", 1229, "portfolio-item", 1229, 14, true);
            WriteAttributeValue(" ", 1243, "mix", 1244, 4, true);
#nullable restore
#line 32 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
WriteAttributeValue(" ", 1247, item.JobCategory.Name, 1248, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("  ", 1270, "", 1272, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"portfolio-image\">\r\n                            <a href=\"#.\"> <img class=\"img-responsive\" alt=\"Open Imagination\"");
            BeginWriteAttribute("src", " src=\"", 1423, "\"", 1467, 2);
            WriteAttributeValue("", 1429, "/uploads/images/portfolio/", 1429, 26, true);
#nullable restore
#line 34 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
WriteAttributeValue("", 1455, item.ImgUrl, 1455, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"> </a>
                            <div class=""portfolio-overlay style-4"">
                                <div class=""detail-info"">
                                    <div class=""position-center-center"">
                                        <h3 class=""no-margin"">");
#nullable restore
#line 38 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <span><a href=\"#.\">");
#nullable restore
#line 39 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
                                                      Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></span> <a href=""#."" class=""go""><i class=""fa fa-search""></i></a> <a href=""#."" class=""go""><i class=""fa fa-link""></i></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </article>
");
#nullable restore
#line 45 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Home\Portfolio.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <!-- ITEM -->
                <!--<article class=""portfolio-item mix photo"">
        <div class=""portfolio-image"">
            <a href=""#.""> <img class=""img-responsive"" alt=""Open Imagination"" src=""/uploads/images/portfolio/5/img-2.jpg""> </a>
            <div class=""portfolio-overlay style-4"">
                <div class=""detail-info"">
                    <div class=""position-center-center"">
                        <h3 class=""no-margin"">Assembly Branding</h3>
                        <span><a href=""#."">Fashion / trending</a></span> <a href=""#."" class=""go""><i class=""fa fa-search""></i></a> <a href=""#."" class=""go""><i class=""fa fa-link""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </article>-->
                <!-- ITEM -->
                <!--<article class=""portfolio-item mix visual pf-branding-design"">
        <div class=""portfolio-image"">
            <a href=""#.""> <img class=""img-responsive"" alt=""Open Imagination"" src=""/upload");
            WriteLiteral(@"s/images/portfolio/5/img-3.jpg""> </a>
            <div class=""portfolio-overlay style-4"">
                <div class=""detail-info"">
                    <div class=""position-center-center"">
                        <h3 class=""no-margin"">Assembly Branding</h3>
                        <span><a href=""#."">Fashion / trending</a></span> <a href=""#."" class=""go""><i class=""fa fa-search""></i></a> <a href=""#."" class=""go""><i class=""fa fa-link""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </article>-->
                <!-- ITEM -->
                <!--<article class=""portfolio-item mix design pf-digital-art "">
        <div class=""portfolio-image"">
            <a href=""#.""> <img class=""img-responsive"" alt=""Open Imagination"" src=""/uploads/images/portfolio/5/img-4.jpg""> </a>
            <div class=""portfolio-overlay style-4"">
                <div class=""detail-info"">
                    <div class=""position-center-center"">
                        <h3 class=""");
            WriteLiteral(@"no-margin"">Assembly Branding</h3>
                        <span><a href=""#."">Fashion / trending</a></span> <a href=""#."" class=""go""><i class=""fa fa-search""></i></a> <a href=""#."" class=""go""><i class=""fa fa-link""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </article>-->
                <!-- ITEM -->
                <!--<article class=""portfolio-item mix brand pf-digital-art"">
        <div class=""portfolio-image"">
            <a href=""#.""> <img class=""img-responsive"" alt=""Open Imagination"" src=""/uploads/images/portfolio/5/img-5.jpg""> </a>
            <div class=""portfolio-overlay style-4"">
                <div class=""detail-info"">
                    <div class=""position-center-center"">
                        <h3 class=""no-margin"">Assembly Branding</h3>
                        <span><a href=""#."">Fashion / trending</a></span> <a href=""#."" class=""go""><i class=""fa fa-search""></i></a> <a href=""#."" class=""go""><i class=""fa fa-link""></i></a>
         ");
            WriteLiteral(@"           </div>
                </div>
            </div>
        </div>
    </article>-->
                <!-- ITEM -->
                <!--<article class=""portfolio-item mix design pf-digital-art"">
        <div class=""portfolio-image"">
            <a href=""#.""> <img class=""img-responsive"" alt=""Open Imagination"" src=""/uploads/images/portfolio/5/img-9.jpg""> </a>
            <div class=""portfolio-overlay style-4"">
                <div class=""detail-info"">
                    <div class=""position-center-center"">
                        <h3 class=""no-margin"">Assembly Branding</h3>
                        <span><a href=""#."">Fashion / trending</a></span> <a href=""#."" class=""go""><i class=""fa fa-search""></i></a> <a href=""#."" class=""go""><i class=""fa fa-link""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </article>-->
                <!-- ITEM -->
                <!--<article class=""portfolio-item mix brand pf-branding-design"">
        <div clas");
            WriteLiteral(@"s=""portfolio-image"">
            <a href=""#.""> <img class=""img-responsive"" alt=""Open Imagination"" src=""/uploads/images/portfolio/5/img-7.jpg""> </a>
            <div class=""portfolio-overlay style-4"">
                <div class=""detail-info"">
                    <div class=""position-center-center"">
                        <h3 class=""no-margin"">Assembly Branding</h3>
                        <span><a href=""#."">Fashion / trending</a></span> <a href=""#."" class=""go""><i class=""fa fa-search""></i></a> <a href=""#."" class=""go""><i class=""fa fa-link""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </article>-->
                <!-- ITEM -->
                <!--<article class=""portfolio-item mix photo pf-digital-art "">
        <div class=""portfolio-image"">
            <a href=""#.""> <img class=""img-responsive"" alt=""Open Imagination"" src=""/uploads/images/portfolio/5/img-8.jpg""> </a>
            <div class=""portfolio-overlay style-4"">
                <div class");
            WriteLiteral(@"=""detail-info"">
                    <div class=""position-center-center"">
                        <h3 class=""no-margin"">Assembly Branding</h3>
                        <span><a href=""#."">Fashion / trending</a></span> <a href=""#."" class=""go""><i class=""fa fa-search""></i></a> <a href=""#."" class=""go""><i class=""fa fa-link""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </article>-->
                <!-- ITEM -->
                <!--<article class=""portfolio-item mix visual pf-branding-design"">
        <div class=""portfolio-image"">
            <a href=""#.""> <img class=""img-responsive"" alt=""Open Imagination"" src=""/uploads/images/portfolio/5/img-9.jpg""> </a>
            <div class=""portfolio-overlay style-4"">
                <div class=""detail-info"">
                    <div class=""position-center-center"">
                        <h3 class=""no-margin"">Assembly Branding</h3>
                        <span><a href=""#."">Fashion / trending</a></span> <a href");
            WriteLiteral(@"=""#."" class=""go""><i class=""fa fa-search""></i></a> <a href=""#."" class=""go""><i class=""fa fa-link""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </article>-->
            </div>
        </section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectJobCategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
