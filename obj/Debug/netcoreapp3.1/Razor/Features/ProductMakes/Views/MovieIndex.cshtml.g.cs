#pragma checksum "C:\Users\Pan\Desktop\Work\WebappRepository\Features\ProductMakes\Views\MovieIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09b9bb8676ac31d4c06bd328fa4d806b6b234459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_ProductMakes_Views_MovieIndex), @"mvc.1.0.view", @"/Features/ProductMakes/Views/MovieIndex.cshtml")]
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
#line 1 "C:\Users\Pan\Desktop\Work\WebappRepository\Features\ProductMakes\Views\_ViewImports.cshtml"
using WebAppAndApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pan\Desktop\Work\WebappRepository\Features\ProductMakes\Views\_ViewImports.cshtml"
using WebAppAndApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pan\Desktop\Work\WebappRepository\Features\ProductMakes\Views\_ViewImports.cshtml"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b9bb8676ac31d4c06bd328fa4d806b6b234459", @"/Features/ProductMakes/Views/MovieIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368b812201e0c6fe215913b663b48e67702dd756", @"/Features/ProductMakes/Views/_ViewImports.cshtml")]
    public class Features_ProductMakes_Views_MovieIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Pan\Desktop\Work\WebappRepository\Features\ProductMakes\Views\MovieIndex.cshtml"
  
ViewData["Title"] = "Movie List";
Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Pan\Desktop\Work\WebappRepository\Features\ProductMakes\Views\MovieIndex.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        <div style=""margin-left : 80%"" >
            <button class=""btn btn-primary"" id=""addbtn"">????????????????????????????????????????????????</button>
        </div>
<div>
    <br><br>
</div>


 <div  class=""modal""   tabindex=""-1"" role=""dialog"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"">Add / Update</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"" style=""margin-top:20px"">
                            <div >
                                <label style=""width:90px"" id=""movieIdLabel"">Movie Code</label>
                                <input type=""text"" id=""inputID"" placeholder=""Movie Code"" disabled>
  ");
            WriteLiteral(@"                          </div>
                            <div style = ""margin-top : 20px"">
                                <label style=""width:90px"" id=""desLabel"">Description</label>
                                <input type=""text"" id=""inputDes"" placeholder=""Movie Description"">
                            </div>
                            
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-primary"" id=""addrow"">Submit</button>
                            <button type=""button"" class=""btn btn-secondary"" id = ""close"" data-dismiss=""modal "">Close</button>
                        </div>
                    </div>
                </div>
            </div>

<div class=""flex-parent jc-center""> 
 <table style = ""margin-top : 20px"" id = ""dynamictable"" class=""table"">
            <div class=""content"">
                <tr class=""table-success"" id = ""tr1"">
                    <th class=""th1"">Movie Code </");
            WriteLiteral(@"th>
                    <th class=""th2"">Description</th>
                    <th class=""th3"">Edit</th>
                    <th class=""th4"">Delete</th>
                </tr>
                <tbody style=""text-align:center;"">
                    <tr></tr>
                </tbody>
                
            </div>
        </table>
</div>



<style>
    .flex-parent {
        display: flex;
    }

    .jc-center {
        justify-content: center;
    }
</style>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n<script");
                BeginWriteAttribute("src", " src=\'", 2650, "\'", 2708, 1);
#nullable restore
#line 72 "C:\Users\Pan\Desktop\Work\WebappRepository\Features\ProductMakes\Views\MovieIndex.cshtml"
WriteAttributeValue("", 2656, Url.Content("~/js/app/productmake/productmovie.js"), 2656, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Options.IOptions<ApplicationConfiguration> applicationConfiguration { get; private set; }
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
