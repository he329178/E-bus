#pragma checksum "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5825b428806417ed6ee6d3b1b926e201e3ccc92f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Passenger_PassengerView), @"mvc.1.0.view", @"/Views/Passenger/PassengerView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Passenger/PassengerView.cshtml", typeof(AspNetCore.Views_Passenger_PassengerView))]
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
#line 1 "E:\Ebus\Ebus\Views\_ViewImports.cshtml"
using Ebus;

#line default
#line hidden
#line 2 "E:\Ebus\Ebus\Views\_ViewImports.cshtml"
using Ebus.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5825b428806417ed6ee6d3b1b926e201e3ccc92f", @"/Views/Passenger/PassengerView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ad30c4f751e99dbd563e33deae9e688e594211", @"/Views/_ViewImports.cshtml")]
    public class Views_Passenger_PassengerView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<route>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("showBus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
  
    ViewData["Title"] = "PassengerView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(116, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(121, 21, false);
#line 6 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
Write(ViewData["userEmail"]);

#line default
#line hidden
            EndContext();
            BeginContext(142, 77, true);
            WriteLiteral("</h1>\r\n<div class=\"container\">\r\n\r\n\r\n    <br>\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(219, 1169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2d9bac437d64e15a628201a9b09a944", async() => {
                BeginContext(277, 251, true);
                WriteLiteral("\r\n            <div class=\"col-md-4\">\r\n\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleFormControlSelect1\">Form</label>\r\n                    <select class=\"form-control\" id=\"exampleFormControlSelect1\" name=\"from\">\r\n");
                EndContext();
#line 19 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
                         foreach (var i in Model)
                        {

#line default
#line hidden
                BeginContext(606, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(634, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e8bac8bb22547738f80ad3f1d3000d2", async() => {
                    BeginContext(659, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(661, 9, false);
#line 21 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
                                                 Write(i.busStop);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 21 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
                              WriteLiteral(i.busStop);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(679, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
                        }

#line default
#line hidden
                BeginContext(708, 324, true);
                WriteLiteral(@"                    </select>
                </div>

            </div>

            <div class=""col-md-4"">


                <div class=""form-group"">
                    <label for=""exampleFormControlSelect1"">To</label>
                    <select class=""form-control"" id=""exampleFormControlSelect1"" name=""to"">
");
                EndContext();
#line 34 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
                         foreach (var i in Model)
                        {

#line default
#line hidden
                BeginContext(1110, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1138, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff47d6eaab164093af98cb2c63e8195b", async() => {
                    BeginContext(1163, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1165, 9, false);
#line 36 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
                                                 Write(i.busStop);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 36 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
                              WriteLiteral(i.busStop);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1183, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
                        }

#line default
#line hidden
                BeginContext(1212, 169, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary mb-2\">Search</button>\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1388, 96, true);
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n            ");
            EndContext();
            BeginContext(1484, 798, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5189b48f047c41de85113915b21cbc59", async() => {
                BeginContext(1510, 503, true);
                WriteLiteral(@"
                <button class=""btn btn-primary mb-2"">Refund</button>

                <button type=""submit"" class=""btn btn-primary mb-2"">Gift To</button>
                <div class=""form-group mb-2"">
                    <label for=""staticEmail2"" class=""sr-only"">Email</label>
                    <input type=""text"" class=""form-control"" id=""exampleFormControlInput1"" placeholder=""give customer id"">
                </div>
                <button class=""btn btn-light mb-2"">
                    ");
                EndContext();
                BeginContext(2014, 55, false);
#line 60 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
               Write(Html.ActionLink("My ticket", "showTicket", "Passenger"));

#line default
#line hidden
                EndContext();
                BeginContext(2069, 102, true);
                WriteLiteral("\r\n                </button>\r\n                <button class=\"btn btn-light mb-2\">\r\n                    ");
                EndContext();
                BeginContext(2172, 58, false);
#line 63 "E:\Ebus\Ebus\Views\Passenger\PassengerView.cshtml"
               Write(Html.ActionLink("My traver Record", "record", "Passenger"));

#line default
#line hidden
                EndContext();
                BeginContext(2230, 45, true);
                WriteLiteral("\r\n                </button>\r\n\r\n\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2282, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<route>> Html { get; private set; }
    }
}
#pragma warning restore 1591
