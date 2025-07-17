namespace SMARTV3.Models;

public class CapabilityDataCard
{
    public int CapabilityId { get; set; }
    public int DataCardId { get; set; }
    public bool PrimaryCode { get; set; }
    public DateTime? validFrom { get; set; }
    public DateTime? validTo { get; set; }

    public virtual Capability Capability { get; set; } = null!;
    public virtual DataCard DataCard { get; set; } = null!;
}
