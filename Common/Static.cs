namespace Common
{
    public static class StaticData
    {
        public static readonly List<TimeRange> TimeRange = new List<TimeRange>();
        /// <summary>
        /// Bảng mã lỗi
        /// </summary>
        public static readonly List<Data_Error> Data_Error = new List<Data_Error>();
        /// <summary>
        /// Bảng vị trí cài đặt máy
        /// </summary>
        public static readonly List<Data_MachineLocation> Data_MachineLocation = new List<Data_MachineLocation>();
        /// <summary>
        /// Bảng danh sách loai máy
        /// </summary>
        public static readonly List<Data_MachineGroup> Data_MachineGroup = new List<Data_MachineGroup>();
        /// <summary>
        /// Bảng danh sách máy
        /// </summary>
        public static readonly List<Data_Machine> Data_Machine = new List<Data_Machine>();
        /// <summary>
        /// Bảng map máy nào đặt ở vị trí nào
        /// </summary>
        public static readonly List<Data_MachineLocationSetup> Data_MachineLocationSetup = new List<Data_MachineLocationSetup>();
        /// <summary>
        /// Bảng máy lỗi
        /// </summary>
        public static readonly List<Data_ErrorHistory> Data_ErrorHistory = new List<Data_ErrorHistory>();
        static StaticData()
        {
            try
            {
                #region TimeRange
                TimeRange.Add(new TimeRange() { TimeRangeID = 1, TimeRangeName = "Tháng trước" });
                TimeRange.Add(new TimeRange() { TimeRangeID = 2, TimeRangeName = "Quý trước" });
                TimeRange.Add(new TimeRange() { TimeRangeID = 3, TimeRangeName = "Năm trước" });
                TimeRange.Add(new TimeRange() { TimeRangeID = 4, TimeRangeName = "Tháng này" });
                TimeRange.Add(new TimeRange() { TimeRangeID = 5, TimeRangeName = "Quý này" });
                TimeRange.Add(new TimeRange() { TimeRangeID = 6, TimeRangeName = "Năm nay" });
                #endregion

                #region Build table Data_Error --> https://docs.google.com/spreadsheets/d/1UMRjN9evTMvQwJMt31RtQRhMZcriXHBo0uEliIhr05M/edit#gid=1052012425&range=J38

                Data_Error.Add(new Common.Data_Error() { ErrorID = 1, ErrorName = "Bộ điều khiển", ErrorCode = "E001" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 2, ErrorName = "Cơ khí", ErrorCode = "E002" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 3, ErrorName = "Thủy lực - khí nén", ErrorCode = "E003" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 4, ErrorName = "Tủ điện điều khiển", ErrorCode = "E004" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 5, ErrorName = "Hệ thống điều khiển", ErrorCode = "E005" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 6, ErrorName = "Phần mềm", ErrorCode = "E006" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 7, ErrorName = "Vận hành máy", ErrorCode = "E007" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 8, ErrorName = "Phụ kiện", ErrorCode = "E008" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 9, ErrorName = "Điều chỉnh thông số", ErrorCode = "E009" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 10, ErrorName = "Nguồn cắt laser", ErrorCode = "E101" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 11, ErrorName = "Nguồn cắt plasma", ErrorCode = "E301" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 12, ErrorName = "Blank", ErrorCode = "E501" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 13, ErrorName = "Nguồn hàn", ErrorCode = "E701" });
                Data_Error.Add(new Common.Data_Error() { ErrorID = 14, ErrorName = "Nguồn hàn/cắt", ErrorCode = "E901" });

                #endregion

                #region Build table Data_MachineLocation --> https://docs.google.com/spreadsheets/d/1UMRjN9evTMvQwJMt31RtQRhMZcriXHBo0uEliIhr05M/edit#gid=1321645102&range=D2

                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 1, LocationName = "AH1" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 2, LocationName = "AH1-Tổ Cắt -LAB" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 3, LocationName = "AH1-Tổ Cắt -LCD" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 4, LocationName = "AH1-Tổ Cắt BM-LBC" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 5, LocationName = "AH1-Tổ Tiện-LDE" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 6, LocationName = "AH2" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 7, LocationName = "AH2-L BC" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 8, LocationName = "AH2-LAB" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 9, LocationName = "AH2-LBC" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 10, LocationName = "AH2-LCD" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 11, LocationName = "AH2-T.CK-LBC" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 12, LocationName = "AH2-Tổ HT-BC" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 13, LocationName = "AH2-Tổ HT-LBC" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 14, LocationName = "AH2-Tổ Hàn Thô -L BC" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 15, LocationName = "AH2-Tổ HÀN Thô -LBC" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 16, LocationName = "AH2-Tổ Ráp Thô 1-L AB" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 17, LocationName = "AH3-LBC" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 18, LocationName = "AH3-Tổ Hàn HT" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 19, LocationName = "AH3-Tổ hàn thô-LB" });
                Data_MachineLocation.Add(new Common.Data_MachineLocation() { LocationID = 20, LocationName = "AH3-Tổ RT+HT-LBC" });

                #endregion

                #region Build table Data_MachineGroup

                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 1, MachineGroupName = "GCN" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 3, MachineGroupName = "LASER" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 4, MachineGroupName = "PLASMA" });
                Data_MachineGroup.Add(new Common.Data_MachineGroup() { MachineGroupID = 5, MachineGroupName = "ROBOT" });

                #endregion

                #region Build table Data_Machine --> https://docs.google.com/spreadsheets/d/1UMRjN9evTMvQwJMt31RtQRhMZcriXHBo0uEliIhr05M/edit#gid=1716046326&range=D3

                Data_Machine.Add(new Common.Data_Machine() { MachineID = 1, MachineName = "MÁY CHẤN YSD 12M", MachineNameOrigin = "Hệ thống máy chấn U CNC hiệu YSD model: 2HPC 1800/60 - ACBL - DDCI", MachineGroupID = 1, MachineGroupName = "GCN" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 2, MachineName = "MÁY CƯA VÒNG KRUMAN 1000", MachineNameOrigin = "Máy cưa vòng KH_1000H_Kruman - HD 3370 - 29/06/19 - Nam Weldcom - DDCI", MachineGroupID = 1, MachineGroupName = "GCN" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 3, MachineName = "MÁY KHOAN ĐẦU DẦM CNC", MachineNameOrigin = "Máy khoan CNC cho dầm thép model BHD1206A/3 - ACBL - DDCI", MachineGroupID = 1, MachineGroupName = "GCN" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 4, MachineName = "Khoan Bản Mã Tốc ĐỘ cao", MachineNameOrigin = "Máy khoan tấm tốc ộ cao CNC FIN", MachineGroupID = 1, MachineGroupName = "GCN" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 5, MachineName = "MÁY PHAY ĐẦU DẦM", MachineNameOrigin = "Máy phay ầu dầm, Model BDX 6080 - HD 1 - 04/07/19 - Trường Phúc - DDCI", MachineGroupID = 1, MachineGroupName = "GCN" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 6, MachineName = "MÁY PHAY ĐẦU DẦM", MachineNameOrigin = "Máy phay ầu dầm, Model BDX 2020 - HD 1 - 04/07/19 - Trường Phúc - DDCI", MachineGroupID = 1, MachineGroupName = "GCN" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 7, MachineName = "MÁY LỐC TÔN 4 TRỤC AKBEND", MachineNameOrigin = "MÁY LỐC TÔN 4 TRỤC AKBEND", MachineGroupID = 1, MachineGroupName = "GCN" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 8, MachineName = "Máy uốn thép hình APK 360 hãng Akypak Thổ Nhĩ Kỳ-Growell", MachineNameOrigin = "Máy uốn thép hình APK 360 hãng Akypak Thổ Nhĩ Kỳ-Growell", MachineGroupID = 1, MachineGroupName = "GCN" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 9, MachineName = "Máy vát mép 2 ầu, Model XBJ-12", MachineNameOrigin = "Máy vát mép 2 ầu, Model XBJ-12 - HD 1 - 04/07/19 - Trường Phúc - DDCI", MachineGroupID = 1, MachineGroupName = "GCN" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 10, MachineName = "MÁY GÁ XOAY BÀN", MachineNameOrigin = "Bộ gá hàn dầm Model 50T-H BRUCO - HD 541 - 27/9/19 - Nam Weldcom - DDCI", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 11, MachineName = "MÁY GÁ HỘP DẠNG CỔNG XXZ15", MachineNameOrigin = "MÁY GÁ HỘP DẠNG CỔNG XXZ15", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 12, MachineName = "MÁY ĐÍNH GÁ DẦM H TỰ ĐỘNG.", MachineNameOrigin = "Máy ính gá dầm H tự ộng Medol BZJ -2000Plus - HD 523 - 26/9/19 - DDCI", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 13, MachineName = "MÁY GÁ TẤM XJZ 15", MachineNameOrigin = "MÁY GÁ TẤM XJZ 15", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 14, MachineName = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 01", MachineNameOrigin = "Máy hàn dầm hộp trọn bộ-Jingfeng-ACBL-DDCI", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 15, MachineName = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 02", MachineNameOrigin = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 02", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 16, MachineName = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 03", MachineNameOrigin = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 03", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 17, MachineName = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 04", MachineNameOrigin = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 04", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 18, MachineName = "MÁY RÁP DẦM ZHOUXIANG - NGANG", MachineNameOrigin = "Máy ính gá dầm H tự ộng Model HZJ-2000", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 19, MachineName = "MÁY NẮN THẲNG CÁNH DẦM HẠNG NẶNG", MachineNameOrigin = "Máy nắn thẳng cánh dầm hạng nặng Model YJZ 80B - HD 526 - 26/9/19 - DDCI", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 20, MachineName = "MÁY NẮN THẲNG CÁNH DẦM HẠNG NẶNG", MachineNameOrigin = "Máy nắn thẳng cánh dầm hạng nặng Model Y80B - HD 526 - 26/9/19 - DDCI", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 21, MachineName = "MÁY HÀN CỔNG HẠNG NẶNG.", MachineNameOrigin = "", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 22, MachineName = "MÁY HÀN CỔNG HẠNG NẶNG.", MachineNameOrigin = "Máy hàn cổng thông minh hạng nặng - VCB02- 62.23.07/CTTC (7 năm)", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 23, MachineName = "MÁY HÀN DẦM CỘT, HÀN NỐI ỐNG", MachineNameOrigin = "Máy hàn cần cột, hàn nối ống CZM-8x6 - HD 459 - 24/10/19 - Cơ Khí Đồng Nai - DDCI", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 24, MachineName = "MÁY HÀN DẦM CỘT, HÀN NỐI ỐNG", MachineNameOrigin = "Máy hàn cần cột, hàn nối ống CZM-4x7 - HD 459 - 24/10/19 - Cơ Khí Đồng Nai - DDCI", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 25, MachineName = "MÁY HÀN CỔNG HẠNG NẶNG", MachineNameOrigin = "Máy hàn cổng hạng nặng model BTMZ-S3 (01 bộ) - HĐ số 013-19/HDMMTB/DDCI-NW-HD 23867 - 20/11/19-NAM WELDCOM-DDCI", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 26, MachineName = "MÁY HÀN CỔNG THÔNG MINH", MachineNameOrigin = "Máy hàn dầm ngang Model (Cổng hàn thông minh) HN0630-S1 - ACBL - DDCI", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 27, MachineName = "MÁY HÀN DẦM CỘT, HÀN NỐI ỐNG", MachineNameOrigin = "Máy hàn cần cột, hàn ống nối CZM-8x6 - HD 459 - 24/10/2019 - CK Đồng Nai - DDCI", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 28, MachineName = "MÁY HÀN CO2 DẠNG CỔNG XQHB-15  1 BỘ GỒM 4 NGUỒN CO2 OTC XD 500", MachineNameOrigin = "MÁY HÀN CO2 DẠNG CỔNG XQHB-15  1 BỘ GỒM 4 NGUỒN CO2 OTC XD 500", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 29, MachineName = "MÁY HÀN CO2 DẠNG CỔNG XQHB-15   1 BỘ GỒM 4 NGUỒN CO2 OTC XD 500", MachineNameOrigin = "MÁY HÀN CO2 DẠNG CỔNG XQHB-15   1 BỘ GỒM 4 NGUỒN CO2 OTC XD 500", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 30, MachineName = "MÁY HÀN ĐIỆN XỈ DẠNG CỔNG XZHB-15", MachineNameOrigin = "MÁY HÀN ĐIỆN XỈ DẠNG CỔNG XZHB-15", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 31, MachineName = "MÁY HÀN HỒ QUANG CHÌM DANG CỔNG XMHB 15", MachineNameOrigin = "MÁY HÀN HỒ QUANG CHÌM DANG CỔNG XMHB 15", MachineGroupID = 2, MachineGroupName = "KCT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 32, MachineName = "MÁY CẮT CNC LAZER YAWEI", MachineNameOrigin = "Máy cắt laser sợi quang Model HLF-24240-20000W - ACBL - DDCI", MachineGroupID = 3, MachineGroupName = "LASER" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 33, MachineName = "MÁY KHOAN, CẮT CNC PLASMA - AKYAPAK", MachineNameOrigin = "Máy cắt Plasma CNC kích thước cắt hữu ích 3000 x 12000 mm, nguồn cắt plasma Smart Focus 300A, Kjellberg,Đức", MachineGroupID = 4, MachineGroupName = "PLASMA" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 34, MachineName = "MÁY CẮT PLASMA XPR3000", MachineNameOrigin = "Máy cắt CNC ầu nghiêng vắt mép - Model TDC-IV - ACBL - DDCI", MachineGroupID = 4, MachineGroupName = "PLASMA" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 35, MachineName = "MÁY CẮT CNC PLASMA AMG", MachineNameOrigin = "Máy cắt Plasma CNC kích thước cắt hữu ích 3000 x 12000 mm, nguồn cắt plasma Smart Focus 300A, Kjellberg,Đức", MachineGroupID = 4, MachineGroupName = "PLASMA" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 36, MachineName = "Máy cắt CNC Plasma FSC 5000D x 18M", MachineNameOrigin = "Máy cắt CNC Plasma FSC 5000D x 18M", MachineGroupID = 4, MachineGroupName = "PLASMA" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 37, MachineName = "MÁY CẮT ĐẦU RẦM ROBOTI", MachineNameOrigin = "Robot cắt ầu dầm Model PKG100/50 (kèm robot ABBIRS 2600, nguồn cắt Hypertherm 260 XD)", MachineGroupID = 5, MachineGroupName = "ROBOT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 38, MachineName = "HỆ THỐNG HÀN ROBOT", MachineNameOrigin = "Hệ thống Robot hàn dầm-HD 523-26/9/19-DDCI", MachineGroupID = 5, MachineGroupName = "ROBOT" });
                Data_Machine.Add(new Common.Data_Machine() { MachineID = 39, MachineName = "MÁY CẮT THỦY LỰC 12M YSD", MachineNameOrigin = "Máy cắt iều khiển CNC", MachineGroupID = 0, MachineGroupName = "" });

                #endregion

                #region Build table Data_MachineLocationSetup --> https://docs.google.com/spreadsheets/d/1UMRjN9evTMvQwJMt31RtQRhMZcriXHBo0uEliIhr05M/edit#gid=793389812&range=E2 

                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 3, MachineName = "MÁY CẮT CNC LAZER YAWEI", LocationID = 2, LocationName = "AH1-Tổ Cắt -LAB" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 28, MachineName = "MÁY KHOAN, CẮT CNC PLASMA - AKYAPAK", LocationID = 2, LocationName = "AH1-Tổ Cắt -LAB" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 8, MachineName = "MÁY CẮT PLASMA XPR3000", LocationID = 3, LocationName = "AH1-Tổ Cắt -LCD" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 4, MachineName = "MÁY CẮT CNC PLASMA AMG", LocationID = 2, LocationName = "AH1-Tổ Cắt -LAB" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 9, MachineName = "MÁY CẮT THỦY LỰC 12M YSD", LocationID = 4, LocationName = "AH1-Tổ Cắt BM-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 6, MachineName = "MÁY CẮT ĐẦU RẦM ROBOTI", LocationID = 4, LocationName = "AH1-Tổ Cắt BM-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 5, MachineName = "Máy cắt CNC Plasma FSC 5000D x 18M", LocationID = 1, LocationName = "AH1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 10, MachineName = "MÁY CHẤN YSD 12M", LocationID = 10, LocationName = "AH2-LCD" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 11, MachineName = "MÁY CƯA VÒNG KRUMAN 1000", LocationID = 11, LocationName = "AH2-T.CK-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 27, MachineName = "MÁY KHOAN ĐẦU DẦM CNC", LocationID = 8, LocationName = "AH2-LAB" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 2, MachineName = "Khoan Bản Mã Tốc ĐỘ cao", LocationID = 1, LocationName = "AH1" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 32, MachineName = "MÁY PHAY ĐẦU DẦM", LocationID = 5, LocationName = "AH1-Tổ Tiện-LDE" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 32, MachineName = "MÁY PHAY ĐẦU DẦM", LocationID = 10, LocationName = "AH2-LCD" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 32, MachineName = "MÁY PHAY ĐẦU DẦM", LocationID = 9, LocationName = "AH2-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 29, MachineName = "MÁY LỐC TÔN 4 TRỤC AKBEND", LocationID = 10, LocationName = "AH2-LCD" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 35, MachineName = "Máy uốn thép hình APK 360 hãng Akypak Thổ Nhĩ Kỳ-Growell", LocationID = 5, LocationName = "AH1-Tổ Tiện-LDE" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 15, MachineName = "MÁY GÁ XOAY BÀN", LocationID = 7, LocationName = "AH2-L BC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 15, MachineName = "MÁY GÁ XOAY BÀN", LocationID = 15, LocationName = "AH2-Tổ HÀN Thô -LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 13, MachineName = "MÁY GÁ HỘP DẠNG CỔNG XXZ15", LocationID = 14, LocationName = "AH2-Tổ Hàn Thô -L BC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 12, MachineName = "MÁY ĐÍNH GÁ DẦM H TỰ ĐỘNG.", LocationID = 16, LocationName = "AH2-Tổ Ráp Thô 1-L AB" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 14, MachineName = "MÁY GÁ TẤM XJZ 15", LocationID = 14, LocationName = "AH2-Tổ Hàn Thô -L BC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 37, MachineName = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 01", LocationID = 9, LocationName = "AH2-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 38, MachineName = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 02", LocationID = 9, LocationName = "AH2-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 39, MachineName = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 03", LocationID = 9, LocationName = "AH2-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 40, MachineName = "THIẾT BỊ LẬT DẦM XF 15 - SỐ 04", LocationID = 9, LocationName = "AH2-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 34, MachineName = "MÁY RÁP DẦM ZHOUXIANG - NGANG", LocationID = 17, LocationName = "AH3-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 30, MachineName = "MÁY NẮN THẲNG CÁNH DẦM HẠNG NẶNG", LocationID = 17, LocationName = "AH3-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 30, MachineName = "MÁY NẮN THẲNG CÁNH DẦM HẠNG NẶNG", LocationID = 8, LocationName = "AH2-LAB" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 36, MachineName = "Máy vát mép 2 ầu, Model XBJ-12", LocationID = 6, LocationName = "AH2" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 19, MachineName = "MÁY HÀN CỔNG HẠNG NẶNG.", LocationID = 12, LocationName = "AH2-Tổ HT-BC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 19, MachineName = "MÁY HÀN CỔNG HẠNG NẶNG.", LocationID = 12, LocationName = "AH2-Tổ HT-BC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 1, MachineName = "HỆ THỐNG HÀN ROBOT", LocationID = 12, LocationName = "AH2-Tổ HT-BC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 22, MachineName = "MÁY HÀN DẦM CỘT, HÀN NỐI ỐNG", LocationID = 13, LocationName = "AH2-Tổ HT-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 22, MachineName = "MÁY HÀN DẦM CỘT, HÀN NỐI ỐNG", LocationID = 13, LocationName = "AH2-Tổ HT-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 18, MachineName = "MÁY HÀN CỔNG HẠNG NẶNG", LocationID = 19, LocationName = "AH3-Tổ hàn thô-LB" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 21, MachineName = "MÁY HÀN CỔNG THÔNG MINH", LocationID = 20, LocationName = "AH3-Tổ RT+HT-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 22, MachineName = "MÁY HÀN DẦM CỘT, HÀN NỐI ỐNG", LocationID = 18, LocationName = "AH3-Tổ Hàn HT" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 17, MachineName = "MÁY HÀN CO2 DẠNG CỔNG XQHB-15 1 BỘ GỒM 4 NGUỒN CO2 OTC XD 500", LocationID = 13, LocationName = "AH2-Tổ HT-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 17, MachineName = "MÁY HÀN CO2 DẠNG CỔNG XQHB-15 1 BỘ GỒM 4 NGUỒN CO2 OTC XD 500", LocationID = 13, LocationName = "AH2-Tổ HT-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 25, MachineName = "MÁY HÀN ĐIỆN XỈ DẠNG CỔNG XZHB-15", LocationID = 13, LocationName = "AH2-Tổ HT-LBC" });
                Data_MachineLocationSetup.Add(new Common.Data_MachineLocationSetup() { MachineID = 26, MachineName = "MÁY HÀN HỒ QUANG CHÌM DANG CỔNG XMHB 15", LocationID = 13, LocationName = "AH2-Tổ HT-LBC" });

                #endregion




                #region Build table Data_ErrorHistory --> Fake
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 1, ErrorDate = new DateTime(2024, 2, 9), ErrorID = 10, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 2, ErrorDate = new DateTime(2022, 10, 17), ErrorID = 17, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 3, ErrorDate = new DateTime(2020, 8, 19), ErrorID = 10, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 4, ErrorDate = new DateTime(2023, 11, 20), ErrorID = 1, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 5, ErrorDate = new DateTime(2021, 6, 12), ErrorID = 3, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 6, ErrorDate = new DateTime(2023, 7, 3), ErrorID = 4, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 7, ErrorDate = new DateTime(2020, 10, 11), ErrorID = 19, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 8, ErrorDate = new DateTime(2023, 1, 27), ErrorID = 19, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 9, ErrorDate = new DateTime(2023, 11, 17), ErrorID = 9, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 10, ErrorDate = new DateTime(2024, 2, 10), ErrorID = 6, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 11, ErrorDate = new DateTime(2023, 4, 9), ErrorID = 18, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 12, ErrorDate = new DateTime(2020, 12, 29), ErrorID = 12, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 13, ErrorDate = new DateTime(2021, 12, 4), ErrorID = 15, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 14, ErrorDate = new DateTime(2020, 8, 21), ErrorID = 8, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 15, ErrorDate = new DateTime(2023, 2, 5), ErrorID = 17, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 16, ErrorDate = new DateTime(2021, 12, 24), ErrorID = 12, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 17, ErrorDate = new DateTime(2021, 11, 11), ErrorID = 9, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 18, ErrorDate = new DateTime(2021, 11, 3), ErrorID = 15, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 19, ErrorDate = new DateTime(2020, 7, 29), ErrorID = 5, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 20, ErrorDate = new DateTime(2020, 6, 11), ErrorID = 20, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 21, ErrorDate = new DateTime(2020, 5, 13), ErrorID = 16, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 22, ErrorDate = new DateTime(2022, 10, 7), ErrorID = 19, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 23, ErrorDate = new DateTime(2021, 6, 2), ErrorID = 14, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 24, ErrorDate = new DateTime(2020, 10, 9), ErrorID = 7, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 25, ErrorDate = new DateTime(2024, 4, 15), ErrorID = 12, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 26, ErrorDate = new DateTime(2024, 3, 30), ErrorID = 18, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 27, ErrorDate = new DateTime(2021, 9, 7), ErrorID = 12, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 28, ErrorDate = new DateTime(2020, 11, 29), ErrorID = 6, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 29, ErrorDate = new DateTime(2020, 9, 2), ErrorID = 7, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 30, ErrorDate = new DateTime(2023, 2, 28), ErrorID = 2, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 31, ErrorDate = new DateTime(2022, 7, 28), ErrorID = 9, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 32, ErrorDate = new DateTime(2022, 9, 27), ErrorID = 10, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 33, ErrorDate = new DateTime(2023, 11, 14), ErrorID = 8, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 34, ErrorDate = new DateTime(2021, 8, 12), ErrorID = 9, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 35, ErrorDate = new DateTime(2020, 4, 9), ErrorID = 15, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 36, ErrorDate = new DateTime(2021, 6, 7), ErrorID = 15, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 37, ErrorDate = new DateTime(2023, 10, 6), ErrorID = 1, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 38, ErrorDate = new DateTime(2024, 2, 17), ErrorID = 14, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 39, ErrorDate = new DateTime(2023, 4, 12), ErrorID = 4, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 40, ErrorDate = new DateTime(2023, 4, 12), ErrorID = 20, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 41, ErrorDate = new DateTime(2021, 1, 23), ErrorID = 20, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 42, ErrorDate = new DateTime(2023, 4, 29), ErrorID = 16, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 43, ErrorDate = new DateTime(2020, 9, 29), ErrorID = 17, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 44, ErrorDate = new DateTime(2020, 12, 15), ErrorID = 3, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 45, ErrorDate = new DateTime(2021, 2, 18), ErrorID = 16, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 46, ErrorDate = new DateTime(2020, 7, 8), ErrorID = 7, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 47, ErrorDate = new DateTime(2020, 12, 4), ErrorID = 3, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 48, ErrorDate = new DateTime(2021, 4, 4), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 49, ErrorDate = new DateTime(2021, 6, 9), ErrorID = 14, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 50, ErrorDate = new DateTime(2023, 9, 13), ErrorID = 13, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 51, ErrorDate = new DateTime(2020, 12, 9), ErrorID = 4, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 52, ErrorDate = new DateTime(2020, 10, 7), ErrorID = 11, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 53, ErrorDate = new DateTime(2022, 10, 7), ErrorID = 1, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 54, ErrorDate = new DateTime(2023, 7, 14), ErrorID = 17, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 55, ErrorDate = new DateTime(2022, 5, 31), ErrorID = 8, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 56, ErrorDate = new DateTime(2020, 8, 7), ErrorID = 5, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 57, ErrorDate = new DateTime(2020, 8, 11), ErrorID = 18, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 58, ErrorDate = new DateTime(2021, 2, 26), ErrorID = 8, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 59, ErrorDate = new DateTime(2020, 7, 31), ErrorID = 6, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 60, ErrorDate = new DateTime(2023, 2, 22), ErrorID = 10, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 61, ErrorDate = new DateTime(2020, 9, 10), ErrorID = 4, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 62, ErrorDate = new DateTime(2021, 12, 22), ErrorID = 9, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 63, ErrorDate = new DateTime(2023, 2, 21), ErrorID = 1, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 64, ErrorDate = new DateTime(2022, 7, 4), ErrorID = 15, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 65, ErrorDate = new DateTime(2024, 1, 31), ErrorID = 8, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 66, ErrorDate = new DateTime(2020, 11, 24), ErrorID = 18, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 67, ErrorDate = new DateTime(2021, 9, 2), ErrorID = 5, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 68, ErrorDate = new DateTime(2020, 11, 4), ErrorID = 5, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 69, ErrorDate = new DateTime(2020, 10, 4), ErrorID = 9, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 70, ErrorDate = new DateTime(2022, 3, 19), ErrorID = 8, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 71, ErrorDate = new DateTime(2020, 8, 5), ErrorID = 11, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 72, ErrorDate = new DateTime(2023, 1, 6), ErrorID = 3, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 73, ErrorDate = new DateTime(2020, 2, 2), ErrorID = 10, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 74, ErrorDate = new DateTime(2021, 11, 9), ErrorID = 12, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 75, ErrorDate = new DateTime(2022, 10, 9), ErrorID = 1, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 76, ErrorDate = new DateTime(2020, 9, 28), ErrorID = 9, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 77, ErrorDate = new DateTime(2024, 4, 17), ErrorID = 7, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 78, ErrorDate = new DateTime(2022, 9, 29), ErrorID = 18, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 79, ErrorDate = new DateTime(2023, 10, 17), ErrorID = 18, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 80, ErrorDate = new DateTime(2022, 10, 31), ErrorID = 5, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 81, ErrorDate = new DateTime(2020, 1, 26), ErrorID = 8, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 82, ErrorDate = new DateTime(2020, 3, 6), ErrorID = 7, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 83, ErrorDate = new DateTime(2023, 5, 8), ErrorID = 7, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 84, ErrorDate = new DateTime(2020, 3, 1), ErrorID = 12, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 85, ErrorDate = new DateTime(2020, 8, 7), ErrorID = 8, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 86, ErrorDate = new DateTime(2023, 6, 9), ErrorID = 16, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 87, ErrorDate = new DateTime(2020, 12, 4), ErrorID = 20, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 88, ErrorDate = new DateTime(2022, 10, 19), ErrorID = 13, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 89, ErrorDate = new DateTime(2021, 12, 8), ErrorID = 10, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 90, ErrorDate = new DateTime(2023, 6, 20), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 91, ErrorDate = new DateTime(2020, 7, 5), ErrorID = 1, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 92, ErrorDate = new DateTime(2020, 7, 23), ErrorID = 16, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 93, ErrorDate = new DateTime(2021, 11, 7), ErrorID = 7, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 94, ErrorDate = new DateTime(2023, 1, 1), ErrorID = 3, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 95, ErrorDate = new DateTime(2020, 9, 6), ErrorID = 12, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 96, ErrorDate = new DateTime(2022, 11, 26), ErrorID = 10, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 97, ErrorDate = new DateTime(2021, 8, 5), ErrorID = 6, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 98, ErrorDate = new DateTime(2023, 5, 19), ErrorID = 12, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 99, ErrorDate = new DateTime(2020, 11, 9), ErrorID = 3, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 100, ErrorDate = new DateTime(2020, 11, 17), ErrorID = 19, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 101, ErrorDate = new DateTime(2020, 12, 28), ErrorID = 13, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 102, ErrorDate = new DateTime(2020, 1, 29), ErrorID = 11, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 103, ErrorDate = new DateTime(2023, 2, 23), ErrorID = 4, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 104, ErrorDate = new DateTime(2021, 12, 29), ErrorID = 6, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 105, ErrorDate = new DateTime(2021, 3, 23), ErrorID = 6, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 106, ErrorDate = new DateTime(2022, 11, 8), ErrorID = 12, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 107, ErrorDate = new DateTime(2021, 8, 5), ErrorID = 3, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 108, ErrorDate = new DateTime(2021, 1, 27), ErrorID = 11, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 109, ErrorDate = new DateTime(2023, 9, 14), ErrorID = 5, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 110, ErrorDate = new DateTime(2021, 6, 23), ErrorID = 9, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 111, ErrorDate = new DateTime(2020, 7, 30), ErrorID = 15, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 112, ErrorDate = new DateTime(2020, 12, 4), ErrorID = 11, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 113, ErrorDate = new DateTime(2023, 1, 22), ErrorID = 19, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 114, ErrorDate = new DateTime(2024, 4, 14), ErrorID = 15, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 115, ErrorDate = new DateTime(2020, 6, 15), ErrorID = 2, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 116, ErrorDate = new DateTime(2023, 8, 22), ErrorID = 18, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 117, ErrorDate = new DateTime(2024, 3, 16), ErrorID = 7, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 118, ErrorDate = new DateTime(2022, 12, 24), ErrorID = 8, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 119, ErrorDate = new DateTime(2020, 10, 15), ErrorID = 14, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 120, ErrorDate = new DateTime(2024, 3, 5), ErrorID = 5, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 121, ErrorDate = new DateTime(2020, 1, 29), ErrorID = 2, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 122, ErrorDate = new DateTime(2020, 9, 10), ErrorID = 8, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 123, ErrorDate = new DateTime(2023, 11, 8), ErrorID = 17, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 124, ErrorDate = new DateTime(2022, 5, 21), ErrorID = 7, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 125, ErrorDate = new DateTime(2021, 8, 11), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 126, ErrorDate = new DateTime(2020, 7, 13), ErrorID = 4, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 127, ErrorDate = new DateTime(2021, 10, 27), ErrorID = 14, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 128, ErrorDate = new DateTime(2023, 1, 14), ErrorID = 15, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 129, ErrorDate = new DateTime(2022, 4, 11), ErrorID = 12, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 130, ErrorDate = new DateTime(2024, 3, 30), ErrorID = 4, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 131, ErrorDate = new DateTime(2023, 9, 27), ErrorID = 17, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 132, ErrorDate = new DateTime(2020, 8, 23), ErrorID = 18, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 133, ErrorDate = new DateTime(2022, 8, 10), ErrorID = 10, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 134, ErrorDate = new DateTime(2023, 10, 1), ErrorID = 4, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 135, ErrorDate = new DateTime(2024, 1, 27), ErrorID = 19, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 136, ErrorDate = new DateTime(2022, 10, 12), ErrorID = 18, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 137, ErrorDate = new DateTime(2023, 8, 12), ErrorID = 5, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 138, ErrorDate = new DateTime(2020, 1, 16), ErrorID = 2, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 139, ErrorDate = new DateTime(2023, 5, 12), ErrorID = 18, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 140, ErrorDate = new DateTime(2022, 6, 14), ErrorID = 18, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 141, ErrorDate = new DateTime(2020, 11, 7), ErrorID = 8, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 142, ErrorDate = new DateTime(2023, 3, 6), ErrorID = 16, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 143, ErrorDate = new DateTime(2023, 10, 2), ErrorID = 5, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 144, ErrorDate = new DateTime(2020, 12, 6), ErrorID = 2, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 145, ErrorDate = new DateTime(2024, 3, 22), ErrorID = 1, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 146, ErrorDate = new DateTime(2020, 9, 18), ErrorID = 10, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 147, ErrorDate = new DateTime(2023, 10, 1), ErrorID = 18, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 148, ErrorDate = new DateTime(2023, 10, 17), ErrorID = 12, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 149, ErrorDate = new DateTime(2022, 7, 22), ErrorID = 17, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 150, ErrorDate = new DateTime(2020, 1, 12), ErrorID = 13, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 151, ErrorDate = new DateTime(2023, 11, 4), ErrorID = 7, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 152, ErrorDate = new DateTime(2022, 11, 14), ErrorID = 15, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 153, ErrorDate = new DateTime(2023, 11, 15), ErrorID = 10, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 154, ErrorDate = new DateTime(2020, 8, 13), ErrorID = 7, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 155, ErrorDate = new DateTime(2022, 11, 21), ErrorID = 17, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 156, ErrorDate = new DateTime(2023, 5, 25), ErrorID = 12, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 157, ErrorDate = new DateTime(2023, 12, 11), ErrorID = 7, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 158, ErrorDate = new DateTime(2024, 3, 17), ErrorID = 14, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 159, ErrorDate = new DateTime(2021, 9, 14), ErrorID = 7, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 160, ErrorDate = new DateTime(2021, 6, 15), ErrorID = 4, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 161, ErrorDate = new DateTime(2020, 11, 25), ErrorID = 10, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 162, ErrorDate = new DateTime(2023, 1, 23), ErrorID = 11, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 163, ErrorDate = new DateTime(2024, 2, 13), ErrorID = 2, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 164, ErrorDate = new DateTime(2021, 7, 11), ErrorID = 3, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 165, ErrorDate = new DateTime(2021, 1, 14), ErrorID = 19, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 166, ErrorDate = new DateTime(2022, 12, 24), ErrorID = 20, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 167, ErrorDate = new DateTime(2020, 4, 26), ErrorID = 7, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 168, ErrorDate = new DateTime(2020, 6, 1), ErrorID = 6, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 169, ErrorDate = new DateTime(2021, 9, 11), ErrorID = 18, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 170, ErrorDate = new DateTime(2024, 1, 22), ErrorID = 19, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 171, ErrorDate = new DateTime(2021, 1, 5), ErrorID = 18, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 172, ErrorDate = new DateTime(2024, 2, 13), ErrorID = 6, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 173, ErrorDate = new DateTime(2020, 4, 8), ErrorID = 15, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 174, ErrorDate = new DateTime(2023, 9, 5), ErrorID = 1, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 175, ErrorDate = new DateTime(2020, 2, 18), ErrorID = 13, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 176, ErrorDate = new DateTime(2021, 9, 1), ErrorID = 2, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 177, ErrorDate = new DateTime(2023, 3, 21), ErrorID = 16, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 178, ErrorDate = new DateTime(2023, 11, 30), ErrorID = 5, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 179, ErrorDate = new DateTime(2022, 8, 5), ErrorID = 13, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 180, ErrorDate = new DateTime(2022, 11, 18), ErrorID = 19, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 181, ErrorDate = new DateTime(2024, 1, 24), ErrorID = 15, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 182, ErrorDate = new DateTime(2022, 12, 30), ErrorID = 6, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 183, ErrorDate = new DateTime(2023, 4, 26), ErrorID = 2, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 184, ErrorDate = new DateTime(2023, 9, 11), ErrorID = 8, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 185, ErrorDate = new DateTime(2023, 8, 6), ErrorID = 10, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 186, ErrorDate = new DateTime(2021, 11, 11), ErrorID = 20, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 187, ErrorDate = new DateTime(2023, 3, 3), ErrorID = 11, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 188, ErrorDate = new DateTime(2022, 12, 22), ErrorID = 16, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 189, ErrorDate = new DateTime(2022, 11, 22), ErrorID = 14, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 190, ErrorDate = new DateTime(2021, 6, 9), ErrorID = 10, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 191, ErrorDate = new DateTime(2022, 8, 12), ErrorID = 5, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 192, ErrorDate = new DateTime(2022, 11, 10), ErrorID = 17, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 193, ErrorDate = new DateTime(2021, 3, 8), ErrorID = 20, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 194, ErrorDate = new DateTime(2023, 10, 14), ErrorID = 15, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 195, ErrorDate = new DateTime(2021, 12, 1), ErrorID = 7, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 196, ErrorDate = new DateTime(2021, 7, 27), ErrorID = 17, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 197, ErrorDate = new DateTime(2022, 2, 9), ErrorID = 7, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 198, ErrorDate = new DateTime(2020, 2, 26), ErrorID = 13, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 199, ErrorDate = new DateTime(2021, 9, 24), ErrorID = 13, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 200, ErrorDate = new DateTime(2023, 7, 2), ErrorID = 3, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 201, ErrorDate = new DateTime(2020, 2, 5), ErrorID = 20, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 202, ErrorDate = new DateTime(2020, 5, 10), ErrorID = 1, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 203, ErrorDate = new DateTime(2020, 5, 10), ErrorID = 13, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 204, ErrorDate = new DateTime(2024, 2, 14), ErrorID = 1, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 205, ErrorDate = new DateTime(2020, 2, 8), ErrorID = 19, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 206, ErrorDate = new DateTime(2021, 1, 14), ErrorID = 13, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 207, ErrorDate = new DateTime(2022, 8, 13), ErrorID = 17, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 208, ErrorDate = new DateTime(2020, 6, 16), ErrorID = 10, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 209, ErrorDate = new DateTime(2022, 3, 24), ErrorID = 1, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 210, ErrorDate = new DateTime(2024, 5, 4), ErrorID = 8, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 211, ErrorDate = new DateTime(2022, 7, 5), ErrorID = 16, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 212, ErrorDate = new DateTime(2021, 3, 13), ErrorID = 10, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 213, ErrorDate = new DateTime(2020, 4, 29), ErrorID = 10, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 214, ErrorDate = new DateTime(2021, 8, 11), ErrorID = 5, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 215, ErrorDate = new DateTime(2020, 1, 3), ErrorID = 5, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 216, ErrorDate = new DateTime(2022, 11, 12), ErrorID = 9, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 217, ErrorDate = new DateTime(2021, 7, 31), ErrorID = 6, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 218, ErrorDate = new DateTime(2022, 4, 18), ErrorID = 17, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 219, ErrorDate = new DateTime(2020, 3, 7), ErrorID = 17, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 220, ErrorDate = new DateTime(2023, 7, 17), ErrorID = 13, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 221, ErrorDate = new DateTime(2021, 11, 24), ErrorID = 4, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 222, ErrorDate = new DateTime(2023, 5, 10), ErrorID = 14, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 223, ErrorDate = new DateTime(2023, 4, 6), ErrorID = 10, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 224, ErrorDate = new DateTime(2024, 3, 4), ErrorID = 3, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 225, ErrorDate = new DateTime(2022, 2, 23), ErrorID = 15, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 226, ErrorDate = new DateTime(2022, 10, 12), ErrorID = 12, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 227, ErrorDate = new DateTime(2020, 9, 27), ErrorID = 2, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 228, ErrorDate = new DateTime(2023, 12, 8), ErrorID = 3, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 229, ErrorDate = new DateTime(2021, 7, 4), ErrorID = 19, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 230, ErrorDate = new DateTime(2021, 3, 3), ErrorID = 3, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 231, ErrorDate = new DateTime(2022, 3, 8), ErrorID = 12, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 232, ErrorDate = new DateTime(2024, 4, 3), ErrorID = 8, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 233, ErrorDate = new DateTime(2023, 7, 11), ErrorID = 6, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 234, ErrorDate = new DateTime(2023, 10, 4), ErrorID = 1, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 235, ErrorDate = new DateTime(2023, 10, 23), ErrorID = 2, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 236, ErrorDate = new DateTime(2020, 6, 11), ErrorID = 6, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 237, ErrorDate = new DateTime(2021, 3, 7), ErrorID = 14, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 238, ErrorDate = new DateTime(2020, 11, 7), ErrorID = 14, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 239, ErrorDate = new DateTime(2023, 2, 9), ErrorID = 13, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 240, ErrorDate = new DateTime(2023, 8, 26), ErrorID = 8, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 241, ErrorDate = new DateTime(2023, 10, 6), ErrorID = 20, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 242, ErrorDate = new DateTime(2022, 8, 22), ErrorID = 5, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 243, ErrorDate = new DateTime(2023, 10, 8), ErrorID = 13, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 244, ErrorDate = new DateTime(2023, 11, 25), ErrorID = 16, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 245, ErrorDate = new DateTime(2020, 5, 16), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 246, ErrorDate = new DateTime(2023, 12, 30), ErrorID = 18, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 247, ErrorDate = new DateTime(2022, 2, 20), ErrorID = 11, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 248, ErrorDate = new DateTime(2024, 3, 12), ErrorID = 3, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 249, ErrorDate = new DateTime(2020, 7, 2), ErrorID = 11, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 250, ErrorDate = new DateTime(2024, 2, 29), ErrorID = 8, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 251, ErrorDate = new DateTime(2020, 7, 20), ErrorID = 17, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 252, ErrorDate = new DateTime(2021, 5, 17), ErrorID = 9, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 253, ErrorDate = new DateTime(2023, 11, 14), ErrorID = 2, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 254, ErrorDate = new DateTime(2020, 9, 23), ErrorID = 17, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 255, ErrorDate = new DateTime(2022, 3, 22), ErrorID = 11, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 256, ErrorDate = new DateTime(2023, 6, 8), ErrorID = 17, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 257, ErrorDate = new DateTime(2022, 12, 23), ErrorID = 4, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 258, ErrorDate = new DateTime(2024, 1, 7), ErrorID = 5, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 259, ErrorDate = new DateTime(2022, 3, 17), ErrorID = 2, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 260, ErrorDate = new DateTime(2020, 5, 26), ErrorID = 10, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 261, ErrorDate = new DateTime(2020, 1, 25), ErrorID = 6, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 262, ErrorDate = new DateTime(2023, 2, 2), ErrorID = 1, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 263, ErrorDate = new DateTime(2023, 11, 19), ErrorID = 18, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 264, ErrorDate = new DateTime(2021, 10, 16), ErrorID = 17, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 265, ErrorDate = new DateTime(2023, 6, 9), ErrorID = 14, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 266, ErrorDate = new DateTime(2021, 2, 26), ErrorID = 3, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 267, ErrorDate = new DateTime(2023, 11, 21), ErrorID = 3, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 268, ErrorDate = new DateTime(2021, 12, 3), ErrorID = 15, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 269, ErrorDate = new DateTime(2024, 2, 7), ErrorID = 3, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 270, ErrorDate = new DateTime(2020, 11, 17), ErrorID = 12, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 271, ErrorDate = new DateTime(2020, 5, 11), ErrorID = 7, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 272, ErrorDate = new DateTime(2023, 6, 15), ErrorID = 19, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 273, ErrorDate = new DateTime(2020, 10, 28), ErrorID = 1, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 274, ErrorDate = new DateTime(2021, 6, 30), ErrorID = 3, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 275, ErrorDate = new DateTime(2022, 10, 6), ErrorID = 9, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 276, ErrorDate = new DateTime(2022, 11, 24), ErrorID = 7, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 277, ErrorDate = new DateTime(2020, 12, 5), ErrorID = 15, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 278, ErrorDate = new DateTime(2020, 12, 5), ErrorID = 9, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 279, ErrorDate = new DateTime(2020, 4, 21), ErrorID = 5, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 280, ErrorDate = new DateTime(2021, 8, 29), ErrorID = 14, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 281, ErrorDate = new DateTime(2021, 6, 1), ErrorID = 7, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 282, ErrorDate = new DateTime(2022, 12, 18), ErrorID = 14, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 283, ErrorDate = new DateTime(2020, 11, 21), ErrorID = 5, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 284, ErrorDate = new DateTime(2020, 3, 29), ErrorID = 4, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 285, ErrorDate = new DateTime(2022, 4, 21), ErrorID = 13, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 286, ErrorDate = new DateTime(2023, 6, 7), ErrorID = 17, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 287, ErrorDate = new DateTime(2022, 5, 27), ErrorID = 6, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 288, ErrorDate = new DateTime(2021, 1, 16), ErrorID = 14, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 289, ErrorDate = new DateTime(2020, 4, 5), ErrorID = 5, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 290, ErrorDate = new DateTime(2020, 8, 10), ErrorID = 17, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 291, ErrorDate = new DateTime(2021, 5, 9), ErrorID = 20, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 292, ErrorDate = new DateTime(2023, 9, 17), ErrorID = 7, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 293, ErrorDate = new DateTime(2022, 10, 10), ErrorID = 7, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 294, ErrorDate = new DateTime(2020, 3, 22), ErrorID = 18, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 295, ErrorDate = new DateTime(2023, 9, 8), ErrorID = 6, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 296, ErrorDate = new DateTime(2020, 5, 21), ErrorID = 16, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 297, ErrorDate = new DateTime(2020, 7, 9), ErrorID = 10, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 298, ErrorDate = new DateTime(2023, 11, 27), ErrorID = 9, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 299, ErrorDate = new DateTime(2023, 11, 19), ErrorID = 12, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 300, ErrorDate = new DateTime(2021, 3, 1), ErrorID = 10, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 301, ErrorDate = new DateTime(2023, 2, 1), ErrorID = 13, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 302, ErrorDate = new DateTime(2022, 11, 4), ErrorID = 17, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 303, ErrorDate = new DateTime(2022, 11, 4), ErrorID = 12, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 304, ErrorDate = new DateTime(2023, 8, 20), ErrorID = 6, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 305, ErrorDate = new DateTime(2022, 12, 5), ErrorID = 20, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 306, ErrorDate = new DateTime(2022, 11, 25), ErrorID = 20, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 307, ErrorDate = new DateTime(2023, 2, 25), ErrorID = 10, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 308, ErrorDate = new DateTime(2023, 3, 23), ErrorID = 19, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 309, ErrorDate = new DateTime(2021, 2, 25), ErrorID = 2, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 310, ErrorDate = new DateTime(2020, 9, 25), ErrorID = 16, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 311, ErrorDate = new DateTime(2024, 4, 2), ErrorID = 18, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 312, ErrorDate = new DateTime(2022, 2, 5), ErrorID = 17, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 313, ErrorDate = new DateTime(2022, 12, 3), ErrorID = 2, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 314, ErrorDate = new DateTime(2023, 6, 9), ErrorID = 3, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 315, ErrorDate = new DateTime(2022, 6, 24), ErrorID = 15, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 316, ErrorDate = new DateTime(2020, 1, 20), ErrorID = 7, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 317, ErrorDate = new DateTime(2023, 11, 27), ErrorID = 8, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 318, ErrorDate = new DateTime(2022, 11, 2), ErrorID = 17, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 319, ErrorDate = new DateTime(2023, 8, 16), ErrorID = 10, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 320, ErrorDate = new DateTime(2022, 2, 27), ErrorID = 20, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 321, ErrorDate = new DateTime(2023, 9, 3), ErrorID = 20, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 322, ErrorDate = new DateTime(2020, 11, 4), ErrorID = 19, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 323, ErrorDate = new DateTime(2020, 6, 30), ErrorID = 2, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 324, ErrorDate = new DateTime(2022, 11, 9), ErrorID = 17, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 325, ErrorDate = new DateTime(2021, 6, 25), ErrorID = 10, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 326, ErrorDate = new DateTime(2024, 5, 4), ErrorID = 2, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 327, ErrorDate = new DateTime(2022, 3, 21), ErrorID = 15, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 328, ErrorDate = new DateTime(2020, 3, 12), ErrorID = 4, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 329, ErrorDate = new DateTime(2022, 3, 11), ErrorID = 16, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 330, ErrorDate = new DateTime(2021, 5, 19), ErrorID = 4, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 331, ErrorDate = new DateTime(2020, 6, 27), ErrorID = 5, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 332, ErrorDate = new DateTime(2020, 8, 25), ErrorID = 3, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 333, ErrorDate = new DateTime(2022, 8, 16), ErrorID = 15, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 334, ErrorDate = new DateTime(2023, 8, 9), ErrorID = 4, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 335, ErrorDate = new DateTime(2022, 4, 23), ErrorID = 5, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 336, ErrorDate = new DateTime(2022, 11, 27), ErrorID = 2, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 337, ErrorDate = new DateTime(2022, 5, 23), ErrorID = 8, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 338, ErrorDate = new DateTime(2022, 3, 1), ErrorID = 1, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 339, ErrorDate = new DateTime(2022, 1, 19), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 340, ErrorDate = new DateTime(2022, 9, 27), ErrorID = 20, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 341, ErrorDate = new DateTime(2021, 2, 1), ErrorID = 10, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 342, ErrorDate = new DateTime(2020, 1, 27), ErrorID = 1, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 343, ErrorDate = new DateTime(2022, 8, 9), ErrorID = 20, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 344, ErrorDate = new DateTime(2021, 4, 3), ErrorID = 5, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 345, ErrorDate = new DateTime(2021, 5, 15), ErrorID = 10, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 346, ErrorDate = new DateTime(2021, 12, 2), ErrorID = 12, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 347, ErrorDate = new DateTime(2020, 12, 16), ErrorID = 17, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 348, ErrorDate = new DateTime(2023, 12, 22), ErrorID = 7, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 349, ErrorDate = new DateTime(2020, 3, 7), ErrorID = 11, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 350, ErrorDate = new DateTime(2020, 6, 10), ErrorID = 12, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 351, ErrorDate = new DateTime(2020, 8, 6), ErrorID = 12, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 352, ErrorDate = new DateTime(2022, 9, 30), ErrorID = 10, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 353, ErrorDate = new DateTime(2020, 8, 23), ErrorID = 11, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 354, ErrorDate = new DateTime(2023, 3, 18), ErrorID = 15, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 355, ErrorDate = new DateTime(2022, 6, 22), ErrorID = 9, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 356, ErrorDate = new DateTime(2021, 12, 6), ErrorID = 2, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 357, ErrorDate = new DateTime(2022, 2, 22), ErrorID = 2, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 358, ErrorDate = new DateTime(2020, 10, 29), ErrorID = 17, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 359, ErrorDate = new DateTime(2021, 1, 14), ErrorID = 1, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 360, ErrorDate = new DateTime(2022, 1, 14), ErrorID = 12, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 361, ErrorDate = new DateTime(2023, 11, 1), ErrorID = 14, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 362, ErrorDate = new DateTime(2022, 7, 3), ErrorID = 15, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 363, ErrorDate = new DateTime(2022, 4, 14), ErrorID = 5, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 364, ErrorDate = new DateTime(2020, 11, 4), ErrorID = 5, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 365, ErrorDate = new DateTime(2020, 6, 17), ErrorID = 6, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 366, ErrorDate = new DateTime(2020, 6, 8), ErrorID = 18, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 367, ErrorDate = new DateTime(2020, 7, 15), ErrorID = 17, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 368, ErrorDate = new DateTime(2021, 1, 23), ErrorID = 16, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 369, ErrorDate = new DateTime(2022, 7, 10), ErrorID = 2, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 370, ErrorDate = new DateTime(2020, 5, 27), ErrorID = 17, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 371, ErrorDate = new DateTime(2023, 5, 4), ErrorID = 5, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 372, ErrorDate = new DateTime(2023, 4, 24), ErrorID = 5, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 373, ErrorDate = new DateTime(2021, 3, 22), ErrorID = 5, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 374, ErrorDate = new DateTime(2023, 8, 13), ErrorID = 4, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 375, ErrorDate = new DateTime(2021, 10, 25), ErrorID = 8, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 376, ErrorDate = new DateTime(2024, 4, 30), ErrorID = 7, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 377, ErrorDate = new DateTime(2020, 11, 11), ErrorID = 5, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 378, ErrorDate = new DateTime(2020, 3, 2), ErrorID = 15, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 379, ErrorDate = new DateTime(2023, 3, 15), ErrorID = 16, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 380, ErrorDate = new DateTime(2020, 7, 25), ErrorID = 14, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 381, ErrorDate = new DateTime(2020, 11, 28), ErrorID = 5, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 382, ErrorDate = new DateTime(2022, 10, 30), ErrorID = 10, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 383, ErrorDate = new DateTime(2023, 9, 16), ErrorID = 6, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 384, ErrorDate = new DateTime(2022, 10, 27), ErrorID = 11, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 385, ErrorDate = new DateTime(2020, 4, 20), ErrorID = 7, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 386, ErrorDate = new DateTime(2022, 11, 21), ErrorID = 13, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 387, ErrorDate = new DateTime(2020, 8, 12), ErrorID = 20, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 388, ErrorDate = new DateTime(2023, 8, 23), ErrorID = 3, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 389, ErrorDate = new DateTime(2021, 1, 9), ErrorID = 19, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 390, ErrorDate = new DateTime(2021, 6, 17), ErrorID = 11, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 391, ErrorDate = new DateTime(2020, 11, 22), ErrorID = 5, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 392, ErrorDate = new DateTime(2020, 4, 8), ErrorID = 20, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 393, ErrorDate = new DateTime(2021, 7, 1), ErrorID = 17, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 394, ErrorDate = new DateTime(2020, 2, 28), ErrorID = 3, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 395, ErrorDate = new DateTime(2021, 7, 14), ErrorID = 16, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 396, ErrorDate = new DateTime(2022, 6, 10), ErrorID = 18, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 397, ErrorDate = new DateTime(2022, 1, 28), ErrorID = 18, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 398, ErrorDate = new DateTime(2021, 9, 25), ErrorID = 9, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 399, ErrorDate = new DateTime(2022, 6, 12), ErrorID = 20, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 400, ErrorDate = new DateTime(2021, 11, 26), ErrorID = 12, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 401, ErrorDate = new DateTime(2023, 6, 14), ErrorID = 1, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 402, ErrorDate = new DateTime(2020, 9, 18), ErrorID = 8, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 403, ErrorDate = new DateTime(2021, 9, 4), ErrorID = 9, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 404, ErrorDate = new DateTime(2021, 5, 15), ErrorID = 13, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 405, ErrorDate = new DateTime(2023, 2, 8), ErrorID = 2, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 406, ErrorDate = new DateTime(2021, 5, 15), ErrorID = 17, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 407, ErrorDate = new DateTime(2021, 2, 10), ErrorID = 8, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 408, ErrorDate = new DateTime(2024, 3, 6), ErrorID = 15, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 409, ErrorDate = new DateTime(2022, 8, 16), ErrorID = 10, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 410, ErrorDate = new DateTime(2022, 11, 23), ErrorID = 11, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 411, ErrorDate = new DateTime(2021, 10, 19), ErrorID = 19, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 412, ErrorDate = new DateTime(2023, 6, 20), ErrorID = 6, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 413, ErrorDate = new DateTime(2023, 7, 23), ErrorID = 3, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 414, ErrorDate = new DateTime(2020, 5, 7), ErrorID = 19, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 415, ErrorDate = new DateTime(2020, 2, 4), ErrorID = 3, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 416, ErrorDate = new DateTime(2023, 5, 11), ErrorID = 13, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 417, ErrorDate = new DateTime(2020, 4, 15), ErrorID = 16, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 418, ErrorDate = new DateTime(2023, 9, 13), ErrorID = 6, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 419, ErrorDate = new DateTime(2020, 3, 17), ErrorID = 13, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 420, ErrorDate = new DateTime(2022, 7, 29), ErrorID = 1, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 421, ErrorDate = new DateTime(2021, 1, 20), ErrorID = 5, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 422, ErrorDate = new DateTime(2022, 9, 26), ErrorID = 3, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 423, ErrorDate = new DateTime(2021, 1, 26), ErrorID = 1, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 424, ErrorDate = new DateTime(2022, 10, 14), ErrorID = 7, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 425, ErrorDate = new DateTime(2021, 5, 12), ErrorID = 2, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 426, ErrorDate = new DateTime(2021, 11, 14), ErrorID = 13, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 427, ErrorDate = new DateTime(2023, 7, 11), ErrorID = 1, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 428, ErrorDate = new DateTime(2020, 12, 18), ErrorID = 13, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 429, ErrorDate = new DateTime(2021, 6, 30), ErrorID = 17, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 430, ErrorDate = new DateTime(2024, 1, 23), ErrorID = 5, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 431, ErrorDate = new DateTime(2021, 8, 2), ErrorID = 7, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 432, ErrorDate = new DateTime(2024, 3, 6), ErrorID = 7, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 433, ErrorDate = new DateTime(2022, 2, 3), ErrorID = 12, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 434, ErrorDate = new DateTime(2021, 2, 9), ErrorID = 19, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 435, ErrorDate = new DateTime(2022, 5, 4), ErrorID = 16, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 436, ErrorDate = new DateTime(2021, 4, 8), ErrorID = 15, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 437, ErrorDate = new DateTime(2022, 5, 27), ErrorID = 20, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 438, ErrorDate = new DateTime(2023, 7, 16), ErrorID = 12, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 439, ErrorDate = new DateTime(2023, 3, 16), ErrorID = 9, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 440, ErrorDate = new DateTime(2024, 1, 14), ErrorID = 4, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 441, ErrorDate = new DateTime(2024, 2, 19), ErrorID = 18, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 442, ErrorDate = new DateTime(2023, 5, 22), ErrorID = 19, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 443, ErrorDate = new DateTime(2022, 10, 14), ErrorID = 4, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 444, ErrorDate = new DateTime(2020, 12, 20), ErrorID = 19, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 445, ErrorDate = new DateTime(2022, 11, 14), ErrorID = 4, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 446, ErrorDate = new DateTime(2023, 5, 6), ErrorID = 14, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 447, ErrorDate = new DateTime(2022, 8, 25), ErrorID = 10, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 448, ErrorDate = new DateTime(2024, 4, 30), ErrorID = 20, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 449, ErrorDate = new DateTime(2022, 6, 22), ErrorID = 16, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 450, ErrorDate = new DateTime(2020, 9, 11), ErrorID = 11, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 451, ErrorDate = new DateTime(2021, 12, 22), ErrorID = 8, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 452, ErrorDate = new DateTime(2021, 4, 5), ErrorID = 4, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 453, ErrorDate = new DateTime(2023, 4, 4), ErrorID = 16, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 454, ErrorDate = new DateTime(2021, 9, 21), ErrorID = 4, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 455, ErrorDate = new DateTime(2024, 3, 1), ErrorID = 13, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 456, ErrorDate = new DateTime(2024, 5, 3), ErrorID = 8, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 457, ErrorDate = new DateTime(2024, 3, 18), ErrorID = 19, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 458, ErrorDate = new DateTime(2020, 9, 25), ErrorID = 19, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 459, ErrorDate = new DateTime(2020, 7, 6), ErrorID = 1, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 460, ErrorDate = new DateTime(2024, 3, 19), ErrorID = 14, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 461, ErrorDate = new DateTime(2022, 4, 14), ErrorID = 14, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 462, ErrorDate = new DateTime(2020, 9, 11), ErrorID = 14, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 463, ErrorDate = new DateTime(2021, 6, 19), ErrorID = 8, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 464, ErrorDate = new DateTime(2022, 5, 6), ErrorID = 1, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 465, ErrorDate = new DateTime(2021, 11, 10), ErrorID = 16, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 466, ErrorDate = new DateTime(2021, 7, 23), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 467, ErrorDate = new DateTime(2023, 1, 18), ErrorID = 1, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 468, ErrorDate = new DateTime(2023, 8, 30), ErrorID = 20, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 469, ErrorDate = new DateTime(2020, 5, 9), ErrorID = 15, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 470, ErrorDate = new DateTime(2022, 8, 24), ErrorID = 5, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 471, ErrorDate = new DateTime(2020, 2, 1), ErrorID = 17, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 472, ErrorDate = new DateTime(2022, 3, 28), ErrorID = 10, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 473, ErrorDate = new DateTime(2023, 9, 16), ErrorID = 15, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 474, ErrorDate = new DateTime(2020, 8, 4), ErrorID = 6, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 475, ErrorDate = new DateTime(2022, 4, 20), ErrorID = 14, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 476, ErrorDate = new DateTime(2022, 3, 18), ErrorID = 20, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 477, ErrorDate = new DateTime(2021, 7, 22), ErrorID = 17, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 478, ErrorDate = new DateTime(2021, 4, 17), ErrorID = 10, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 479, ErrorDate = new DateTime(2020, 3, 31), ErrorID = 11, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 480, ErrorDate = new DateTime(2023, 10, 22), ErrorID = 9, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 481, ErrorDate = new DateTime(2023, 9, 1), ErrorID = 16, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 482, ErrorDate = new DateTime(2022, 12, 19), ErrorID = 18, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 483, ErrorDate = new DateTime(2023, 12, 21), ErrorID = 20, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 484, ErrorDate = new DateTime(2021, 4, 8), ErrorID = 14, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 485, ErrorDate = new DateTime(2023, 7, 26), ErrorID = 6, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 486, ErrorDate = new DateTime(2024, 5, 5), ErrorID = 10, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 487, ErrorDate = new DateTime(2020, 3, 19), ErrorID = 8, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 488, ErrorDate = new DateTime(2020, 1, 12), ErrorID = 7, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 489, ErrorDate = new DateTime(2024, 1, 15), ErrorID = 8, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 490, ErrorDate = new DateTime(2023, 11, 28), ErrorID = 18, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 491, ErrorDate = new DateTime(2023, 4, 3), ErrorID = 8, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 492, ErrorDate = new DateTime(2023, 1, 3), ErrorID = 1, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 493, ErrorDate = new DateTime(2020, 7, 14), ErrorID = 19, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 494, ErrorDate = new DateTime(2024, 4, 12), ErrorID = 16, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 495, ErrorDate = new DateTime(2023, 3, 25), ErrorID = 18, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 496, ErrorDate = new DateTime(2021, 5, 22), ErrorID = 5, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 497, ErrorDate = new DateTime(2021, 10, 8), ErrorID = 18, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 498, ErrorDate = new DateTime(2023, 6, 10), ErrorID = 8, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 499, ErrorDate = new DateTime(2022, 12, 14), ErrorID = 20, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 500, ErrorDate = new DateTime(2023, 8, 30), ErrorID = 10, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 501, ErrorDate = new DateTime(2023, 5, 7), ErrorID = 18, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 502, ErrorDate = new DateTime(2021, 11, 21), ErrorID = 14, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 503, ErrorDate = new DateTime(2023, 4, 20), ErrorID = 4, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 504, ErrorDate = new DateTime(2024, 1, 25), ErrorID = 3, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 505, ErrorDate = new DateTime(2021, 10, 13), ErrorID = 8, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 506, ErrorDate = new DateTime(2024, 3, 29), ErrorID = 6, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 507, ErrorDate = new DateTime(2023, 6, 14), ErrorID = 1, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 508, ErrorDate = new DateTime(2021, 12, 11), ErrorID = 8, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 509, ErrorDate = new DateTime(2020, 4, 23), ErrorID = 4, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 510, ErrorDate = new DateTime(2021, 3, 11), ErrorID = 6, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 511, ErrorDate = new DateTime(2020, 3, 26), ErrorID = 2, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 512, ErrorDate = new DateTime(2022, 6, 26), ErrorID = 12, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 513, ErrorDate = new DateTime(2020, 6, 19), ErrorID = 3, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 514, ErrorDate = new DateTime(2021, 1, 17), ErrorID = 2, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 515, ErrorDate = new DateTime(2020, 4, 6), ErrorID = 17, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 516, ErrorDate = new DateTime(2024, 2, 2), ErrorID = 14, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 517, ErrorDate = new DateTime(2023, 10, 11), ErrorID = 3, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 518, ErrorDate = new DateTime(2024, 4, 26), ErrorID = 17, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 519, ErrorDate = new DateTime(2024, 1, 21), ErrorID = 10, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 520, ErrorDate = new DateTime(2024, 3, 27), ErrorID = 18, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 521, ErrorDate = new DateTime(2020, 9, 28), ErrorID = 17, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 522, ErrorDate = new DateTime(2021, 5, 20), ErrorID = 10, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 523, ErrorDate = new DateTime(2024, 2, 3), ErrorID = 13, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 524, ErrorDate = new DateTime(2023, 10, 13), ErrorID = 11, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 525, ErrorDate = new DateTime(2023, 9, 8), ErrorID = 19, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 526, ErrorDate = new DateTime(2021, 1, 24), ErrorID = 8, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 527, ErrorDate = new DateTime(2023, 2, 6), ErrorID = 9, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 528, ErrorDate = new DateTime(2022, 5, 18), ErrorID = 17, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 529, ErrorDate = new DateTime(2023, 12, 31), ErrorID = 6, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 530, ErrorDate = new DateTime(2021, 5, 15), ErrorID = 16, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 531, ErrorDate = new DateTime(2024, 1, 2), ErrorID = 6, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 532, ErrorDate = new DateTime(2023, 2, 9), ErrorID = 19, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 533, ErrorDate = new DateTime(2021, 10, 28), ErrorID = 6, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 534, ErrorDate = new DateTime(2021, 2, 24), ErrorID = 10, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 535, ErrorDate = new DateTime(2021, 6, 27), ErrorID = 7, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 536, ErrorDate = new DateTime(2024, 4, 28), ErrorID = 11, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 537, ErrorDate = new DateTime(2023, 5, 6), ErrorID = 20, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 538, ErrorDate = new DateTime(2022, 1, 9), ErrorID = 15, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 539, ErrorDate = new DateTime(2023, 11, 4), ErrorID = 6, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 540, ErrorDate = new DateTime(2022, 11, 7), ErrorID = 4, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 541, ErrorDate = new DateTime(2022, 1, 1), ErrorID = 17, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 542, ErrorDate = new DateTime(2021, 11, 23), ErrorID = 5, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 543, ErrorDate = new DateTime(2022, 7, 15), ErrorID = 14, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 544, ErrorDate = new DateTime(2020, 8, 17), ErrorID = 9, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 545, ErrorDate = new DateTime(2023, 11, 11), ErrorID = 8, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 546, ErrorDate = new DateTime(2020, 7, 26), ErrorID = 2, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 547, ErrorDate = new DateTime(2022, 5, 26), ErrorID = 17, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 548, ErrorDate = new DateTime(2020, 1, 21), ErrorID = 15, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 549, ErrorDate = new DateTime(2021, 11, 10), ErrorID = 3, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 550, ErrorDate = new DateTime(2022, 4, 16), ErrorID = 1, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 551, ErrorDate = new DateTime(2022, 7, 16), ErrorID = 18, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 552, ErrorDate = new DateTime(2021, 2, 11), ErrorID = 6, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 553, ErrorDate = new DateTime(2020, 11, 27), ErrorID = 12, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 554, ErrorDate = new DateTime(2020, 12, 26), ErrorID = 20, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 555, ErrorDate = new DateTime(2021, 12, 15), ErrorID = 5, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 556, ErrorDate = new DateTime(2021, 7, 16), ErrorID = 7, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 557, ErrorDate = new DateTime(2022, 8, 27), ErrorID = 4, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 558, ErrorDate = new DateTime(2021, 10, 17), ErrorID = 6, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 559, ErrorDate = new DateTime(2023, 12, 5), ErrorID = 2, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 560, ErrorDate = new DateTime(2022, 2, 7), ErrorID = 3, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 561, ErrorDate = new DateTime(2020, 10, 15), ErrorID = 15, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 562, ErrorDate = new DateTime(2022, 3, 18), ErrorID = 19, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 563, ErrorDate = new DateTime(2020, 5, 27), ErrorID = 17, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 564, ErrorDate = new DateTime(2022, 3, 18), ErrorID = 18, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 565, ErrorDate = new DateTime(2022, 5, 25), ErrorID = 6, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 566, ErrorDate = new DateTime(2021, 6, 15), ErrorID = 6, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 567, ErrorDate = new DateTime(2021, 7, 14), ErrorID = 4, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 568, ErrorDate = new DateTime(2021, 5, 7), ErrorID = 9, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 569, ErrorDate = new DateTime(2024, 1, 6), ErrorID = 6, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 570, ErrorDate = new DateTime(2021, 8, 14), ErrorID = 6, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 571, ErrorDate = new DateTime(2021, 7, 26), ErrorID = 11, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 572, ErrorDate = new DateTime(2024, 3, 12), ErrorID = 12, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 573, ErrorDate = new DateTime(2023, 11, 15), ErrorID = 8, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 574, ErrorDate = new DateTime(2024, 4, 14), ErrorID = 4, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 575, ErrorDate = new DateTime(2020, 11, 23), ErrorID = 20, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 576, ErrorDate = new DateTime(2020, 6, 4), ErrorID = 16, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 577, ErrorDate = new DateTime(2022, 10, 27), ErrorID = 4, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 578, ErrorDate = new DateTime(2020, 7, 8), ErrorID = 1, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 579, ErrorDate = new DateTime(2021, 2, 20), ErrorID = 1, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 580, ErrorDate = new DateTime(2021, 10, 11), ErrorID = 16, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 581, ErrorDate = new DateTime(2020, 9, 27), ErrorID = 15, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 582, ErrorDate = new DateTime(2024, 4, 24), ErrorID = 3, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 583, ErrorDate = new DateTime(2022, 9, 26), ErrorID = 15, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 584, ErrorDate = new DateTime(2020, 6, 13), ErrorID = 20, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 585, ErrorDate = new DateTime(2022, 4, 13), ErrorID = 4, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 586, ErrorDate = new DateTime(2023, 9, 5), ErrorID = 10, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 587, ErrorDate = new DateTime(2022, 5, 22), ErrorID = 14, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 588, ErrorDate = new DateTime(2021, 8, 4), ErrorID = 7, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 589, ErrorDate = new DateTime(2021, 7, 3), ErrorID = 15, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 590, ErrorDate = new DateTime(2022, 6, 24), ErrorID = 3, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 591, ErrorDate = new DateTime(2021, 10, 12), ErrorID = 12, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 592, ErrorDate = new DateTime(2022, 7, 1), ErrorID = 3, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 593, ErrorDate = new DateTime(2021, 7, 28), ErrorID = 12, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 594, ErrorDate = new DateTime(2021, 9, 12), ErrorID = 8, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 595, ErrorDate = new DateTime(2023, 11, 6), ErrorID = 20, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 596, ErrorDate = new DateTime(2020, 12, 15), ErrorID = 19, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 597, ErrorDate = new DateTime(2020, 4, 2), ErrorID = 17, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 598, ErrorDate = new DateTime(2021, 11, 5), ErrorID = 5, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 599, ErrorDate = new DateTime(2021, 4, 23), ErrorID = 12, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 600, ErrorDate = new DateTime(2023, 6, 14), ErrorID = 6, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 601, ErrorDate = new DateTime(2023, 4, 25), ErrorID = 19, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 602, ErrorDate = new DateTime(2020, 1, 11), ErrorID = 9, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 603, ErrorDate = new DateTime(2022, 4, 15), ErrorID = 17, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 604, ErrorDate = new DateTime(2020, 4, 4), ErrorID = 4, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 605, ErrorDate = new DateTime(2023, 11, 15), ErrorID = 18, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 606, ErrorDate = new DateTime(2020, 10, 24), ErrorID = 11, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 607, ErrorDate = new DateTime(2022, 7, 27), ErrorID = 12, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 608, ErrorDate = new DateTime(2020, 9, 30), ErrorID = 5, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 609, ErrorDate = new DateTime(2022, 10, 14), ErrorID = 5, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 610, ErrorDate = new DateTime(2023, 1, 7), ErrorID = 15, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 611, ErrorDate = new DateTime(2023, 2, 19), ErrorID = 17, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 612, ErrorDate = new DateTime(2020, 7, 2), ErrorID = 6, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 613, ErrorDate = new DateTime(2020, 10, 13), ErrorID = 10, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 614, ErrorDate = new DateTime(2024, 1, 28), ErrorID = 4, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 615, ErrorDate = new DateTime(2023, 1, 21), ErrorID = 10, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 616, ErrorDate = new DateTime(2023, 5, 12), ErrorID = 7, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 617, ErrorDate = new DateTime(2021, 1, 21), ErrorID = 9, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 618, ErrorDate = new DateTime(2021, 8, 13), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 619, ErrorDate = new DateTime(2021, 4, 10), ErrorID = 1, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 620, ErrorDate = new DateTime(2023, 5, 5), ErrorID = 8, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 621, ErrorDate = new DateTime(2020, 6, 11), ErrorID = 16, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 622, ErrorDate = new DateTime(2022, 9, 8), ErrorID = 19, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 623, ErrorDate = new DateTime(2024, 1, 9), ErrorID = 12, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 624, ErrorDate = new DateTime(2023, 10, 10), ErrorID = 5, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 625, ErrorDate = new DateTime(2020, 4, 29), ErrorID = 6, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 626, ErrorDate = new DateTime(2021, 4, 8), ErrorID = 2, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 627, ErrorDate = new DateTime(2020, 5, 28), ErrorID = 12, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 628, ErrorDate = new DateTime(2021, 8, 12), ErrorID = 17, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 629, ErrorDate = new DateTime(2020, 5, 31), ErrorID = 3, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 630, ErrorDate = new DateTime(2021, 9, 1), ErrorID = 8, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 631, ErrorDate = new DateTime(2022, 7, 30), ErrorID = 5, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 632, ErrorDate = new DateTime(2021, 9, 11), ErrorID = 9, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 633, ErrorDate = new DateTime(2021, 8, 17), ErrorID = 17, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 634, ErrorDate = new DateTime(2021, 9, 30), ErrorID = 2, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 635, ErrorDate = new DateTime(2021, 5, 7), ErrorID = 1, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 636, ErrorDate = new DateTime(2021, 7, 21), ErrorID = 13, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 637, ErrorDate = new DateTime(2023, 9, 28), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 638, ErrorDate = new DateTime(2020, 11, 9), ErrorID = 19, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 639, ErrorDate = new DateTime(2021, 5, 8), ErrorID = 16, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 640, ErrorDate = new DateTime(2021, 9, 13), ErrorID = 10, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 641, ErrorDate = new DateTime(2020, 2, 10), ErrorID = 9, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 642, ErrorDate = new DateTime(2022, 6, 6), ErrorID = 5, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 643, ErrorDate = new DateTime(2023, 7, 16), ErrorID = 2, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 644, ErrorDate = new DateTime(2021, 9, 22), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 645, ErrorDate = new DateTime(2022, 1, 23), ErrorID = 12, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 646, ErrorDate = new DateTime(2020, 12, 1), ErrorID = 12, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 647, ErrorDate = new DateTime(2020, 3, 8), ErrorID = 1, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 648, ErrorDate = new DateTime(2023, 11, 11), ErrorID = 11, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 649, ErrorDate = new DateTime(2020, 3, 29), ErrorID = 6, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 650, ErrorDate = new DateTime(2023, 5, 30), ErrorID = 8, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 651, ErrorDate = new DateTime(2020, 1, 25), ErrorID = 4, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 652, ErrorDate = new DateTime(2022, 7, 4), ErrorID = 3, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 653, ErrorDate = new DateTime(2021, 8, 12), ErrorID = 1, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 654, ErrorDate = new DateTime(2023, 3, 30), ErrorID = 11, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 655, ErrorDate = new DateTime(2020, 9, 7), ErrorID = 2, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 656, ErrorDate = new DateTime(2022, 12, 24), ErrorID = 15, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 657, ErrorDate = new DateTime(2020, 7, 8), ErrorID = 12, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 658, ErrorDate = new DateTime(2024, 3, 27), ErrorID = 8, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 659, ErrorDate = new DateTime(2024, 1, 5), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 660, ErrorDate = new DateTime(2023, 8, 17), ErrorID = 3, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 661, ErrorDate = new DateTime(2021, 1, 3), ErrorID = 8, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 662, ErrorDate = new DateTime(2023, 12, 18), ErrorID = 17, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 663, ErrorDate = new DateTime(2023, 4, 17), ErrorID = 6, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 664, ErrorDate = new DateTime(2020, 3, 20), ErrorID = 17, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 665, ErrorDate = new DateTime(2022, 8, 8), ErrorID = 18, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 666, ErrorDate = new DateTime(2023, 4, 10), ErrorID = 15, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 667, ErrorDate = new DateTime(2021, 9, 12), ErrorID = 20, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 668, ErrorDate = new DateTime(2020, 9, 5), ErrorID = 2, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 669, ErrorDate = new DateTime(2020, 2, 19), ErrorID = 15, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 670, ErrorDate = new DateTime(2020, 9, 18), ErrorID = 17, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 671, ErrorDate = new DateTime(2023, 10, 10), ErrorID = 16, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 672, ErrorDate = new DateTime(2021, 7, 14), ErrorID = 11, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 673, ErrorDate = new DateTime(2021, 1, 4), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 674, ErrorDate = new DateTime(2021, 8, 28), ErrorID = 13, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 675, ErrorDate = new DateTime(2023, 2, 8), ErrorID = 1, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 676, ErrorDate = new DateTime(2021, 2, 3), ErrorID = 14, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 677, ErrorDate = new DateTime(2023, 5, 7), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 678, ErrorDate = new DateTime(2021, 8, 7), ErrorID = 12, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 679, ErrorDate = new DateTime(2021, 6, 12), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 680, ErrorDate = new DateTime(2020, 3, 5), ErrorID = 17, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 681, ErrorDate = new DateTime(2021, 9, 25), ErrorID = 6, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 682, ErrorDate = new DateTime(2023, 12, 19), ErrorID = 19, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 683, ErrorDate = new DateTime(2020, 5, 15), ErrorID = 4, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 684, ErrorDate = new DateTime(2023, 2, 11), ErrorID = 13, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 685, ErrorDate = new DateTime(2022, 12, 3), ErrorID = 7, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 686, ErrorDate = new DateTime(2020, 8, 22), ErrorID = 10, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 687, ErrorDate = new DateTime(2022, 2, 3), ErrorID = 8, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 688, ErrorDate = new DateTime(2022, 5, 3), ErrorID = 1, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 689, ErrorDate = new DateTime(2022, 1, 4), ErrorID = 8, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 690, ErrorDate = new DateTime(2020, 1, 17), ErrorID = 15, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 691, ErrorDate = new DateTime(2022, 6, 19), ErrorID = 1, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 692, ErrorDate = new DateTime(2023, 12, 10), ErrorID = 10, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 693, ErrorDate = new DateTime(2023, 8, 26), ErrorID = 15, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 694, ErrorDate = new DateTime(2022, 7, 17), ErrorID = 16, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 695, ErrorDate = new DateTime(2023, 12, 25), ErrorID = 13, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 696, ErrorDate = new DateTime(2024, 3, 14), ErrorID = 17, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 697, ErrorDate = new DateTime(2023, 8, 7), ErrorID = 16, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 698, ErrorDate = new DateTime(2020, 6, 4), ErrorID = 12, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 699, ErrorDate = new DateTime(2022, 7, 10), ErrorID = 4, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 700, ErrorDate = new DateTime(2020, 1, 31), ErrorID = 13, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 701, ErrorDate = new DateTime(2022, 11, 25), ErrorID = 11, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 702, ErrorDate = new DateTime(2022, 6, 19), ErrorID = 16, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 703, ErrorDate = new DateTime(2024, 4, 23), ErrorID = 3, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 704, ErrorDate = new DateTime(2023, 5, 14), ErrorID = 12, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 705, ErrorDate = new DateTime(2022, 7, 13), ErrorID = 10, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 706, ErrorDate = new DateTime(2023, 6, 2), ErrorID = 10, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 707, ErrorDate = new DateTime(2020, 5, 12), ErrorID = 13, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 708, ErrorDate = new DateTime(2020, 6, 20), ErrorID = 15, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 709, ErrorDate = new DateTime(2022, 3, 19), ErrorID = 11, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 710, ErrorDate = new DateTime(2021, 6, 1), ErrorID = 4, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 711, ErrorDate = new DateTime(2023, 7, 16), ErrorID = 17, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 712, ErrorDate = new DateTime(2022, 10, 17), ErrorID = 3, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 713, ErrorDate = new DateTime(2023, 11, 3), ErrorID = 19, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 714, ErrorDate = new DateTime(2023, 3, 16), ErrorID = 6, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 715, ErrorDate = new DateTime(2023, 12, 23), ErrorID = 19, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 716, ErrorDate = new DateTime(2020, 3, 11), ErrorID = 14, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 717, ErrorDate = new DateTime(2021, 9, 6), ErrorID = 12, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 718, ErrorDate = new DateTime(2024, 4, 8), ErrorID = 3, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 719, ErrorDate = new DateTime(2023, 9, 22), ErrorID = 19, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 720, ErrorDate = new DateTime(2021, 4, 13), ErrorID = 20, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 721, ErrorDate = new DateTime(2022, 2, 15), ErrorID = 3, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 722, ErrorDate = new DateTime(2021, 9, 16), ErrorID = 9, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 723, ErrorDate = new DateTime(2020, 1, 26), ErrorID = 9, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 724, ErrorDate = new DateTime(2022, 10, 7), ErrorID = 2, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 725, ErrorDate = new DateTime(2023, 3, 30), ErrorID = 11, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 726, ErrorDate = new DateTime(2020, 8, 5), ErrorID = 20, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 727, ErrorDate = new DateTime(2022, 3, 23), ErrorID = 3, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 728, ErrorDate = new DateTime(2020, 3, 31), ErrorID = 8, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 729, ErrorDate = new DateTime(2020, 4, 5), ErrorID = 9, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 730, ErrorDate = new DateTime(2021, 2, 3), ErrorID = 11, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 731, ErrorDate = new DateTime(2021, 12, 22), ErrorID = 11, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 732, ErrorDate = new DateTime(2021, 10, 9), ErrorID = 2, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 733, ErrorDate = new DateTime(2022, 4, 29), ErrorID = 1, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 734, ErrorDate = new DateTime(2023, 7, 1), ErrorID = 20, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 735, ErrorDate = new DateTime(2020, 9, 19), ErrorID = 8, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 736, ErrorDate = new DateTime(2021, 3, 30), ErrorID = 14, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 737, ErrorDate = new DateTime(2020, 8, 13), ErrorID = 5, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 738, ErrorDate = new DateTime(2022, 8, 26), ErrorID = 14, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 739, ErrorDate = new DateTime(2022, 3, 17), ErrorID = 2, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 740, ErrorDate = new DateTime(2023, 5, 13), ErrorID = 10, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 741, ErrorDate = new DateTime(2020, 7, 15), ErrorID = 10, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 742, ErrorDate = new DateTime(2021, 2, 25), ErrorID = 1, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 743, ErrorDate = new DateTime(2022, 9, 18), ErrorID = 18, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 744, ErrorDate = new DateTime(2020, 3, 14), ErrorID = 10, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 745, ErrorDate = new DateTime(2024, 3, 18), ErrorID = 14, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 746, ErrorDate = new DateTime(2024, 2, 25), ErrorID = 9, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 747, ErrorDate = new DateTime(2020, 12, 4), ErrorID = 19, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 748, ErrorDate = new DateTime(2022, 8, 15), ErrorID = 4, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 749, ErrorDate = new DateTime(2023, 8, 21), ErrorID = 4, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 750, ErrorDate = new DateTime(2022, 8, 8), ErrorID = 20, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 751, ErrorDate = new DateTime(2024, 4, 18), ErrorID = 15, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 752, ErrorDate = new DateTime(2022, 8, 25), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 753, ErrorDate = new DateTime(2022, 2, 2), ErrorID = 10, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 754, ErrorDate = new DateTime(2021, 10, 31), ErrorID = 9, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 755, ErrorDate = new DateTime(2020, 7, 20), ErrorID = 11, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 756, ErrorDate = new DateTime(2021, 9, 18), ErrorID = 8, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 757, ErrorDate = new DateTime(2020, 7, 12), ErrorID = 2, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 758, ErrorDate = new DateTime(2024, 4, 7), ErrorID = 5, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 759, ErrorDate = new DateTime(2021, 3, 15), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 760, ErrorDate = new DateTime(2022, 12, 28), ErrorID = 3, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 761, ErrorDate = new DateTime(2020, 11, 7), ErrorID = 20, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 762, ErrorDate = new DateTime(2024, 4, 26), ErrorID = 7, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 763, ErrorDate = new DateTime(2020, 12, 30), ErrorID = 4, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 764, ErrorDate = new DateTime(2022, 7, 4), ErrorID = 3, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 765, ErrorDate = new DateTime(2022, 8, 9), ErrorID = 7, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 766, ErrorDate = new DateTime(2020, 3, 1), ErrorID = 12, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 767, ErrorDate = new DateTime(2021, 10, 18), ErrorID = 18, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 768, ErrorDate = new DateTime(2022, 1, 26), ErrorID = 6, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 769, ErrorDate = new DateTime(2023, 8, 31), ErrorID = 2, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 770, ErrorDate = new DateTime(2021, 9, 14), ErrorID = 13, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 771, ErrorDate = new DateTime(2020, 11, 10), ErrorID = 16, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 772, ErrorDate = new DateTime(2022, 10, 19), ErrorID = 8, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 773, ErrorDate = new DateTime(2022, 6, 6), ErrorID = 1, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 774, ErrorDate = new DateTime(2023, 5, 29), ErrorID = 15, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 775, ErrorDate = new DateTime(2021, 9, 25), ErrorID = 9, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 776, ErrorDate = new DateTime(2023, 11, 6), ErrorID = 10, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 777, ErrorDate = new DateTime(2023, 11, 13), ErrorID = 17, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 778, ErrorDate = new DateTime(2023, 6, 4), ErrorID = 17, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 779, ErrorDate = new DateTime(2022, 2, 12), ErrorID = 14, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 780, ErrorDate = new DateTime(2020, 8, 9), ErrorID = 14, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 781, ErrorDate = new DateTime(2022, 9, 16), ErrorID = 6, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 782, ErrorDate = new DateTime(2024, 4, 24), ErrorID = 5, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 783, ErrorDate = new DateTime(2023, 3, 13), ErrorID = 20, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 784, ErrorDate = new DateTime(2022, 7, 8), ErrorID = 12, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 785, ErrorDate = new DateTime(2021, 7, 27), ErrorID = 5, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 786, ErrorDate = new DateTime(2023, 7, 14), ErrorID = 16, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 787, ErrorDate = new DateTime(2024, 2, 7), ErrorID = 9, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 788, ErrorDate = new DateTime(2023, 1, 24), ErrorID = 1, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 789, ErrorDate = new DateTime(2022, 9, 26), ErrorID = 2, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 790, ErrorDate = new DateTime(2020, 1, 4), ErrorID = 12, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 791, ErrorDate = new DateTime(2021, 12, 30), ErrorID = 2, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 792, ErrorDate = new DateTime(2022, 11, 25), ErrorID = 11, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 793, ErrorDate = new DateTime(2022, 8, 7), ErrorID = 1, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 794, ErrorDate = new DateTime(2022, 3, 9), ErrorID = 6, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 795, ErrorDate = new DateTime(2023, 11, 19), ErrorID = 1, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 796, ErrorDate = new DateTime(2023, 1, 24), ErrorID = 5, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 797, ErrorDate = new DateTime(2024, 4, 20), ErrorID = 16, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 798, ErrorDate = new DateTime(2021, 3, 18), ErrorID = 14, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 799, ErrorDate = new DateTime(2021, 6, 30), ErrorID = 4, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 800, ErrorDate = new DateTime(2020, 10, 17), ErrorID = 4, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 801, ErrorDate = new DateTime(2023, 9, 8), ErrorID = 12, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 802, ErrorDate = new DateTime(2020, 7, 13), ErrorID = 13, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 803, ErrorDate = new DateTime(2024, 1, 5), ErrorID = 6, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 804, ErrorDate = new DateTime(2020, 8, 12), ErrorID = 2, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 805, ErrorDate = new DateTime(2020, 3, 19), ErrorID = 3, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 806, ErrorDate = new DateTime(2021, 4, 20), ErrorID = 8, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 807, ErrorDate = new DateTime(2020, 7, 6), ErrorID = 3, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 808, ErrorDate = new DateTime(2023, 1, 5), ErrorID = 19, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 809, ErrorDate = new DateTime(2023, 8, 15), ErrorID = 20, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 810, ErrorDate = new DateTime(2020, 3, 3), ErrorID = 19, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 811, ErrorDate = new DateTime(2023, 6, 28), ErrorID = 15, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 812, ErrorDate = new DateTime(2023, 10, 4), ErrorID = 9, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 813, ErrorDate = new DateTime(2020, 11, 21), ErrorID = 10, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 814, ErrorDate = new DateTime(2022, 4, 20), ErrorID = 16, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 815, ErrorDate = new DateTime(2023, 5, 10), ErrorID = 11, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 816, ErrorDate = new DateTime(2022, 11, 27), ErrorID = 20, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 817, ErrorDate = new DateTime(2022, 12, 18), ErrorID = 5, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 818, ErrorDate = new DateTime(2020, 5, 9), ErrorID = 19, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 819, ErrorDate = new DateTime(2021, 2, 24), ErrorID = 4, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 820, ErrorDate = new DateTime(2021, 5, 20), ErrorID = 1, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 821, ErrorDate = new DateTime(2023, 7, 30), ErrorID = 20, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 822, ErrorDate = new DateTime(2022, 6, 16), ErrorID = 4, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 823, ErrorDate = new DateTime(2021, 4, 21), ErrorID = 2, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 824, ErrorDate = new DateTime(2022, 1, 10), ErrorID = 2, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 825, ErrorDate = new DateTime(2023, 11, 7), ErrorID = 1, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 826, ErrorDate = new DateTime(2020, 2, 29), ErrorID = 3, MachineID = 27 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 827, ErrorDate = new DateTime(2022, 7, 26), ErrorID = 19, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 828, ErrorDate = new DateTime(2021, 4, 4), ErrorID = 11, MachineID = 34 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 829, ErrorDate = new DateTime(2020, 11, 21), ErrorID = 7, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 830, ErrorDate = new DateTime(2023, 3, 10), ErrorID = 17, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 831, ErrorDate = new DateTime(2021, 11, 12), ErrorID = 5, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 832, ErrorDate = new DateTime(2020, 3, 5), ErrorID = 13, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 833, ErrorDate = new DateTime(2020, 9, 14), ErrorID = 8, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 834, ErrorDate = new DateTime(2021, 1, 16), ErrorID = 6, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 835, ErrorDate = new DateTime(2020, 11, 30), ErrorID = 13, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 836, ErrorDate = new DateTime(2021, 10, 29), ErrorID = 3, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 837, ErrorDate = new DateTime(2020, 7, 20), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 838, ErrorDate = new DateTime(2023, 1, 20), ErrorID = 8, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 839, ErrorDate = new DateTime(2020, 11, 26), ErrorID = 8, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 840, ErrorDate = new DateTime(2023, 4, 8), ErrorID = 18, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 841, ErrorDate = new DateTime(2021, 8, 5), ErrorID = 10, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 842, ErrorDate = new DateTime(2021, 10, 7), ErrorID = 4, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 843, ErrorDate = new DateTime(2023, 5, 30), ErrorID = 12, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 844, ErrorDate = new DateTime(2022, 1, 12), ErrorID = 6, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 845, ErrorDate = new DateTime(2023, 3, 8), ErrorID = 20, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 846, ErrorDate = new DateTime(2023, 12, 4), ErrorID = 20, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 847, ErrorDate = new DateTime(2022, 3, 7), ErrorID = 6, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 848, ErrorDate = new DateTime(2023, 10, 28), ErrorID = 18, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 849, ErrorDate = new DateTime(2023, 10, 6), ErrorID = 19, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 850, ErrorDate = new DateTime(2020, 9, 1), ErrorID = 17, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 851, ErrorDate = new DateTime(2021, 12, 22), ErrorID = 16, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 852, ErrorDate = new DateTime(2022, 4, 27), ErrorID = 7, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 853, ErrorDate = new DateTime(2023, 6, 5), ErrorID = 16, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 854, ErrorDate = new DateTime(2023, 7, 11), ErrorID = 18, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 855, ErrorDate = new DateTime(2023, 4, 2), ErrorID = 11, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 856, ErrorDate = new DateTime(2023, 1, 23), ErrorID = 19, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 857, ErrorDate = new DateTime(2024, 4, 23), ErrorID = 17, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 858, ErrorDate = new DateTime(2023, 10, 16), ErrorID = 19, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 859, ErrorDate = new DateTime(2021, 1, 18), ErrorID = 15, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 860, ErrorDate = new DateTime(2023, 5, 16), ErrorID = 8, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 861, ErrorDate = new DateTime(2022, 6, 22), ErrorID = 3, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 862, ErrorDate = new DateTime(2021, 9, 16), ErrorID = 14, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 863, ErrorDate = new DateTime(2022, 5, 9), ErrorID = 1, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 864, ErrorDate = new DateTime(2021, 3, 6), ErrorID = 18, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 865, ErrorDate = new DateTime(2022, 2, 22), ErrorID = 18, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 866, ErrorDate = new DateTime(2023, 10, 30), ErrorID = 19, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 867, ErrorDate = new DateTime(2023, 5, 27), ErrorID = 20, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 868, ErrorDate = new DateTime(2021, 5, 25), ErrorID = 3, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 869, ErrorDate = new DateTime(2023, 12, 3), ErrorID = 17, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 870, ErrorDate = new DateTime(2021, 2, 22), ErrorID = 9, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 871, ErrorDate = new DateTime(2023, 11, 12), ErrorID = 17, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 872, ErrorDate = new DateTime(2020, 11, 17), ErrorID = 20, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 873, ErrorDate = new DateTime(2020, 6, 26), ErrorID = 3, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 874, ErrorDate = new DateTime(2020, 3, 6), ErrorID = 1, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 875, ErrorDate = new DateTime(2023, 10, 18), ErrorID = 6, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 876, ErrorDate = new DateTime(2021, 8, 21), ErrorID = 8, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 877, ErrorDate = new DateTime(2020, 8, 1), ErrorID = 11, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 878, ErrorDate = new DateTime(2021, 7, 25), ErrorID = 9, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 879, ErrorDate = new DateTime(2020, 12, 8), ErrorID = 6, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 880, ErrorDate = new DateTime(2020, 9, 24), ErrorID = 3, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 881, ErrorDate = new DateTime(2023, 1, 3), ErrorID = 20, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 882, ErrorDate = new DateTime(2021, 1, 27), ErrorID = 8, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 883, ErrorDate = new DateTime(2022, 3, 30), ErrorID = 2, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 884, ErrorDate = new DateTime(2023, 5, 19), ErrorID = 6, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 885, ErrorDate = new DateTime(2020, 3, 5), ErrorID = 6, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 886, ErrorDate = new DateTime(2020, 10, 8), ErrorID = 17, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 887, ErrorDate = new DateTime(2021, 12, 4), ErrorID = 12, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 888, ErrorDate = new DateTime(2023, 11, 2), ErrorID = 20, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 889, ErrorDate = new DateTime(2022, 1, 3), ErrorID = 18, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 890, ErrorDate = new DateTime(2022, 2, 10), ErrorID = 8, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 891, ErrorDate = new DateTime(2021, 11, 16), ErrorID = 1, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 892, ErrorDate = new DateTime(2021, 12, 21), ErrorID = 9, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 893, ErrorDate = new DateTime(2024, 2, 9), ErrorID = 6, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 894, ErrorDate = new DateTime(2023, 10, 15), ErrorID = 4, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 895, ErrorDate = new DateTime(2023, 3, 25), ErrorID = 15, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 896, ErrorDate = new DateTime(2023, 3, 7), ErrorID = 15, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 897, ErrorDate = new DateTime(2021, 8, 21), ErrorID = 17, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 898, ErrorDate = new DateTime(2021, 8, 16), ErrorID = 19, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 899, ErrorDate = new DateTime(2021, 2, 4), ErrorID = 4, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 900, ErrorDate = new DateTime(2022, 6, 14), ErrorID = 2, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 901, ErrorDate = new DateTime(2022, 7, 14), ErrorID = 6, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 902, ErrorDate = new DateTime(2023, 5, 23), ErrorID = 15, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 903, ErrorDate = new DateTime(2023, 5, 14), ErrorID = 6, MachineID = 25 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 904, ErrorDate = new DateTime(2021, 9, 25), ErrorID = 14, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 905, ErrorDate = new DateTime(2022, 12, 5), ErrorID = 10, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 906, ErrorDate = new DateTime(2021, 7, 17), ErrorID = 16, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 907, ErrorDate = new DateTime(2023, 8, 13), ErrorID = 20, MachineID = 11 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 908, ErrorDate = new DateTime(2021, 3, 12), ErrorID = 10, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 909, ErrorDate = new DateTime(2021, 12, 8), ErrorID = 2, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 910, ErrorDate = new DateTime(2020, 9, 6), ErrorID = 2, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 911, ErrorDate = new DateTime(2022, 3, 10), ErrorID = 4, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 912, ErrorDate = new DateTime(2020, 6, 29), ErrorID = 2, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 913, ErrorDate = new DateTime(2020, 2, 29), ErrorID = 1, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 914, ErrorDate = new DateTime(2024, 4, 15), ErrorID = 6, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 915, ErrorDate = new DateTime(2021, 10, 9), ErrorID = 15, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 916, ErrorDate = new DateTime(2021, 11, 11), ErrorID = 17, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 917, ErrorDate = new DateTime(2022, 11, 24), ErrorID = 19, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 918, ErrorDate = new DateTime(2020, 10, 4), ErrorID = 6, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 919, ErrorDate = new DateTime(2024, 1, 20), ErrorID = 7, MachineID = 7 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 920, ErrorDate = new DateTime(2021, 7, 30), ErrorID = 11, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 921, ErrorDate = new DateTime(2020, 1, 10), ErrorID = 3, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 922, ErrorDate = new DateTime(2024, 4, 23), ErrorID = 13, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 923, ErrorDate = new DateTime(2022, 5, 6), ErrorID = 15, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 924, ErrorDate = new DateTime(2022, 7, 25), ErrorID = 19, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 925, ErrorDate = new DateTime(2022, 12, 29), ErrorID = 1, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 926, ErrorDate = new DateTime(2022, 3, 5), ErrorID = 11, MachineID = 15 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 927, ErrorDate = new DateTime(2021, 5, 22), ErrorID = 14, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 928, ErrorDate = new DateTime(2020, 11, 20), ErrorID = 12, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 929, ErrorDate = new DateTime(2022, 4, 22), ErrorID = 12, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 930, ErrorDate = new DateTime(2024, 4, 13), ErrorID = 18, MachineID = 33 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 931, ErrorDate = new DateTime(2020, 4, 11), ErrorID = 7, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 932, ErrorDate = new DateTime(2020, 11, 19), ErrorID = 17, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 933, ErrorDate = new DateTime(2021, 1, 15), ErrorID = 15, MachineID = 2 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 934, ErrorDate = new DateTime(2024, 4, 14), ErrorID = 16, MachineID = 22 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 935, ErrorDate = new DateTime(2023, 2, 10), ErrorID = 9, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 936, ErrorDate = new DateTime(2022, 4, 1), ErrorID = 4, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 937, ErrorDate = new DateTime(2023, 7, 24), ErrorID = 1, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 938, ErrorDate = new DateTime(2020, 5, 13), ErrorID = 13, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 939, ErrorDate = new DateTime(2022, 2, 27), ErrorID = 16, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 940, ErrorDate = new DateTime(2023, 9, 24), ErrorID = 2, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 941, ErrorDate = new DateTime(2021, 9, 16), ErrorID = 11, MachineID = 12 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 942, ErrorDate = new DateTime(2021, 3, 25), ErrorID = 11, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 943, ErrorDate = new DateTime(2023, 12, 28), ErrorID = 7, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 944, ErrorDate = new DateTime(2023, 8, 20), ErrorID = 11, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 945, ErrorDate = new DateTime(2023, 10, 5), ErrorID = 16, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 946, ErrorDate = new DateTime(2023, 5, 29), ErrorID = 1, MachineID = 9 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 947, ErrorDate = new DateTime(2022, 8, 23), ErrorID = 7, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 948, ErrorDate = new DateTime(2023, 11, 14), ErrorID = 11, MachineID = 19 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 949, ErrorDate = new DateTime(2023, 3, 2), ErrorID = 15, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 950, ErrorDate = new DateTime(2021, 10, 29), ErrorID = 18, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 951, ErrorDate = new DateTime(2020, 8, 27), ErrorID = 14, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 952, ErrorDate = new DateTime(2022, 8, 7), ErrorID = 4, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 953, ErrorDate = new DateTime(2021, 4, 20), ErrorID = 13, MachineID = 5 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 954, ErrorDate = new DateTime(2023, 7, 31), ErrorID = 14, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 955, ErrorDate = new DateTime(2020, 6, 26), ErrorID = 5, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 956, ErrorDate = new DateTime(2023, 7, 17), ErrorID = 2, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 957, ErrorDate = new DateTime(2023, 9, 19), ErrorID = 19, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 958, ErrorDate = new DateTime(2022, 11, 22), ErrorID = 16, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 959, ErrorDate = new DateTime(2020, 4, 16), ErrorID = 15, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 960, ErrorDate = new DateTime(2024, 2, 4), ErrorID = 8, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 961, ErrorDate = new DateTime(2022, 1, 20), ErrorID = 18, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 962, ErrorDate = new DateTime(2024, 1, 3), ErrorID = 11, MachineID = 28 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 963, ErrorDate = new DateTime(2022, 12, 24), ErrorID = 11, MachineID = 29 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 964, ErrorDate = new DateTime(2021, 6, 1), ErrorID = 3, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 965, ErrorDate = new DateTime(2023, 8, 10), ErrorID = 15, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 966, ErrorDate = new DateTime(2020, 11, 15), ErrorID = 15, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 967, ErrorDate = new DateTime(2023, 12, 9), ErrorID = 6, MachineID = 21 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 968, ErrorDate = new DateTime(2021, 10, 15), ErrorID = 9, MachineID = 3 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 969, ErrorDate = new DateTime(2023, 11, 28), ErrorID = 14, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 970, ErrorDate = new DateTime(2022, 8, 1), ErrorID = 6, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 971, ErrorDate = new DateTime(2023, 5, 31), ErrorID = 17, MachineID = 30 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 972, ErrorDate = new DateTime(2023, 9, 18), ErrorID = 10, MachineID = 35 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 973, ErrorDate = new DateTime(2020, 12, 29), ErrorID = 8, MachineID = 40 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 974, ErrorDate = new DateTime(2021, 10, 30), ErrorID = 17, MachineID = 10 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 975, ErrorDate = new DateTime(2023, 11, 2), ErrorID = 9, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 976, ErrorDate = new DateTime(2020, 9, 30), ErrorID = 20, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 977, ErrorDate = new DateTime(2022, 1, 9), ErrorID = 10, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 978, ErrorDate = new DateTime(2021, 12, 15), ErrorID = 20, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 979, ErrorDate = new DateTime(2024, 1, 28), ErrorID = 16, MachineID = 32 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 980, ErrorDate = new DateTime(2024, 1, 1), ErrorID = 6, MachineID = 24 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 981, ErrorDate = new DateTime(2023, 11, 29), ErrorID = 18, MachineID = 38 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 982, ErrorDate = new DateTime(2023, 12, 19), ErrorID = 1, MachineID = 18 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 983, ErrorDate = new DateTime(2020, 8, 2), ErrorID = 2, MachineID = 20 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 984, ErrorDate = new DateTime(2022, 9, 6), ErrorID = 19, MachineID = 31 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 985, ErrorDate = new DateTime(2020, 3, 4), ErrorID = 3, MachineID = 26 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 986, ErrorDate = new DateTime(2022, 11, 30), ErrorID = 18, MachineID = 39 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 987, ErrorDate = new DateTime(2022, 3, 3), ErrorID = 6, MachineID = 16 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 988, ErrorDate = new DateTime(2023, 4, 29), ErrorID = 2, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 989, ErrorDate = new DateTime(2022, 11, 18), ErrorID = 14, MachineID = 8 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 990, ErrorDate = new DateTime(2021, 10, 1), ErrorID = 13, MachineID = 6 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 991, ErrorDate = new DateTime(2023, 8, 3), ErrorID = 3, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 992, ErrorDate = new DateTime(2022, 1, 8), ErrorID = 7, MachineID = 17 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 993, ErrorDate = new DateTime(2021, 9, 5), ErrorID = 18, MachineID = 14 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 994, ErrorDate = new DateTime(2022, 6, 27), ErrorID = 6, MachineID = 1 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 995, ErrorDate = new DateTime(2020, 3, 29), ErrorID = 18, MachineID = 23 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 996, ErrorDate = new DateTime(2020, 1, 2), ErrorID = 10, MachineID = 36 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 997, ErrorDate = new DateTime(2022, 1, 17), ErrorID = 20, MachineID = 37 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 998, ErrorDate = new DateTime(2021, 1, 6), ErrorID = 16, MachineID = 4 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 999, ErrorDate = new DateTime(2020, 12, 26), ErrorID = 10, MachineID = 13 });
                Data_ErrorHistory.Add(new Common.Data_ErrorHistory() { ErrorHistoryID = 1000, ErrorDate = new DateTime(2023, 2, 11), ErrorID = 3, MachineID = 5 });

                #endregion


            }
            catch (Exception ex)
            {

            }
        }

    }

    public class TimeRange
    {
        public int TimeRangeID { get; set; }
        public string TimeRangeName { get; set; }
    }


    /// <summary>
    /// Bảng mã lỗi
    /// </summary>
    public class Data_Error
    {
        public int ErrorID { get; set; }
        public string ErrorName { get; set; }
        public string ErrorCode { get; set; }
    }
    /// <summary>
    /// Bảng danh sách loai máy 
    /// </summary>
    public class Data_MachineGroup
    {
        public int MachineGroupID { get; set; }
        public string MachineGroupName { get; set; }
    }
    /// <summary>
    /// Bảng danh sách máy
    /// </summary>
    public class Data_Machine
    {
        public int MachineID { get; set; }
        public string MachineName { get; set; }
        public string MachineNameOrigin { get; set; }
        public int MachineGroupID { get; set; }
        public string MachineGroupName { get; set; }
    }
    /// <summary>
    /// Bảng vị trí cài đặt máy
    /// </summary>
    public class Data_MachineLocation
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
    }
    /// <summary>
    /// Bảng map máy nào đặt ở vị trí nào
    /// </summary>
    public class Data_MachineLocationSetup
    {
        public int MachineID { get; set; }
        public string MachineName { get; set; }
        public int LocationID { get; set; }
        public string LocationName { get; set; }
    }
    /// <summary>
    /// Bảng máy lỗi
    /// </summary>
    public class Data_ErrorHistory
    {
        public int ErrorHistoryID { get; set; }
        public DateTime ErrorDate { get; set; }

        public int MachineID { get; set; }
        public int ErrorID { get; set; }
    }
}
