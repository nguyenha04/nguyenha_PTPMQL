Routing trong .NET MVC
- Route là cơ chế ánh xạ Url hoặc có thể nói Route chịu trách nhiệm điều hướng đến trang tương ứng với Url được nhập
- cấu tạo của Route trong .NET MVC "{controller=Home}/{action=Index}/{id?}" trong đó:
    + Home là giá trị nhập vào tương ứng với tên của controller bỏ hậu tố controller
    + Index là tên method public
    + id là tham số
- có 2 cách để cấu tạo Route trong .NET MVC
    + cách 1: dùng Route gắn trên controller/action (Convention-based Routing)
    ```
        [Route("orders")]
        public class OrderController : Controller
        {
            [HttpGet("")]
            public IActionResult Index() { }

            [HttpGet("create")]
            public IActionResult Create() { }

            [HttpGet("edit/{id}")]
            public IActionResult Edit(int id) { }
        }
    ```
    + cách 2: dùng Convention-based Routing (mặc định trong Program.cs)
    ```
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    ```      
