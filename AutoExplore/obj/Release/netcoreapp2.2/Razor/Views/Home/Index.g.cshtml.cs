#pragma checksum "E:\GitHub\AutoExplore\AutoExplore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "801b129b344720485f30390b5ec3c9dfaa738531"
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
#line 1 "E:\GitHub\AutoExplore\AutoExplore\Views\_ViewImports.cshtml"
using AutoExplore;

#line default
#line hidden
#line 2 "E:\GitHub\AutoExplore\AutoExplore\Views\_ViewImports.cshtml"
using AutoExplore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"801b129b344720485f30390b5ec3c9dfaa738531", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2164b72a7841f2c69acabc00ffd987d30c10b6f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\GitHub\AutoExplore\AutoExplore\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2062, true);
            WriteLiteral(@"<link href=""https://fonts.googleapis.com/css?family=Roboto&display=swap"" rel=""stylesheet"">
<div class=""jumbotron text-right"">
    <h1> Auto Explore</h1>
</div>

<div class=""busItem"">
    <h1> Transparency </h1>
    <p class=""busDescription""> Explore your options with all the facts in front of you, from peer reviews to actual specifications received from 
    the <a href=""http://www.carqueryapi.com/"">CarQuery</a> API
    </p>
</div>

<div class=""busItem"">
    <h1> Features </h1>
    <p class=""busDescription"">
        Auto Explorer uses the power of Entity framework to store your Auto shopping options and share them with <a href=""https://www.facebook.com/"">YouTube</a> and
        <a href=""http://www.carqueryapi.com/"">CarQuery</a> to give you as much information that you need to make an informed purchase.
    </p>
</div>

<div class=""busItem"">
    <h1> Security </h1>
    <p class=""busDescription"">
    Auto Explore uses the power of <a href=""https://www.facebook.com/"">Facebook</a> Facebook ");
            WriteLiteral(@"and <a href=""https://www.google.com/"">Google</a> Authentification for your ensured security.
    </p>
</div>

<style>
    .jumbotron {
        margin-bottom: 0px;
        background: linear-gradient(
                rgba(20, 20, 20, .6),
                rgba(20, 20, 20, .6)
              ),
              url(https://s1.cdn.autoevolution.com/images/gallery/QOROS-5-5642_19.jpg);
        background-position: 0% 50%;
        background-size: cover;
        background-repeat: no-repeat;
        color: white;
        text-shadow: black 0.3em 0.3em 0.3em;
        height: 100%;
    }
    .imageText {
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
    }

    .busItem{
        display: inline-block;
        font-family: 'Roboto', sans-serif;
        padding: 25px;
    }

    .busDescription {
        display: inline-block;
        font-family: 'Roboto', sans-serif;
        font-size: 18px;
        padding: 25px;
    }


");
            WriteLiteral("</style>\r\n\r\n\r\n");
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
