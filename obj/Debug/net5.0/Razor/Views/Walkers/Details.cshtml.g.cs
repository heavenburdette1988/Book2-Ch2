#pragma checksum "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2578c5ee5afa7d219ba5adec7bab9f9a78ccbfe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Walkers_Details), @"mvc.1.0.view", @"/Views/Walkers/Details.cshtml")]
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
#line 1 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\_ViewImports.cshtml"
using DogGoMVC2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\_ViewImports.cshtml"
using DogGoMVC2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2578c5ee5afa7d219ba5adec7bab9f9a78ccbfe0", @"/Views/Walkers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5db36a4b57745c6b23fc8164d7c9a85aa05196b", @"/Views/_ViewImports.cshtml")]
    public class Views_Walkers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DogGoMVC2.Models.ViewModels.WalkersProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml"
   ViewData["Title"] ="Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n  <h1 class=\"mb-4\">Walker Profile</h1>\r\n      <section>\r\n\r\n          <img\r\n      style=\"width:100px;float:left;margin-right:20px\"");
            BeginWriteAttribute("src", "\r\n      src=\"", 238, "\"", 273, 1);
#nullable restore
#line 12 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml"
WriteAttributeValue("", 251, Model.Walker.ImageUrl, 251, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n    />\r\n\r\n    <div>\r\n      <label class=\"font-weight-bold\">Name:</label>\r\n      <span>");
#nullable restore
#line 17 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml"
       Write(Model.Walker.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div>\r\n      <label class=\"font-weight-bold\">Neighborhood:</label>\r\n      <span>");
#nullable restore
#line 21 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml"
       Write(Model.Walker.Neighborhood.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
    </div>
  </section>
  <hr class=""mt-5"" />
  <div class=""clearfix""></div>

  <div class=""row"">
    <section class=""col-8 container mt-5"">
      <h1 class=""text-left"">Recent Walks</h1>

      <table class=""table"">
          <thead>
              <tr>
                  <th scope=""col"">Date</th>
                  <th scope=""col"">Client</th>
                  <th scope=""col"">Duration</th>
              </tr>
          </thead>
          <tbody>

");
#nullable restore
#line 41 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml"
             foreach (Walk walk in Model.Walks) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml"
                   Write(walk.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml"
                   Write(walk.Dog.Owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml"
                   Write(TimeSpan.FromSeconds(walk.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </tbody>\r\n      </table>\r\n    </section>\r\n\r\n    <section class=\"col-lg-4 col-md-8 container mt-5\">\r\n      <h1>Total Walk Time: ");
#nullable restore
#line 53 "C:\Users\heave\workspace\NewForce-Backend\SQL\DogGoMVC2\DogGoMVC2\Views\Walkers\Details.cshtml"
                      Write(TimeSpan.FromSeconds(Model.Walks.Sum(walk => walk.Duration)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </section>\r\n  </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DogGoMVC2.Models.ViewModels.WalkersProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
