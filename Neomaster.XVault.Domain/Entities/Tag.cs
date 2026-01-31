namespace Neomaster.XVault.Domain;

public record Tag : Entity
{
  public List<Node> Nodes { get; set; } = [];
}
