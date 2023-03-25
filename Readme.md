add footer on sql with query

```sql

update Footers set Content='<div class="footer-bottom-cate">
					<h6>Danh mục</h6>
					<ul>
						<li><a href="#">Điện Thoại - Máy Tính Bảng</a></li>
						<li><a href="#">Laptop - Máy Vi Tính - Linh kiện</a></li>
						<li><a href="#">Làm Đẹp - Sức Khỏe</a></li>
						<li ><a href="#">Thời trang nữ</a></li>
						<li ><a href="#">Thời trang nam</a></li>
						<li><a href="#">Thiết Bị Số - Phụ Kiện Số</a></li>
					</ul>
				</div>
				<div class="footer-bottom-cate bottom-grid-cat">
					<h6>Liên kết</h6>
					<ul>
						<li><a href="#">FAQ</a></li>
						<li><a href="#">Doanh nghiệp</a></li>
						<li><a href="#">Cookies</a></li>
					</ul>
				</div>
				<div class="footer-bottom-cate">
					<h6>Thông tin</h6>
					<ul>
						<li>Với hàng triệu sản phẩm từ các thương hiệu, cửa hàng uy tín, hàng nghìn loại mặt hàng từ Điện thoại smartphone tới Rau củ quả tươi, kèm theo dịch vụ giao hàng siêu tốc TikiNOW, Tiki mang đến cho bạn một trải nghiệm mua sắm online bắt đầu bằng chữ tín. Thêm vào đó, ở Tiki bạn có thể dễ dàng sử dụng vô vàn các tiện ích khác như mua thẻ cào, thanh toán hoá đơn điện nước, các dịch vụ bảo hiểm.</li>
					</ul>
				</div>
				<div class="footer-bottom-cate cate-bottom">
					<h6>Liên hệ</h6>
					<ul>
						<li>Cảm ơn quý khách đã quan tâm đến VJETSTORE. Nếu quý khách có bất kỳ câu hỏi hay nhu cầu gì về cửa hàng của chúng tôi, vui lòng liên hệ với chúng tôi theo các thông tin sau:</li>
						<li>Địa chỉ: 123 Đường ABC, Quận DEF, Thành phố GHI</li>
						<li> Điện thoại: 0987654321</li>
						<li >Email: vjetgolang@vjetgolang.onmicrosoft.com</li>
						<li >Website: www.vjettiki.com</li>
						<li class="phone">© 2023 Bản quyền thuộc về Vjet Tiki</li>
						<li class="temp"> <p class="footer-class">Design by <a href="https://github.com/nustvondev" target="_blank">Vjetgolang</a> </p></li>
					</ul>
				</div>' where ID= 'default'
```
