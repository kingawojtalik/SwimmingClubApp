using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwimmingClubApp.Models
{
    public class Result
    {
        public int ResultId { get; set; }
        public Swimmer Swimmer { get; set; }
        [Required(ErrorMessage = "Wybierz zawodnika")]
        public int SwimmerId { get; set; }
        public Competition Competition { get; set; }
        [Required(ErrorMessage = "Wybierz zawody")]
        public int CompetitionId { get; set; }
        [Required(ErrorMessage = "Wpisz dystans")]
        public int Distance { get; set; }
        [Required(ErrorMessage = "Wpisz styl pływacki")]
        public string Stroke { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
        [NotMapped]
        [Required]
        public int Minutes { get; set; }
        [NotMapped]
        [Required]
        public int Seconds { get; set; }
        [NotMapped]
        [Required]
        public int Miliseconds { get; set; }

        [Required(ErrorMessage = "Wpisz liczbę punktów")]
        [Range(0, 1000, ErrorMessage = "Wpisz poprawną wartość z przedziału {1} - {2}.")]
        public int Point { get; set; }
        [Required(ErrorMessage = "Wpisz zdobyte miejsce")]
        [Range(0, 200, ErrorMessage = "Wpisz poprawną wartość z przedziału {1} - {2}.")]
        public int Place { get; set; }
        [Required(ErrorMessage = "Wybierz medal/brak medalu")]
        public string Medal { get; set; }

        public TimeSpan CreateTimeSpan() => new TimeSpan(0, 0, Minutes, Seconds, Miliseconds * 10);


    }
}
