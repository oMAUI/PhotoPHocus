#pragma checksum "D:\УЧЕБА\MyProject\PhotoFoc\PHotoFockus\Views\FockusCart\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aab8c13093d2e0dea856fc7df43daff4d6bbd22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FockusCart_index), @"mvc.1.0.view", @"/Views/FockusCart/index.cshtml")]
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
#line 1 "D:\УЧЕБА\MyProject\PhotoFoc\PHotoFockus\Views\_ViewImports.cshtml"
using PHotoFockus.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\УЧЕБА\MyProject\PhotoFoc\PHotoFockus\Views\_ViewImports.cshtml"
using PHotoFockus.Data.models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aab8c13093d2e0dea856fc7df43daff4d6bbd22", @"/Views/FockusCart/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051fb108f41998c82e67c1f52407e6850dd2b68f", @"/Views/_ViewImports.cshtml")]
    public class Views_FockusCart_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FockusCartViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 4 "D:\УЧЕБА\MyProject\PhotoFoc\PHotoFockus\Views\FockusCart\index.cshtml"
     foreach (var el in Model.fockusCart.listFockusItem)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning mt-3\">\r\n            <b>Продукт:</b> ");
#nullable restore
#line 7 "D:\УЧЕБА\MyProject\PhotoFoc\PHotoFockus\Views\FockusCart\index.cshtml"
                       Write(el.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            <b>Цена:</b> ");
#nullable restore
#line 8 "D:\УЧЕБА\MyProject\PhotoFoc\PHotoFockus\Views\FockusCart\index.cshtml"
                    Write(el.product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 10 "D:\УЧЕБА\MyProject\PhotoFoc\PHotoFockus\Views\FockusCart\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    <div class=\"btn btn-danger\" asp-controller=\"Order\">Оплатить</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FockusCartViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591