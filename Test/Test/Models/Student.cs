using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public enum TypeContact
    {
        Name,
        List,
        Email,
        Birthdate,
    }
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact Type { get; set; }
        [Required]
        public string Test { get; set; }

    }
}