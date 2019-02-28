#pragma checksum "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/Chef/Chefs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30b55f30e0baad7968f6c852ff0492e09e7278fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chef_Chefs), @"mvc.1.0.view", @"/Views/Chef/Chefs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chef/Chefs.cshtml", typeof(AspNetCore.Views_Chef_Chefs))]
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
#line 1 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/_ViewImports.cshtml"
using chefs_dishes;

#line default
#line hidden
#line 2 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/_ViewImports.cshtml"
using chefs_dishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30b55f30e0baad7968f6c852ff0492e09e7278fd", @"/Views/Chef/Chefs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"984361c454c399ce828948cefdbf606ba3f6bc7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Chef_Chefs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(34, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a874e9c846ce4c85a9cb649c33f8281a", async() => {
                BeginContext(40, 189, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>Document</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(236, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(237, 554, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e0df4d4ef44600be683e09ff98479b", async() => {
                BeginContext(243, 156, true);
                WriteLiteral("\n    <h2>Chefs | <a href = \"/dishes\">Dishes</a></h2>\n    <h4>Yum, take a look at our tasty dishes!</h4>\n    <a href = \"/dishes/new\">Add a dish</a>\n    <hr>\n");
                EndContext();
#line 15 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/Chef/Chefs.cshtml"
      
        foreach(var chef in @ViewBag.ChefwithDish){

#line default
#line hidden
                BeginContext(458, 26, true);
                WriteLiteral("            <p>Chef Name: ");
                EndContext();
                BeginContext(485, 14, false);
#line 17 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/Chef/Chefs.cshtml"
                     Write(chef.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(499, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 18 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/Chef/Chefs.cshtml"

            foreach(var dish in @chef.CreatedDishes){

#line default
#line hidden
                BeginContext(559, 29, true);
                WriteLiteral("               <p>Dish Name: ");
                EndContext();
                BeginContext(589, 13, false);
#line 20 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/Chef/Chefs.cshtml"
                        Write(dish.DishName);

#line default
#line hidden
                EndContext();
                BeginContext(602, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 21 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/Chef/Chefs.cshtml"
               var age = DateTime.Today.Year-@chef.DOB.Year;
                

#line default
#line hidden
                BeginContext(684, 3, true);
                WriteLiteral("<p>");
                EndContext();
                BeginContext(688, 3, false);
#line 22 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/Chef/Chefs.cshtml"
              Write(age);

#line default
#line hidden
                EndContext();
                BeginContext(691, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 23 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/Chef/Chefs.cshtml"
            }
            

#line default
#line hidden
                BeginContext(723, 15, true);
                WriteLiteral("            <p>");
                EndContext();
                BeginContext(739, 24, false);
#line 25 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/Chef/Chefs.cshtml"
          Write(chef.CreatedDishes.Count);

#line default
#line hidden
                EndContext();
                BeginContext(763, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 26 "/Users/chinguyen/1CODINGDOJO/C#/chefs_dishes/Views/Chef/Chefs.cshtml"
        }
    

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(791, 8, true);
            WriteLiteral("\n</html>");
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