using Repository.Entity;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class Data_MenuRepository : GenericRepository<Data_Menu>, IData_MenuRepository
    {
        private readonly AppDBContext _context;
        public Data_MenuRepository(AppDBContext context) : base(context)
        {
            _context = context;
        }

        public ICollection<Data_Menu> GetList()
        {
            var a = this.GetAllAsync();
            // Root
            ICollection<Data_Menu> reval = new List<Data_Menu>();
            try
            {
                #region Fake data

                var l1 = new Data_Menu();
                var l2 = new Data_Menu();
                 
                //===================================================
                l1 = new Data_Menu() { MenuID = 2, Name = "Quản lý dịch vụ kỹ thuật (Filed Service)", ParentID = 0, OrderNo = 2, IsShowMenu = true };  // reval.Add(l1);  
                    l2 = (new Data_Menu() { MenuID = 10, Name = "Quản lý lặp đặt / dịch vụ kỹ thuật", ParentID = 2, OrderNo = 10, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 11, Name = "Quản lý lệnh Lắp đặt / Sửa chữa kỹ thuật", ParentID = 10, OrderNo = 11, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 13, Name = "Quản lý lập lịch, phân công cá nhân / tổ / đội thực hiện", ParentID = 10, OrderNo = 13, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 14, Name = "Quản lý phương án sửa chữa kỹ thuật", ParentID = 10, OrderNo = 14, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 15, Name = "Có chức năng truy suất thông tin lịch sử máy", ParentID = 10, OrderNo = 15, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 18, Name = "Quản lý tình trạng thực hiện lệnh", ParentID = 10, OrderNo = 18, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 19, Name = "Quản lý hiện trường, đo lường thời gian thực hiện cho các  tác nghiệp sửa chữa, lắp đặt …", ParentID = 10, OrderNo = 19, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 20, Name = "Ghi nhận thông tin thực tế tiêu hao về vật tư, hàng hoá & nhân lực cho từng lệnh sửa chữa", ParentID = 10, OrderNo = 20, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 21, Name = "Nghiệm thu lệnh lắp đặt / Sửa chữa / Bảo hành", ParentID = 10, OrderNo = 21, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 22, Name = "Lấy ý kiến phải hồi (đánh giá) của khách hàng)", ParentID = 10, OrderNo = 22, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);


                    l2 = new Data_Menu() { MenuID = 23, Name = "Quản lý chấm công đi hiện trường", ParentID = 2, OrderNo = 23, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 24, Name = "Quản lý chấm công + Định vị GPS khi kỹ thuật đi thực hiện theo lệnh điều động", ParentID = 23, OrderNo = 24, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 25, Name = "Xuất bảng chấm công / Xuất báo cáo tính thưởng", ParentID = 23, OrderNo = 25, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);


                    l2= new Data_Menu() { MenuID = 3, Name = "Danh mục QLDVKT", ParentID = 2, OrderNo = 3, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 4, Name = "Danh mục nhân viên, kỹ sư", ParentID = 3, OrderNo = 4, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 5, Name = "Danh mục máy móc thiết bị", ParentID = 3, OrderNo = 5, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 6, Name = "Danh mục vật tư, phụ tùng, linh kiện", ParentID = 3, OrderNo = 6, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);
            reval.Add(l1);
            // --------------------


                l1 = new Data_Menu() { MenuID = 41, Name = "Quản lý bảo hành", ParentID = 0, OrderNo = 41, IsShowMenu = true };  // reval.Add(l1);  
                    l2= new Data_Menu() { MenuID = 42, Name = "Quản lý tiếp nhận bảo hành", ParentID = 41, OrderNo = 42, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 43, Name = "Lập yêu cầu tiếp nhận bảo hành", ParentID = 42, OrderNo = 43, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 44, Name = "Kiểm tra điều kiện và phạm vi bảo hành", ParentID = 42, OrderNo = 44, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);


                    l2= new Data_Menu() { MenuID = 45, Name = "Phương án bảo hành", ParentID = 41, OrderNo = 45, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 46, Name = "Lập phương án xử lý bảo hành", ParentID = 45, OrderNo = 46, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 47, Name = "Quản lý danh mục lỗi theo máy", ParentID = 45, OrderNo = 47, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 48, Name = "Chỉ định phương án xử lý bảo hành", ParentID = 45, OrderNo = 48, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);


                    l2= new Data_Menu() { MenuID = 49, Name = "Lệnh sửa chữa bảo hành", ParentID = 41, OrderNo = 49, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 50, Name = "Tạo lệnh sửa chữa bảo hành", ParentID = 49, OrderNo = 50, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 51, Name = "Kiểm soát định mức sửa chữa bảo hành", ParentID = 49, OrderNo = 51, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 52, Name = "Thống kê chi phí sưa chữa bảo hành", ParentID = 49, OrderNo = 52, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 53, Name = "Theo dõi trình trạng sửa chữa bảo hành", ParentID = 49, OrderNo = 53, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 54, Name = "Đóng lệnh bảo hành, tợp hợp chi phí sửa chữa bảo hành", ParentID = 49, OrderNo = 54, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);


                    l2= new Data_Menu() { MenuID = 55, Name = "Quản lý xuất nhập bảo hành", ParentID = 41, OrderNo = 55, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 56, Name = "Lệnh gửi hàng đi bảo hành tại hãng", ParentID = 55, OrderNo = 56, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 57, Name = "Nhập kho hàng bảo hành", ParentID = 55, OrderNo = 57, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 58, Name = "Lệnh cho mượn máy móc (thay thế trong quá trinh bảo hành)", ParentID = 55, OrderNo = 58, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 59, Name = "Quản ly tồn kho CCDC, vật tư thiết bị bảo hành", ParentID = 55, OrderNo = 59, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // --------------------



                    l1 = new Data_Menu() { MenuID = 63, Name = "Hệ thống cổng thông in khách hàng WELDCOM (WELDCOM CUSTOMER PORTAL)", ParentID = 0, OrderNo = 63, IsShowMenu = true };  // reval.Add(l1);  
                        l2 = new Data_Menu() { MenuID = 64, Name = "Thiết lập", ParentID = 63, OrderNo = 64, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 65, Name = "Thiết lập ngôn ngữ", ParentID = 64, OrderNo = 65, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 66, Name = "Thiết lập múi giờ", ParentID = 64, OrderNo = 66, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 67, Name = "Thiết lập chi nhánh", ParentID = 64, OrderNo = 67, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 68, Name = "Thiết lập email", ParentID = 64, OrderNo = 68, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 69, Name = "Cấu hình chung", ParentID = 64, OrderNo = 69, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);


                    l2 = new Data_Menu() { MenuID = 70, Name = "Quản lý người dùng", ParentID = 63, OrderNo = 70, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 71, Name = "Đồng bộ dữ liệu khách hàng khởi tạo từ ERP", ParentID = 70, OrderNo = 71, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 72, Name = "Quản lý người dùng", ParentID = 70, OrderNo = 72, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 73, Name = "Phân quyền người dùng", ParentID = 70, OrderNo = 73, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);


                    l2= new Data_Menu() { MenuID = 74, Name = "Quản lý thông tin danh sách tài sản", ParentID = 63, OrderNo = 74, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 75, Name = "Giao diện quản lý thông tin danh sách máy móc đã ký hợp đồng cùng WELDCOM", ParentID = 74, OrderNo = 75, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 76, Name = "Thông số kỹ thuật theo máy móc", ParentID = 74, OrderNo = 76, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 77, Name = "Thống kê lịch sử bảo dưỡng", ParentID = 74, OrderNo = 77, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 78, Name = "Lịch bảo dưỡng định kỳ", ParentID = 74, OrderNo = 78, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);

                    l2 = new Data_Menu() { MenuID = 79, Name = "Quản lý yêu cầu sửa chữa", ParentID = 63, OrderNo = 79, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 80, Name = "Lập yêu cầu sửa chữa bất thường", ParentID = 79, OrderNo = 80, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 81, Name = "Đánh giá chất lượng sửa chữa & bảo dưỡng", ParentID = 79, OrderNo = 81, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 82, Name = "Quản lý chi phí sửa chữa & bảo dưỡng", ParentID = 79, OrderNo = 82, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);

                    l2 = new Data_Menu() { MenuID = 83, Name = "Quản lý cảnh báo", ParentID = 63, OrderNo = 83, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 84, Name = "Cánh bảo tài sản đến hạn bảo dưỡng", ParentID = 83, OrderNo = 84, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 85, Name = "Cảnh báo tình hình sửa chữa theo lệnh", ParentID = 83, OrderNo = 85, IsShowMenu = true });
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 86, Name = "Thông báo từ Weldcom", ParentID = 83, OrderNo = 86, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);

                    l2 = new Data_Menu() { MenuID = 87, Name = "Hiệu suất máy (OEE)", ParentID = 63, OrderNo = 87, IsShowMenu = true };
                        l2.ChildMenus.Add(new Data_Menu() { MenuID = 88, Name = "Dashboard quản lý hiệu suât máy theo từng máy", ParentID = 87, OrderNo = 88, IsShowMenu = true });
                    l1.ChildMenus.Add(l2);
                reval.Add(l1);
                // --------------------


                //reval.ChildMenus = new List<Data_Menu>();
                //// Level 1
                //reval.ChildMenus.Add(new Data_Menu()
                //{
                //    MenuID = 0,
                //    Name = "",
                //    ParentID = 0,
                //    OrderNo = 0,
                //    IsShowMenu = true,
                //    IsDeleted = false,
                //    CreatedDate = new DateTime(2024,05,04),
                //});

                #endregion
            }
            catch (Exception ex)
            {

            }
            return reval;
        }
    }
}
