using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace MotocycleShop.Models
{
    public class KhoPhanKhucViewModel
    {
        public List<Kho>? Khoes { get; set; }
        public SelectList? PhanKhuc { get; set; }
        public string? KhoPhanKhuc { get; set; }
        public string? SearchString { get; set; }
    }
}
