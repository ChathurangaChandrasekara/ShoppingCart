#pragma checksum "E:\GitClone\ShoppingCart\ShoppingCart\Views\Shared\ItemList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b004f47bf7288d586299890047b05c3f13f17e40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ItemList), @"mvc.1.0.view", @"/Views/Shared/ItemList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ItemList.cshtml", typeof(AspNetCore.Views_Shared_ItemList))]
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
#line 1 "E:\GitClone\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Areas.Home.ViewModels;

#line default
#line hidden
#line 2 "E:\GitClone\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#line 3 "E:\GitClone\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Areas.Administration.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b004f47bf7288d586299890047b05c3f13f17e40", @"/Views/Shared/ItemList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a8c8d126d9288f9ccedfd8654f2db6ab678810c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ItemList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(81, 15, false);
#line 5 "E:\GitClone\ShoppingCart\ShoppingCart\Views\Shared\ItemList.cshtml"
Write(Model.ImageUrl1);

#line default
#line hidden
            EndContext();
            BeginContext(96, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(118, 20, false);
#line 8 "E:\GitClone\ShoppingCart\ShoppingCart\Views\Shared\ItemList.cshtml"
Write(Model.ItemCategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(138, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(160, 12, false);
#line 11 "E:\GitClone\ShoppingCart\ShoppingCart\Views\Shared\ItemList.cshtml"
Write(Model.ItemId);

#line default
#line hidden
            EndContext();
            BeginContext(172, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(194, 14, false);
#line 14 "E:\GitClone\ShoppingCart\ShoppingCart\Views\Shared\ItemList.cshtml"
Write(Model.ItemName);

#line default
#line hidden
            EndContext();
            BeginContext(208, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(230, 15, false);
#line 17 "E:\GitClone\ShoppingCart\ShoppingCart\Views\Shared\ItemList.cshtml"
Write(Model.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(245, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
