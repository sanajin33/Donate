using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donate.Data.Entities;

public class DonationItem
{
    public int Id { get; set; }

    [Required]
    public int ProjectId { get; set; }
    public virtual Project? Project { get; set; }

    [Required]
    public int ItemTypeId { get; set; }
    public virtual DonationItemType? ItemType { get; set; }

    [Required]
    [MaxLength(100)]
    public string ItemName { get; set; } = string.Empty;

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public bool Active { get; set; } = true;

    public ICollection<DonationDetail> Details { get; set; } = [];
}
