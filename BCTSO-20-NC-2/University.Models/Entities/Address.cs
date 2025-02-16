using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models.Entities
{
    public class Address
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string City { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string Street { get; set; }


        //ერთი ერთთან კავშირი
        //[ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
