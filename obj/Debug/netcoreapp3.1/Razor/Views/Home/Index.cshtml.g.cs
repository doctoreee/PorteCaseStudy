#pragma checksum "C:\Users\icagr\Desktop\Porte\BoxOptimizer\BoxOptimizer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39233eca9ee52af6ae81fb64fb0e60e98a8bb9f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\icagr\Desktop\Porte\BoxOptimizer\BoxOptimizer\Views\_ViewImports.cshtml"
using BoxOptimizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\icagr\Desktop\Porte\BoxOptimizer\BoxOptimizer\Views\_ViewImports.cshtml"
using BoxOptimizer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39233eca9ee52af6ae81fb64fb0e60e98a8bb9f9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0fda285992f5c55ecc29f2a8f374baab51a6a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\icagr\Desktop\Porte\BoxOptimizer\BoxOptimizer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>This project is implemented by Çağrı TEZEL for Porte, as a Case Study for the job interview.</p>
    <p></p>
    <p>Project is implemanted using <a> ASP.NET Core MVC, Visual Studio Core and Entity Framework.</a></p>
</div>

<div class=""text-center"">
    <h2 class=""display-5"">Technical Explanations</h2>
    <p>This project uses two tables, Boxes and ShipmentParts and scripts for DB is attached to Git repository. </p>
    <p>Please change appsettings.json for server and database name. </p>
    <p></p>
    <p><a>DbInitiliazer.cs</a> class defines the input for Boxes table. For other inputs, please change this class.</p>
    <p></p>
    <p>There is only one view and controller for the case, since it is sufficient for implementing the specifications.</p>
    <p></p>
    <p>SplitBoxesToParts and CreateParts actions change the view. I can actually calculate all with one action (you can see it from the code).</p>
    <p>But I s");
            WriteLiteral(@"plit it because of the two-function specification.</p>

    <p>Kindest Regards,</p>
    <p>İ. Çağrı TEZEL</p>
    
    <p>For other projects, please see my newly founded Git account (New projects from university years and afterwards, will be available if I found my ex-harddrive.)
        <a href=""https://github.com/doctoreee/"">here.</a></p>
</div>
");
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
