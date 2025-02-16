using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models.Entities
{
    public class Group
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string Title { get; set; }


        //ბევრი ბევრთან კავშირი
        //[ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        //[NotMapped]
        //public List<Student> Students { get; set; }


        //ბევრი ბევრთან კავშირი
        //[ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        //[NotMapped]
        //public List<Course> Courses { get; set; }

    }
}
