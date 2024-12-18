using System.ComponentModel.DataAnnotations;
using ToBlazor.Contracts.Contract;

namespace ToBlazor.Entities
{
    public class Todo : IId
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25, ErrorMessage ="Name cannot exceed 25 characters.")]
        public string Name { get; set; } = string.Empty;
        [StringLength(120, ErrorMessage ="Description cannot exceed 120 characters.")]
        public string Description { get; set; } = string.Empty;

        public Todo(string name, string description) 
        {
            Name = name;
            Description = description;
        }
        public Todo() { }
    }
}
