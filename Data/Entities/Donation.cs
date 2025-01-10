using System.ComponentModel.DataAnnotations;

namespace Donate.Data.Entities;

public class Donation
{
    public int Id { get; set; }

    public int DonorId { get; set; }
    public virtual AppUser? Donor { get; set; }

    public DateTime DonationDate { get; set; } = DateTime.UtcNow;

    [MaxLength(512)]
    public string? Notes { get; set; }

    public ICollection<DonationDetail> Details { get; set; } = [];

}
