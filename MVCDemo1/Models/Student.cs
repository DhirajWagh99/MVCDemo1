


using System.ComponentModel.DataAnnotations;

namespace MVCDemo1.Models
{
   
    public class Student
    {
        [Key]
        [ScaffoldColumn(false)]
        public int RollNo { get; set; }
        [Display(Name ="Student Name")]
        [Required(ErrorMessage ="Name is required")]

       
        public string Name { get; set; }
        [Required(ErrorMessage ="Age is required")]
        [Range(minimum:18, maximum:60,ErrorMessage ="Age should be in between 18 to 60")]
        public int Age { get; set; }

        [Required(ErrorMessage ="email id is required ")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email Id is not in proper format")]

        public string EmailId { get; set; }

        [Required(ErrorMessage ="City is required")]
        [MaxLength(50)]
        public string   City { get; set; }

        [Required(ErrorMessage ="pass")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
