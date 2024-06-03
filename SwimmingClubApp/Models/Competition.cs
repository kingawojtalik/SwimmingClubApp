using System.ComponentModel.DataAnnotations;

namespace SwimmingClubApp.Models
{
    public class Competition
    {
        public int CompetitionId { get; set; }
        [Required(ErrorMessage = "Wpisz nazwę zawodów")]
        public string Name { get; set; }
        [Required]
        public DateOnly Date { get; set; }
        [Required(ErrorMessage = "Wpisz miasto")]
        public string City { get; set; }
    }
}
