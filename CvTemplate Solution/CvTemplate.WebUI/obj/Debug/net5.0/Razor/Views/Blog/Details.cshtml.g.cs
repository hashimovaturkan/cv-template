#pragma checksum "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cbc79fd57fc4bacec93a9b4ed8e9ddedcfd223a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cbc79fd57fc4bacec93a9b4ed8e9ddedcfd223a", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ea3f6ea9d0387d7afd5c355a53175b8fdc7dc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogPost>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""tab-content"">
    <div class=""inside-sec blog"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">BLOG POST</h5>

        <!-- Blog -->
        <article class=""blog-post width-100 padding-25"">
            <div class=""post-img"">
                <img");
            BeginWriteAttribute("src", " src=\"", 339, "\"", 374, 2);
            WriteAttributeValue("", 345, "/uploads/images/", 345, 16, true);
#nullable restore
#line 14 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Details.cshtml"
WriteAttributeValue("", 361, Model.ImgUrl, 361, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 375, "\"", 381, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <span class=\"date-in\">");
#nullable restore
#line 15 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Details.cshtml"
                                 Write(Model.PublishedDate?.ToString("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <!-- BLOG DETAIL -->\r\n            <h4 class=\"font-normal\">");
#nullable restore
#line 19 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Details.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            <span class=""post-bt"">by <span class=""text-color-primary"">Admin</span></span>
            <ul class=""post-info"">
                <li> <i class=""fa fa-comments-o""></i>97 </li>
                <li> <i class=""fa fa-eye""></i>565 </li>
                <li> <i class=""fa fa-bookmark-o""></i>");
#nullable restore
#line 24 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\Details.cshtml"
                                                Write(ViewBag.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                <li>  </li>
            </ul>
            <p>
                Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source.<br>
                <br>
                There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true genera");
            WriteLiteral(@"tor on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable.
            </p>
            <blockquote class=""margin-top-30"">“Sensibus oportere signiferumque id mea. At usu lucilius phaedrum, vix oratio epicurei ne. Eripuit conceptam sea cu, ius minim delectus euripidis cu. Probo nonumy gubergren id nec. In est probo ridens, his laoreet euripidis et.”</blockquote>
            <h5 class=""margin-top-30 margin-bottom-0"">1914 translation by H. Rackham</h5>
            <p>Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source.There are man");
            WriteLiteral(@"y variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures,</p>
            <div class=""row"">
                <div class=""col-md-6"">
                    <p>
                        Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage");
            WriteLiteral(@", literature, discovered the undoubtable source. <br>
                        <br>
                        There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words
                    </p>
                </div>
                <div class=""col-md-6""><img class=""img-responsive margin-top-10"" src=""/uploads/images/post-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4411, "\"", 4417, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
            </div>
            <p>
                Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source.<br>
                <br>
                There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It us");
            WriteLiteral(@"es a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable.
            </p>
            <div class=""auther-name text-center margin-top-50"">
                <h6 class=""font-12px margin-top-20 margin-bottom-10"">WHITE SHADOW WALKER</h6>
                <span class=""font-16px font-crimson font-italic"">Writer/Personal blog</span>
            </div>



            <div class=""next-prev"">
                <div class=""row"">
                    <div class=""col-md-6 text-left""><a href=""#."" class=""font-16px font-crimson text-uppercase""><i class=""fa fa-long-arrow-left margin-right-15""></i> PREVIOUS Article</a></div>
                    <div class=""col-md-6 text-right""><a href=""#."" class=""font-16px font-crimson text-uppercase"">Next Article<i class=""fa fa-long-arrow-right margin-left-15""></i></a></div>
                </div>
            </div>


            <div class=""comments"">

                <!-- Main Heading -->
   ");
            WriteLiteral(@"             <div class=""heading-side-bar margin-bottom-50 margin-top-100"">
                    <h4>Comment (37)</h4>
                </div>
                <ul>

                    <!-- Comments -->
                    <li class=""margin-bottom-30"">
                        <div class=""media"">
                            <div class=""media-left"">
                                <div class=""avatar""><img src=""/uploads/images/avatar-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6914, "\"", 6920, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            </div>
                            <div class=""media-body"">
                                <div class=""a-com"">
                                    <span class=""a-name text-color-primary"">JAMMIE LANDING </span><span class=""date"">24.03.2015 at 10:21</span>
                                    <p class=""margin-top-20"">
                                        “Quando feugait duo ei, te erant corpora interpretaris eos. Illud accommodare vituperatoribus an mea. Erat mazim animal
                                        at nam, eam te doctus evertitur, sed decore ornatus”
                                    </p>
                                    <a href=""#."" class=""text-right""> REPLAY <i class=""fa fa-reply""></i></a>
                                </div>
                            </div>
                        </div>
                    </li>

                    <!-- Comments Replay -->
                    <li class=""com-reply"">
                        <div cl");
            WriteLiteral("ass=\"media\">\r\n                            <div class=\"media-left\">\r\n                                <div class=\"avatar\"><img src=\"/uploads/images/avatar-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 8104, "\"", 8110, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            </div>
                            <div class=""media-body"">
                                <div class=""a-com"">
                                    <span class=""a-name "">JAMMIE LANDING </span><span class=""date"">24.03.2015 at 10:21</span>
                                    <p class=""margin-top-20"">
                                        “Quando feugait duo ei, te erant corpora interpretaris eos. Illud accommodare vituperatoribus an mea. Erat mazim animal
                                        at nam, eam te doctus evertitur, sed decore ornatus”
                                    </p>
                                    <a href=""#."" class=""text-right""> REPLAY <i class=""fa fa-reply""></i></a>
                                </div>
                            </div>
                        </div>
                    </li>
                    <li class=""text-center more-comments""><a href=""#."">MORE COMMENT <i class=""fa fa-angle-down""></i></a></li>
              ");
            WriteLiteral(@"  </ul>

                <!-- Comments Form -->
                <div class=""comment-form"">
                    <!-- Main Heading -->
                    <div class=""heading-side-bar margin-bottom-50 margin-top-80"">
                        <h4>Post to Reply</h4>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cbc79fd57fc4bacec93a9b4ed8e9ddedcfd223a16210", async() => {
                WriteLiteral("\r\n                        <ul class=\"row\">\r\n                            <li class=\"col-sm-4\">\r\n                                <label>\r\n                                    *NAME\r\n                                    <input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 9712, "\"", 9726, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </label>
                            </li>
                            <li class=""col-sm-4"">
                                <label>
                                    *EMAIL ADDRESS
                                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 10026, "\"", 10040, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </label>
                            </li>
                            <li class=""col-sm-4"">
                                <label>
                                    WEBSITE
                                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 10333, "\"", 10347, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </label>
                            </li>
                            <li class=""col-sm-12"">
                                <label>
                                    SUBJECT
                                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 10641, "\"", 10655, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </label>
                            </li>
                            <li class=""col-sm-12"">
                                <textarea placeholder=""YOUR MESSAGE""></textarea>
                            </li>
                            <li class=""col-sm-12"">
                                <button type=""submit"" class=""btn btn-dark"">POST COMMENT </button>
                            </li>
                        </ul>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </article>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
