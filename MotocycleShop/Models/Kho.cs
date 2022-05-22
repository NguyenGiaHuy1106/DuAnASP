using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MotocycleShop.Models
{
    public class Kho
    {
        public int Id { get; set; }
        [Display(Name = "Tên Xe")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Ten { get; set; }
        [Display(Name = "Ngày Nhập")]
        [DataType(DataType.Date)]
        public DateTime NgayNhap{ get; set; }
        [Display(Name = "Phân Khúc")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string PhanKhuc { get; set; }
        [Range(1, 1000000000)]
        [DataType(DataType.Currency)]
        [Display(Name = "Giá")]
       
        public decimal Gia { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Loai { get; set; }
        [Display(Name = "Loại")]
    }
}
