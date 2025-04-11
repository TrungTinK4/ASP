using System;

namespace NguyenTrungTin_2122110033.Model
{
    public class OrderDetail
    {
        public int Id { get; set; }                     // ID chi tiết
        public int OrderId { get; set; }                // ID đơn hàng
        public int ProductId { get; set; }              // ID sản phẩm
        public int Quantity { get; set; }               // Số lượng mua
        public decimal UnitPrice { get; set; }          // Giá từng sản phẩm

        public Order Order { get; set; }                // Tham chiếu đơn hàng
        public SanPham Product { get; set; }            // Tham chiếu sản phẩm
    }
}
