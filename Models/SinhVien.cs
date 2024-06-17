
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HoangVanPhan0403.Models

{
    [Table("SinhVien")]
    public class SinhVien 
    {
        [Key]
        public string? SinhVienId { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
    }
}
