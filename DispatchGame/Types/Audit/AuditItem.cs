namespace DispatchGame.Types.Audit;

public sealed class AuditItem
{
    public Guid Id { get; set; }
    public DateTime TimeStamp { get; set; }
    public AuditItemType Type { get; set; }
    public string Value { get; set; }
}