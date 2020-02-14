using EPPlus.Core.Extensions.Attributes;

namespace KeToanDTO
{
    public class SoLieuTonKhoDto
    {
        [ExcelTableColumn("TT")]
        public int Stt { get; set; }

        [ExcelTableColumn(@"Mã Hàng")]
        public string MaHang { get; set; }
        //public int TenHang { get; set; }
    }
}
