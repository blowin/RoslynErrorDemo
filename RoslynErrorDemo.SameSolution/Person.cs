using System.ComponentModel.DataAnnotations;

namespace SameSolution
{
    public record Person
    {
        [Required]
        public string Name { get; set; } = "";

        public int Age { get; set; }
    }
}
