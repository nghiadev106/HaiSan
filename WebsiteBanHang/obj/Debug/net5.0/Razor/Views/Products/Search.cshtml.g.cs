#pragma checksum "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54d66932712fecbc85489452c9282a3ce5773ace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Search), @"mvc.1.0.view", @"/Views/Products/Search.cshtml")]
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
#line 1 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\_ViewImports.cshtml"
using WebsiteBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\_ViewImports.cshtml"
using WebsiteBanHang.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54d66932712fecbc85489452c9282a3ce5773ace", @"/Views/Products/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea9d782b3b6a4d4d62df034c111d3c646244e96", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
  
    ViewData["Title"] = "Tìm kiếm";

    var ListProduct = (List<WebsiteBanHang.Data.Product>)ViewBag.ListProduct;
    var categories = (List<WebsiteBanHang.Data.Category>)ViewBag.categories;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""content"">
    <div class=""wrapper"">
        <div class=""lf"">
            <ul class=""crumbs"">
                <li>
                    <h3>
                        <a id=""ctl00_cphContent_hplHomepage"" title=""Trang chủ"" href=""/"">Trang chủ</a>
                    </h3>
                </li>
                <li>
                    <h2>
                        Tìm kiếm
                    </h2>
                </li>
            </ul>
            <div class=""com_ddl"">
                <strong>
                    Sắp sếp theo:
                </strong>
                <div class=""dropdown_content"">
                    <span id=""ctl00_cphContent_filterItem_lblSortTitle"">Mặc định</span>
                    <ul>
                        <li>
                            <a id=""ctl00_cphContent_filterItem_hplDefault"" title=""Mặc định""");
            BeginWriteAttribute("href", " href=\"", 1068, "\"", 1075, 0);
            EndWriteAttribute();
            WriteLiteral(">Mặc định</a>\r\n                        </li>\r\n                        <li>\r\n                            <a id=\"ctl00_cphContent_filterItem_hplPriceLow\" title=\"Giá từ thấp tới cao\"");
            BeginWriteAttribute("href", " href=\"", 1255, "\"", 1262, 0);
            EndWriteAttribute();
            WriteLiteral(">Giá từ thấp tới cao</a>\r\n                        </li>\r\n                        <li>\r\n                            <a id=\"ctl00_cphContent_filterItem_hplPriceHigh\" title=\"Giá từ cao tới thấp\"");
            BeginWriteAttribute("href", " href=\"", 1454, "\"", 1461, 0);
            EndWriteAttribute();
            WriteLiteral(">Giá từ cao tới thấp</a>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div id=\"data_items\" class=\"data_items\">\r\n                <h3 style=\"margin-top:30px;\">Tìm kiếm : ");
#nullable restore
#line 42 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                                                   Write(ViewBag.keyword);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div class=\"items\">\r\n");
#nullable restore
#line 44 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                     if (ListProduct.Count() > 0)
                    {
                        foreach (var item in ListProduct)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item\">\r\n                        <div class=\"i\">\r\n                            <a");
            BeginWriteAttribute("title", " title=\"", 2031, "\"", 2063, 5);
            WriteAttributeValue("", 2039, "Hoa", 2039, 3, true);
            WriteAttributeValue(" ", 2042, "cao", 2043, 4, true);
            WriteAttributeValue(" ", 2046, "cấp", 2047, 4, true);
            WriteAttributeValue(" ", 2050, "-", 2051, 2, true);
#nullable restore
#line 50 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue(" ", 2052, item.Name, 2053, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2064, "\"", 2099, 4);
            WriteAttributeValue("", 2071, "/san-pham/", 2071, 10, true);
#nullable restore
#line 50 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue("", 2081, item.Url, 2081, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2090, "/", 2090, 1, true);
#nullable restore
#line 50 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue("", 2091, item.Id, 2091, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"lazy\" data-original=\"");
#nullable restore
#line 50 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                                                                                                                                Write(item.Logo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("alt", " alt=\"", 2145, "\"", 2161, 1);
#nullable restore
#line 50 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue("", 2151, item.Name, 2151, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2162, "\"", 2180, 1);
#nullable restore
#line 50 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue("", 2170, item.Name, 2170, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""150"" height=""180"" src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABAQMAAAAl21bKAAAAA1BMVEX6+vqsEtnpAAAACklEQVQI12NgAAAAAgAB4iG8MwAAAABJRU5ErkJggg=="" style=""border-width:0px;"" /></a>
                        </div>
                        <div class=""t"">
                            <span>
                                <a");
            BeginWriteAttribute("title", " title=\"", 2525, "\"", 2557, 5);
            WriteAttributeValue("", 2533, "Hoa", 2533, 3, true);
            WriteAttributeValue(" ", 2536, "cao", 2537, 4, true);
            WriteAttributeValue(" ", 2540, "cấp", 2541, 4, true);
            WriteAttributeValue(" ", 2544, "-", 2545, 2, true);
#nullable restore
#line 54 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue(" ", 2546, item.Name, 2547, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2558, "\"", 2593, 4);
            WriteAttributeValue("", 2565, "/san-pham/", 2565, 10, true);
#nullable restore
#line 54 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue("", 2575, item.Url, 2575, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2584, "/", 2584, 1, true);
#nullable restore
#line 54 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue("", 2585, item.Id, 2585, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </span>\r\n                            <span class=\"vn\"><em class=\'oprice\'>");
#nullable restore
#line 56 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                                                           Write(Convert.ToDecimal(item.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</em><em>");
#nullable restore
#line 56 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                                                                                                                   Write(Convert.ToDecimal(item.PriceDiscount).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</em></span>\r\n                        </div>\r\n");
#nullable restore
#line 58 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                         if (item.IsNew == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"ibadge inew\"></span>\r\n");
#nullable restore
#line 61 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 63 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Không tìm thấy sản phẩm nào</span>\r\n");
#nullable restore
#line 68 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"rt\">\r\n            <div class=\"r_nav\">\r\n                <h2 title=\"Danh mụct\">Danh mục</h2>\r\n                <ul>\r\n");
#nullable restore
#line 76 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                     if (categories.Count() > 0)
                    {
                        foreach (var item in categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><strong><a");
            BeginWriteAttribute("title", " title=\"", 3646, "\"", 3664, 1);
#nullable restore
#line 80 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue("", 3654, item.Name, 3654, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3665, "\"", 3702, 4);
            WriteAttributeValue("", 3672, "/chuyen-muc/", 3672, 12, true);
#nullable restore
#line 80 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue("", 3684, item.Url, 3684, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3693, "/", 3693, 1, true);
#nullable restore
#line 80 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
WriteAttributeValue("", 3694, item.Id, 3694, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 80 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></strong></li>\r\n");
#nullable restore
#line 81 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\Products\Search.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
            <div class=""t"">
                <div class=""order"">
                    <a id=""ctl00_cphContent_ucLargeOrder_hplLargeOrder"" title=""Đặt hoa số lượng lớn"" href=""../lien-he.html""><img id=""ctl00_cphContent_ucLargeOrder_imgLargeOrder"" alt=""Đặt hoa số lượng lớn"" title=""Đặt hoa số lượng lớn"" src=""../../hyt.r.worldssl.net/images/dat-hoa-so-luong-lon.png"" style=""border-width:0px;"" /></a>
                </div>
                <div class=""discount"">
                    <h4>
                        Giảm 20.000đ
                    </h4>
                    <span>Nhằm khuyến khích mọi người quen sử dụng website trong việc giao dịch thương mại điện tử, Chúng tôi tặng cho mỗi đơn hàng 20.000đ nều bạn mua hoa trực tiếp từ webiste.</span>
                </div>
                <div class=""line"">
                </div>
                <div class=""satisfaction"">
                    <h4>
                        100% Hài lòng
                    </h4>
       ");
            WriteLiteral(@"             <span>Với nhiều năm kinh nghiệm phục vụ trong ngành điện hoa, chúng tôi hiểu mức độ quan trọng trong công việc của mình là truyền tải đúng và đủ thông điệp của người tặng đến người nhận. Vì thế chúng tôi cam kết 100% sự hài lòng của khách hàng với chúng dịch vụ của chúng tôi. Với bất cứ điều gì không hài lòng bạn đều được hoàn lại 100% phí dịch vụ đã chuyển cho chúng tôi.</span>
                </div>
            </div>
            <div class=""b"">
                <a id=""ctl00_cphContent_ucContact_hplAbout"" title=""Giới thiệu"" href=""../gioi-thieu.html"">
                    <div class=""contact"">
                        <h4>
                            Giới thiệu
                        </h4>
                        <span>Với sự đầu tư nghiêm túc, chúng tôi tập trung nâng cao trải nghiệm người dùng (UX) kể cả trên môi trường trực tuyến và ngoại tuyến để đem lại một dịch vụ hoàn hảo xứng đáng trong nỗ lực trở thành công ty điện hoa số 1 tại Việt Nam.</span>
                    </div>
      ");
            WriteLiteral("          </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
