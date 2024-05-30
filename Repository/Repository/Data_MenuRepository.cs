using Repository.Entity;
using Repository.IRepository;

namespace Repository.Repository
{
    public class Data_MenuRepository : GenericRepository<Data_Menu>, IData_MenuRepository
    {
        private readonly AppDBContext _context;
        public Data_MenuRepository(AppDBContext context) : base(context)
        {
            _context = context;
        }

        public List<Data_Menu> GetList()
        {
            // var a = this.GetAllAsync(); ==> Dòng này lỗi
            // fail: Microsoft.EntityFrameworkCore.Database.Connection[20004]
            // An error occurred using the connection to database 'wdi_oee' on server 'nhamnv'.
            // info: Microsoft.Hosting.Lifetime[0]

            List<Data_Menu> reval = new List<Data_Menu>();
            try
            {
                Data_Menu l1 = new Data_Menu();
                Data_Menu l2 = new Data_Menu();

                #region Fake data
                l1 = new Data_Menu() { MenuID = 1, Name = "Báo cáo tổng hợp", ParentID = 0, OrderNo = 1, IsShowMenu = true, Url = string.Empty };  // reval.Add(l1);  
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 2, Name = "Thống kê số lượng máy", ParentID = 1, OrderNo = 2, IsShowMenu = true, Url = "/MachineManagement/Statitics" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 3, Name = "Hiện trạng hoạt động", ParentID = 1, OrderNo = 3, IsShowMenu = true, Url = "/Dashboard/Index" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 4, Name = "Thời gian hoạt động", ParentID = 1, OrderNo = 4, IsShowMenu = true, Url = "/ReportMachineRuningStatus/Index" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 5, Name = "Chi tiết hoạt động", ParentID = 1, OrderNo = 5, IsShowMenu = true, Url = "/ReportMachineRuningStatus/Detail" });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 6, Name = "Thống kê lỗi", ParentID = 1, OrderNo = 6, IsShowMenu = true, Url = "/ReportErrorMachine/Index" });
                reval.Add(l1);
                // ------------------------------------------


                l1 = new Data_Menu() { MenuID = 20, Name = "Dịch vụ kỹ thuật", ParentID = 0, OrderNo = 20, IsShowMenu = true, Url = string.Empty };  // reval.Add(l1);  
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 21, Name = "Bảo dưỡng định kỳ", ParentID = 20, OrderNo = 21, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 22, Name = "Lệnh lắp đặt, sửa chữa", ParentID = 20, OrderNo = 22, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 23, Name = "Lập lịch làm việc", ParentID = 20, OrderNo = 23, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 25, Name = "Truy suất lịch sử máy", ParentID = 20, OrderNo = 25, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 26, Name = "Cập nhật công việc", ParentID = 20, OrderNo = 26, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 27, Name = "Nghiệm thu công việc", ParentID = 20, OrderNo = 27, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 28, Name = "Đánh giá từ khách hàng", ParentID = 20, OrderNo = 28, IsShowMenu = true, Url = string.Empty });
                reval.Add(l1);
                // ------------------------------------------


                l1 = new Data_Menu() { MenuID = 29, Name = "Quản lý bảo hành", ParentID = 0, OrderNo = 29, IsShowMenu = true, Url = string.Empty };  // reval.Add(l1);  
                l2 = new Data_Menu() { MenuID = 30, Name = "Tiếp nhận", ParentID = 29, OrderNo = 30, IsShowMenu = true, Url = string.Empty };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 31, Name = "Lập yêu cầu", ParentID = 30, OrderNo = 31, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 32, Name = "Kiểm tra điều kiện, phạm vi Bảo hành", ParentID = 30, OrderNo = 32, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 33, Name = "Phương án", ParentID = 29, OrderNo = 33, IsShowMenu = true, Url = string.Empty };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 34, Name = "Lập phương án xử lý", ParentID = 33, OrderNo = 34, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 35, Name = "Danh mục lỗi", ParentID = 33, OrderNo = 35, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 36, Name = "Chỉ định phương án", ParentID = 33, OrderNo = 36, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 37, Name = "Thực hiện", ParentID = 29, OrderNo = 37, IsShowMenu = true, Url = string.Empty };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 38, Name = "Lập lệnh", ParentID = 37, OrderNo = 38, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 39, Name = "Kiểm soát định mức", ParentID = 37, OrderNo = 39, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 40, Name = "Thống kê chi phí", ParentID = 37, OrderNo = 40, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 41, Name = "Tình trạng thực hiện", ParentID = 37, OrderNo = 41, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 42, Name = "Đóng lệnh", ParentID = 37, OrderNo = 42, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 43, Name = "Xuất nhập bảo hành", ParentID = 29, OrderNo = 43, IsShowMenu = true, Url = string.Empty };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 44, Name = "Gửi hàng bảo hành hãng", ParentID = 43, OrderNo = 44, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 45, Name = "Nhập kho hàng bảo hành", ParentID = 43, OrderNo = 45, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 46, Name = "Xuất mượn máy", ParentID = 43, OrderNo = 46, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 47, Name = "Tồn kho", ParentID = 43, OrderNo = 47, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // ------------------------------------------


                l1 = new Data_Menu() { MenuID = 48, Name = "Guest Portal", ParentID = 0, OrderNo = 48, IsShowMenu = true, Url = string.Empty };  // reval.Add(l1);  
                l2 = new Data_Menu() { MenuID = 49, Name = "Quản lý tài sản", ParentID = 48, OrderNo = 49, IsShowMenu = true, Url = string.Empty };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 50, Name = "Thông số kỹ thuật", ParentID = 49, OrderNo = 50, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 51, Name = "Lịch sử bảo dưỡng", ParentID = 49, OrderNo = 51, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 52, Name = "Lịch sủ bảo dưỡng định kỳ", ParentID = 49, OrderNo = 52, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 53, Name = "Yêu cầu sửa chữa", ParentID = 48, OrderNo = 53, IsShowMenu = true, Url = string.Empty };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 54, Name = "Lập yêu cầu", ParentID = 53, OrderNo = 54, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 55, Name = "Đánh giá chất lượng", ParentID = 53, OrderNo = 55, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 56, Name = "Quản lý chi phí", ParentID = 53, OrderNo = 56, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 57, Name = "Quản lý cảnh báo", ParentID = 48, OrderNo = 57, IsShowMenu = true, Url = string.Empty };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 58, Name = "Thời hạn bảo dưỡng", ParentID = 57, OrderNo = 58, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 59, Name = "Tình hình sửa chữa theo lệnh", ParentID = 57, OrderNo = 59, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 60, Name = "Thông báo từ Weldcom", ParentID = 57, OrderNo = 60, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // ------------------------------------------


                l1 = new Data_Menu() { MenuID = 61, Name = "Hệ thống", ParentID = 0, OrderNo = 61, IsShowMenu = true, Url = string.Empty };  // reval.Add(l1);  
                l2 = new Data_Menu() { MenuID = 62, Name = "Danh mục", ParentID = 61, OrderNo = 62, IsShowMenu = true, Url = string.Empty };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 63, Name = "Nhân viên, kỹ sư", ParentID = 62, OrderNo = 63, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 64, Name = "Máy móc thiết bị", ParentID = 62, OrderNo = 64, IsShowMenu = true, Url = "/MachineManagement/List" });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 65, Name = "Vật tư, phụ tùng, linh kiện", ParentID = 62, OrderNo = 65, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 66, Name = "Thiết lập chung", ParentID = 61, OrderNo = 66, IsShowMenu = true, Url = string.Empty };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 67, Name = "Thiết lập ngôn ngữ", ParentID = 66, OrderNo = 67, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 68, Name = "Thiết lập múi giờ", ParentID = 66, OrderNo = 68, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 69, Name = "Thiết lập chi nhánh", ParentID = 66, OrderNo = 69, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 70, Name = "Thiết lập email", ParentID = 66, OrderNo = 70, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 71, Name = "Cấu hình chung", ParentID = 66, OrderNo = 71, IsShowMenu = true, Url = string.Empty });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 72, Name = "Quản lý người dùng", ParentID = 61, OrderNo = 72, IsShowMenu = true, Url = string.Empty };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 73, Name = "Thiết lập người dùng", ParentID = 72, OrderNo = 73, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 74, Name = "Phân quyền", ParentID = 72, OrderNo = 74, IsShowMenu = true, Url = string.Empty });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 75, Name = "Đăng nhập", ParentID = 72, OrderNo = 75, IsShowMenu = true, Url = "/Authentication/LoginForm" });
                l1.ChildMenus.Add(l2);

                reval.Add(l1);
                // ------------------------------------------



                #endregion
            }
            catch (Exception)
            {

            }
            return reval;
        }

        public List<Data_Menu> GetList_20240529()
        {
            // var a = this.GetAllAsync(); ==> Dòng này lỗi
            // fail: Microsoft.EntityFrameworkCore.Database.Connection[20004]
            // An error occurred using the connection to database 'wdi_oee' on server 'nhamnv'.
            // info: Microsoft.Hosting.Lifetime[0]

            List<Data_Menu> reval = new List<Data_Menu>();
            try
            {
                Data_Menu l1 = new Data_Menu();
                Data_Menu l2 = new Data_Menu();

                #region Fake data
                //l1 = new Data_Menu() { MenuID = 1, Name = "Báo cáo tổng hợp", ParentID = 0, OrderNo = 1, IsShowMenu = true };  // reval.Add(l1);  
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 2, Name = "Thống kê số lượng máy", ParentID = 1, OrderNo = 2, IsShowMenu = true, Url = "/MachineManagement/Statitics" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 3, Name = "Hiện trạng hoạt động", ParentID = 1, OrderNo = 3, IsShowMenu = true, Url = "/ReportMachineRuningStatus/Index" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 4, Name = "Thời gian hoạt động", ParentID = 1, OrderNo = 4, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 5, Name = "Chi tiết hoạt động", ParentID = 1, OrderNo = 5, IsShowMenu = true, Url = "" });
                //l1.ChildMenus.Add(new Data_Menu() { MenuID = 6, Name = "Thống kê lỗi", ParentID = 1, OrderNo = 6, IsShowMenu = true, Url = "" });
                //reval.Add(l1);
                // ------------------------------------------

                l1 = new Data_Menu() { MenuID = 20, Name = "Dịch vụ kỹ thuật", ParentID = 0, OrderNo = 20, IsShowMenu = true };  // reval.Add(l1);  
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 21, Name = "Bảo dưỡng định kỳ", ParentID = 20, OrderNo = 21, IsShowMenu = true });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 22, Name = "Lệnh lắp đặt, sửa chữa", ParentID = 20, OrderNo = 22, IsShowMenu = true });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 23, Name = "Lập lịch làm việc", ParentID = 20, OrderNo = 23, IsShowMenu = true });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 25, Name = "Truy suất lịch sử máy", ParentID = 20, OrderNo = 25, IsShowMenu = true });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 26, Name = "Cập nhật công việc", ParentID = 20, OrderNo = 26, IsShowMenu = true });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 27, Name = "Nghiệm thu công việc", ParentID = 20, OrderNo = 27, IsShowMenu = true });
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 28, Name = "Đánh giá từ khách hàng", ParentID = 20, OrderNo = 28, IsShowMenu = true });
                reval.Add(l1);
                // ------------------------------------------

                l1 = new Data_Menu() { MenuID = 29, Name = "Quản lý bảo hành", ParentID = 0, OrderNo = 29, IsShowMenu = true };  // reval.Add(l1);  
                l2 = new Data_Menu() { MenuID = 30, Name = "Tiếp nhận", ParentID = 29, OrderNo = 30, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 31, Name = "Lập yêu cầu", ParentID = 30, OrderNo = 31, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 32, Name = "Kiểm tra điều kiện, phạm vi Bảo hành", ParentID = 30, OrderNo = 32, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 33, Name = "Phương án", ParentID = 29, OrderNo = 33, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 34, Name = "Lập phương án xử lý", ParentID = 33, OrderNo = 34, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 35, Name = "Danh mục lỗi", ParentID = 33, OrderNo = 35, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 36, Name = "Chỉ định phương án", ParentID = 33, OrderNo = 36, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 37, Name = "Thực hiện", ParentID = 29, OrderNo = 37, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 38, Name = "Lập lệnh", ParentID = 37, OrderNo = 38, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 39, Name = "Kiểm soát định mức", ParentID = 37, OrderNo = 39, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 40, Name = "Thống kê chi phí", ParentID = 37, OrderNo = 40, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 41, Name = "Tình trạng thực hiện", ParentID = 37, OrderNo = 41, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 42, Name = "Đóng lệnh", ParentID = 37, OrderNo = 42, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 43, Name = "Xuất nhập bảo hành", ParentID = 29, OrderNo = 43, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 44, Name = "Gửi hàng bảo hành hãng", ParentID = 43, OrderNo = 44, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 45, Name = "Nhập kho hàng bảo hành", ParentID = 43, OrderNo = 45, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 46, Name = "Xuất mượn máy", ParentID = 43, OrderNo = 46, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 47, Name = "Tồn kho", ParentID = 43, OrderNo = 47, IsShowMenu = true });
                l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // ------------------------------------------

                l1 = new Data_Menu() { MenuID = 48, Name = "Guest Portal", ParentID = 0, OrderNo = 48, IsShowMenu = true };  // reval.Add(l1);  
                l1.ChildMenus.Add(new Data_Menu() { MenuID = 49, Name = "Quản lý tài sản", ParentID = 48, OrderNo = 49, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 50, Name = "Thông số kỹ thuật", ParentID = 49, OrderNo = 50, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 51, Name = "Lịch sử bảo dưỡng", ParentID = 49, OrderNo = 51, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 52, Name = "Lịch sủ bảo dưỡng định kỳ", ParentID = 49, OrderNo = 52, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 53, Name = "Yêu cầu sửa chữa", ParentID = 48, OrderNo = 53, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 54, Name = "Lập yêu cầu", ParentID = 53, OrderNo = 54, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 55, Name = "Đánh giá chất lượng", ParentID = 53, OrderNo = 55, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 56, Name = "Quản lý chi phí", ParentID = 53, OrderNo = 56, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 57, Name = "Quản lý cảnh báo", ParentID = 48, OrderNo = 57, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 58, Name = "Thời hạn bảo dưỡng", ParentID = 57, OrderNo = 58, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 59, Name = "Tình hình sửa chữa theo lệnh", ParentID = 57, OrderNo = 59, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 60, Name = "Thông báo từ Weldcom", ParentID = 57, OrderNo = 60, IsShowMenu = true });
                l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // ------------------------------------------

                l1 = new Data_Menu() { MenuID = 61, Name = "Hệ thống", ParentID = 0, OrderNo = 61, IsShowMenu = true };  // reval.Add(l1);  
                l2 = new Data_Menu() { MenuID = 62, Name = "Danh mục", ParentID = 61, OrderNo = 62, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 63, Name = "Nhân viên, kỹ sư", ParentID = 62, OrderNo = 63, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 64, Name = "Máy móc thiết bị", ParentID = 62, OrderNo = 64, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 65, Name = "Vật tư, phụ tùng, linh kiện", ParentID = 62, OrderNo = 65, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 66, Name = "Thiết lập chung", ParentID = 61, OrderNo = 66, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 67, Name = "Thiết lập ngôn ngữ", ParentID = 66, OrderNo = 67, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 68, Name = "Thiết lập múi giờ", ParentID = 66, OrderNo = 68, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 69, Name = "Thiết lập chi nhánh", ParentID = 66, OrderNo = 69, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 70, Name = "Thiết lập email", ParentID = 66, OrderNo = 70, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 71, Name = "Cấu hình chung", ParentID = 66, OrderNo = 71, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 72, Name = "Quản lý người dùng", ParentID = 61, OrderNo = 72, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 73, Name = "Thiết lập người dùng", ParentID = 72, OrderNo = 73, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 74, Name = "Phân quyền", ParentID = 72, OrderNo = 74, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 75, Name = "Đăng nhập", ParentID = 72, OrderNo = 75, IsShowMenu = true, Url = "/Authentication/LoginForm" });
                l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // ------------------------------------------

                #endregion
            }
            catch (Exception)
            {

            }
            return reval;
        }
        public List<Data_Menu> GetList_old()
        {
            // var a = this.GetAllAsync(); ==> Dòng này lỗi
            // fail: Microsoft.EntityFrameworkCore.Database.Connection[20004]
            // An error occurred using the connection to database 'wdi_oee' on server 'nhamnv'.
            // info: Microsoft.Hosting.Lifetime[0]

            List<Data_Menu> reval = new List<Data_Menu>();
            try
            {
                Data_Menu l1 = new Data_Menu();
                Data_Menu l2 = new Data_Menu();

                #region Fake data
                l1 = new Data_Menu() { MenuID = 2, Name = "Dịch vụ kỹ thuật", ParentID = 0, OrderNo = 2, IsShowMenu = true };  // reval.Add(l1);  
                l2 = new Data_Menu() { MenuID = 3, Name = "Danh mục", ParentID = 2, OrderNo = 3, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 4, Name = "Nhân viên, kỹ sư", ParentID = 3, OrderNo = 4, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 5, Name = "Máy móc thiết bị", ParentID = 3, OrderNo = 5, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 6, Name = "Vật tư, phụ tùng, linh kiện", ParentID = 3, OrderNo = 6, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 10, Name = "Dịch vụ kỹ thuật", ParentID = 2, OrderNo = 10, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 11, Name = "Lệnh lắp đặt, sửa chữa", ParentID = 10, OrderNo = 11, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 13, Name = "Lập lịch làm việc", ParentID = 10, OrderNo = 13, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 14, Name = "Phương án sửa chữa", ParentID = 10, OrderNo = 14, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 15, Name = "Truy suất lịch sử máy", ParentID = 10, OrderNo = 15, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 18, Name = "Cập nhật công việc", ParentID = 10, OrderNo = 18, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 21, Name = "Nghiệm thu công việc", ParentID = 10, OrderNo = 21, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 22, Name = "Đánh giá từ khách hàng", ParentID = 10, OrderNo = 22, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 23, Name = "Chấm công", ParentID = 2, OrderNo = 23, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 24, Name = "Chấm công online", ParentID = 23, OrderNo = 24, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 25, Name = "Báo cáo chấm công", ParentID = 23, OrderNo = 25, IsShowMenu = true });
                l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // ------------------------------------------



                l1 = new Data_Menu() { MenuID = 41, Name = "Quản lý bảo hành", ParentID = 0, OrderNo = 41, IsShowMenu = true };  // reval.Add(l1);  
                l2 = new Data_Menu() { MenuID = 42, Name = "Tiếp nhận", ParentID = 41, OrderNo = 42, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 43, Name = "Lập yêu cầu", ParentID = 42, OrderNo = 43, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 44, Name = "Kiểm tra điều kiện, phạm vi BH", ParentID = 42, OrderNo = 44, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 45, Name = "Phương án", ParentID = 41, OrderNo = 45, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 46, Name = "Lập phương án xử lý", ParentID = 45, OrderNo = 46, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 47, Name = "Danh mục lỗi ", ParentID = 45, OrderNo = 47, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 48, Name = "Chỉ định phương án", ParentID = 45, OrderNo = 48, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 49, Name = "Thực hiện", ParentID = 41, OrderNo = 49, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 50, Name = "Lập lệnh", ParentID = 49, OrderNo = 50, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 51, Name = "Kiểm soát định mức", ParentID = 49, OrderNo = 51, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 52, Name = "Thống kê chi phí", ParentID = 49, OrderNo = 52, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 53, Name = "Tình trạng thực hiện", ParentID = 49, OrderNo = 53, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 54, Name = "Đóng lệnh", ParentID = 49, OrderNo = 54, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 55, Name = "Xuất nhập bảo hành", ParentID = 41, OrderNo = 55, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 56, Name = "Gửi hàng bảo hành hãng", ParentID = 55, OrderNo = 56, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 57, Name = "Nhập kho hàng bảo hành", ParentID = 55, OrderNo = 57, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 58, Name = "Xuất mượn máy", ParentID = 55, OrderNo = 58, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 59, Name = "Tồn kho", ParentID = 55, OrderNo = 59, IsShowMenu = true });
                l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // ------------------------------------------



                l1 = new Data_Menu() { MenuID = 63, Name = "Guest Portal", ParentID = 0, OrderNo = 63, IsShowMenu = true };  // reval.Add(l1);  
                l2 = new Data_Menu() { MenuID = 64, Name = "Thiết lập", ParentID = 63, OrderNo = 64, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 65, Name = "Thiết lập ngôn ngữ", ParentID = 64, OrderNo = 65, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 66, Name = "Thiết lập múi giờ", ParentID = 64, OrderNo = 66, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 67, Name = "Thiết lập chi nhánh", ParentID = 64, OrderNo = 67, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 68, Name = "Thiết lập email", ParentID = 64, OrderNo = 68, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 69, Name = "Cấu hình chung", ParentID = 64, OrderNo = 69, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 70, Name = "Quản lý người dùng", ParentID = 63, OrderNo = 70, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 71, Name = "Đồng bộ dữ liệu khách hàng khởi tạo từ ERP", ParentID = 70, OrderNo = 71, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 72, Name = "Thiết lập người dùng", ParentID = 70, OrderNo = 72, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 73, Name = "Phân quyền", ParentID = 70, OrderNo = 73, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 74, Name = "Quản lý tài sản", ParentID = 63, OrderNo = 74, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 75, Name = "Danh sách máy (WDI)", ParentID = 74, OrderNo = 75, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 76, Name = "Thông số kỹ thuật", ParentID = 74, OrderNo = 76, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 77, Name = "Lịch sử bảo dưỡng", ParentID = 74, OrderNo = 77, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 78, Name = "Lịch bảo dưỡng định kỳ", ParentID = 74, OrderNo = 78, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 79, Name = "Yêu cầu sửa chữa", ParentID = 63, OrderNo = 79, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 80, Name = "Lập yêu cầu", ParentID = 79, OrderNo = 80, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 81, Name = "Đánh giá chất lượng", ParentID = 79, OrderNo = 81, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 82, Name = "Quản lý chi phí", ParentID = 79, OrderNo = 82, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 83, Name = "Quản lý cảnh báo", ParentID = 63, OrderNo = 83, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 84, Name = "Thời hạn bảo dưỡng", ParentID = 83, OrderNo = 84, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 85, Name = "Tình hình sửa chữa theo lệnh", ParentID = 83, OrderNo = 85, IsShowMenu = true });
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 86, Name = "Thông báo từ Weldcom", ParentID = 83, OrderNo = 86, IsShowMenu = true });
                l1.ChildMenus.Add(l2);

                l2 = new Data_Menu() { MenuID = 87, Name = "Hiệu suất máy (OEE)", ParentID = 63, OrderNo = 87, IsShowMenu = true };
                l2.ChildMenus.Add(new Data_Menu() { MenuID = 88, Name = "Dashboard ", ParentID = 87, OrderNo = 88, IsShowMenu = true });
                l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // ------------------------------------------





                // ------------------------------------------

                #endregion
            }
            catch (Exception)
            {

            }
            return reval;
        }
    }
}
