using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        public int? CategoryId { get; set; }
        public Categories? Category { get; set; }

        [Required]
        public string Title { get; set; } = "";
        [Required]
        [Range(1888, 3000)]
        public int Year { get; set; }
        public string? Director { get; set; } = "";
        public string? Rating { get; set; } = "";
        public bool Edited { get; set; }
        public string? LentTo { get; set; } = "";
        public string CopiedToPlex { get; set; } = "";
        public string? Notes { get; set; } = "";

    }
}
