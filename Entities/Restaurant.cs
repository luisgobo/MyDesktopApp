using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Restaurant
    {
        [Required]
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool Status { get; set; }

        public Restaurant(string name, string description, bool status = true)
        {
            Name = name;
            Description = description;
            Status = status;
        }
    }
}