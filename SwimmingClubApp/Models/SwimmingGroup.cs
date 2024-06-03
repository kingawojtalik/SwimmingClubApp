using System.ComponentModel.DataAnnotations;

namespace SwimmingClubApp.Models
{
    public class SwimmingGroup
    {
        public int SwimmingGroupId { get; set; }
        [Required(ErrorMessage = "Wpisz nazwę grupy")]
        public string Name { get; set; }

        [Range(1, 3, ErrorMessage = "Wybierz poziom grupy: 1, 2 lub 3")]
        public int Level { get; set; }

    }
}
