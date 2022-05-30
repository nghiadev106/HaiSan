#pragma checksum "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "000315f9c2f4acb2cdf4aa50c17cfe97d48f427d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Index.cshtml")]
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
#line 1 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteBanHang.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"000315f9c2f4acb2cdf4aa50c17cfe97d48f427d", @"/Areas/Admin/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8177a17ed15d7047f24e11f5db85014f9da01e1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    var ListOrder = (List<WebsiteBanHang.Data.Order>)ViewBag.ListOrder;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh sách hóa đơn</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách hóa đơn</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-body"">
            <div class=""table-responsive"">
");
#nullable restore
#line 15 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                 if (ListOrder.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>Tên</th>
                                <th>Email</th>
                                <th>SĐT</th>
                                <th>Địa chỉ</th>
                                <th>Ghi chú</th>
                                <th>Trạng thái</th>
                                <th>#</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 31 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                              
                                var stt = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                                 foreach (var item in ListOrder)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 36 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                               Write(Html.Raw(stt = stt + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                               Write(item.OrderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                               Write(item.OrderEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                               Write(item.OrderPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                               Write(item.OrderAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                               Write(item.OrderNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                                 if (item.PaymentStatus == 2)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"btn-success\">Hoàn thành</span></td>\r\n");
#nullable restore
#line 45 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                                }
                                else if (item.PaymentStatus == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"btn-warning\">Đã xác thực</span></td>\r\n");
#nullable restore
#line 49 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"btn-danger\">Chờ Xác thực</span></td>\r\n");
#nullable restore
#line 53 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2494, "\"", 2529, 2);
            WriteAttributeValue("", 2501, "/Admin/Order/Detail/", 2501, 20, true);
#nullable restore
#line 55 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 2521, item.Id, 2521, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary glyphicon glyphicon-pencilt\">Chi tiết</a>\r\n                                    <a class=\"btn btn-danger glyphicon glyphicon-trash\" onclick=\"return confirm(\'Bạn có muốn hóa đơn xóa không?\');\"");
            BeginWriteAttribute("href", " href=\"", 2744, "\"", 2789, 3);
#nullable restore
#line 56 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 2751, Url.Action("Delete","Order"), 2751, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2780, "/", 2780, 1, true);
#nullable restore
#line 56 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 2781, item.Id, 2781, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 59 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 63 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Không có hóa đơn nào</span>\r\n");
#nullable restore
#line 67 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Areas\Admin\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
