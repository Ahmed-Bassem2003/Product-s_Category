using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Final_Project.Models
{
    public class Product
    {
        [Key]
        public int ProdId { get; set; }

        [Required(ErrorMessage = "Title Is Required")]
        [MinLength(3, ErrorMessage = "Title Min Length Is 3")]
        [MaxLength(50, ErrorMessage = "Title Max Length Is 50")]
        [DisplayName("Title")] 
        [Column("Title")] 
        public string Title { get; set; }

        [Range(10000, 100000, ErrorMessage = "Price Must Be Between 10000 and 100000")]
        public decimal Price { get; set; }

        [StringLength(100, ErrorMessage = "Description Must Be Between 4 and 100", MinimumLength = 4)]
        public string Description { get; set; }

        [Range(100, 2000, ErrorMessage = "Quantity Must Be Between 100 and 2000")]
        public int Quantity { get; set; }

        public string ImagePath { get; set; }


        [ForeignKey(nameof(Category))]
        [DisplayName("Category")]
        public int CatId { get; set; }

        public virtual Category Category { get; set; }
    }
}
