#pragma checksum "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5552b026266c6f4a953b40a9e3e28163b0436660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BlogPosts_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/BlogPosts/Details.cshtml")]
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
#line 4 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CvTemplate.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CvTemplate.Application.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CvTemplate.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CvTemplate.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CvTemplate.Application.Modules.Admin.PersonalSettingsModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CvTemplate.Domain.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CvTemplate.Application.Modules.Admin.UsersModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CvTemplate.Application.Modules.Admin.AcademicBackGroundModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CvTemplate.Application.Modules.Admin.AttachmentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CvTemplate.Application.Modules.Admin.BioModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5552b026266c6f4a953b40a9e3e28163b0436660", @"/Areas/Admin/Views/BlogPosts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b757568309c86178e1c524e6def10572defe1dcb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BlogPosts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CvTemplate.Domain.Models.Entities.BlogPost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>BlogPost</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 17 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 20 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 23 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 26 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 35 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImgUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 41 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ImgUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 44 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BlogCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 47 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.BlogCategory.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 50 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedByUserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 53 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedByUserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 56 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 59 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 62 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeletedByUserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 65 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeletedByUserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 68 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeletedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 71 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeletedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5552b026266c6f4a953b40a9e3e28163b043666013644", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "E:\Lesson folder\Asp.Net Core MVC\cv-template\CvTemplate Solution\CvTemplate.WebUI\Areas\Admin\Views\BlogPosts\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5552b026266c6f4a953b40a9e3e28163b043666015833", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CvTemplate.Domain.Models.Entities.BlogPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
