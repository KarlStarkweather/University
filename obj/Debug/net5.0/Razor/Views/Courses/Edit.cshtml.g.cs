#pragma checksum "C:\Users\kstar\Desktop\University\Views\Courses\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e58bafe6d96d723680d0109b9c60c9d82da39da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Edit), @"mvc.1.0.view", @"/Views/Courses/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e58bafe6d96d723680d0109b9c60c9d82da39da", @"/Views/Courses/Edit.cshtml")]
    public class Views_Courses_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<University.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kstar\Desktop\University\Views\Courses\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit this course: ");
#nullable restore
#line 9 "C:\Users\kstar\Desktop\University\Views\Courses\Edit.cshtml"
                 Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\kstar\Desktop\University\Views\Courses\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kstar\Desktop\University\Views\Courses\Edit.cshtml"
Write(Html.HiddenFor(model => model.CourseId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kstar\Desktop\University\Views\Courses\Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kstar\Desktop\University\Views\Courses\Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 19 "C:\Users\kstar\Desktop\University\Views\Courses\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 20 "C:\Users\kstar\Desktop\University\Views\Courses\Edit.cshtml"
Write(Html.ActionLink("Back to course list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<University.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
