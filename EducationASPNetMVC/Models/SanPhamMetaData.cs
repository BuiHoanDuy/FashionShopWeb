using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationASPNetMVC.Models
{
    [MetadataType(typeof(SanphamMetaData))]
    public partial class Sanpham
    {
        // Sử dụng Metadata để hiển thị nhãn tiếng Việt
    }

    public class SanphamMetaData
    {
        [Display(Name = "Tên sản phẩm")]
        public string TenSanpham { get; set; }
        
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }

        [Display(Name = "Giá sản phẩm")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Chỉ được nhập số")]
        public decimal Gia { get; set; }
        
        [Display(Name = "Trạng thái")]
        public Byte TrangThai { get; set; }
       

        [Display(Name = "Ảnh đại diện")]
        [RegularExpression(@"^.*\.jpg$", ErrorMessage = "Chỉ chấp nhận tệp hình ảnh có định dạng .jpg.")]
        public string AnhDaiDien { get; set; }

        [Display(Name = "Phân loại sản phẩm")]
        public int PhanLoaiSanPhamID { get; set; }
    }
}