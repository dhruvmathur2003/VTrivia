using System.ComponentModel.DataAnnotations;

namespace VTrivia.Model
{
    public class Que
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Statement { get; set; }
        public List<string>? options { get; set; }

        [Required]
        public string answer {  get; set; }

    }
}
