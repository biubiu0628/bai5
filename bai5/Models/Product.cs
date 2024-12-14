using System.ComponentModel.DataAnnotations;

namespace bai5.Models
{
    public class Product
    {
        [Required(ErrorMessage="Mã sản phẩm không được để trống")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Phải có ít nhất 6 kí tự.")]
        public required string ProductId { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(50, ErrorMessage = "Tên sản phẩm không được quá 50 kí tự.")]
        public required string ProductName { get; set; }
        public string? Image {  get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        [Range(1, 999999, ErrorMessage = "Giá trị từ 1-999999")]
        public decimal BuyPrice { get; set; }
        [Range(1, 999999, ErrorMessage = "Giá trị từ 1-999999")]
        public decimal SellPrice { get; set; }
        public virtual Category? Category { get; set; }
    }
}
