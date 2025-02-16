using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace University.Models.Entities
{
    public class Course
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(150)]
        public string Title { get; set; }


        //ერთი ბევრთნ კავშირი
        //[ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        //ბევრი ბევრთან კავშირი
        public List<Group> Groups { get; set; }
    }
}
