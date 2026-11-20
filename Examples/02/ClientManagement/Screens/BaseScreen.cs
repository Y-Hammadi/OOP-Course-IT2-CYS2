
namespace ClientManagement.Screens;

public abstract class BaseScreen
{
  // Print screen title
  protected void PrintTitle(string title)
  {
    Console.Clear();

    Console.WriteLine("================================");
    Console.WriteLine($"       {title}");
    Console.WriteLine("================================");
    Console.WriteLine();
  }

  // Print separator
  protected void PrintSeparator()
  {
    Console.WriteLine("--------------------------------");
  }

  // Print message
  protected void PrintMessage(string message)
  {
    Console.WriteLine($"\n{message}");
  }

  // Display screen
  public abstract void Show();
}
