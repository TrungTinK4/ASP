using System;

namespace NguyenTrungTin_2122110033.Model
{
    public class Cart
    {
        public int Id { get; set; }                  // ID giỏ hàng
        public int UserId { get; set; }              // ID người dùng
        public int ProductId { get; set; }           // ID sản phẩm
        public int Quantity { get; set; }            // Số lượng
        public DateTime CreatedAt { get; set; }      // Ngày thêm vào giỏ
    }
}
