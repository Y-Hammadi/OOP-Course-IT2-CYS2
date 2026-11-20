
using ClientManagement.Helpers;
using ClientManagement.Models;

namespace ClientManagement.Screens.ClientScreens;

public class DeleteClientScreen : BaseScreen
{
  private readonly Client _clientManager;

  public DeleteClientScreen(Client clientManager)
  {
    _clientManager = clientManager;
  }

  public override void Show()
  {
    PrintTitle("DELETE CLIENT");

    int id = InputHelper.ReadNumber("Enter Client ID: ");

    var client = _clientManager.GetAll()
        .FirstOrDefault(c => c.ClientId == id);

    if (client == null)
    {
      PrintMessage("Client not found!");
      InputHelper.Pause();
      return;
    }

    Console.WriteLine($"Client Name: {client.FullName}");

    bool confirm = InputHelper.ReadYesNo(
        "Are you sure you want to delete this client? (Y/N): "
    );

    if (!confirm)
    {
      PrintMessage("Deletion cancelled.");
      InputHelper.Pause();
      return;
    }

    bool deleted = _clientManager.Delete(id);

    if (deleted)
    {
      _clientManager.Save();
      PrintMessage("Client deleted successfully!");
    }
    else
    {
      PrintMessage("Deletion failed!");
    }

    InputHelper.Pause();
  }
}
