#pragma checksum "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db3fecc18d267e5a6e2979672059e07ef493006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Shop_Views_Item_ItemList), @"mvc.1.0.view", @"/Areas/Shop/Views/Item/ItemList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Shop/Views/Item/ItemList.cshtml", typeof(AspNetCore.Areas_Shop_Views_Item_ItemList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db3fecc18d267e5a6e2979672059e07ef493006", @"/Areas/Shop/Views/Item/ItemList.cshtml")]
    public class Areas_Shop_Views_Item_ItemList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingCart.Areas.Shop.Models.ItemDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("errrroor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px; height:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
  
    ViewData["Title"] = "ItemList";
    Layout = "_ShopLayout";

#line default
#line hidden
            BeginContext(187, 32, true);
            WriteLiteral("\r\n<h2>ItemList</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(219, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11791706798a4964821438a41d471ce5", async() => {
                BeginContext(300, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
                                                       WriteLiteral(TempData["id"]);

#line default
#line hidden
            WriteLiteral(" ");
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
            BeginContext(314, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
#line 38 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1094, 115, true);
            WriteLiteral("            <div class=\"col-lg-4 col-md-4 col-sm-4\">\r\n                <div class=\"thumbnail\">\r\n                    ");
            EndContext();
            BeginContext(1209, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8618a2aec094efd99ffac347c8411e4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1219, "~/shopImages/", 1219, 13, true);
#line 42 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
AddHtmlAttributeValue("", 1232, item.SignUpId, 1232, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1246, "/ItemImages/", 1246, 12, true);
#line 42 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
AddHtmlAttributeValue("", 1258, item.ItemName, 1258, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1272, "/", 1272, 1, true);
#line 42 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
AddHtmlAttributeValue("", 1273, item.ImageUrl1, 1273, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1342, 92, true);
            WriteLiteral("\r\n                    <div class=\"caption\">\r\n                        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(1435, 28, false);
#line 44 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
                                          Write(item.UnitPrice.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 68, true);
            WriteLiteral("</h3>\r\n                        <h3>\r\n                            <a>");
            EndContext();
            BeginContext(1532, 13, false);
#line 46 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
                          Write(item.ItemName);

#line default
#line hidden
            EndContext();
            BeginContext(1545, 64, true);
            WriteLiteral("</a>\r\n                        </h3>\r\n                        <p>");
            EndContext();
            BeginContext(1610, 16, false);
#line 48 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1626, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(1660, 13, false);
#line 49 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
                      Write(item.SignUpId);

#line default
#line hidden
            EndContext();
            BeginContext(1673, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(1707, 13, false);
#line 50 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
                      Write(item.ItemName);

#line default
#line hidden
            EndContext();
            BeginContext(1720, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(1754, 14, false);
#line 51 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
                      Write(item.ImageUrl1);

#line default
#line hidden
            EndContext();
            BeginContext(1768, 80, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
            EndContext();
#line 81 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Shop\Views\Item\ItemList.cshtml"
                   
        }

#line default
#line hidden
            BeginContext(2916, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingCart.Areas.Shop.Models.ItemDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
