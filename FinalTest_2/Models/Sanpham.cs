namespace kiemtra.Models
{
    public class HomeProduct
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int TamTinh { get; set; }
        public double Khuyenmai { get; set; }
        public double Tongtien { get; set; }
        public HomeProduct() { }
        public HomeProduct(string tenSanPham, int soLuong, int gia, double giamgia)
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            DonGia = gia;
            TamTinh = soLuong * gia;
            Khuyenmai = SoLuong * gia * (giamgia / 100);
            Tongtien = TamTinh - Khuyenmai; 
        }
    }
}
