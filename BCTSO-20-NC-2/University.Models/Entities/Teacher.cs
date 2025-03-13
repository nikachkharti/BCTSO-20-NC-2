using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models.Entities
{
    public class Teacher
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string Name { get; set; }

        //ერთი ბევრთან კავშირი
        public List<Course> Courses { get; set; }

        public string ProfilePictureUrl { get; set; }
    }
}
