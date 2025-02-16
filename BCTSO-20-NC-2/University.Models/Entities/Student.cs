using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models.Entities
{
    public class Student
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string Name { get; set; }

        //[Required]
        //[StringLength(11)]
        //[Column(TypeName = "CHAR(11)")]
        public string PersonalNumber { get; set; }

        //[Required]
        //[MaxLength(50)]
        //[EmailAddress]
        //[Column(TypeName = "VARCHAR(50)")]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }


        //ერთი ერთთან კავშირი
        public Address Address { get; set; }


        //ბევრი ბევრთან კავშირი
        public List<Group> Groups { get; set; }
    }
}
