#pragma checksum "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e407a6d62750d34774b9f58b08e5bac2edfad2f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e407a6d62750d34774b9f58b08e5bac2edfad2f6", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<WebApplication1.Storage.Entity.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Студенты</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Идентификационный номер</th>\r\n        <th>Фамилия</th>\r\n        <th>Имя</th>\r\n        <th>Группа</th>\r\n    </tr>\r\n");
#nullable restore
#line 12 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\Student\Index.cshtml"
     foreach(var student in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\Student\Index.cshtml"
           Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\Student\Index.cshtml"
           Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\Student\Index.cshtml"
           Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\Student\Index.cshtml"
           Write(student.Group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />");
#nullable restore
#line 18 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\Student\Index.cshtml"
                                     Write(student.Group.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<div>\r\n    <h1>Удаление студента</h1>\r\n");
#nullable restore
#line 25 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\Student\Index.cshtml"
     using (Html.BeginForm("DeleteStudent", "Student", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <textarea name=\"studentId\" id=\"studentId\"></textarea>\r\n        <button type=\"submit\">Отчислить</button>\r\n");
#nullable restore
#line 29 "C:\Users\Соня\Desktop\sunrise\SUNR1SE\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<WebApplication1.Storage.Entity.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
