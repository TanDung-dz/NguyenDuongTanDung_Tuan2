using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace NguyenDuongTanDung_Tuan2.Models
{
    public class Product
    {
        [DisplayName ("Ma San Pham")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [DisplayName("Ten San Pham")]
        public string Name { get; set; }
        [Range(0.01, 10000.00)]
        [DisplayName("Gia Ban")]
        public decimal Price { get; set; }
        [DisplayName("Mp ta")]
        public string Description { get; set; }
        [DisplayName("Ma loai san pham")]
        public int Categories { get; set; }
    }
}
