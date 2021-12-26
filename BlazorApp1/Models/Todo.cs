using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
