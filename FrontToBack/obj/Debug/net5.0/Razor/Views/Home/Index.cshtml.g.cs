#pragma checksum "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a06372d303ce4a27f448e1496358926a431c5140"
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
#line 1 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a06372d303ce4a27f448e1496358926a431c5140", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af58ae78f0b33fee8a60f1b5da5ea3e45ebb31d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    HomeViewModel homeViewModel = Model;
    List<SliderImage> sliderImages = homeViewModel.SliderImage;
    Slider slider = homeViewModel.Slider;
    AboutSection aboutSections = homeViewModel.AboutSections;
    AboutSectionImage aboutSectionImages = homeViewModel.AboutSectionImages;
    List<AboutSectionList> aboutSectionLists = homeViewModel.AboutSectionLists;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- SLIDER START -->\r\n\r\n<section id=\"slider\">\r\n    <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 16 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
         foreach (var item in sliderImages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a06372d303ce4a27f448e1496358926a431c51405416", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 588, "~/img/", 588, 6, true);
#nullable restore
#line 18 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 594, item.Name, 594, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 19 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"container context pl-lg-5 ml-lg-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-5\">\r\n                <div class=\"text\">\r\n                   ");
#nullable restore
#line 25 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
              Write(Html.Raw(slider.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    <p class=\"text-black-50 d-none d-sm-block\">\r\n                       ");
#nullable restore
#line 27 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                  Write(slider.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a06372d303ce4a27f448e1496358926a431c51408025", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1063, "~/img/", 1063, 6, true);
#nullable restore
#line 31 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1069, slider.SignatureImage, 1069, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</section>

<!-- SLIDER END -->
<!-- PRODUCTS START -->

<section id=""products"">
    <div class=""container"">
        <div class=""row pt-5"">
            <div class=""col-12 d-flex justify-content-between"">
                <ul class=""category-mobile d-md-none list-unstyled"">
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1509, "\"", 1516, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                        <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1735, "\"", 1742, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 51 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                             foreach (var item in homeViewModel.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1918, "\"", 1925, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 53 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                                                   Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 53 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 54 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </li>\r\n                </ul>\r\n                <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2187, "\"", 2194, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 60 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                     foreach (var item in homeViewModel.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2346, "\"", 2353, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 62 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                                           Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 62 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 63 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <ul class=\"list-unstyled\">\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2549, "\"", 2556, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 74 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"        </div>
    </div>
</section>

<!-- PRODUCTS END -->
<!-- ABOUT START -->

<section id=""about"">
    <div class=""container py-5"">
        <div class=""row py-5"">
            <div class=""col-lg-6"">
                <div class=""img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a06372d303ce4a27f448e1496358926a431c514014385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4075, "~/img/", 4075, 6, true);
#nullable restore
#line 107 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4081, aboutSectionImages.Image, 4081, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                        <i class=""fas fa-play fa-lg""></i>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                  ");
#nullable restore
#line 115 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
             Write(Html.Raw(aboutSections.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p class=\"py-3\">\r\n                       ");
#nullable restore
#line 117 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                  Write(aboutSections.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 120 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                         foreach (var item in aboutSectionLists)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"mt-3\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a06372d303ce4a27f448e1496358926a431c514017389", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4881, "~/img/", 4881, 6, true);
#nullable restore
#line 123 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4887, item.Image, 4887, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 123 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                                                                             Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 125 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- ABOUT END -->
<!-- EXPERTS START -->

<section id=""experts"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"">
                    <h1>");
#nullable restore
#line 141 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                   Write(homeViewModel.ExpertSections.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"text-black-50\">\r\n                      ");
#nullable restore
#line 143 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                 Write(homeViewModel.ExpertSections.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pb-5\">\r\n");
#nullable restore
#line 149 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
             foreach (var item in homeViewModel.ExpertSectionLists)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3\">\r\n                    <div class=\"item text-center\">\r\n                        <div class=\"img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a06372d303ce4a27f448e1496358926a431c514021077", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5891, "~/img/", 5891, 6, true);
#nullable restore
#line 154 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5897, item.Image, 5897, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"text mt-3\">\r\n                            <h6>");
#nullable restore
#line 157 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p class=\"text-black-50\">");
#nullable restore
#line 158 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                                                Write(item.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 162 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-lg-3\"></div>\r\n            <div class=\"col-lg-3\"></div>\r\n            <div class=\"col-lg-3\"></div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- EXPERTS END -->\r\n<!-- SUBSCRIBE START -->\r\n\r\n<section id=\"subscribe\"");
            BeginWriteAttribute("style", " style=\"", 6498, "\"", 6583, 3);
            WriteAttributeValue(" ", 6506, "background:", 6507, 12, true);
#nullable restore
#line 174 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6518, homeViewModel.Subscribes.ImageLink, 6519, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6554, ";background-attachment:fixed;", 6554, 29, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container py-5\">\r\n        <div class=\"row py-5\">\r\n            <div class=\"col-12\">\r\n                <div class=\"content text-center py-5\">\r\n                    <h3>");
#nullable restore
#line 179 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                   Write(homeViewModel.Subscribes.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                        <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                        <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">");
#nullable restore
#line 182 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                                                                                     Write(homeViewModel.Subscribes.ButtonText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- SUBSCRIBE END -->
<!-- BLOG START -->

<section id=""blog"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"">
                    <h1>");
#nullable restore
#line 198 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                   Write(homeViewModel.Blogs.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"text-black-50\">\r\n                       ");
#nullable restore
#line 200 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                  Write(homeViewModel.Blogs.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pb-5\">\r\n");
#nullable restore
#line 206 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
             foreach (var item in homeViewModel.BlogLists)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4\">\r\n                    <div class=\"item\">\r\n                        <div class=\"img position-relative\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a06372d303ce4a27f448e1496358926a431c514027073", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8016, "~/img/", 8016, 6, true);
#nullable restore
#line 211 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8022, item.Image, 8022, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>");
#nullable restore
#line 217 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"text-black-50\">\r\n                               ");
#nullable restore
#line 219 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                          Write(item.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 224 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>

<!-- BLOG END -->
<!-- SAY START -->

<section id=""say"">
    <div class=""container"">
        <div class=""row py-5 justify-content-center"">
           
            <div class=""col-md-8 col-xl-6"">
                <div class=""owl-carousel say"">
");
#nullable restore
#line 238 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                     foreach (var item in homeViewModel.SliderSays)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <div class=\"item text-center\">\r\n                                <div class=\"img d-flex justify-content-center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a06372d303ce4a27f448e1496358926a431c514030708", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9234, "~/img/", 9234, 6, true);
#nullable restore
#line 243 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9240, item.Image, 9240, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"text text-muted pt-3 pb-5\">\r\n                                    <i>\r\n                                        ");
#nullable restore
#line 247 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </i>\r\n                                </div>\r\n                                <div class=\"author\">\r\n                                    <h6>");
#nullable restore
#line 251 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                                   Write(item.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <p class=\"text-black-50\">");
#nullable restore
#line 252 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                                                        Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 256 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- SAY END -->\r\n<!-- INSTAGRAM START -->\r\n\r\n<section id=\"instagram\">\r\n    <div class=\"owl-carousel instagram\">\r\n");
#nullable restore
#line 270 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
         foreach (var item in homeViewModel.Instagrams)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a06372d303ce4a27f448e1496358926a431c514034283", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10173, "~/img/", 10173, 6, true);
#nullable restore
#line 272 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 10179, item.Image, 10179, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 273 "C:\Users\ACER\Desktop\MVC Basket\FrontToBack\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n        #FIORELLO\r\n    </div>\r\n</section>\r\n\r\n<!-- INSTAGRAM END -->\r\n");
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