#pragma checksum "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Books/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a638201e5d2d798523363587ec16f17d99fdb6fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Delete), @"mvc.1.0.view", @"/Views/Books/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Delete.cshtml", typeof(AspNetCore.Views_Books_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a638201e5d2d798523363587ec16f17d99fdb6fe", @"/Views/Books/Delete.cshtml")]
    public class Views_Books_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Books/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 54, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this book?</h2>\n\n");
            EndContext();
            BeginContext(110, 41, false);
#line 9 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Books/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(151, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(154, 37, false);
#line 9 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Books/Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(191, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Books/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(220, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Books/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(266, 40, false);
#line 14 "/Users/alexskreen/Desktop/Library.Solution/Library/Views/Books/Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
