using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MotocycleShop.Data;
using System;
using System.Linq;
namespace MotocycleShop.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MotocycleShopContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<MotocycleShopContext>>()))
            {
                // Kiểm tra thông tin cuốn sách đã tồn tại hay chưa
                if (context.Kho.Any())
                {
                    return; // Không thêm nếu cuốn sách đã tồn tại trong DB
                }
                context.Kho.AddRange(
                new Kho
                {
                    Ten = "Ducati V4",
                    NgayNhap = DateTime.Parse("2018-10-16"),
                    PhanKhuc = "PKL",
                    Gia = 110000000,
                    Loai = "S"
                },
                new Kho
                {
                    Ten = "Suzuki 1000rr",
                    NgayNhap = DateTime.Parse("2021-8-3"),
                    PhanKhuc = "PKL",
                    Gia = 180000000,
                    Loai = "S"
                }
                );
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}