#pragma checksum "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2358412fd0706231bfa4b25bf021b4ce52a2436"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_ListBlogs), @"mvc.1.0.view", @"/Views/Blogs/ListBlogs.cshtml")]
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
#line 1 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\_ViewImports.cshtml"
using WebsiteBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\_ViewImports.cshtml"
using WebsiteBanHang.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2358412fd0706231bfa4b25bf021b4ce52a2436", @"/Views/Blogs/ListBlogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea9d782b3b6a4d4d62df034c111d3c646244e96", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_ListBlogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
  
    var ListBlog = (List<WebsiteBanHang.Data.News>)ViewBag.ListBlog;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"}
<div id=""content"">
    <div class=""wrapper"">
        <div class=""lf"">
            <ul class=""crumbs"">
                <li>
                    <h2>
                        <a id=""ctl00_cphContent_hplHomepage"" title=""Trang chủ"" href=""https://hoayeuthuong.com/"">Trang chủ</a>
                    </h2>
                </li>
                <li>
                    <h1>
                        <a id=""ctl00_cphContent_hplNews"" title=""Blog"" href=""https://hoayeuthuong.com/blog.aspx"">Blog</a>
                    </h1>
                </li>
            </ul>
            <input type=""hidden"" name=""ctl00$cphContent$ucNews$hdfMaxResult"" id=""ctl00_cphContent_ucNews_hdfMaxResult"" value=""8"" />
            <div class=""cms_news"">
");
#nullable restore
#line 22 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
                 if (ListBlog.Count() > 0)
                {
                    foreach (var item in ListBlog)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"item_img\">\r\n                                <a");
            BeginWriteAttribute("title", "  title=\"", 1087, "\"", 1106, 1);
#nullable restore
#line 28 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1096, item.Name, 1096, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1107, "\"", 1138, 4);
            WriteAttributeValue("", 1114, "/blog/", 1114, 6, true);
#nullable restore
#line 28 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1120, item.Url, 1120, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1129, "/", 1129, 1, true);
#nullable restore
#line 28 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1130, item.Id, 1130, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("alt", " alt=\"", 1144, "\"", 1160, 1);
#nullable restore
#line 28 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1150, item.Name, 1150, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1161, "\"", 1179, 1);
#nullable restore
#line 28 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1169, item.Name, 1169, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 1180, "\"", 1196, 1);
#nullable restore
#line 28 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1186, item.Logo, 1186, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:150px;width:200px;border-width:0px;\" /></a>\r\n                            </div>\r\n                            <div class=\"item_info\">\r\n                                <h3>\r\n                                    <a");
            BeginWriteAttribute("title", "  title=\"", 1422, "\"", 1441, 1);
#nullable restore
#line 32 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1431, item.Name, 1431, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1442, "\"", 1473, 4);
            WriteAttributeValue("", 1449, "/blog/", 1449, 6, true);
#nullable restore
#line 32 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1455, item.Url, 1455, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1464, "/", 1464, 1, true);
#nullable restore
#line 32 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1465, item.Id, 1465, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
                                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h3>\r\n                                <div class=\"desc\">\r\n                                    ");
#nullable restore
#line 35 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <a class=\"more\" title=\"Xem thêm\"");
            BeginWriteAttribute("href", " href=\"", 1741, "\"", 1772, 4);
            WriteAttributeValue("", 1748, "/blog/", 1748, 6, true);
#nullable restore
#line 37 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1754, item.Url, 1754, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1763, "/", 1763, 1, true);
#nullable restore
#line 37 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1764, item.Id, 1764, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem thêm</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 40 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>Không có bài viết nào</div>\r\n");
#nullable restore
#line 45 "D:\nghia\Net Core\flower\flower\WebsiteBanHang\Views\Blogs\ListBlogs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
            <div class=""paging"">
                <ul><li class='current'>1</li><li><a href='https://hoayeuthuong.com/blog.aspx?page=2'>2</a></li><li><a href='https://hoayeuthuong.com/blog.aspx?page=3'>3</a></li><li><a href='https://hoayeuthuong.com/blog.aspx?page=4'>4</a></li><li class='next'><a href='https://hoayeuthuong.com/blog.aspx?page=4'></a></li></ul>
            </div>
        </div>
        <div class=""rt"">
            <div class=""t"">
                <div class=""order"">
                    <a id=""ctl00_cphContent_ucLargeOrder_hplLargeOrder"" title=""Đặt hoa số lượng lớn"" href=""https://hoayeuthuong.com/lien-he.aspx""><img id=""ctl00_cphContent_ucLargeOrder_imgLargeOrder"" alt=""Đặt hoa số lượng lớn"" title=""Đặt hoa số lượng lớn"" src=""https://hyt.r.worldssl.net/images/dat-hoa-so-luong-lon.png"" style=""border-width:0px;"" /></a>
                </div>
                <div class=""discount"">
                    <h4>
                        Giảm 20.000đ
                    </h4>
            WriteLiteral(@"
                    <span>Nhằm khuyến khích mọi người quen sử dụng website trong việc giao dịch thương mại điện tử, Chúng tôi tặng cho mỗi đơn hàng 20.000đ nều bạn mua hoa trực tiếp từ webiste.</span>
                </div>
                <div class=""line"">
                </div>
                <div class=""satisfaction"">
                    <h4>
                        100% Hài lòng
                    </h4>
                    <span>Với nhiều năm kinh nghiệm phục vụ trong ngành điện hoa, chúng tôi hiểu mức độ quan trọng trong công việc của mình là truyền tải đúng và đủ thông điệp của người tặng đến người nhận. Vì thế chúng tôi cam kết 100% sự hài lòng của khách hàng với chúng dịch vụ của chúng tôi. Với bất cứ điều gì không hài lòng bạn đều được hoàn lại 100% phí dịch vụ đã chuyển cho chúng tôi.</span>
                </div>
            </div>
            <div class=""b"">
                <a id=""ctl00_cphContent_ucContact_hplAbout"" title=""Giới thiệu"" href=""https://hoayeuthuong.com/gioi-thieu.aspx");
            WriteLiteral(@""">
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
</div>
<div class=""line-b padding_top_20"">
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