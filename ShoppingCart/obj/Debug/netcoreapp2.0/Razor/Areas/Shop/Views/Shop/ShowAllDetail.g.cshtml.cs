#pragma checksum "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6957eaa1b90b75bca268a3cab106d61922c3f136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Shop_Views_Shop_ShowAllDetail), @"mvc.1.0.view", @"/Areas/Shop/Views/Shop/ShowAllDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Shop/Views/Shop/ShowAllDetail.cshtml", typeof(AspNetCore.Areas_Shop_Views_Shop_ShowAllDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6957eaa1b90b75bca268a3cab106d61922c3f136", @"/Areas/Shop/Views/Shop/ShowAllDetail.cshtml")]
    public class Areas_Shop_Views_Shop_ShowAllDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart.Areas.Shop.Models.AllDataDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("error"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMoreDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
  
    ViewData["Title"] = "ShowAllDetail";
    Layout = "_ShopLayout";

#line default
#line hidden
            BeginContext(182, 130, true);
            WriteLiteral("\r\n<h2>ShowAllDetail</h2>\r\n\r\n<div>\r\n    <h4>AllDataDTO</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(313, 44, false);
#line 15 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(357, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(401, 40, false);
#line 18 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(441, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(485, 43, false);
#line 21 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(528, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(572, 39, false);
#line 24 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(611, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(655, 41, false);
#line 27 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(696, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(740, 37, false);
#line 30 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(777, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(821, 47, false);
#line 33 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(868, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(912, 43, false);
#line 36 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(955, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(1168, 34, true);
            WriteLiteral("            <dt>\r\n                ");
            EndContext();
            BeginContext(1203, 42, false);
#line 45 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1301, 38, false);
#line 48 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
           Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 47, true);
            WriteLiteral("\r\n            </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1387, 45, false);
#line 51 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.LoginType));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1476, 41, false);
#line 54 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayFor(model => model.LoginType));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 47, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n                ");
            EndContext();
            BeginContext(1565, 43, false);
#line 57 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
           Write(Html.HiddenFor(model => model.MoreDetailId));

#line default
#line hidden
            EndContext();
            BeginContext(1608, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1664, 43, false);
#line 60 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
           Write(Html.HiddenFor(model => model.MoreDetailId));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 47, true);
            WriteLiteral("\r\n            </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1755, 55, false);
#line 63 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.AdditionPhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1810, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1854, 51, false);
#line 66 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayFor(model => model.AdditionPhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1949, 51, false);
#line 69 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.AdditionAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2044, 47, false);
#line 72 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayFor(model => model.AdditionAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2135, 44, false);
#line 75 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(2179, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2223, 40, false);
#line 78 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(2263, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2307, 44, false);
#line 81 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2351, 70, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            \r\n           \r\n            ");
            EndContext();
            BeginContext(2421, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72cd5dd98dd4487ea6a0912a06c549f7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2431, "~/shopImages/", 2431, 13, true);
#line 86 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
AddHtmlAttributeValue("", 2444, Model.SignUpId, 2444, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2459, "/images/", 2459, 8, true);
#line 86 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
AddHtmlAttributeValue("", 2467, Model.ImageUrl, 2467, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2524, 61, true);
            WriteLiteral("\r\n            \r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2585, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "663b59f6e5c94b52a8cf2b32ad593bec", async() => {
                BeginContext(2702, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-edit", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
                                                             WriteLiteral(Model.SignUpId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["edit"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-edit", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["edit"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 92 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
                                                                                            WriteLiteral(Model.SignUpId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2710, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2718, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd4b1306d1e745ddbc35d55b168c7489", async() => {
                BeginContext(2793, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Shop\ShowAllDetail.cshtml"
                                                  WriteLiteral(Model.SignUpId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2809, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart.Areas.Shop.Models.AllDataDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591