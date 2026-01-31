namespace Neomaster.XVault.Domain;

public record Node : Entity
{
  public string Name { get; set; }
  public NodeType NodeType { get; set; }
  public List<Tag> Tags { get; set; } = [];
}
