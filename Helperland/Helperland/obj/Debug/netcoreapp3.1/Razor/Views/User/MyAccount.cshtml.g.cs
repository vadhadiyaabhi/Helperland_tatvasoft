#pragma checksum "D:\Tatvasoft\Helperland\Helperland\Views\User\MyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "625532b059b458860a1846ed294593bd0f210188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MyAccount), @"mvc.1.0.view", @"/Views/User/MyAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"625532b059b458860a1846ed294593bd0f210188", @"/Views/User/MyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96bb1ef7955c1397a49dbc9396c03a07262c68b9", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("close-modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/close.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ForgotPasswordEmail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxPost(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Tatvasoft\Helperland\Helperland\Views\User\MyAccount.cshtml"
  
    ViewBag.title = "Helperland - MyAccount";
    ViewData["Header"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"welcome-heading py-4\">\r\n    <h1 class=\"welcome\">Welcome,</h1>\r\n    <h1 class=\"fw-bold\">");
#nullable restore
#line 9 "D:\Tatvasoft\Helperland\Helperland\Views\User\MyAccount.cshtml"
                   Write(User.FindFirst("FirstName").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<div class=\"dashboard service-history d-flex justify-content-around\">\r\n    <div class=\"side-menu\">\r\n        <ul>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 384, "\"", 391, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <li class=\"side-menu-item\" id=\"Dashboard\">Dashboard</li>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 497, "\"", 504, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <li class=\"side-menu-item\" id=\"Service-History\">Service History</li>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 622, "\"", 629, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <li class=\"side-menu-item\" id=\"Service-Schedules\">Service Schedules</li>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 751, "\"", 758, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <li class=\"side-menu-item\" id=\"Favourite-Pros\">Favourite Pros</li>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 874, "\"", 881, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <li class=\"side-menu-item\" id=\"Invoices\">Invoices</li>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 985, "\"", 992, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <li class=""side-menu-item"" id=""Notification"">Notification</li>
            </a>
        </ul>
    </div>
    <div class="" my-setting dashboard-table row-table"">
        <div class=""nav nav-tabs my-setting-tab"" id=""myTab"" role=""tablist"">
            <div class=""tab1 active"" id=""home-tab"" data-bs-toggle=""tab"" data-bs-target=""#Index"" type=""button"" role=""tab"" aria-controls=""home"" aria-selected=""true"" onclick=""Show('Index');"">My Details</div>
            <div class=""tab2"" id=""address-tab"" data-bs-toggle=""tab"" data-bs-target=""#UserAddresses"" type=""button"" role=""tab"" aria-controls=""profile"" aria-selected=""false"" onclick=""Show('UserAddresses');"">My Addresses</div>
            <div class=""tab3"" id=""passowrd-tab"" data-bs-toggle=""tab"" data-bs-target=""#ResetPassword"" type=""button"" role=""tab"" aria-controls=""contact"" aria-selected=""false"" onclick=""Show('ResetPassword');"">Change Password</div>
            <div class=""tab4"" id=""subscribe-tab"" data-bs-toggle=""tab"" data-bs-target=""#subscribe"" type=""butt");
            WriteLiteral("on\" role=\"tab\" aria-controls=\"contact\" aria-selected=\"false\" onclick=\"Show(\'Subscribe\');\">Subscribe Notifications</div>\r\n        </div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 2166, "\"", 2174, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""myTabContent"">
            <div class=""tab-pane fade show active"" id=""Index"" role=""tabpanel"" aria-labelledby=""home-tab"" style=""display: block;"">
                <div class=""Index"" id=""index"" >
                    
                </div>
            </div>
            <div class=""tab-pane fade"" id=""UserAddresses"" role=""tabpanel"" aria-labelledby=""address-tab"" style=""display: none;"">
                <div class=""userAddresses"" id=""userAddresses"">

                </div>
            </div>
            <div class=""tab-pane fade"" id=""ResetPassword"" role=""tabpanel"" aria-labelledby=""password-tab"" style=""display: none;"">
                <div class=""resetPassword"" id=""resetPassword"">

                </div>
            </div>
            <div class=""tab-pane fade"" id=""Subscribe"" role=""tabpanel"" aria-labelledby=""subscribe-tab"" style=""display: none;"">
                <div class=""d-flex"" >
                    <input name=""subscribe"" type=""checkbox"" />
                    <span>Yes, I would like to s");
            WriteLiteral(@"ubscribe to the newsletter of Helperland GmbH with vouchers, trends, promotions and individualized offers. I can unsubscribe from the newsletter at any time in the newsletter and in the customer account itself. If you no longer wish to receive our newsletter, remove the tick.</span>
                </div>
            </div>
        </div>

    </div>
</div>

<!-- ------------- Modal--------------- -->
<div class=""Modal "" id=""Delete-Modal"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "625532b059b458860a1846ed294593bd0f21018810388", async() => {
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
            WriteLiteral("\r\n    <h4 class=\"modal-title\">Delete Address</h4>\r\n    <div>Are you sure you want to delete this address ?</div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "625532b059b458860a1846ed294593bd0f21018811624", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Addressid\"");
                BeginWriteAttribute("value", " value=\"", 3979, "\"", 3987, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <button type=\"submit\">Delete</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    
    <script>
        window.onload = LoadMyDetails;
        function LoadMyDetails() {
            $(""#index"").html(""Loading user details..."").load(`/User/MyDetails`);
            $(""#resetPassword"").html(""Loading Password reset form"").load(`/User/ResetPassword`);
            $(""#userAddresses"").html(""Loading User addresses..."").load(`/User/UserAddresses`);
        }
        
        function Show(action) {
            $(""#"" + action).css(""display"", ""block"");
            $(""#"" + action).siblings().css(""display"", ""none"");
        };
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
