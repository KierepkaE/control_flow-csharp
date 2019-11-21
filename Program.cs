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

      var random = new Random ();
      for (var i = 0; i < 10; i++) {
        Console.Write ((char) random.Next (97, 122));
      }

    }
  }
}