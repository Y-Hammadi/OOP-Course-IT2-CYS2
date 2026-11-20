
using ClientManagement.Helpers;
using ClientManagement.Models;

namespace ClientManagement.Screens.ClientScreens;

public class AddNewClientScreen : BaseScreen
{
  private readonly Client _clientManager;

  public AddNewClientScreen(Client clientManager)
  {
    _clientManager = clientManager;
  }

  public override void Show()
  {
    PrintTitle("ADD NEW CLIENT");

    string name = InputHelper.ReadText("Full Name: ");
    string phone = InputHelper.ReadPhoneNumber();
    string email = InputHelper.ReadEmail();

    Client newClient = _clientManager.Create(new Client
    {
      FullName = name,
      PhoneNumber = phone,
      Email = email
    });

    _clientManager.Save();

    PrintMessage("Client added successfully!");
    Console.WriteLine($"Client ID: {newClient.ClientId}");

    InputHelper.Pause();
  }
}
