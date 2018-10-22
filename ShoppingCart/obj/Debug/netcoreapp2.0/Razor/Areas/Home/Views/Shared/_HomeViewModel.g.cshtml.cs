#pragma checksum "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e82707c6a8c0a42c89978eaca366b9c085fc197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Home_Views_Shared__HomeViewModel), @"mvc.1.0.view", @"/Areas/Home/Views/Shared/_HomeViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Home/Views/Shared/_HomeViewModel.cshtml", typeof(AspNetCore.Areas_Home_Views_Shared__HomeViewModel))]
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
#line 1 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\_ViewImports.cshtml"
using ShoppingCart.Areas.Home.ViewModels;

#line default
#line hidden
#line 2 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#line 3 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\_ViewImports.cshtml"
using ShoppingCart.Areas.Administration.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e82707c6a8c0a42c89978eaca366b9c085fc197", @"/Areas/Home/Views/Shared/_HomeViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a8c8d126d9288f9ccedfd8654f2db6ab678810c", @"/Areas/Home/Views/_ViewImports.cshtml")]
    public class Areas_Home_Views_Shared__HomeViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart.Areas.Home.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner1.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("No Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px; height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cartButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
  
    ViewData["Title"] = "HomeViewModel";
   

#line default
#line hidden
            BeginContext(165, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(194, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78a5b7b1ad014ee09984966d78aa82c6", async() => {
                BeginContext(217, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(231, 44, true);
            WriteLiteral("\r\n</p>\r\n\r\n\r\n\r\n\r\n<div>Add Shopping Cart Logo ");
            EndContext();
            BeginContext(275, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b319ada946ac4fd8be87e72632947cd4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(309, 88, true);
            WriteLiteral("</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        <ul class=\"list-group\">\r\n");
            EndContext();
#line 21 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
             foreach (var item in Model.ShopList)
            {

#line default
#line hidden
            BeginContext(463, 42, true);
            WriteLiteral("                <ul>\r\n                    ");
            EndContext();
            BeginContext(505, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc1468997954e2aa1ec7188fdb1d808", async() => {
                BeginContext(594, 32, true);
                WriteLiteral("\r\n                        <h4>  ");
                EndContext();
                BeginContext(627, 13, false);
#line 25 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                         Write(item.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(640, 28, true);
                WriteLiteral(" </h4>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                                                                                 WriteLiteral(item.SignUpId);

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
            BeginContext(672, 25, true);
            WriteLiteral("\r\n                </ul>\r\n");
            EndContext();
#line 28 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
            }

#line default
#line hidden
            BeginContext(712, 69, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"thumbnail col-sm-9\">\r\n\r\n\r\n");
            EndContext();
#line 34 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
         for (int j = 0; j < Model.Category.Count; j++)
        {

#line default
#line hidden
            BeginContext(849, 65, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"caption\"><h4> ");
            EndContext();
            BeginContext(915, 38, false);
#line 37 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                                 Write(Model.ListCategory[j].ItemCategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(953, 14, true);
            WriteLiteral(" </h4></div>\r\n");
            EndContext();
#line 38 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
             for (int i = 0; i < Model.ItemList.Count; i++)
            {

                

#line default
#line hidden
#line 41 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                 if (Model.ItemList[i].ItemCategoryId == Model.ListCategory[j].ItemCategoryId)
                {

#line default
#line hidden
            BeginContext(1160, 121, true);
            WriteLiteral("                    <div class=\"col-sm-3\">\r\n                        <div class=\"thumbnail\">\r\n                            ");
            EndContext();
            BeginContext(1281, 825, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4d4748ea3a644e1a6fb114f99b339ac", async() => {
                BeginContext(1381, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1415, 141, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf8da9ef7a7c4d10bc85a17f305e365c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1425, "~/itemImages/", 1425, 13, true);
#line 46 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
AddHtmlAttributeValue("", 1438, Model.ListCategory[j].ItemCategoryId, 1438, 37, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 1475, "/", 1475, 1, true);
#line 46 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
AddHtmlAttributeValue("", 1476, Model.ItemList[i].ImageUrl1, 1476, 28, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1556, 160, true);
                WriteLiteral("\r\n                                <div class=\"caption\">\r\n\r\n                                    <h5 class=\"pull-right\">\r\n                                        ");
                EndContext();
                BeginContext(1717, 41, false);
#line 50 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                                   Write(Model.ItemList[i].UnitPrice.ToString("c"));

#line default
#line hidden
                EndContext();
                BeginContext(1758, 127, true);
                WriteLiteral("\r\n                                    </h5>\r\n                                    <h5>\r\n                                        ");
                EndContext();
                BeginContext(1886, 26, false);
#line 53 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                                   Write(Model.ItemList[i].ItemName);

#line default
#line hidden
                EndContext();
                BeginContext(1912, 85, true);
                WriteLiteral("\r\n                                    </h5>\r\n                                    <p> ");
                EndContext();
                BeginContext(1998, 29, false);
#line 55 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                                   Write(Model.ItemList[i].Description);

#line default
#line hidden
                EndContext();
                BeginContext(2027, 75, true);
                WriteLiteral(" </p>\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                                                                                         WriteLiteral(Model.ItemList[i].ItemId);

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
            BeginContext(2106, 118, true);
            WriteLiteral("\r\n                            <div class=\"addToCart text-right\">\r\n                                <p class=\"button\">  ");
            EndContext();
            BeginContext(2224, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb7a5b8a8f494b6885310ac7ead5f1c1", async() => {
                BeginContext(2385, 11, true);
                WriteLiteral("Add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                                                                                                                              WriteLiteral(Model.ItemList[i].ItemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2400, 103, true);
            WriteLiteral(" </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 63 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                }

#line default
#line hidden
#line 63 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                 

            }

#line default
#line hidden
            BeginContext(2539, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 67 "E:\GitClone\ShoppingCart\ShoppingCart\Areas\Home\Views\Shared\_HomeViewModel.cshtml"
                }

#line default
#line hidden
            BeginContext(2574, 49, true);
            WriteLiteral("           \r\n\r\n\r\n        </div>\r\n        \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart.Areas.Home.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
