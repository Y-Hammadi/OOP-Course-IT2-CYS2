
using ClientManagement.Models;
using ClientManagement.Screens.ClientScreens;

// Create client manager
var clientManager = new Client();

// Load saved data
clientManager.Load();

// Open client menu
var clientMenu = new ClientMainMenuScreen(clientManager);

clientMenu.Show();