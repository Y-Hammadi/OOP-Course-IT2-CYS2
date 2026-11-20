
using System.Text.Json.Serialization;

namespace ClientManagement.Models;

public class Client : BaseModel<Client>
{
  // Properties
  [JsonInclude]
  public int ClientId { get; private set; }

  public string FullName { get; set; } = string.Empty;

  public string PhoneNumber { get; set; } = string.Empty;

  public string Email { get; set; } = string.Empty;

  // Constructor
  public Client() : base("clients.json")
  {
  }

  // Get ID
  protected override int GetId(Client item)
  {
    return item.ClientId;
  }

  // Create with ID
  protected override Client CreateWithId(Client item, int id)
  {
    return new Client
    {
      ClientId = id,
      FullName = item.FullName,
      PhoneNumber = item.PhoneNumber,
      Email = item.Email
    };
  }
}
