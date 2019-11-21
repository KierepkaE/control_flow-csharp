namespace Conditionals {
  class Program {
    static void Main (string[] args) {
      int hour = 10;
      if (hour > 0 && hour < 12) {
        Console.WriteLine ("It's morning");
      } else if (hour >= 12 && hour < 18) {
        Console.WriteLine ("It's afternoon");
      } else {
        Console.WriteLine ("It's evening");
      }
      var i = 0;
      while (i <= 10) {
        if (i % 2 == 0) {
          Console.WriteLine (i);
        }
        i++;
      }

      for (var i = 1; i <= 10; i++) {
        if (i % 2 == 0) {
          Console.WriteLine (i);
        }
      }

      while (true) {
        Console.Write ("Type your name:");
        string input = Console.ReadLine ();
        if (!String.IsNullorWhiteSpace (input)) {
          Console.WriteLine ("@echo: " + input);
          continue;
        }
        break;
      }

      const int passwordLength = 10;

      var random = new Random ();
      var buffer = new char[passwordLength];
      for (var i = 0; i < passwordLength; i++) {
        var buffer = new char[passwordLength];
        buffer[i] = (char) ('a' + random.Next (0, 26));
        var password = new string (buffer);
        Console.WriteLine (password);
      }

    }
  }
}