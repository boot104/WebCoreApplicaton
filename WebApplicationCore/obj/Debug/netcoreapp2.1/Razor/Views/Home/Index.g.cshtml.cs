#pragma checksum "D:\GitHub\WebApplicationCore\WebApplicationCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab05e8f6d211ddfeb2d93f98c075582121e1c4ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\GitHub\WebApplicationCore\WebApplicationCore\Views\_ViewImports.cshtml"
using WebApplicationCore;

#line default
#line hidden
#line 2 "D:\GitHub\WebApplicationCore\WebApplicationCore\Views\_ViewImports.cshtml"
using WebApplicationCore.Models;

#line default
#line hidden
#line 4 "D:\GitHub\WebApplicationCore\WebApplicationCore\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab05e8f6d211ddfeb2d93f98c075582121e1c4ad", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c435e06d206d7e61469154eba17d757c03cb0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\GitHub\WebApplicationCore\WebApplicationCore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2510, 115, true);
            WriteLiteral("\r\n<div class=\"row\" style=\"padding:10px\">\r\n    <div class=\"col-md-6\">\r\n        <div style=\"color:red\">\r\n            ");
            EndContext();
            BeginContext(2627, 108, false);
#line 59 "D:\GitHub\WebApplicationCore\WebApplicationCore\Views\Home\Index.cshtml"
        Write(Html.DevExtreme().TextBox()
                                      .Value(@User.Identity.Name)
            );

#line default
#line hidden
            EndContext();
            BeginContext(2736, 140, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\"></div>\r\n</div>\r\n<div class=\"row\" style=\"padding:10px\">\r\n    <div class=\"col-md-9\">\r\n");
            EndContext();
            BeginContext(2878, 396, false);
#line 68 "D:\GitHub\WebApplicationCore\WebApplicationCore\Views\Home\Index.cshtml"
Write(Html.DevExtreme().DataGrid<UserModel>()
    .DataSource(ds => ds.Mvc()
        .Controller("User")
        .LoadAction("Get")
        .Key("UserId")
    )
    .RemoteOperations(true)
    .Columns(columns => {

        columns.AddFor(m => m.UserId);

        columns.AddFor(m => m.UserName);

        columns.AddFor(m => m.Email);

        columns.AddFor(m => m.Password);
    })
);

#line default
#line hidden
            EndContext();
            BeginContext(3275, 71, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n       \r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
