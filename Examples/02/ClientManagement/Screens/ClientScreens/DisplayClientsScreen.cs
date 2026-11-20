
using ClientManagement.Helpers;
using ClientManagement.Models;

namespace ClientManagement.Screens.ClientScreens;

public class DisplayClientsScreen : BaseScreen
{
  private readonly Client _clientManager;

  public DisplayClientsScreen(Client clientManager)
  {
    _clientManager = clientManager;
  }

  public override void Show()
  {
    PrintTitle("ALL CLIENTS");

    var clients = _clientManager.GetAll();

    if (clients.Count == 0)
    {
      PrintMessage("No clients found.");
    }
    else
    {
      // Table Header
      Console.WriteLine(
          $"{"ID",-6} {"Full Name",-25} {"Phone Number",-18} {"Email",-30}"
      );

      Console.WriteLine("---------------------------------------------------------------- ");

      // Table Rows
      foreach (var client in clients)
      {
        Console.WriteLine(
            $"{client.ClientId,-6} " +
            $"{client.FullName,-25} " +
            $"{client.PhoneNumber,-18} " +
            $"{client.Email,-30}"
        );
      }

      Console.WriteLine("---------------------------------------------------------------- ");


      Console.WriteLine($"Total Clients: {clients.Count}");
    }

    InputHelper.Pause();
  }
}
