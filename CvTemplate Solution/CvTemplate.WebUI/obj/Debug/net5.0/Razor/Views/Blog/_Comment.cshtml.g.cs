#pragma checksum "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d5f61fb0142ad715a2339e4cc749b036d7e015d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog__Comment), @"mvc.1.0.view", @"/Views/Blog/_Comment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5f61fb0142ad715a2339e4cc749b036d7e015d", @"/Views/Blog/_Comment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ea3f6ea9d0387d7afd5c355a53175b8fdc7dc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog__Comment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogPostComment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/images/blog/comments/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<li");
            BeginWriteAttribute("class", " class=\'", 29, "\'", 93, 2);
            WriteAttributeValue("", 37, "comment", 37, 7, true);
#nullable restore
#line 3 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml"
WriteAttributeValue(" ", 44, Model.ParentId != null?"comment-sub ml-10":"", 45, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 94, "\"", 111, 2);
            WriteAttributeValue("", 99, "#c-", 99, 3, true);
#nullable restore
#line 3 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml"
WriteAttributeValue("", 102, Model.Id, 102, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-comment-id=\"");
#nullable restore
#line 3 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml"
                                                                                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <figure class=\"comment-media\">\r\n        <a href=\"#\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d5f61fb0142ad715a2339e4cc749b036d7e015d6444", async() => {
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
            WriteLiteral("\r\n        </a>\r\n    </figure>\r\n    <div class=\"comment-body\">\r\n        <div class=\"comment-user\">\r\n            <span class=\"comment-date\">");
#nullable restore
#line 11 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml"
                                  Write(Model.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <h4><a href=\"#\">");
#nullable restore
#line 12 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml"
                       Write(Model.CreatedByUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n        </div>\r\n\r\n        <div class=\"comment-content mb-2\">\r\n");
#nullable restore
#line 16 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml"
             if (Model.ParentId != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 655, "\"", 680, 2);
            WriteAttributeValue("", 662, "#c-", 662, 3, true);
#nullable restore
#line 18 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml"
WriteAttributeValue("", 665, Model.ParentId, 665, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            WriteLiteral("@");
#nullable restore
#line 18 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml"
                                           Write($"{Model.Parent.CreatedByUser?.UserName}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span>&nbsp; &nbsp;</span>\r\n");
#nullable restore
#line 19 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                ");
#nullable restore
#line 21 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Views\Blog\_Comment.cshtml"
           Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <a href=\"#\" class=\"btn btn-link btn-reveal-right btn-comment-reply\">\r\n            REPLY<i class=\"d-icon-arrow-right\"></i>\r\n        </a>\r\n    </div>\r\n</li>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPostComment> Html { get; private set; }
    }
}
#pragma warning restore 1591
