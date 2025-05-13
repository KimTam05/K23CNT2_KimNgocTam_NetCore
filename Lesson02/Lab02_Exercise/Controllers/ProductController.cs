using Lab02_Exercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02_Exercise.Controllers
{
    public class ProductController : Controller
    {
        [Route("san-pham", Name = "product")]
        public IActionResult Index()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Clothes",
                },
                new Category()
                {
                    Id = 2,
                    Name = "Bag",
                },
                new Category()
                {
                    Id = 3,
                    Name = "Watches",
                },
                new Category()
                {
                    Id = 4,
                    Name = "Television",
                },
                new Category()
                {
                    Id = 5,
                    Name = "Fridge",
                },
                new Category()
                {
                    Id = 6,
                    Name = "Fans",
                },
                new Category()
                {
                    Id = 7,
                    Name = "Heater",
                }
            };
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Áo Thun Feelready Sport Designed to Move AEROREADY",
                    Description = "Chiếc áo thun tập luyện thể thao có sử dụng chất liệu tái chế. Từ hoạt động tập luyện sáng sớm đến buổi chạy bộ ban chiều, chiếc áo thun adidas này luôn mang lại cảm giác thoải mái khi vận động. Công nghệ AEROREADY kiểm soát ẩm giúp bạn luôn khô thoáng khi di chuyển. Thiết kế FreeLift cho phạm vi chuyển động tối đa và cố định vị trí khi thực hiện các động tác giơ tay qua đầu. Gấu áo phía sau dài hơn giúp che chắn kín đáo.",
                    Image = "~/images/clothes_01.png",
                    CategoryID = 1,
                    OldPrice = 650000,
                    NewPrice = 552500,
                    StillAvaliable = true,
                },
                new Product()
                {
                    Id = 2,
                    Name = "Louis Vuitton Cotton Signature Crewneck Sweatshirt",
                    Description = "Thu hút mọi ánh nhìn bởi tone màu tươi sáng trên nền chất liệu cotton mềm mịn, chiếc áo LV mang đến tính ứng dụng cao và gây ấn tượng với hoạ tiết LV Lovers đính đá đặc trưng trong SS24 Show.",
                    Image = "~/images/clothes_02.png",
                    CategoryID = 1,
                    OldPrice = 40500000,
                    NewPrice = 39000000,
                    StillAvaliable = true,
                },
                new Product()
                {
                    Id = 3,
                    Name = "[INSIDEMEN x ANH TÚ] Quần Âu Nam Insidemen Dáng Relax ITR06503",
                    Description = "Quần âu phom dáng relax rộng rãi, thoải mái. Quần thiết kế cơ bản với túi cơi và túi sau tiện lợi. Gam màu trung tính, dễ kết hợp với nhiều loại trang phục, nhiều phong cách khác nhau.",
                    Image = "~/images/clothes_03.png",
                    CategoryID = 1,
                    OldPrice = 450000,
                    NewPrice = 350000,
                    StillAvaliable = true,
                },
                new Product()
                {
                    Id = 4,
                    Name = "Túi MICHAEL KORS Wilma",
                    Description = "Túi Đeo Chéo Nữ Michael Kors MK Wilma Small Signature Logo Crossbody Bag 35H3G3WC5B Màu Be Nâu là chiếc túi xách cao cấp đến từ thương hiệu Michael Kors. Đây là mẫu túi được nhiều chị em yêu thích bởi không chỉ thông dụng mà nó còn mang xu hướng thời trang cách điệu, chưa bao giờ là lỗi mốt.",
                    Image = "~/images/bag_01.png",
                    CategoryID = 2,
                    OldPrice = 3100000,
                    NewPrice = 2590000,
                    StillAvaliable = true,
                },
                new Product()
                {
                    Id = 5,
                    Name = "Túi Tote Michael Kors Jet Set Travel Small Carryall Convertible Top Zip",
                    Description = "Túi Tote Michael Kors Jet Set Travel Small Carryall Convertible Top Zip hất liệu da mềm xịn đẹp. Túi tote Michael Kors B0CL59H4MG tông trắng kem thanh lịch, dễ kết hợp với trang phục khác.",
                    Image = "~/images/bag_02.png",
                    CategoryID = 2,
                    OldPrice = 2300000,
                    NewPrice = 2100000,
                    StillAvaliable = true,
                },
                new Product()
                {
                    Id = 6,
                    Name = "Tabby S Crossbody Bag",
                    Description = "Thêm nét thanh lịch vượt thời gian cho vẻ ngoài của bạn với Túi đeo chéo Tabby S, sự pha trộn tinh tế giữa sự tinh tế hiện đại và nét quyến rũ độc đáo. Hình bóng cong mềm mại làm tăng thêm sức hấp dẫn duyên dáng của chiếc túi, trong khi logo Lyn đặc trưng tạo nên một tuyên bố táo bạo. Được thiết kế với dây đeo xích có thể tháo rời để tạo kiểu đa năng, sản phẩm này hoàn hảo cho những ai tìm kiếm cả sự thanh lịch và chức năng trong các phụ kiện hàng ngày của họ.",
                    Image = "~/images/bag_03.png",
                    CategoryID = 2,
                    OldPrice = 2100000,
                    NewPrice = 1950200,
                    StillAvaliable = true,
                },
                new Product()
                {
                    Id = 7,
                    Name = "Rolex Cosmograph Daytona Rainbow 116595RBOW",
                    Description = "Rolex là một trong những thương hiệu đồng hồ xa xỉ hàng đầu thế giới, nổi tiếng với các sản phẩm chất lượng, thiết kế tinh tế và đột phá về công nghệ. Trong số đó, chiếc Rolex Cosmograph Daytona Rainbow 116595RBOW là một trong những mẫu đồng hồ gây ấn tượng mạnh mẽ với giới mộ điệu và các nhà sưu tập bởi thiết kế lộng lẫy, sử dụng đá quý đầy màu sắc cùng các công nghệ hàng đầu. Chiếc đồng hồ không chỉ là một biểu tượng của sự tinh tế mà còn là hiện thân của sự đẳng cấp và sang trọng.",
                    Image = "~/images/watch_01.png",
                    CategoryID = 3,
                    OldPrice = 9900000000,
                    NewPrice = 9890000000,
                    StillAvaliable = true,
                },
                new Product()
                {
                    Id = 8,
                    Name = ""
                }

            };
            return View();
        }
    }
}

