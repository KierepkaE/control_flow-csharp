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

    }
  }
}