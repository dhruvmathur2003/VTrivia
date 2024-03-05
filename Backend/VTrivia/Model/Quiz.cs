using System.ComponentModel.DataAnnotations;

namespace VTrivia.Model
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int? groupId { get; set; }
        [Required]
        public DateTime startTimeStamp { get; set; }
        [Required]
        public TimeSpan timeWindow {  get; set; }
        [Required]
        public TimeSpan quizDuration { get; set; }

        public List<Que>? Ques { get; set; }
    }
}
