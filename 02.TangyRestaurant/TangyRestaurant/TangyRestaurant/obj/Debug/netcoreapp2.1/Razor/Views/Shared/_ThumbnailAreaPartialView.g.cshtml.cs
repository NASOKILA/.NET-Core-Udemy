#pragma checksum "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b4c792388c58d8a72b349dea0a45c1f97353f83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThumbnailAreaPartialView), @"mvc.1.0.view", @"/Views/Shared/_ThumbnailAreaPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ThumbnailAreaPartialView.cshtml", typeof(AspNetCore.Views_Shared__ThumbnailAreaPartialView))]
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
#line 1 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\_ViewImports.cshtml"
using TangyRestaurant;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\_ViewImports.cshtml"
using TangyRestaurant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b4c792388c58d8a72b349dea0a45c1f97353f83", @"/Views/Shared/_ThumbnailAreaPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe269e8e12cfb9656ec18123dac71ede72709165", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThumbnailAreaPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(150, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
 if (Model.Count() > 0)
{

    foreach (var menuItem in Model)
    {


#line default
#line hidden
            BeginContext(232, 367, true);
            WriteLiteral(@"        <div class=""border border-info rounded col-12"" style=""margin-top:10px; margin-bottom:10px;padding:10px;"">
            <div class=""row"">
                <div class=""col-sm-9"">
                    <div class=""row"">
                        <div class=""col-sm-10"">
                            <label class=""text-primary"" style=""font-size:21px;color:maroon;"">");
            EndContext();
            BeginContext(600, 13, false);
#line 18 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                                                                                        Write(menuItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(613, 109, true);
            WriteLiteral("</label>\r\n                            <br />\r\n                            <label class=\"badge badge-primary\">");
            EndContext();
            BeginContext(723, 25, false);
#line 20 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                                                          Write(menuItem.SubCategory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(748, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 21 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                             if (menuItem.Spicyness == "1")
                            {

#line default
#line hidden
            BeginContext(850, 64, true);
            WriteLiteral("                                <label class=\"badge badge-info\">");
            EndContext();
            BeginContext(915, 21, false);
#line 23 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                                                           Write(MenuItem.Espicy.Spicy);

#line default
#line hidden
            EndContext();
            BeginContext(936, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 24 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                            }

#line default
#line hidden
            BeginContext(977, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 25 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                             if (menuItem.Spicyness == "2")
                            {

#line default
#line hidden
            BeginContext(1069, 64, true);
            WriteLiteral("                                <label class=\"badge badge-info\">");
            EndContext();
            BeginContext(1134, 25, false);
#line 27 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                                                           Write(MenuItem.Espicy.VerySpicy);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 28 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                            }

#line default
#line hidden
            BeginContext(1200, 123, true);
            WriteLiteral("                        </div>\r\n                        <div class=\"col-sm-2 text-right\">\r\n                            <h4>");
            EndContext();
            BeginContext(1324, 14, false);
#line 31 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                           Write(menuItem.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 154, true);
            WriteLiteral("</h4>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-12 text-justify\">\r\n                        <p>");
            EndContext();
            BeginContext(1493, 20, false);
#line 36 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                      Write(menuItem.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1513, 61, true);
            WriteLiteral("</p>\r\n                        <br/>\r\n                        ");
            EndContext();
            BeginContext(1574, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74dc25965268487fa870210e2ea7299f", async() => {
                BeginContext(1650, 34, true);
                WriteLiteral("<i class=\"fas fa-info\"></i>Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
                                                  WriteLiteral(menuItem.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1688, 133, true);
            WriteLiteral("\r\n                    </div>   \r\n                    </div>\r\n                    <div class=\"col-sm-3\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1821, "\"", 1842, 1);
#line 42 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"
WriteAttributeValue("", 1827, menuItem.Image, 1827, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1843, 138, true);
            WriteLiteral(" width=\"90%\" style=\"border: 1px solid #bbb9b9; border-radius:5px;\"/>\r\n                    </div>\r\n                </div>\r\n        </div>\r\n");
            EndContext();
#line 46 "C:\Users\Asus\Desktop\.NET Core MVC 2.0\02.TangyRestaurant\TangyRestaurant\TangyRestaurant\Views\Shared\_ThumbnailAreaPartialView.cshtml"

    }
}

#line default
#line hidden
            BeginContext(1993, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
