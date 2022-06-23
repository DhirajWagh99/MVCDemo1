using System;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo1.Models
{
    public class Book
    {

        [Key]
        [ScaffoldColumn(false)]
        
        public int Id { get; set; }

        [Display(Name = "Author Name")]
        [Required(ErrorMessage ="Name is Required")]
        public string AuthorName { get; set; }
        [Display(Name = "Publisher Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string PublisherName { get; set; }

        [Required(ErrorMessage ="Date Is Required")]
        [DataType(DataType.Date)]
        public DateTime PublisherDate { get; set; }


        [Range(100, 500)]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage ="Price is required")]
        public int Price{ get; set; }
    }
}
