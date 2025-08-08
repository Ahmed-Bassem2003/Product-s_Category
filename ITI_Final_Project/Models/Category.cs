using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ITI_Final_Project.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Category Id")]
        public int CatId { get; set; }

        [DisplayName("Category Name")]
        public string CatName { get; set; }

        [DisplayName("Category Description")]
        public string CatDes { get; set; }

        public virtual ICollection<Product> Products { get; set;} = new HashSet<Product>();
    }
}
