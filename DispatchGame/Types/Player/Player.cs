namespace DispatchGame.Types.Player;

public sealed class Player
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Credits { get; set; }
}