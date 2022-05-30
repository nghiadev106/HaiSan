using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanHang.Areas.Admin.Models.Product
{
    public class ProductUpdateRequest
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        [StringLength(500, ErrorMessage = "tên sản phẩm không quá 500 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn danh mục")]
        public long? CategoryId { get; set; }
        public string Logo { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập mô tả sản phẩm")]
        [StringLength(500, ErrorMessage = "mô tả sản phẩm không quá 500 ký tự")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập chi tiết sản phẩm")]
        [DataType(DataType.MultilineText)]
        public string Detail { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập giá bán")]
        public decimal? Price { get; set; }
        public decimal? PriceDiscount { get; set; }
        public bool? IsNew { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập URL")]
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn trạng thái")]
        public int? Status { get; set; }
        public bool IsNewInput
        {
            get => this.IsNew.GetValueOrDefault();
            set { this.IsNew = value; }
        }
        public IFormFile FileUpload { get; set; }
    }
}
