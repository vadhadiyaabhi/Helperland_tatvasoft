#pragma checksum "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9491b3411c0090561a4bfc21050c06561f93e51d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SP_BlockCustomer), @"mvc.1.0.view", @"/Views/SP/BlockCustomer.cshtml")]
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
#line 1 "D:\Tatvasoft\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tatvasoft\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tatvasoft\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9491b3411c0090561a4bfc21050c06561f93e51d", @"/Views/SP/BlockCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96bb1ef7955c1397a49dbc9396c03a07262c68b9", @"/Views/_ViewImports.cshtml")]
    public class Views_SP_BlockCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FavoriteAndBlocked>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar-hat.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml"
   
    ViewBag.Title = "Helperland - Block Customer";
    ViewBag.Header = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\" my-setting my-sp-setting dashboard-table row-table\">\r\n    <div class=\"d-flex px-4  flex-wrap mx-auto\">\r\n");
#nullable restore
#line 9 "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml"
         foreach (FavoriteAndBlocked blocked in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"user-box py-2\">\r\n                <div class=\"text-center\">\r\n                    <div class=\"my-2 text-center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9491b3411c0090561a4bfc21050c06561f93e51d4705", async() => {
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
            WriteLiteral("</div>\r\n                    <div class=\"fw-bold my-3\">");
#nullable restore
#line 14 "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml"
                                          Write(blocked.TargetUser.FirstName + " " + blocked.TargetUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"my-3\"");
            BeginWriteAttribute("id", " id=\"", 668, "\"", 684, 1);
#nullable restore
#line 15 "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml"
WriteAttributeValue("", 673, blocked.Id, 673, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                        <span");
            BeginWriteAttribute("class", " class=\"", 1394, "\"", 1452, 2);
            WriteAttributeValue("", 1402, "block-button", 1402, 12, true);
#nullable restore
#line 24 "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml"
WriteAttributeValue(" ", 1414, blocked.IsBlocked ? "blocked" : "", 1415, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1453, "\"", 1481, 3);
            WriteAttributeValue("", 1463, "block(", 1463, 6, true);
#nullable restore
#line 24 "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml"
WriteAttributeValue("", 1469, blocked.Id, 1469, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1480, ")", 1480, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml"
                                                                                                                  Write(blocked.IsBlocked ? "Unblock" : "Block");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml"
         if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-danger m-2\">You haven\'t completed any service with customer as of now</div>\r\n");
#nullable restore
#line 32 "D:\Tatvasoft\Helperland\Helperland\Views\SP\BlockCustomer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<script type=""text/javascript"">
    function block(id) {
        var value;
        if ($(""#"" + id + "" .block-button"").html() == ""Block"") {
            console.log(""blocked"");
            value = 'False';
        }
        else {
            value = 'True';
        }
        $(""#"" + id + "" .block-button"").html(""Processing"").load(`/SP/BlockUnblock/${id}/${value}`);
        $(""#"" + id + "" .block-button"").toggleClass(""blocked"");
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FavoriteAndBlocked>> Html { get; private set; }
    }
}
#pragma warning restore 1591
