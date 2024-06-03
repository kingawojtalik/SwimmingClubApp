using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwimmingClubApp.Models
{
    public class Swimmer
    {
        public int SwimmerId { get; set; }
        [Required(ErrorMessage = "Wpisz imię zawodnika")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Wpisz nazwisko zawodnika")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Podaj datę urodzenia zawodnika")]
        public DateOnly BirthDate { get; set; }
        [Required(ErrorMessage = "Wybierz płeć")]
        public string Gender { get; set; }
        public SwimmingGroup SwimmingGroup { get; set; }
        [Required(ErrorMessage = "Wybierz grupę pływacką")]
        public int SwimmingGroupId { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

    }
}
