#pragma checksum "E:\GitClone\ShoppingCart\ShoppingCart\Views\Shared\ShopList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9879ed56cca807963926c22af160a7386f960df6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ShopList), @"mvc.1.0.view", @"/Views/Shared/ShopList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ShopList.cshtml", typeof(AspNetCore.Views_Shared_ShopList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9879ed56cca807963926c22af160a7386f960df6", @"/Views/Shared/ShopList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a8c8d126d9288f9ccedfd8654f2db6ab678810c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ShopList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignUp>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(83, 14, false);
#line 5 "E:\GitClone\ShoppingCart\ShoppingCart\Views\Shared\ShopList.cshtml"
Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(97, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(119, 14, false);
#line 8 "E:\GitClone\ShoppingCart\ShoppingCart\Views\Shared\ShopList.cshtml"
Write(Model.SignUpId);

#line default
#line hidden
            EndContext();
            BeginContext(133, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignUp> Html { get; private set; }
    }
}
#pragma warning restore 1591
