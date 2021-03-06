#pragma checksum "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a679a55ea91bf50fdcf7c3e9a4346d4675f3f5e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a679a55ea91bf50fdcf7c3e9a4346d4675f3f5e5", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ea3f6ea9d0387d7afd5c355a53175b8fdc7dc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogPost>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""blog"">
    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">BLOG</h5>

        <!-- Blog -->
        <section class=""blog blog-page padding-20 padding-top-50 padding-bottom-50 "">

            <!-- Blog Post -->
");
#nullable restore
#line 15 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <article>\r\n                    <img class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 468, "\"", 502, 2);
            WriteAttributeValue("", 474, "/uploads/images/", 474, 16, true);
#nullable restore
#line 18 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Index.cshtml"
WriteAttributeValue("", 490, item.ImgUrl, 490, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 503, "\"", 509, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"post-info\">\r\n                        <div class=\"post-in\">\r\n                            <div class=\"extra\"> <span><i class=\"icon-calendar\"></i>");
#nullable restore
#line 21 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Index.cshtml"
                                                                              Write(item.PublishedDate?.ToString("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"margin-left-15\"><i class=\"icon-user\"></i>Admin</span> <span class=\"margin-left-15\"><i class=\"icon-bubbles\"></i> Featured</span></div>\r\n                            <a href=\"#.\" class=\"tittle-post\">  ");
#nullable restore
#line 22 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Index.cshtml"
                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                            <p>");
#nullable restore
#line 23 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Index.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a679a55ea91bf50fdcf7c3e9a4346d4675f3f5e58135", async() => {
                WriteLiteral("Read MOre <i class=\"fa fa-angle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Index.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </article>\r\n");
#nullable restore
#line 28 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <!-- BLOG POST -->
            <!--<article>
                <img class=""img-responsive"" src=""/uploads/images/blog-img-2.jpg"" alt="""">
                <div class=""post-info"">
                    <div class=""post-in"">
                        <div class=""extra""> <span><i class=""icon-calendar""></i>Aug 29, 2015</span> <span class=""margin-left-15""><i class=""icon-user""></i>Admin</span> <span class=""margin-left-15""><i class=""icon-bubbles""></i> Featured</span></div>
                        <a href=""#."" class=""tittle-post""> ENJOYING THE SMALL THINGS </a>
                        <p>t's time to play the music. It's time to light the lights. It's time to meet the Muppets on the Muppet Show tonight! Boy the way Glen Miller played Songs the hit parade. Guys like us we had it made. Those were the days. These Happy Days are yours and mine Happy Days.</p>
                        <a href=""#."" class=""btn-1"">Read MOre <i class=""fa fa-angle-right""></i></a>
                    </div>
                </div>
");
            WriteLiteral(@"            </article>-->

            <!-- BLOG POST -->

            <!--<article>
                <img class=""img-responsive"" src=""/uploads/images/blog-img-3.jpg"" alt="""">
                <div class=""post-info"">
                    <div class=""post-in"">
                        <div class=""extra""> <span><i class=""icon-calendar""></i>Aug 29, 2015</span> <span class=""margin-left-15""><i class=""icon-user""></i>Admin</span> <span class=""margin-left-15""><i class=""icon-bubbles""></i> Featured</span></div>
                        <a href=""#."" class=""tittle-post""> ENJOYING THE SMALL THINGS </a>
                        <p>t's time to play the music. It's time to light the lights. It's time to meet the Muppets on the Muppet Show tonight! Boy the way Glen Miller played Songs the hit parade. Guys like us we had it made. Those were the days. These Happy Days are yours and mine Happy Days.</p>
                        <a href=""#."" class=""btn-1"">Read MOre <i class=""fa fa-angle-right""></i></a>
                    </d");
            WriteLiteral(@"iv>
                </div>
            </article>-->

            <!-- Pagination -->
            <ul class=""pagination"">
                <li><a href=""#"">1</a></li>
                <li><a href=""#"">2</a></li>
                <li><a href=""#"">3</a></li>
                <li><a href=""#"">Next</a></li>
            </ul>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
