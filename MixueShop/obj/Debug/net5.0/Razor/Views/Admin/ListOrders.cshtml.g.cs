#pragma checksum "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e116132e5ad497325874729f154f0b236a03b19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListOrders), @"mvc.1.0.view", @"/Views/Admin/ListOrders.cshtml")]
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
#line 4 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
using MixueShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e116132e5ad497325874729f154f0b236a03b19", @"/Views/Admin/ListOrders.cshtml")]
    #nullable restore
    public class Views_Admin_ListOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleadmin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("listPro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 90%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e116132e5ad497325874729f154f0b236a03b196498", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e116132e5ad497325874729f154f0b236a03b196939", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <title>Mixue</title>
    <style>
        ion-icon {
            padding-right: 5px;
            margin: auto;
        }
    </style>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css""
          integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e116132e5ad497325874729f154f0b236a03b199205", async() => {
                WriteLiteral(@"
    <div class=""header"">
        <div class=""inheader"">
            <div class=""menu"">
                <ul>
                    <li>
                        <a href=""/Home/ViewProduct"">
                            <ion-icon name=""storefront""></ion-icon>
                            Shop
                        </a>
                    </li>
                    <li>
                        <a href=""/Admin/OverView"">
                            <ion-icon name=""stats-chart""></ion-icon>
                            Statisctic
                        </a>
                    </li>
                    <li class=""active"">
                        <a href=""/Admin/ListOrders"">
                            <ion-icon name=""settings""></ion-icon>
                            Manage
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <ion-icon name=""person-circle""></ion-icon>
");
#nullable restore
#line 53 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                             if (@ViewBag.Name != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                           Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                             
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p>Account</p>\r\n");
#nullable restore
#line 60 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 63 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                     if (@ViewBag.Name != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e116132e5ad497325874729f154f0b236a03b1912056", async() => {
                    WriteLiteral("\r\n                                <ion-icon name=\"log-out-outline\"></ion-icon>\r\n                                Log out\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 72 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </ul>
            </div>
        </div>
    </div>
    <div class=""content"">
        <div class=""left"">
            <div class=""categories"">
                <div class=""rightTitle"">
                    Page
                </div>
                <button class=""cateactive"" id=""directPageOrder"" value=""/Admin/ListOrders"" onclick=""changeDirectOrder()"">
                    List Orders
                </button>
                <button class=""cate"" id=""directPageProduct"" value=""/Admin/ListProducts"" onclick=""changeDirectProduct()"">
                    List Products
                </button>

            </div>
        </div>
        <div class=""right"">
            <div class=""cart"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e116132e5ad497325874729f154f0b236a03b1914675", async() => {
                    WriteLiteral("\r\n                    <div class=\"cartContact\">\r\n                        <div style=\"margin: auto 0\">\r\n                            <h4 style=\"margin:auto;\">List Order</h4>\r\n");
#nullable restore
#line 98 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                             if (@ViewBag.mess != null)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <h5 style=\"color:red\">");
#nullable restore
#line 100 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                                 Write(ViewBag.mess);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h5>\r\n");
#nullable restore
#line 101 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        </div>\r\n                        <div class=\"optionSort\" style=\"margin: auto 0;display:flex\">\r\n");
#nullable restore
#line 104 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                             if (@ViewBag.error != null)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <div class=\"option\" style=\"margin:auto\">\r\n                                    ");
#nullable restore
#line 107 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                               Write(ViewBag.error);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 109 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                            <div class=""option"" style=""margin:auto"">
                                From:
                                <input type=""date"" name=""from"" />
                            </div>
                            <div class=""option"" style=""margin:auto"">
                                To:
                                <input type=""date"" name=""to"" />
                            </div>
                            <div class=""option"" style=""margin:auto;"">
                                <button style=""padding:5px"" type=""submit"">Find</button>
                            </div>
                        </div>
                    </div>
                    <div style=""height: 95%;"">
                        <div class=""listProduct"">

                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th style=""border-top: none;"" scope=""col"">#</th>
                       ");
                    WriteLiteral(@"                 <th style=""border-top: none;"" scope=""col"">Order Date</th>
                                        <th style=""border-top: none;"" scope=""col"">Amount</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 135 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                     if (@ViewBag.orders != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                         foreach (var o in ViewBag.orders)
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            <tr");
                    BeginWriteAttribute("onclick", " onclick=\"", 5761, "\"", 5796, 3);
                    WriteAttributeValue("", 5771, "orderDetail(\'", 5771, 13, true);
#nullable restore
#line 139 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
WriteAttributeValue("", 5784, o.OrderID, 5784, 10, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 5794, "\')", 5794, 2, true);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                                <th style=\"border-top: none;\" scope=\"row\">");
#nullable restore
#line 140 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                                                                     Write(o.OrderID);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                                                <td>");
#nullable restore
#line 141 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                               Write(o.OrderDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 142 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                               Write(o.Amount);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 145 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 150 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                         if (ViewData["TotalPage"] != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                             if ((int)ViewData["TotalPage"] > 1)
                            {


#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <div style=\"height:5%;text-align:center\">\r\n\r\n");
#nullable restore
#line 157 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                     for (int i = 1; i <= (int)ViewData["TotalPage"]; i++)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                         if (@ViewBag.pageSelected == i)
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            <button class=\"pageActive\"");
                    BeginWriteAttribute("value", " value=\"", 6946, "\"", 6956, 1);
#nullable restore
#line 161 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
WriteAttributeValue("", 6954, i, 6954, 2, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"submit\" name=\"page\">");
#nullable restore
#line 161 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</button>\r\n");
#nullable restore
#line 162 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            <button style=\"padding: 5px;border-radius: 15px;cursor:pointer\"");
                    BeginWriteAttribute("value", " value=\"", 7236, "\"", 7246, 1);
#nullable restore
#line 165 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
WriteAttributeValue("", 7244, i, 7244, 2, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"submit\" name=\"page\">");
#nullable restore
#line 165 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                                                                                                                            Write(i);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</button>\r\n");
#nullable restore
#line 166 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 166 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 170 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Admin\ListOrders.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </div>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
    <script>
        function orderDetail(OrderId){
           const URL = `/Admin/OrderDetail?OrderId=${OrderId}`;
           window.location=URL;
        }
        function changeDirectProduct(){
            var x=document.getElementById(""directPageProduct"").value;
            console.log(x);
            window.location=x;
        }
        function changeDirectOrder(){
            var x=document.getElementById(""directPageOrder"").value;
            console.log(x);
            window.location=x;
        }
    </script>
    <script>
        function orderDetail(OrderId){
               const URL = `/Admin/OrderDetail?OrderId=${OrderId}`;
               window.location=URL;
            }
    </script>
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
            integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.j");
                WriteLiteral(@"sdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js""
            integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js""
            integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
            crossorigin=""anonymous""></script>
    <script type=""module"" src=""https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js""></script>
    <script nomodule src=""https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js""></script>
");
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
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
