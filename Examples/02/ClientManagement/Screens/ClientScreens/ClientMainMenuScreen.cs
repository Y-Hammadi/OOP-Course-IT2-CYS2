
using ClientManagement.Helpers;
using ClientManagement.Models;

namespace ClientManagement.Screens.ClientScreens;

public class ClientMainMenuScreen : BaseScreen
{
  private readonly Client _clientManager;

  public ClientMainMenuScreen(Client clientManager)
  {
    _clientManager = clientManager;
  }

  public override void Show()
  {
    while (true)
    {
      PrintTitle("CLIENT MANAGEMENT");

      Console.WriteLine("1. Add New Client");
      Console.WriteLine("2. Display All Clients");
      Console.WriteLine("3. Update Client");
      Console.WriteLine("4. Delete Client");
      Console.WriteLine("5. Back to Main Menu");

      PrintSeparator();

      int choice = InputHelper.ReadNumber(1, 5);

      switch (choice)
      {
        case 1:
          new AddNewClientScreen(_clientManager).Show();
          break;

        case 2:
          new DisplayClientsScreen(_clientManager).Show();
          break;

        case 3:
          new UpdateClientScreen(_clientManager).Show();
          break;

        case 4:
          new DeleteClientScreen(_clientManager).Show();
          break;

        case 5:
          return;
      }
    }
  }
}
