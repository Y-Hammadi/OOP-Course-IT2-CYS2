
using ClientManagement.Helpers;
using ClientManagement.Models;

namespace ClientManagement.Screens.ClientScreens;

public class UpdateClientScreen : BaseScreen
{
  private readonly Client _clientManager;

  public UpdateClientScreen(Client clientManager)
  {
    _clientManager = clientManager;
  }

  public override void Show()
  {
    PrintTitle("UPDATE CLIENT");

    int id = InputHelper.ReadNumber("Enter Client ID: ");

    var client = _clientManager.GetAll()
        .FirstOrDefault(c => c.ClientId == id);

    if (client == null)
    {
      PrintMessage("Client not found!");
      InputHelper.Pause();
      return;
    }

    Console.WriteLine($"Current Name: {client.FullName}");

    string name = InputHelper.ReadText("New Full Name: ");
    string phone = InputHelper.ReadPhoneNumber();
    string email = InputHelper.ReadEmail();

    bool updated = _clientManager.Update(id, new Client
    {
      FullName = name,
      PhoneNumber = phone,
      Email = email
    });

    if (updated)
    {
      _clientManager.Save();
      PrintMessage("Client updated successfully!");
    }
    else
    {
      PrintMessage("Update failed!");
    }

    InputHelper.Pause();
  }
}
