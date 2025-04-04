using System;
using System.Collections.Generic;

namespace NguyenTrungTin_2122110033.Model
{
    public class Order
    {
        public int Id { get; set; }                    // ID đơn hàng
        public int UserId { get; set; }                // ID người đặt hàng
        public DateTime OrderDate { get; set; }        // Ngày đặt hàng
        public decimal TotalAmount { get; set; }       // Tổng tiền
        public string Status { get; set; }             // Trạng thái (Pending, Shipped, Cancelled...)

        public List<OrderDetail> OrderDetails { get; set; }  // Chi tiết đơn hàng
    }
}
