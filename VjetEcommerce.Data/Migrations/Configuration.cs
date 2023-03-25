namespace VjetEcommerce.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VjetEcommerce.Common;
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
            CreateSlide(context);
            //  This method will be called after migrating to the latest version.
        }
        private void CreateUser(VjetEcommerceDbContext context)
        {

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
        private void CreateFooter(VjetEcommerceDbContext context)
        {
            if (context.Footers.Count(x => x.ID == CommonConstants.DefaultFooterId) == 0)
            {
                string content = "";
            }
        }
        private void CreateSlide(VjetEcommerceDbContext context)
        {
            if (context.Slides.Count() == 0)
            {
                List<Slide> listSlide = new List<Slide>()
                {
                    new Slide() {
                        Name ="Slide 1",
                        DisplayOrder =1,
                        Status =true,
                        Url ="#",
                        Image ="/Assets/client/images/mac.png",
                        Content =@"	<h2>SALE 50%</h2>
                                <label>CHO TẤT CẢ <b>MẶT HÀNG</b></label>
                                <p>Hãy ghé thăm VJET TIKI ngay hôm nay để khám
                    phá những ưu đãi </ p >
                        <span class=""on-get"">XEM NGAY</span>" },
                    new Slide() {
                        Name ="Slide 2",
                        DisplayOrder =2,
                        Status =true,
                        Url ="#",
                        Image ="/Assets/client/images/coolmateao.png",
                    Content=@"<h2>SALE 50%</h2>
                                <label>CHO TẤT CẢ <b>MẶT HÀNG</b></label>
                                <p>Hãy ghé thăm VJET TIKI ngay hôm nay để khám
                    phá những ưu đãi </ p >
                        <span class=""on-get"">XEM NGAY</span>"},
                    new Slide() {
                        Name ="Slide 3",
                        DisplayOrder =3,
                        Status =true,
                        Url ="#",
                        Image ="/Assets/client/images/s22utra.png",
                    Content=@"<h2>SALE 50%</h2>
                                <label>CHO TẤT CẢ <b>MẶT HÀNG</b></label>
                                <p>Hãy ghé thăm VJET TIKI ngay hôm nay để khám
                    phá những ưu đãi </ p >
                        <span class=""on-get"">XEM NGAY</span>"},
                };
                context.Slides.AddRange(listSlide);
                context.SaveChanges();
            }
        }
    }
}