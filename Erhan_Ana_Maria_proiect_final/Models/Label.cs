using System.ComponentModel.DataAnnotations;

namespace Erhan_Ana_Maria_proiect_final.Models
{
    public class Label
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Label Name")]
        [StringLength(50)]
        public string? LabelName { get; set; }

        [StringLength(70)]
        public string? Address { get; set; }
        public ICollection<ReleasedAlbum>? ReleasedAlbums { get; set; }
    }
}
