#pragma checksum "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4414e8039bdab2d16aa930518c5d3742f576e77d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewProduct), @"mvc.1.0.view", @"/Views/Home/ViewProduct.cshtml")]
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
#line 7 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
using MixueShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4414e8039bdab2d16aa930518c5d3742f576e77d", @"/Views/Home/ViewProduct.cshtml")]
    #nullable restore
    public class Views_Home_ViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4414e8039bdab2d16aa930518c5d3742f576e77d5242", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""/css/style.css"">
    <title>Mixue</title>
    <style>
        ion-icon {
            padding-right: 5px;
        }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4414e8039bdab2d16aa930518c5d3742f576e77d6556", async() => {
                WriteLiteral(@"
    <div class=""header"">
        <div class=""inheader"">
            <div class=""menu"">
                <ul>
                    <li class=""active"">
                        <a href=""#"">
                            <ion-icon name=""storefront""></ion-icon>
                            Shop
                        </a>
                    </li>
");
#nullable restore
#line 37 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                     if (@ViewBag.Role == 1)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li>
                            <a href=""/Admin/ListOrders"">
                                <ion-icon name=""settings""></ion-icon>
                                Manage
                            </a>
                        </li>
");
#nullable restore
#line 45 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li>\r\n                        <a href=\"#\">\r\n                            <ion-icon name=\"person-circle\"></ion-icon>\r\n");
#nullable restore
#line 50 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                             if (@ViewBag.Name != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                           Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                             
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p>Account</p>\r\n");
#nullable restore
#line 57 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 60 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                     if (@ViewBag.Name != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4414e8039bdab2d16aa930518c5d3742f576e77d9691", async() => {
                    WriteLiteral("\r\n                                <ion-icon name=\"log-out-outline\"></ion-icon>\r\n                                Log out\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 69 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
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
            <div class=""cart"">
                <div class=""cartContact"">
                    <h4 style=""margin:auto;"">Order Infor</h4>
                </div>
                <div class=""inforOrder"">
");
#nullable restore
#line 81 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                     if (@ViewBag.carts != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4414e8039bdab2d16aa930518c5d3742f576e77d12195", async() => {
                    WriteLiteral(@"
                            <table style=""color: white;"">
                                <thead>
                                    <tr>
                                        <th style=""padding0 10px"">Product</th>
                                        <th style=""padding0 10px"">Price</th>
                                        <th style=""padding0 10px"">Quantity</th>
                                        <th style=""padding0 10px"">Total</th>
                                        <th style=""padding0 10px"">Remove</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 95 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                     foreach (var item in @ViewBag.carts)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        <tr>\r\n                                            <td style=\"text-align: center;\">\r\n                                                ");
#nullable restore
#line 99 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            </td>\r\n                                            <td style=\"text-align: center;\">");
#nullable restore
#line 101 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                            <td style=\"text-align: center;\">\r\n                                                <div>\r\n                                                    ");
#nullable restore
#line 104 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                                </div>\r\n\r\n                                            </td>\r\n                                            <td style=\"text-align: center;\">");
#nullable restore
#line 108 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                                       Write(item.TotalMoney);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                            <td style=\"text-align: center;\">\r\n                                                <button>\r\n                                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4414e8039bdab2d16aa930518c5d3742f576e77d15566", async() => {
                        WriteLiteral("\r\n                                                        Remove\r\n                                                    ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                                                                      WriteLiteral(item.Id);

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
                    WriteLiteral("\r\n                                                </button>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 117 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                    <tr>
                                        <td style=""text-align: center;"">
                                        </td>
                                        <td style=""text-align: center;""></td>
                                        <td style=""text-align: center;"">
                                            <div>
                                            </div>

                                        </td>
                                        <td style=""text-align: center;""></td>
                                        <td style=""text-align: center;"">
                                            Amount:	");
#nullable restore
#line 130 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                  Write(ViewBag.Amount);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 136 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
            </div>
            <div class=""acceptOrder"">
                <button class=""action"" onclick=""checkout()"">
                    Checkout
                </button>
                <button class=""action"" onclick=""Cancel()"">
                    Cancel
                </button>
            </div>
        </div>
        <div class=""right"">
            <div class=""products"">

                <div class=""rightTitle"">
                    Product
                </div>
                <div style=""padding:10px"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4414e8039bdab2d16aa930518c5d3742f576e77d22001", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 157 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                         if (@ViewBag.keySearch == null)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                            <p style=""display: flex;"">
                                Title: <input style=""width:90%"" type=""text"" name=""searchString"" />
                                <input style=""width:10%"" type=""submit"" value=""Search"" />
                            </p>
");
#nullable restore
#line 163 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <p style=\"display: flex;\">\r\n                                Title: <input style=\"width:90%\" type=\"text\" name=\"searchString\"");
                    BeginWriteAttribute("value", " value=\"", 6918, "\"", 6944, 1);
#nullable restore
#line 167 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 6926, ViewBag.keySearch, 6926, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                <input style=\"width:10%\" type=\"submit\" value=\"Search\" />\r\n                            </p>\r\n");
#nullable restore
#line 170 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"forProduct\">\r\n\r\n");
#nullable restore
#line 175 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                     foreach (var p in @ViewBag.products)
                    {
                        
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 178 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                         if (p.ProductPrice >= 10 && p.ProductPrice < 15)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button class=\"product\" style=\"background-color:blue\"");
                BeginWriteAttribute("onclick", " onclick=\"", 7489, "\"", 7522, 3);
                WriteAttributeValue("", 7499, "addCart(\'", 7499, 9, true);
#nullable restore
#line 180 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 7508, p.ProductId, 7508, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7520, "\')", 7520, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
#nullable restore
#line 181 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                           Write(p.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 181 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                          Write(p.ProductPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </button>\r\n");
#nullable restore
#line 183 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 184 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                         if (p.ProductPrice >= 15 && p.ProductPrice <= 25)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button class=\"product\" style=\"background-color:red\"");
                BeginWriteAttribute("onclick", " onclick=\"", 7839, "\"", 7872, 3);
                WriteAttributeValue("", 7849, "addCart(\'", 7849, 9, true);
#nullable restore
#line 186 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 7858, p.ProductId, 7858, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7870, "\')", 7870, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
#nullable restore
#line 187 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                           Write(p.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 187 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                          Write(p.ProductPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </button>\r\n");
#nullable restore
#line 189 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 190 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                         if (p.ProductPrice > 25 && p.ProductPrice < 40)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button class=\"product\" style=\"background-color:yellow\"");
                BeginWriteAttribute("onclick", " onclick=\"", 8190, "\"", 8223, 3);
                WriteAttributeValue("", 8200, "addCart(\'", 8200, 9, true);
#nullable restore
#line 192 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 8209, p.ProductId, 8209, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8221, "\')", 8221, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
#nullable restore
#line 193 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                           Write(p.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 193 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                          Write(p.ProductPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </button>\r\n");
#nullable restore
#line 195 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"categories\">\r\n                <div class=\"rightTitle\">\r\n                    Category\r\n                </div>\r\n");
#nullable restore
#line 204 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                 if (@ViewBag.selectedCate == 0 || @ViewBag.selectedCate == null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button style=\"background-color: #afaf7d;\" class=\"cate\" onclick=\"changeCate(\'0\')\">All</button>\r\n");
#nullable restore
#line 207 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"cate\" onclick=\"changeCate(\'0\')\">All</button>\r\n");
#nullable restore
#line 211 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 214 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                 foreach (var p in @ViewBag.cate)
                {
                    if (@ViewBag.selectedCate == p.CateId)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button style=\"background-color: #afaf7d;\" class=\"cate\"");
                BeginWriteAttribute("value", " value=\"", 9174, "\"", 9191, 1);
#nullable restore
#line 218 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 9182, p.CateId, 9182, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 9192, "\"", 9225, 3);
                WriteAttributeValue("", 9202, "changeCate(\'", 9202, 12, true);
#nullable restore
#line 218 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 9214, p.CateId, 9214, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9223, "\')", 9223, 2, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 218 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                                                                                               Write(p.CateName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
#nullable restore
#line 219 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button class=\"cate\"");
                BeginWriteAttribute("value", " value=\"", 9365, "\"", 9382, 1);
#nullable restore
#line 222 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 9373, p.CateId, 9373, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 9383, "\"", 9416, 3);
                WriteAttributeValue("", 9393, "changeCate(\'", 9393, 12, true);
#nullable restore
#line 222 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
WriteAttributeValue("", 9405, p.CateId, 9405, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9414, "\')", 9414, 2, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 222 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                                                                                            Write(p.CateName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
#nullable restore
#line 223 "D:\University\Semester5\PRN211\ProjectPRN\Phu\MixueShop\MixueShop\Views\Home\ViewProduct.cshtml"
                    }

                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
    </div>
    <script>
        function Cancel(){
           const URL = `/Cart/Cancel`;
           window.location=URL;
        }
        function changeCate(cateid){
           const URL = `/Home/Filter/${cateid}`;
           window.location=URL;
        }
        function checkout(){
            const URL=""/Cart/CheckoutCart"";
            window.location=URL;
        }
        function addCart(pro){
            const URL=`/Cart/AddToCart/${pro}`;
            window.location=URL;
        }
    </script>
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
