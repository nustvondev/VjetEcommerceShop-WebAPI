namespace VjetEcommerce.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VjetEcommerce.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VjetEcommerce.Data.VjetEcommerceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VjetEcommerce.Data.VjetEcommerceDbContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //    var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new VjetEcommerceDbContext()));

            //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new VjetEcommerceDbContext()));

            //    var user = new ApplicationUser()
            //    {
            //        UserName = "vjetgolang",
            //        Email = "vjetnodestudio@gmail.com",
            //        EmailConfirmed = true,
            //        BirthDay = DateTime.Now,
            //        FullName = "Nguyen Huu Hoa"

            //    };

            //    manager.Create(user, "123654$");

            //    if (!roleManager.Roles.Any())
            //    {
            //        roleManager.Create(new IdentityRole { Name = "Admin" });
            //        roleManager.Create(new IdentityRole { Name = "User" });
            //    }

            //    var adminUser = manager.FindByEmail("vjetnodestudio@gmail.com");

            //    manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
            //}
        }

        private void CreateProductCategorySample(VjetEcommerce.Data.VjetEcommerceDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name="Phụ kiện thời trang",Alias="phu-kien-thoi-trang",Status=true },
                 new ProductCategory() { Name="Điện Thoại - Máy Tính Bảng",Alias="dien-thoai-may-tinh-bang",Status=true },
                  new ProductCategory() { Name="Điện Gia Dụng",Alias="dien-gia-dung",Status=true },
                   new ProductCategory() { Name="Laptop - Máy Vi Tính - Linh kiện",Alias="laptop-may-vi-tinh-linh-kien",Status=true },
                   new ProductCategory() { Name="Làm Đẹp - Sức Khỏe",Alias="lam-dep-suc-khoe",Status=true },
                   new ProductCategory() { Name="Thời trang nữ",Alias="thoi-trang-nu",Status=true },
                   new ProductCategory() { Name="Thời trang nam",Alias="thoi-trang-nam",Status=true },
                   new ProductCategory() { Name="Thiết Bị Số - Phụ Kiện Số",Alias="thiet-bi-kts-phu-kien-so",Status=true }
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
    }
}