#pragma checksum "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79998d094880aed5b142d8014db58f26e70afae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Index), @"mvc.1.0.view", @"/Views/Bookings/Index.cshtml")]
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
#line 1 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\_ViewImports.cshtml"
using HotelBooking.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\_ViewImports.cshtml"
using HotelBooking.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79998d094880aed5b142d8014db58f26e70afae0", @"/Views/Bookings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bfc8c8a4a2c143210d5320c0e513b6a294d0d3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelBooking.Mvc.Models.BookingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int year = Model.YearToDisplay;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Bookings</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79998d094880aed5b142d8014db58f26e70afae04119", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79998d094880aed5b142d8014db58f26e70afae05297", async() => {
                WriteLiteral("Next year");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
                             WriteLiteral(year+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79998d094880aed5b142d8014db58f26e70afae07465", async() => {
                WriteLiteral("Previous year");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
                             WriteLiteral(year-1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <tr>\r\n        <th>");
#nullable restore
#line 21 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
       Write(year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 22 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
         for (int day = 1; day <= 31; day++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>");
#nullable restore
#line 24 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
           Write(day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 25 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
     for (int month = 1; month <= 12; month++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
           Write(Model.GetMonthName(month));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
             for (int day = 1; day <= 31; day++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td ");
#nullable restore
#line 37 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
                     if (Model.DateIsOccupied(year, month, day)) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"bg-danger\" ");
#nullable restore
#line 37 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
                                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("></td>\r\n");
#nullable restore
#line 38 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>
                <h4>Start date</h4>
            </th>
            <th>
                <h4>End date</h4>
            </th>
            <th>
                <h4>IsActive</h4>
            </th>
            <th>
                <h4>Customer</h4>
            </th>
            <th>
                <h4>Room</h4>
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 65 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
 foreach (var item in Model.Bookings) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Room.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\tiham\Desktop\SchoolStuff\TestClass\PBSW_Testing\HotelBooking.Mvc\Views\Bookings\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelBooking.Mvc.Models.BookingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
