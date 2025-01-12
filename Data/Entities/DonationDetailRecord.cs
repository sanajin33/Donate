using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donate.Data.Entities;

public class DonationDetailRecord
{
    public int DonationId { get; set; }
    public DateTimeOffset DonationDate { get; set; }
    public string ItemName { get; set; }
    public int ItemQuantity { get; set; }
    public decimal ItemPrice { get; set; }
    public decimal TotalValue { get; set; }
    public string Notes { get; set; }
}
