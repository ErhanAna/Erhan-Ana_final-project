using System.ComponentModel.DataAnnotations;

namespace Erhan_Ana_Maria_proiect_final.Models
{
    public class RoleModification
    {
        public string? RoleId { get; set; }

        [Required]
        public string? RoleName { get; set; }
        public string[]? AddIds { get; set; }
        public string[]? DeleteIds { get; set; }
        
    }
}
