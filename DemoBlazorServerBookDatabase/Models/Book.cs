using System.ComponentModel.DataAnnotations;

namespace DemoBlazorServerBookDatabase.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Image { get; set; }
    }
}
