namespace Donate.Data.Entities;

public class ViewDonationItem
{
    public int Id { get; set; }

    public int ProjectId { get; set; }
    public string? Project { get; set; }

    public int ItemTypeId { get; set; }
    public string? ItemType { get; set; }

    public string? ItemName { get; set; } 

    public decimal Price { get; set; }
    public bool Active { get; set; } 
}