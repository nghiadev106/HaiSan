#pragma checksum "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "686ded2c0260b5b9ab7fe8cde80bbc1eb70362b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Category), @"mvc.1.0.view", @"/Views/News/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ded2c0260b5b9ab7fe8cde80bbc1eb70362b5", @"/Views/News/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea9d782b3b6a4d4d62df034c111d3c646244e96", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
  
    ViewData["Title"] = "Danh mục sp";

    var listNews = (List<WebsiteBanHang.Data.News>)ViewBag.listNews;
    var categories = (List<WebsiteBanHang.Data.CategoriesNew>)ViewBag.categories;
    var cate = (WebsiteBanHang.Data.CategoriesNew)ViewBag.cate;


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
                        <a");
            BeginWriteAttribute("id", " id=\"", 650, "\"", 655, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 656, "\"", 664, 0);
            EndWriteAttribute();
            WriteLiteral(" href=\"/tin-tuc\">Tin tức </a>\r\n                    </h2>\r\n                </li>\r\n                <li>\r\n                    <h2>\r\n                        <a");
            BeginWriteAttribute("id", " id=\"", 820, "\"", 825, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 826, "\"", 834, 0);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 25 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
                                              Write(cate.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </a>
                    </h2>
                </li>
            </ul>
            <div id=""data_items"" class=""data_items"">
                <input type=""hidden"" name=""ctl00$cphContent$ucGroupItems$hdfMaxResult"" id=""ctl00_cphContent_ucGroupItems_hdfMaxResult"" value=""16"" />
                <div class=""items"">
");
#nullable restore
#line 32 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
                     if (listNews.Count() > 0)
                    {
                        foreach (var item in listNews)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"item\">\r\n                                <div class=\"i\">\r\n                                    <a");
            BeginWriteAttribute("title", " title=\"", 1461, "\"", 1479, 1);
#nullable restore
#line 38 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 1469, item.Name, 1469, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1480, "\"", 1514, 4);
            WriteAttributeValue("", 1487, "/tin-tuc/", 1487, 9, true);
#nullable restore
#line 38 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 1496, item.Url, 1496, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1505, "/", 1505, 1, true);
#nullable restore
#line 38 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 1506, item.Id, 1506, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"lazy\" data-original=\"");
#nullable restore
#line 38 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
                                                                                                                         Write(item.Logo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("alt", " alt=\"", 1560, "\"", 1576, 1);
#nullable restore
#line 38 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 1566, item.Name, 1566, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1577, "\"", 1595, 1);
#nullable restore
#line 38 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 1585, item.Name, 1585, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""150"" height=""180"" src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABAQMAAAAl21bKAAAAA1BMVEX6+vqsEtnpAAAACklEQVQI12NgAAAAAgAB4iG8MwAAAABJRU5ErkJggg=="" style=""border-width:0px;"" /></a>
                                </div>
                                <div class=""t"">
                                    <span>
                                        <a");
            BeginWriteAttribute("title", " title=\"", 1972, "\"", 1990, 1);
#nullable restore
#line 42 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 1980, item.Name, 1980, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1991, "\"", 2025, 4);
            WriteAttributeValue("", 1998, "/tin-tuc/", 1998, 9, true);
#nullable restore
#line 42 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 2007, item.Url, 2007, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2016, "/", 2016, 1, true);
#nullable restore
#line 42 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 2017, item.Id, 2017, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </span>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 46 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"rt\">\r\n            <div class=\"r_nav\">\r\n                <h2 title=\"Danh mụct\">Danh mục</h2>\r\n                <ul>\r\n");
#nullable restore
#line 55 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
                     if (categories.Count() > 0)
                    {
                        foreach (var item in categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><strong><a");
            BeginWriteAttribute("title", " title=\"", 2608, "\"", 2626, 1);
#nullable restore
#line 59 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 2616, item.Name, 2616, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2627, "\"", 2662, 4);
            WriteAttributeValue("", 2634, "/loai-tin/", 2634, 10, true);
#nullable restore
#line 59 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 2644, item.Url, 2644, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2653, "/", 2653, 1, true);
#nullable restore
#line 59 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
WriteAttributeValue("", 2654, item.Id, 2654, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></strong></li>\r\n");
#nullable restore
#line 60 "D:\nghia\DoAnTotNghiep2022\Hưng\HaiSan\WebsiteBanHang\Views\News\Category.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
            <div class=""t"">
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
                    <span>Với nhiều năm kinh nghiệm phục vụ trong ngành điện hoa, chúng tôi hiểu mức độ quan trọng trong công việc của mình là truyền tải đúng và đủ thông điệp của người tặng đến người nhận. Vì thế chúng tôi cam kết 100% sự hài lòng của khách hàng với chúng dịch vụ của chúng tôi. Với bất cứ điều gì không hài lòng bạn đều được hoàn lại 100% phí dịch vụ đã chuyển cho chúng tôi.</spa");
            WriteLiteral(@"n>
                </div>
            </div>
            <div class=""b"">
                <a id=""ctl00_cphContent_ucContact_hplAbout"" title=""Giới thiệu"" href=""/gioi-thieu"">
                    <div class=""contact"">
                        <h4>
                            Giới thiệu
                        </h4>
                        <span>Với sự đầu tư nghiêm túc, chúng tôi tập trung nâng cao trải nghiệm người dùng (UX) kể cả trên môi trường trực tuyến và ngoại tuyến để đem lại một dịch vụ hoàn hảo xứng đáng trong nỗ lực trở thành công ty điện hoa số 1 tại Việt Nam.</span>
                    </div>
                </a>
            </div>
        </div>
    </div>
</div>");
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
