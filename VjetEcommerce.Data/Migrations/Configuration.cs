namespace VjetEcommerce.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
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
            CreatePage(context);
            CreateContactDetail(context);
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

        private void CreatePage(VjetEcommerceDbContext context)
        {
            if (context.Pages.Count() == 0)
            {
                try
                {
                    var page = new Page()
                    {
                        Name = "Giới thiệu",
                        Alias = "gioi-thieu",
                        Content = @"VJET TIKI là một trang thương mại điện tử chuyên cung cấp các sản phẩm chất lượng cao với giá cả hợp lý nhất. Tại VJET TIKI, chúng tôi cam kết mang đến cho khách hàng những trải nghiệm mua sắm tuyệt vời nhất với một hệ thống đặt hàng và giao hàng nhanh chóng, chính xác và tin cậy.

Chúng tôi cung cấp đa dạng các sản phẩm từ thực phẩm, thời trang, gia dụng, công nghệ, đồ chơi cho đến sản phẩm dành cho các bé yêu. Tất cả đều được chọn lọc kỹ càng từ những thương hiệu uy tín và chất lượng nhất để đảm bảo khách hàng sẽ luôn tìm thấy sản phẩm ưng ý tại VJET TIKI.

Với đội ngũ nhân viên tận tình, chu đáo và giàu kinh nghiệm, chúng tôi luôn sẵn sàng giúp đỡ khách hàng trong quá trình mua sắm và giải đáp mọi thắc mắc của khách hàng. Hãy đến với VJET TIKI để trải nghiệm mua sắm trực tuyến tuyệt vời nhất và có được những sản phẩm tốt nhất cho gia đình bạn!",
                        Status = true

                    };
                    context.Pages.Add(page);
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                        }
                    }
                }

            }
        }

        private void CreateContactDetail(VjetEcommerceDbContext context)
        {
            if (context.ContactDetails.Count() == 0)
            {
                try
                {
                    var contactDetail = new ContactDetail()
                    {
                        Name = "Văn phòng VJET TIKI",
                        Address = "10/80C XL Hà Nội, Phường Tân Phú, Thủ Đức, Thành phố Hồ Chí Minh, Việt Nam",
                        Email = "vjetgolang@vjetgolang.onmicrosoft.com",
                        Lat = 10.8555880871146,
                        Lng = 106.78510077999104,
                        Phone = "0987654321",
                        Website = "https://github.com/vjetgolangs",
                        Other = "",
                        Status = true
                        

                    };
                    context.ContactDetails.Add(contactDetail);
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                        }
                    }
                }

            }
        }
    }
}