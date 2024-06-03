using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwimmingClubApp.Models
{
    public class Training
    {
        public int TrainingId { get; set; }
        public SwimmingGroup SwimmingGroup { get; set; }
        [Required(ErrorMessage = "Wybierz grupę")]
        public int SwimmingGroupId { get; set; }
        [Required(ErrorMessage = "Wpisz miejsce")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Wpisz dzień tygodnia")]
        public string TrainingDay { get; set; }
        [Required]
        public TimeOnly TrainingTime { get; set; }

    }
}
