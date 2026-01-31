namespace Neomaster.XVault.Domain;

public record NodeType : Entity
{
  public List<Node> Nodes { get; set; } = [];
}
