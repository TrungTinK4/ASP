using System;

namespace NguyenTrungTin_2122110033.Model
{
    public class Post
    {
        public int Id { get; set; }                  // ID bài viết
        public string Title { get; set; }            // Tiêu đề
        public string Content { get; set; }          // Nội dung
        public string ImageUrl { get; set; }         // Ảnh đại diện
        public DateTime CreatedAt { get; set; }      // Ngày tạo
        public DateTime UpdatedAt { get; set; }      // Ngày cập nhật
        public string Author { get; set; }           // Người viết
        public bool IsPublished { get; set; }        // Trạng thái đã đăng hay chưa
    }
}
