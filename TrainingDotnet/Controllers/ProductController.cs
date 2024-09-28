using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;
using TrainingDotnet.Data;
using TrainingDotnet.Models.Entities;

namespace TrainingDotnet.Controllers
{
    public class ProductController : Controller
    {
        //Định nghĩa một biến để lưu đối tượng ApplicationDbContext dùng cho việc 
        //    tương tác với cơ sở dữ liệu.
        private readonly ApplicationDbContext dbContext;

        //Khởi tạo controller và gán dbContext(đối tượng tương tác với cơ sở dữ liệu) thông 
        //    qua Dependency Injection.
        public ProductController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();


        }
        [HttpGet]

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        //Product product: Đối số này nhận dữ liệu từ form khi form được submit.
        //    Product là một đại diện cho dữ liệu product là tên biến nhận dữ liệu.
        public IActionResult Add(Product product)
        {
            return View();
        }
        [HttpGet]

        public IActionResult Update()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Delete()
        {
            return View();
        }
    }
}
//Bạn có 2 phương thức cùng tên vì mỗi phương thức xử lý một loại yêu cầu
//    HTTP khác nhau: GET và POST. Điều này cho phép bạn sử dụng cùng một URL cho cả
//    việc hiển thị form (GET) và xử lý dữ liệu từ form (POST).
//    [HttpGet]: Phương thức này được dùng để xử lý các yêu cầu GET từ trình duyệt, 
//    thường là khi bạn cần hiển thị một form để thêm dữ liệu mới.
//    [HttpPost]: Phương thức này được dùng để xử lý các yêu cầu POST, tức là khi người
//    dùng gửi dữ liệu từ form về server.







